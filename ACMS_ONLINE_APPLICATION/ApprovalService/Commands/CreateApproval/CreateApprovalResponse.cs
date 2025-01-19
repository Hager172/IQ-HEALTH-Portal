using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_APPLICATION.ApprovalService.Commands.CreateApproval
{
    public class CreateApprovalResponse
    {
        public long ApprovalId { get; set; }
        public bool IsSuccess { get; set; } = false;
    }
}
