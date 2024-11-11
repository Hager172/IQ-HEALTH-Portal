using System;
using System.Collections.Generic;

namespace ACMS_ONLINE_INFRASTRUCTURE.Data.Models;

public partial class Residence
{
    public string ResidenceId { get; set; } = null!;

    public string ResidenceName { get; set; } = null!;

    public virtual ICollection<ContractPlan> ContractPlans { get; set; } = new List<ContractPlan>();
}
