using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_APPLICATION.ApprovalService.Queries.GetApprovalStats
{
    public class GetApprovalStatsResponse
    {
        public int TotalApprovalsD { get; set; }
        public int TotalApprovalsP { get; set; }
        public int ApprovalsThisWeekD { get; set; }
        public int ApprovalsTodayD { get; set; }
        public int ApprovalsThisMonthD { get; set; }
        public int ApprovalsThisWeekP { get; set; }
        public int ApprovalsTodayP { get; set; }
        
        public int ApprovalsThisMonthP { get; set; }

    }
}
