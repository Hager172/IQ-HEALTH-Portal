using ACMS_ONLINE_INFRASTRUCTURE.Utility.ResponseModel;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_APPLICATION.VendorService.Commands.AddClaimsType
{
    public class AddClaimsTypeCommand : IRequest<ServiceResponse<AddClaimsTypeResponse>>
    {
        public long Approvalid { get; set; }
        public List<int> Typeid { get; set; }
        public IFormFile? file { get; set; }
    }
}
