using System;
using System.Collections.Generic;

namespace ACMS_ONLINE_INFRASTRUCTURE.Data.Models;

public partial class VendorRating
{
    public int VendorRateId { get; set; }

    public string VendorId { get; set; } = null!;

    public string MemberId { get; set; } = null!;

    public int? Rate { get; set; }

    public string? ReteNote { get; set; }

    public DateOnly? RatingDate { get; set; }

    public string? PhoneNumber { get; set; }

    public long? VendorBranchSerial { get; set; }

    public virtual Member Member { get; set; } = null!;

    public virtual VendorGeneral Vendor { get; set; } = null!;

    public virtual VendorBranch? VendorBranchSerialNavigation { get; set; }
}
