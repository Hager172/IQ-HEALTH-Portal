using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_APPLICATION.ApprovalService.Commands.PrintApproval
{
    public class PrintApprovalResponse
    {
        public string FileName { get; set; }

        public byte[] FileContent { get; set; }
    }
}
