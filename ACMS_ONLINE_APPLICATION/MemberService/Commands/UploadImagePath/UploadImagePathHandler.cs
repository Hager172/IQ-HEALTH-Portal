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
using System.Text.RegularExpressions;
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
                // Check if the file size exceeds 5 MB
                const long maxFileSizeInBytes = 5 * 1024 * 1024; // 5 MB
                var d = request.file.Length;
                if (request.file.Length > maxFileSizeInBytes)
                {
                    response.Success = false;
                    response.MessageEn = "File size exceeds the maximum limit of 5 MB.";
                    return response;
                }
                // Validate phone number
                var phoneRegex = new Regex(@"^01[0125][0-9]{8}$");
                if (!phoneRegex.IsMatch(request.phone))
                {
                    response.Success = false;
                    response.MessageEn = "Invalid Egyptian phone number format.";
                    return response;
                }

                // Validate email
                var emailRegex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
                if (!emailRegex.IsMatch(request.Email))
                {
                    response.Success = false;
                    response.MessageEn = "Invalid email format.";
                    return response;
                }
                var user = await _userManager.FindByIdAsync(userId);

                //var directoryPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", request.folderPath);
                var directoryPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\avatars");
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }
                var username = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

                // Check if the user already has an image and delete it
                if (!string.IsNullOrEmpty(user.PathImage))
                {
                    var existingFilePath = Path.Combine(Directory.GetCurrentDirectory(), user.PathImage);
                    if (File.Exists(existingFilePath))
                    { 
                        File.Delete(existingFilePath);
                    }
                }
                var fileExtension = Path.GetExtension(request.file.FileName);

                var filePath = Path.Combine(directoryPath, username+ fileExtension);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await request.file.CopyToAsync(fileStream);
                }


                if (user == null)
                {
                    response.Success = false;
                    response.MessageEn = "User not found."; 
                    return response;
                }

                user.PathImage = Path.Combine("wwwroot\\avatars", username + fileExtension);
                user.PhoneNumber = request.phone;
                user.Email = request.Email;
                user.NormalizedEmail=request.Email.ToUpper();

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
