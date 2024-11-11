using System;
using System.Collections.Generic;

namespace ACMS_ONLINE_INFRASTRUCTURE.Data.Models;

public partial class VendorSpecialrole
{
    public string VendorId { get; set; } = null!;

    public string Exception { get; set; } = null!;

    public virtual VendorGeneral Vendor { get; set; } = null!;
}
