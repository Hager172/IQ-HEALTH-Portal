using System;
using System.Collections.Generic;

namespace ACMS_ONLINE_INFRASTRUCTURE.Data.Models;

public partial class VWafedMember
{
    public string MemberName { get; set; } = null!;

    public string MemberId { get; set; } = null!;

    public string CustomerContractId { get; set; } = null!;

    public string PlanCode { get; set; } = null!;

    public string CustomerName { get; set; } = null!;

    public int? CaseId { get; set; }
}
