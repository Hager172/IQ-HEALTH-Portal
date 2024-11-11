using System;
using System.Collections.Generic;

namespace ACMS_ONLINE_INFRASTRUCTURE.Data.Models;

public partial class OnlineUserClient
{
    public string UserId { get; set; } = null!;

    public int ClientId { get; set; }

    public bool IsDefault { get; set; }

    public string? VendorId { get; set; }

    public long? BranchId { get; set; }

    public virtual OnlineClient Client { get; set; } = null!;

    public virtual AspNetUser User { get; set; } = null!;
}
