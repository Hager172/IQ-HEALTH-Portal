

using IQHealthPortal.Application.Interfaces.Auth;
using IQHealthPortal.Application.Interfaces.Auth.DTOs;
using IQHealthPortal.Domain.Identity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace IQHealthPortal.Infrastructure.Identity.Services
{
    public class IdentityService : IIdentityService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly JWT _jwt;
        public IdentityService(UserManager<ApplicationUser> userManager,
                               SignInManager<ApplicationUser> signInManager, IConfiguration configuration, IHttpContextAccessor httpContextAccessor, IOptions<JWT> jwt)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
            _jwt = jwt.Value;
        }

        public async Task<(bool, string?)> ValidateUserAsync(string name, string password)
        {
            var user = await _userManager.FindByNameAsync(name);
            if (user == null)

            { return (false, null); }

            var result = await _signInManager.CheckPasswordSignInAsync(user, password, false);

            return result.Succeeded ? (true, user.Id) : (false, null);
        }

        public async Task<List<string>> GetUserRolesAsync(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            return (await _userManager.GetRolesAsync(user)).ToList();
        }
      
        public async Task<JwtTokenDto> CreateJwtTokenAsync(string userid,OnlineUserClient? userClient)
        {
            var user = await _userManager.FindByIdAsync(userid);
            var claims = new List<Claim>
    {
        new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
    };

            if (userClient != null)
            {
                claims.Add(new Claim("VendorId", userClient.VendorId));
                claims.Add(new Claim("BranchId", userClient.BranchId.ToString()));
            }

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwt.Key));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _jwt.Issuer,
                audience: _jwt.Audience,
                claims: claims,
                expires: DateTime.UtcNow.AddDays(_jwt.DurationInDays),
                signingCredentials: creds
            );

            return new JwtTokenDto
            {
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                Expiration = token.ValidTo
            };
        }


      

        public RefreshTokenDto GenerateRefreshToken()
        {
            var randomBytes = new byte[32];
            using var rng = RandomNumberGenerator.Create();
            rng.GetBytes(randomBytes);

            return new RefreshTokenDto
            {
                Token = Convert.ToBase64String(randomBytes),
                ExpiresOn = DateTime.UtcNow.AddDays(_jwt.DurationInDays * 3)
            };
        }

        public string GetUserCurrentClient()
        {
            try
            {

                // Get the JWT token from the Authorization header
                string? jwtToken = _httpContextAccessor.HttpContext.Request.Headers["Authorization"]
                .FirstOrDefault()?.Split(" ")
                .Last();

                if (string.IsNullOrEmpty(jwtToken))
                {
                    return null;
                }

                var tokenHandler = new JwtSecurityTokenHandler();
                var token = tokenHandler.ReadToken(jwtToken) as JwtSecurityToken;

                if (token == null)
                {
                    // Invalid token
                    return null;
                }

                var ClientId = token.Claims.FirstOrDefault(c => c.Type == "ClientId")?.Value;
                return ClientId;


            }
            catch (Exception ex)
            {
                return null;
            }
        }

        

        //public Task<List<OnlineUserClient>> GetUserClientList(string userId)
        //{
        //    var clients = await _unitOfWork.OnlineUserClientRepository.FindAllAsync(x => x.UserId == userId, includes: new[] { "Client" });

        //    return _mapper.Map<List<OnlineUserClient>>(clients);
        //}
    }

}
