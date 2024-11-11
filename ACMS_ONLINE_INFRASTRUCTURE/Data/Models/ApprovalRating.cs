using System;
using System.Collections.Generic;

namespace ACMS_ONLINE_INFRASTRUCTURE.Data.Models;

public partial class ApprovalRating
{
    public long ApprovalId { get; set; }

    public string MemberId { get; set; } = null!;

    public int Rate { get; set; }

    public string? ReteNote { get; set; }

    public DateOnly? RatingDate { get; set; }

    public string? PhoneNumber { get; set; }

    public virtual Approval Approval { get; set; } = null!;

    public virtual Member Member { get; set; } = null!;
}
