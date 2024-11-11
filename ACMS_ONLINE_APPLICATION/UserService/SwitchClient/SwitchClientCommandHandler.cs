using  ACMS_ONLINE_INFRASTRUCTURE.Utility.ResponseModel;
using ACMS_ONLINE_APPLICATION.User.Auth;
using ACMS_ONLINE_APPLICATION.User.Login;
using ACMS_ONLINE_INFRASTRUCTURE.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_APPLICATION.User.SwitchClient
{
    public class SwitchClientCommandHandler : IRequestHandler<SwitchClientCommand, ServiceResponse<SwitchClientCommandResponse>>
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IAuthService _authService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHttpContextAccessor _contextAccessor;
        public SwitchClientCommandHandler
            (   UserManager<IdentityUser> userManager,
                SignInManager<IdentityUser> signInManager,
                IAuthService authService,
                IUnitOfWork unitOfWork,
                IHttpContextAccessor contextAccessor
            )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _authService = authService;
            _unitOfWork = unitOfWork;
            _contextAccessor = contextAccessor;
        }
        
        public async Task<ServiceResponse<SwitchClientCommandResponse>> Handle(SwitchClientCommand request, CancellationToken cancellationToken)
        {
            var serviceResponse = new ServiceResponse<SwitchClientCommandResponse>();

            try
            {
                var UserId = _contextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var client = await _unitOfWork.OnlineUserClientRepository.FindAsync(x => x.UserId == UserId && x.ClientId == request.ClientId);
                if (client == null)
                {
                    serviceResponse.Success = false;
                    serviceResponse.Status = -1;
                    throw new Exception("Client Not Found");

                }
                var user = await _userManager.Users.FirstOrDefaultAsync(x => x.Id == UserId);

                if (user == null)
                {
                    serviceResponse.Success = false;
                    serviceResponse.Status = -2;
                    throw new Exception("User Not Found");
                }

                var token = await _authService.CreateJwtToken(user, client);

                var switchClient = new SwitchClientCommandResponse()
                {
                    BranchId = client.BranchId.ToString(),
                    VendorId = client.VendorId,
                    Token = new JwtSecurityTokenHandler().WriteToken(token),

                };

               
                serviceResponse.Data = switchClient;
            }
            catch (Exception ex)
            {
                serviceResponse.MessageAr = "";
            }

            return serviceResponse;
        }
    }
}
