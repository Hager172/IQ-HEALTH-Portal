using ACMS_ONLINE_APPLICATION.User.Dto;
using ACMS_ONLINE_INFRASTRUCTURE.Data.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_APPLICATION.User.Auth
{
    public interface IAuthService
    {
        string GenerateToken(IdentityUser user);

        //string GenerateRefreshToken(IdentityUser user);
        public string GetUserCurrentClient();
        Task<JwtSecurityToken> CreateJwtToken(IdentityUser user, OnlineUserClient? userClient);
        public Task<List<UserClientDto>> GetUserClientList (string userId);
    }
}
