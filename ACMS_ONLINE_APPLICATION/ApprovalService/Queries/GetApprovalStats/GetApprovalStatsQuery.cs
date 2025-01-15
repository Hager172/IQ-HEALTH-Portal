using ACMS_ONLINE_APPLICATION.VendorService.Queries.GetDiagnosis;
using ACMS_ONLINE_INFRASTRUCTURE.Utility.ResponseModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_APPLICATION.ApprovalService.Queries.GetApprovalStats
{
    public class GetApprovalStatsQuery : IRequest<ServiceResponse<GetApprovalStatsResponse>>
    {
    }
}
