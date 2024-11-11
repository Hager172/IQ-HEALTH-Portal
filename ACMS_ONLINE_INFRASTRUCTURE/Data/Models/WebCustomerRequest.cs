using System;
using System.Collections.Generic;

namespace ACMS_ONLINE_INFRASTRUCTURE.Data.Models;

public partial class WebCustomerRequest
{
    public string MemberName { get; set; } = null!;

    public long Serial { get; set; }

    public string Type { get; set; } = null!;

    public string? Notes { get; set; }

    public DateTime? Date { get; set; }

    public string? Status { get; set; }

    public string? CreatedBy { get; set; }

    public double? CoverageLimit { get; set; }

    public string? ResposeBy { get; set; }

    public string? Currency { get; set; }

    public string? Customer { get; set; }

    public string? MemberPhone { get; set; }
}
