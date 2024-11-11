using System;
using System.Collections.Generic;

namespace ACMS_ONLINE_INFRASTRUCTURE.Data.Models;

public partial class VOtherOnlineUser
{
    public long Id { get; set; }

    public string UserName { get; set; } = null!;

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public short? Status { get; set; }

    public int? RoleId { get; set; }

    public string? Vendor { get; set; }

    public string? VType { get; set; }
}
