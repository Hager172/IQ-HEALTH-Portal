using System;
using System.Collections.Generic;

namespace ACMS_ONLINE_INFRASTRUCTURE.Data.Models;

public partial class ClaimsType
{
    public int TypeId { get; set; }

    public string Type { get; set; } = null!;

    public virtual ICollection<Approval> Approvals { get; set; } = new List<Approval>();
}
