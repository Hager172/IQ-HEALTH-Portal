using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.DTOs.ApprovalDtos
    {
    public class MemberApprovalListDto
        {
        public long ApprovalNumber { get; set; }
        public DateTime ApprovalDate { get; set; }
        public string Status { get; set; } = null!;
        }
    }
