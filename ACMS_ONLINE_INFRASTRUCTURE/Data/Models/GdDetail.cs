using System;
using System.Collections.Generic;

namespace ACMS_ONLINE_INFRASTRUCTURE.Data.Models;

public partial class GdDetail
{
    public int Id { get; set; }

    public int? RequestId { get; set; }

    public string? MemberId { get; set; }

    public virtual Member? Member { get; set; }

    public virtual GdRequest? Request { get; set; }
}
