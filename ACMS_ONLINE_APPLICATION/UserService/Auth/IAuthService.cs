using ACMS_ONLINE_APPLICATION.User.Dto;

using ACMS_ONLINE_INFRASTRUCTURE.Identity.Entities;
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
        string GenerateToken(ApplicationUser user);

        RefreshToken GenerateRefreshToken();
        public string GetUserCurrentClient();
        Task<JwtSecurityToken> CreateJwtToken(ApplicationUser user, OnlineUserClient? userClient);
        public Task<List<UserClientDto>> GetUserClientList (string userId);
    }
}
