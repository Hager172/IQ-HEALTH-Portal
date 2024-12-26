using ACMS_ONLINE_INFRASTRUCTURE.Utility.ResponseModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_APPLICATION.VendorService.Queries.GetPharmaServices
{
    public class GetPharmaServicesQuery:IRequest<ServiceResponse<List<GetPharmaServicesResponse>>>
    {
        public string Name { get; set; }    
    }
}
