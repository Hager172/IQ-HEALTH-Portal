using System;
using System.Collections.Generic;

namespace ACMS_ONLINE_INFRASTRUCTURE.Data.Models;

public partial class GdRequest
{
    public int RequestId { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? StopDate { get; set; }

    public string? ContractId { get; set; }

    public string? UpdateFrom { get; set; }

    public string? UpdateBy { get; set; }

    public virtual CustomerContract? Contract { get; set; }

    public virtual ICollection<GdDetail> GdDetails { get; set; } = new List<GdDetail>();
}
