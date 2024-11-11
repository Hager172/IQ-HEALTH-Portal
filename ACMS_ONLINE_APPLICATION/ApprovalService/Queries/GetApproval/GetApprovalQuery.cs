using ACMS_ONLINE_APPLICATION.ApprovalService.Queries.GetMemberDetails;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_APPLICATION.ApprovalService.Queries.GetApproval
{
    public class GetApprovalQuery : IRequest<GetApprovalDetailsQuery>
    {
        public long ApprovalId { get; set; }
    }
}
