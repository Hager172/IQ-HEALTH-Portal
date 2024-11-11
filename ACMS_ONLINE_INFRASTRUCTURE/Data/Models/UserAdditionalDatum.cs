using System;
using System.Collections.Generic;

namespace ACMS_ONLINE_INFRASTRUCTURE.Data.Models;

public partial class UserAdditionalDatum
{
    public string UserId { get; set; } = null!;

    public string ChartAccountId { get; set; } = null!;

    public virtual AspNetUser User { get; set; } = null!;
}
