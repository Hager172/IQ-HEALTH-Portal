using System;
using System.Collections.Generic;

namespace ACMS_ONLINE_INFRASTRUCTURE.Data.Models;

public partial class OnlineSubmittedApproval
{
    public string Vcode { get; set; } = null!;

    public string Serial { get; set; } = null!;

    public decimal ActId { get; set; }

    public double? Net { get; set; }

    public DateTime? Date { get; set; }
}
