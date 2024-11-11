using System;
using System.Collections.Generic;

namespace ACMS_ONLINE_INFRASTRUCTURE.Data.Models;

public partial class Broker
{
    public int BrokerId { get; set; }

    public string BrokerName { get; set; } = null!;

    public int BrokerPhone { get; set; }

    public string? BrokerMail { get; set; }

    public string? BrokerAddress { get; set; }

    public string? BankAccount { get; set; }

    public string? BankName { get; set; }

    public int? NationalId { get; set; }

    public string? Notes { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public virtual ICollection<ContractBroker> ContractBrokers { get; set; } = new List<ContractBroker>();
}
