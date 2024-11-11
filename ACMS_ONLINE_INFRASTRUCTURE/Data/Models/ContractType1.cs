using System;
using System.Collections.Generic;

namespace ACMS_ONLINE_INFRASTRUCTURE.Data.Models;

public partial class ContractType1
{
    public string ContractTypeId { get; set; } = null!;

    public string? ContractTypeNameAr { get; set; }

    public string? ContractTypeNameEn { get; set; }

    public virtual ICollection<BatchDetail> BatchDetails { get; set; } = new List<BatchDetail>();

    public virtual ICollection<ContractActivity> ContractActivities { get; set; } = new List<ContractActivity>();

    public virtual ICollection<CustomerContract> CustomerContracts { get; set; } = new List<CustomerContract>();
}
