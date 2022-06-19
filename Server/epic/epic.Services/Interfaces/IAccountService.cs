using epic.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epic.Services.Interfaces
{
    public interface IAccountService
    {
        Task<UserModel> AuthenticateUser(string userName, string password);
        Task<UserModel> Refresh(string accessToken, string refreshToken);
        Task<UserModel> Revoke(string? userName);
    }
}
