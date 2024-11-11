using System;
using System.Collections.Generic;

namespace ACMS_ONLINE_INFRASTRUCTURE.Data.Models;

public partial class ClientOnlineUser
{
    public long UserId { get; set; }

    public int ClientId { get; set; }

    public string VendorId { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public virtual VendorGeneral Vendor { get; set; } = null!;
}
