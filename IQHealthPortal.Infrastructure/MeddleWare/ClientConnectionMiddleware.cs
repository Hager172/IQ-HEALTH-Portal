
using IQHealthPortal.Application.Interfaces.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQHealthPortal.Infrastructure.MeddleWare
{
    public class ClientConnectionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IConfiguration  _configuration;

        public ClientConnectionMiddleware(RequestDelegate next , IConfiguration configuration)
        {
            _next = next;
            _configuration = configuration;
        }

        public async Task InvokeAsync(HttpContext context)
         {
            var authHeader = context.Request.Headers["Authorization"].ToString();
            Console.WriteLine($"Authorization Header: {authHeader}");

            // If a token is present 
            //if (!string.IsNullOrEmpty(authHeader) && authHeader.StartsWith("Bearer "))
            //{
            //    var token = authHeader.Substring("Bearer ".Length).Trim();
            //    Console.WriteLine($"Token: {token}");

            //    // Validate the token manually if needed
            //    var tokenHandler = new JwtSecurityTokenHandler();
            //    try
            //    {
            //        var principal = tokenHandler.ValidateToken(token, new TokenValidationParameters
            //        {
            //            ValidateIssuerSigningKey = true,
            //            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSetting:Key"])),
            //            ValidateIssuer = true,
            //            ValidIssuer = _configuration["JwtSetting:Issuer"],
            //            ValidateAudience = true,
            //            ValidAudience = _configuration["JwtSetting:Audience"],
            //            ValidateLifetime = true,
            //            ClockSkew = TimeSpan.Zero // Set to zero for immediate expiration check
            //        }, out SecurityToken validatedToken);

            //        context.User = principal; // Set the user in the context
            //        Console.WriteLine("Token is valid");
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine($"Token validation failed: {ex.Message}");
            //    }
            //}

            if (context.User.Identity.IsAuthenticated)
            {
                var clientId = context.User.FindFirst("ClientId")?.Value;
                Console.WriteLine($"Authenticated ClientId: {clientId}");

                var unitOfWork = context.RequestServices.GetRequiredService<IUnitOfWork>();

                // Logic for switching the connection string
                if (!string.IsNullOrEmpty(clientId))
                {
                    unitOfWork.SetConnectionString(clientId);
                }
            }
            else
            {
                Console.WriteLine("User is not authenticated");
            }
            await _next(context);
        }
    }
}
