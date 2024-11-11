using System;
using System.Collections.Generic;

namespace ACMS_ONLINE_INFRASTRUCTURE.Data.Models;

public partial class VGetApprovalService
{
    public int ServiceId { get; set; }

    public string? Name { get; set; }

    public int? Count { get; set; }
}
