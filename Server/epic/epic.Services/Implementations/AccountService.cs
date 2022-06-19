using epic.Entities;
using epic.Repositories.Interfaces;
using epic.Services.Interfaces;
using epic.Services.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace epic.Services.Implementations
{
    public class AccountService : IAccountService
    {
        protected IConfiguration _config;
        protected IUserRepository _userRepository;
        protected IRoleRepository _roleRepository;
        protected ITokenService _tokenService;
        public AccountService(IConfiguration config, IUserRepository userRepository, IRoleRepository roleRepository
            , ITokenService tokenService)
        {
            _config = config;
            _userRepository = userRepository;
            _roleRepository = roleRepository;
            _tokenService = tokenService;
        }

        public async Task<UserModel> AuthenticateUser(string userName, string password)
        {
            User user = await _userRepository.Exists(userName);
            if (user == null)
            {
                return null;
            }
            using var hmac = new HMACSHA512(user.PasswordSalt);

            var computedhash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

            for (int i = 0; i < computedhash.Length; i++)
            {
                if (computedhash[i] != user.PasswordHash[i])
                    return new UserModel();
            }
            List<int> lstRoleIds = new List<int>();
            List<string> lstRoles = new List<string>();
            foreach (var role in await _roleRepository.GetRolesByUserId(user.Id))
            {
                lstRoleIds.Add(role.Id);
                lstRoles.Add(role.Name);
            }

            var accessToken = _tokenService.GenerateJSONWebToken(user, lstRoles);
            var refreshToken = _tokenService.GenerateRefreshToken();
            //_userRepo.Update(user);
            //_userRepo.SaveChanges();
            await _userRepository.Update(user);

            UserModel userModel = new UserModel {
                Id = user.Id,
                UserName = user.UserName,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                IsActive = user.IsActive,
                RoleIds = lstRoleIds.ToArray(),
                Roles = lstRoles.ToArray(),
                Token = accessToken,
                RefreshToken = refreshToken
            };

            return userModel;
        }

        public async Task<UserModel> Refresh(string accessToken, string refreshToken)
        {
            var principal = _tokenService.GetPrincipalFromExpiredToken(accessToken);
            var username = principal.Identity?.Name; //this is mapped to the Name claim by default
            var user = await _userRepository.GetUserByUserName(username);
            bool isDateDifferance = DateTime.Compare(user.RefreshTokenExpiryTime, DateTime.Now) > 0 ? false : true;
            if (user == null || user.RefreshToken != refreshToken || isDateDifferance)
            {
                //return BadRequest("Invalid client request");
                return null;
            }
            var roles = _roleRepository.GetRolesByUserId(user.Id);
            List<int> lstRoleIds = new List<int>();
            List<string> lstRoles = new List<string>();
            foreach (var role in await roles)
            {
                lstRoleIds.Add(role.Id);
                lstRoles.Add(role.Name);
            }
            var newAccessToken = _tokenService.GenerateJSONWebToken(user, lstRoles);
            var newRefreshToken = _tokenService.GenerateRefreshToken();
            user.RefreshToken = newRefreshToken;

            //_userRepo.Update(user);
            //_userRepo.SaveChanges();
            await _userRepository.Update(user);
            return new UserModel
            {
                Id = user.Id,
                UserName = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                IsActive = user.IsActive,
                Token = newAccessToken,
                RefreshToken = newRefreshToken,
                RoleIds = lstRoleIds.ToArray(),
                Roles = lstRoles.ToArray()
            };
        }

        public async Task<UserModel> Revoke(string? userName)
        {
            var user = await _userRepository.GetUserByUserName(userName);
            if (user == null) return null;
            user.RefreshToken = null;
            //_userRepo.Update(user);
            //_userRepo.SaveChanges();
            await _userRepository.Update(user);
            return new UserModel
            {
                Id = user.Id,
                UserName = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                IsActive = user.IsActive,
                Token = null,
                RefreshToken = null
            };
        }
    }
}
