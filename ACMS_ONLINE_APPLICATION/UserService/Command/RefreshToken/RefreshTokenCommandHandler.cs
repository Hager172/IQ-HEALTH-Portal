using ACMS_ONLINE_APPLICATION.User.Auth;
using ACMS_ONLINE_APPLICATION.User.Login;
using ACMS_ONLINE_INFRASTRUCTURE.Identity.Entities;
using ACMS_ONLINE_INFRASTRUCTURE.Interfaces;
using ACMS_ONLINE_INFRASTRUCTURE.Utility.ResponseModel;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_APPLICATION.UserService.Command.RefreshToken
{
    public class RefreshTokenCommandHandler : IRequestHandler<RefreshTokenCommandDto, ServiceResponse<RefreshTokenCommandResponse>>
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IAuthService _authService;
        private readonly IUnitOfWork _unitOfWork;

        public RefreshTokenCommandHandler(UserManager<ApplicationUser> userManager,
                                   SignInManager<ApplicationUser> signInManager,
                                   IAuthService authService,
                                   IUnitOfWork unitOfWork                                
                                    )

        {
            _userManager = userManager;
            _signInManager = signInManager;
            _authService = authService;
            _unitOfWork = unitOfWork;
        }
        public async Task<ServiceResponse<RefreshTokenCommandResponse>> Handle(RefreshTokenCommandDto request, CancellationToken cancellationToken)
        {
            var serviceResponse = new ServiceResponse<RefreshTokenCommandResponse>();

            try
            {
                var user = await _userManager.Users.SingleOrDefaultAsync(u => u.RefreshTokens.Any(t => t.Token == request.RefreshToken.Trim()));

                if (user == null)
                {
                    serviceResponse.Success = false;
                    serviceResponse.MessageEn = "User Not Found";
                    serviceResponse.MessageAr = "حدث خطأ ";
                    throw new ArgumentException("User Not Found");
                }

                var refreshToken = user.RefreshTokens.Single(t => t.Token == request.RefreshToken);

                if (!refreshToken.IsActive)
                {
                    serviceResponse.Success = false;
                    serviceResponse.MessageEn = "User Not Found";
                    serviceResponse.MessageAr = "حدث خطأ ";
                    throw new ArgumentException("Inactive token");
                   
                }

                refreshToken.RevokedOn = DateTime.UtcNow;

                var newRefreshToken = _authService.GenerateRefreshToken();
                user.RefreshTokens.Add(newRefreshToken);
                await _userManager.UpdateAsync(user);

                //var userCurrentClientId = _authService.GetUserCurrentClient();
                var client = await _unitOfWork.OnlineUserClientRepository.FindAsync( x => x.UserId == user.Id && x.IsDefault);

                var jwtToken = await _authService.CreateJwtToken(user, client);


                var loginResponse = new RefreshTokenCommandResponse()
                {
                    Username = user.UserName,
                    // Clients = clients,
                    VendorId = client.VendorId,
                    BranchId = client.BranchId.ToString(),
                    IsAuthenticated = true,
                    AuthToken = new JwtSecurityTokenHandler().WriteToken(jwtToken),
                    ExpiresIn = jwtToken.ValidTo,
                    RefreshToken = newRefreshToken.Token,
                    RefreshTokenExpiration = refreshToken.ExpiresOn,


                   
                };

                serviceResponse.Data = loginResponse;


                
            }
            catch (Exception ex)
            {



            }

            //return new LoginResponseDto();
            return serviceResponse;
        }


    }
}
