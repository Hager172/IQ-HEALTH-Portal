using System;
using System.Collections.Generic;

namespace ACMS_ONLINE_INFRASTRUCTURE.Data.Models;

public partial class VCustomerAllBill
{
    public int CustomerId { get; set; }

    public string CustomerName { get; set; } = null!;

    public string CustomerEmail { get; set; } = null!;

    public string CustomerContractId { get; set; } = null!;

    public string? PaymentType { get; set; }

    public DateOnly InstallmentDate { get; set; }

    public DateOnly? BillDate { get; set; }

    public string? BillStatus { get; set; }

    public decimal? BillValue { get; set; }

    public decimal? Collected { get; set; }

    public decimal? Balance { get; set; }

    public string InstallmentId { get; set; } = null!;

    public string? ContractType { get; set; }

    public double? InstallmentValue { get; set; }

    public int HasBill { get; set; }

    public int? Billid { get; set; }

    public decimal? AccBillId { get; set; }
}
