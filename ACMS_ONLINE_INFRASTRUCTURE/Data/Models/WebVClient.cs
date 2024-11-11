using System;
using System.Collections.Generic;

namespace ACMS_ONLINE_INFRASTRUCTURE.Data.Models;

public partial class WebVClient
{
    public int CustomerId { get; set; }

    public string CustomerName { get; set; } = null!;

    public string CustomerContractId { get; set; } = null!;
}
