using ACMS_ONLINE_INFRASTRUCTURE.Utility.ResponseModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_APPLICATION.VendorService.Queries.GetApprovalFileAndClaims
{
    public class GetApprovalFileAndClaimsQuery:IRequest<ServiceResponse<GetApprovalFileAndClaimsResponse>>
    {
        public long approvalid {  get; set; }
    }
}
