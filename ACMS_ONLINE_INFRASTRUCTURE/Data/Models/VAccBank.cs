using System;
using System.Collections.Generic;

namespace ACMS_ONLINE_INFRASTRUCTURE.Data.Models;

public partial class VAccBank
{
    public int? SafeBankSerial { get; set; }

    public string SbType { get; set; } = null!;

    public string SbName { get; set; } = null!;
}
