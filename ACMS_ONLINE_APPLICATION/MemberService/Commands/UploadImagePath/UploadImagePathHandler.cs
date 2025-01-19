using ACMS_ONLINE_APPLICATION.MemberService.Queries.GetImageMember;
using ACMS_ONLINE_INFRASTRUCTURE.Data.Models;
using ACMS_ONLINE_INFRASTRUCTURE.Identity.Entities;
using ACMS_ONLINE_INFRASTRUCTURE.Utility.ResponseModel;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ACMS_ONLINE_APPLICATION.MemberService.Commands.UploadImagePath
{
    public class UploadImagePathHandler : IRequestHandler<UploadImagePathCommand, ServiceResponse<UploadImagePathResponse>>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<ApplicationUser> _userManager; // Replace ApplicationUser with your user class

        public UploadImagePathHandler(IHttpContextAccessor httpContextAccessor, UserManager<ApplicationUser> userManager)
        {
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
        }

        public async Task<ServiceResponse<UploadImagePathResponse>> Handle(UploadImagePathCommand request, CancellationToken cancellationToken)
        {
            var response = new ServiceResponse<UploadImagePathResponse>();

            try
            {

                var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                if (userId == null)
                {
                    response.Success = false;
                    response.MessageEn = "User not found.";
                    return response;
                }


                var directoryPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", request.folderPath);
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                var filePath = Path.Combine(directoryPath, request.file.FileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await request.file.CopyToAsync(fileStream);
                }


                var user = await _userManager.FindByIdAsync(userId);
                if (user == null)
                {
                    response.Success = false;
                    response.MessageEn = "User not found.";
                    return response;
                }

                user.PathImage = Path.Combine(request.folderPath, request.file.FileName);
                user.PhoneNumber = request.phone;

                await _userManager.UpdateAsync(user);


                response.Data = new UploadImagePathResponse
                {
                    FilePath = filePath,
                    Message = "Image uploaded and path updated successfully."
                };
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.MessageEn = "Error uploading image: " + ex.Message;
            }

            return response;
        }




    }

}
