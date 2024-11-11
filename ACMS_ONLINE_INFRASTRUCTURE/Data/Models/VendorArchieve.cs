using System;
using System.Collections.Generic;

namespace ACMS_ONLINE_INFRASTRUCTURE.Data.Models;

public partial class VendorArchieve
{
    public int VendorArchieveId { get; set; }

    public string? VendorId { get; set; }

    public string? VendorArchieveName { get; set; }

    public string? VendorArchieveFolderPath { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? LastUpdateFrom { get; set; }

    public virtual ICollection<VendorContract> VendorContracts { get; set; } = new List<VendorContract>();
}
