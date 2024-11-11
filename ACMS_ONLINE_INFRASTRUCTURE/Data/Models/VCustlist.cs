using System;
using System.Collections.Generic;

namespace ACMS_ONLINE_INFRASTRUCTURE.Data.Models;

public partial class VCustlist
{
    public int CustomerId { get; set; }

    public string CustomerName { get; set; } = null!;

    public int? CusParent { get; set; }
}
