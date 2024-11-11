using System;
using System.Collections.Generic;

namespace ACMS_ONLINE_INFRASTRUCTURE.Data.Models;

public partial class OnlineClient
{
    public int ClientId { get; set; }

    public string ClientName { get; set; } = null!;

    public string ConnectionString { get; set; } = null!;

    public virtual ICollection<OnlineUserClient> OnlineUserClients { get; set; } = new List<OnlineUserClient>();
}
