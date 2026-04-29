

using IQHealthPortal.Application.Interfaces.Auth.DTOs;
using IQHealthPortal.Domain.Identity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.Interfaces.Auth
{
    public interface IIdentityService
    {


        Task<JwtTokenDto> CreateJwtTokenAsync(string userid, OnlineUserClient? userClient);



        RefreshTokenDto GenerateRefreshToken();

       
        string GetUserCurrentClient();

        
        //Task<List<Page>> GetUserClientList(string userId);
        
        Task<(bool IsSuccess, string? UserId)> ValidateUserAsync(string name, string password);
        Task<List<string>> GetUserRolesAsync(string userId);
    }
}
