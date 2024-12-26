using ACMS_ONLINE_APPLICATION.VendorService.Queries.GetSetting;
using ACMS_ONLINE_INFRASTRUCTURE.Utility.ResponseModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_APPLICATION.VendorService.Queries.GetServices
{
    public class GetServicesQuery : IRequest<ServiceResponse<List<GetServicesResponse>>>
    {
        public string Type { get; set; }
    }
}
