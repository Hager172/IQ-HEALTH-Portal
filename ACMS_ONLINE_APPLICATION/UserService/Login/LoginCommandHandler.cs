using  ACMS_ONLINE_INFRASTRUCTURE.Utility.ResponseModel;
using ACMS_ONLINE_APPLICATION.User.Auth;
using ACMS_ONLINE_INFRASTRUCTURE.Data.Models;
using ACMS_ONLINE_INFRASTRUCTURE.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_APPLICATION.User.Login
{
    public class LoginCommandHandler :IRequestHandler<LoginCommandDto, LoginResponseDto>
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IAuthService _authService;
        private readonly IUnitOfWork _unitOfWork;

        public LoginCommandHandler(UserManager<IdentityUser> userManager,
                                   SignInManager<IdentityUser> signInManager,
                                   IAuthService authService,
                                   IUnitOfWork unitOfWork
                                    )

        {
            _userManager = userManager;
            _signInManager = signInManager;
            _authService = authService;
            _unitOfWork = unitOfWork;
        }
        public async Task<LoginResponseDto> Handle(LoginCommandDto request, CancellationToken cancellationToken)
        {
            var serviceResponse = new ServiceResponse<LoginResponseDto>();

            try
            {
                var user = await _userManager.Users.FirstOrDefaultAsync(x => x.UserName == request.UserName.Trim());

                if (user == null)
                {
                    throw new Exception("User Not Found");
                }

                // Check password
                var result = await _signInManager.CheckPasswordSignInAsync(user, request.Password, lockoutOnFailure: false);

                if (result.Succeeded)
                {
                    var client = await _unitOfWork.OnlineUserClientRepository.FindAsync(x => x.UserId == user.Id && x.IsDefault == true);
                    // Generate JWT token
                    var token = await _authService.CreateJwtToken(user, client);
                    // var clients = await _authService.GetUserClientList(user.Id);


                    var loginResponse = new LoginResponseDto()
                    {
                        Username = request.UserName,
                        // Clients = clients,
                        VendorId = client.VendorId,
                        BranchId = client.BranchId.ToString(),
                        IsAuthenticated = true,
                        Token = new JwtSecurityTokenHandler().WriteToken(token),



                        //Clients = _authService.g
                    };


                }
            }
            catch (Exception ex)
            {

            }

            return new LoginResponseDto();
            //return serviceResponse;
        }

    

    }
}
