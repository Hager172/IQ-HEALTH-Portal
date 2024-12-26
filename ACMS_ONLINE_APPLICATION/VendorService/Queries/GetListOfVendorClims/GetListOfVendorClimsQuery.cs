using ACMS_ONLINE_INFRASTRUCTURE.Utility.ResponseModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_APPLICATION.VendorService.Queries.GetListOfVendorClims
{
    public class GetListOfVendorClimsQuery : IRequest<ServiceResponse<List<GetListOfVendorClimsResponse>>>
    {
        //public string? VendorId { get; set; }
        public string From { get; set; }
        public string To { get; set; }

    }
}
