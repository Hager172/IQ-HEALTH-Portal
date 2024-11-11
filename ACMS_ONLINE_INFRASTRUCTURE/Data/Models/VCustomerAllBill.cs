using System;
using System.Collections.Generic;

namespace ACMS_ONLINE_INFRASTRUCTURE.Data.Models;

public partial class VCustomerAllBill
{
    public int CustomerId { get; set; }

    public string CustomerName { get; set; } = null!;

    public string CustomerEmail { get; set; } = null!;

    public string CustomerContractId { get; set; } = null!;

    public DateOnly InstallmentDate { get; set; }

    public DateTime? BillDate { get; set; }

    public decimal? BillValue { get; set; }

    public decimal? Collected { get; set; }

    public decimal? Balance { get; set; }

    public string InstallmentId { get; set; } = null!;

    public int? InstallmentValue { get; set; }

    public int HasBill { get; set; }

    public decimal? Billid { get; set; }
}
