using ACMS_ONLINE_INFRASTRUCTURE.Utility.ResponseModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_APPLICATION.ApprovalService.Commands.ChangeStatusApproval
{
    public class ChangeStatusApprovalCommand:IRequest<ServiceResponse<ChangeStatusApprovalResponse>>
    {
        public long ApprovalId { get; set; }
    }
}
