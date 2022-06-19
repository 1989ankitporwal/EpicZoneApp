using epic.APIs.Model;
using epic.Services.Interfaces;
using epic.Services.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace epic.APIs.Controllers
{
    [EnableCors("AllowAll")]
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;
        private readonly ILogger<AccountController> _logger;
        public AccountController(IAccountService accountService, ILogger<AccountController> logger)
        {
            _accountService = accountService;
            _logger = logger;
        }

        [HttpPost("Login")]
        public async Task<ActionResult<UserModel>> Login(LoginModel loginModel)
        {
            try
            {
                UserModel user = await _accountService.AuthenticateUser(loginModel.Email, loginModel.Password);

                if (user == null) return Unauthorized("Invalid User");
                if (!user.IsActive) return Unauthorized("User is Inactive");
                if (user.Id == 0) return Unauthorized("Please Enter Valid UserName and Password.");

                return Ok(user);
            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;
                if (ex.InnerException != null)
                {
                    errorMessage = ex.InnerException.Message;
                }
                _logger.LogError(ex, errorMessage);
                return BadRequest($"Login Failed. Error: { errorMessage }");
            }
        }

        [HttpPost]
        [Route("refresh")]
        public async Task<ActionResult<UserModel>> Refresh(TokenApiModel tokenApiModel)
        {
            try
            {
                if (tokenApiModel is null)
                {
                    return BadRequest("Invalid client request");
                }
                string accessToken = tokenApiModel.AccessToken;
                string refreshToken = tokenApiModel.RefreshToken;

                UserModel user = await _accountService.Refresh(accessToken, refreshToken);
                if (user == null) return Unauthorized("Invalid User");
                if (!user.IsActive) return Unauthorized("User is Inactive");
                if (user.Id == 0) return Unauthorized("Please Enter Valid UserName and Password.");

                return Ok(user);
            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;
                if (ex.InnerException != null)
                {
                    errorMessage = ex.InnerException.Message;
                }
                _logger.LogError(ex, errorMessage);
                return BadRequest($"Login Failed. Error: { errorMessage }");
            }
        }

        [HttpPost, Authorize]
        [Route("revoke")]
        public async Task<IActionResult> Revoke()
        {
            try
            {
                var username = User.Identity?.Name;
                var user = await _accountService.Revoke(username);
                if (user == null) return BadRequest();
                return NoContent();
            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;
                if (ex.InnerException != null)
                {
                    errorMessage = ex.InnerException.Message;
                }
                _logger.LogError(ex, errorMessage);
                return BadRequest($"Login Failed. Error: { errorMessage }");
            }
        }
    }
}
