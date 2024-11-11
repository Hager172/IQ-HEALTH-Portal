using System;
using System.Collections.Generic;

namespace ACMS_ONLINE_INFRASTRUCTURE.Data.Models;

public partial class MemberStatusMonitor
{
    public int Id { get; set; }

    public string MemberId { get; set; } = null!;

    public string? Status { get; set; }

    public string NewStatus { get; set; } = null!;

    public DateTime? Date { get; set; }

    public string UpdateBy { get; set; } = null!;

    public string UpdateFrom { get; set; } = null!;

    public virtual Member Member { get; set; } = null!;
}
