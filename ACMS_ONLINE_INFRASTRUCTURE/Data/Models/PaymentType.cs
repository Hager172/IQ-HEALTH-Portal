using System;
using System.Collections.Generic;

namespace ACMS_ONLINE_INFRASTRUCTURE.Data.Models;

public partial class PaymentType
{
    public string PaymentTypeId { get; set; } = null!;

    public string? PaymentType1 { get; set; }

    public virtual ICollection<ContractInstallment> ContractInstallments { get; set; } = new List<ContractInstallment>();
}
