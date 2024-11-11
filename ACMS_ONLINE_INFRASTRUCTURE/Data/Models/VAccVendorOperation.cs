using System;
using System.Collections.Generic;

namespace ACMS_ONLINE_INFRASTRUCTURE.Data.Models;

public partial class VAccVendorOperation
{
    public string VendorId { get; set; } = null!;

    public string? VendorName { get; set; }

    public double? OppeningBalance { get; set; }

    public double? Credit { get; set; }

    public double? Debit { get; set; }
}
