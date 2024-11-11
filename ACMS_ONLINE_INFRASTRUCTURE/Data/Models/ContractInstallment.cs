using System;
using System.Collections.Generic;

namespace ACMS_ONLINE_INFRASTRUCTURE.Data.Models;

public partial class ContractInstallment
{
    public string InstallmentId { get; set; } = null!;

    public string? PaymentType { get; set; }

    public DateOnly InstallmentDate { get; set; }

    public bool? IsValue { get; set; }

    public int? InstallmentValue { get; set; }

    public string? LastUpdatedFrom { get; set; }

    public string? LastUpdatedBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? Notes { get; set; }

    public string CustomerContractId { get; set; } = null!;

    public virtual CustomerContract CustomerContract { get; set; } = null!;

    public virtual PaymentType? PaymentTypeNavigation { get; set; }
}
