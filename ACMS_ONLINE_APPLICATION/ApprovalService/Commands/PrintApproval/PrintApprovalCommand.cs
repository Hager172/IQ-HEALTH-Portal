using ACMS_ONLINE_INFRASTRUCTURE.Utility.ResponseModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_APPLICATION.ApprovalService.Commands.PrintApproval
{
    public class PrintApprovalCommand:IRequest<ServiceResponse<PrintApprovalResponse>>
    {
        public long ApprovalId { get; set; }
    }
}
