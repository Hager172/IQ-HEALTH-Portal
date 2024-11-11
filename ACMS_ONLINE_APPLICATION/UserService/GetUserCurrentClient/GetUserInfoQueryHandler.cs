using ACMS_ONLINE_INFRASTRUCTURE.Data.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_APPLICATION.User.GetUserCurrentClient
{
    public class GetUserInfoQueryHandler : IRequestHandler<GetUserClientQuery, string>
    {
        //private readonly UserManager<AspNetUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public GetUserInfoQueryHandler(/*UserManager<AspNetUser> userManager, */IHttpContextAccessor httpContextAccessor)
        {
            //_userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<string> Handle(GetUserClientQuery request, CancellationToken cancellationToken)
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

                var memberIdClaim = token.Claims.FirstOrDefault(c => c.Type == "clinetId")?.Value;
                return memberIdClaim;

                //var user = await _userManager.FindByNameAsync(userIdClaim?.Value);

                //if (user == null)
                //    throw new System.Exception("User Mot Found");

                //return user.MemberId;// userIdClaim?.Value;

            }
            catch (Exception ex)
            {
                return null;
            }
            //// Fetch user by UserId
            //var user = await _userManager.FindByIdAsync(request.UserId);

            //        if (user == null)
            //        {
            //            throw new Exception("User not found");
            //        }

            //        // Retrieve the claim by ClaimType
            //        var userClaim = user.AspNetUserClaims.FirstOrDefault(c => c.t == request.ClaimType)?.Value;

            //        if (userClaim == null)
            //        {
            //            throw new Exception($"{request.ClaimType} not found in user claims");
            //        }

            //        return userClaim;
        }
    }

}
