using ACMS_ONLINE_APPLICATION.User.Auth;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.Extensions.Options;
using ACMS_ONLINE_INFRASTRUCTURE.Interfaces;
using ACMS_ONLINE_APPLICATION.User.Dto;
using AutoMapper;
using ACMS_ONLINE_INFRASTRUCTURE.Identity.Entities;

namespace ACMS_ONLINE_APPLICATION.User.Auth
{
    public class AuthService : IAuthService
    {
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly JWT _jwt;
        private readonly IUnitOfWork _unitOfWork;
        //private readonly IHttpContextAccessor _httpContextAccessor;

        private readonly IMapper _mapper;
        public AuthService
            (
            IConfiguration configuration,
            IHttpContextAccessor httpContextAccessor,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,

            RoleManager<ApplicationRole> roleManager,
            IOptions<JWT> jwt,
            IUnitOfWork unitOfWork,
            IMapper mapper
            )
        {
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _jwt = jwt.Value;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public string GenerateToken(ApplicationUser user)
        {
            var claims = new[]
            {
            new System.Security.Claims.Claim(JwtRegisteredClaimNames.Sub, user.UserName),
            new System.Security.Claims.Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSetting:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                _configuration["JwtSetting:Issuer"],
                _configuration["JwtSetting:Issuer"],
                claims,
                expires: DateTime.Now.AddMinutes(_jwt.DurationInDays),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public async Task<JwtSecurityToken> CreateJwtToken(ApplicationUser user, OnlineUserClient? userClient)
        {
            var userClaims = await _userManager.GetClaimsAsync(user);
            var roles = await _userManager.GetRolesAsync(user);
            var roleClaims = new List<System.Security.Claims.Claim>();
            var clients = new List<System.Security.Claims.Claim>();

            foreach (var role in roles)
                roleClaims.Add(new System.Security.Claims.Claim("roles", role));




            if (userClient is not null)
            {
                clients.Add(new System.Security.Claims.Claim("VendorId", userClient.VendorId.ToString()));
                clients.Add(new System.Security.Claims.Claim("BranchId", userClient.BranchId.ToString()));
                clients.Add(new System.Security.Claims.Claim("ClientId", userClient.ClientId.ToString()));

            }


            var claims = new[]
            {
                new System.Security.Claims.Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
                new System.Security.Claims.Claim(JwtRegisteredClaimNames.UniqueName, user.UserName.ToString()),
                new System.Security.Claims.Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),

            }
            .Union(userClaims)
            .Union(roleClaims)
            .Union(clients);



            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwt.Key));
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

            var jwtSecurityToken = new JwtSecurityToken(
                issuer: _jwt.Issuer,
                audience: _jwt.Audience,
                claims: claims,
                expires: DateTime.UtcNow.AddDays(_jwt.DurationInDays), // DateTime.UtcNow.AddSeconds(60),  //
            signingCredentials: signingCredentials);
            return jwtSecurityToken;
        }


        public RefreshToken GenerateRefreshToken()
        {
            var randomNumber = new byte[32];

            using var generator = new RNGCryptoServiceProvider();

            generator.GetBytes(randomNumber);

            return new RefreshToken
            {
                Token = Convert.ToBase64String(randomNumber),
                ExpiresOn = DateTime.UtcNow.AddDays(_jwt.DurationInDays * 3),
                CreatedOn = DateTime.UtcNow
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

        public async Task< List<UserClientDto>> GetUserClientList(string userId)
        {
            var clients = await _unitOfWork.OnlineUserClientRepository.FindAllAsync(x => x.UserId == userId, includes: new[] { "Client" } );

            return _mapper.Map<List<UserClientDto>>(clients);
        }
    }
}
