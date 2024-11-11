using System;
using System.Collections.Generic;

namespace ACMS_ONLINE_INFRASTRUCTURE.Data.Models;

public partial class OutlookAttachment
{
    public int Id { get; set; }

    public int? OutlookEmailId { get; set; }

    public string? FileName { get; set; }

    public virtual OutlookEmail? OutlookEmail { get; set; }
}
