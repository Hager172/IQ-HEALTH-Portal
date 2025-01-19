using ACMS_ONLINE_INFRASTRUCTURE.Utility.ResponseModel;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_APPLICATION.MemberService.Commands.UploadImagePath
{
    public class UploadImagePathCommand : IRequest<ServiceResponse<UploadImagePathResponse>>
    {
        //public string folderPath { get; set; }
        public string phone { get; set; }
        public IFormFile file { get; set; }

        public string Email {  get; set; }
    }
}
