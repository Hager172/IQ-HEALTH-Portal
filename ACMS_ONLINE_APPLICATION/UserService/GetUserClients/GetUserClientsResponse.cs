using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_APPLICATION.User.GetUserClients
{
    public class GetUserClientsResponse
    {
        public string UserId { get; set; } = null!;

        public int ClientId { get; set; }

        public bool IsDefault { get; set; }

        public string? VendorId { get; set; }

        public long? BranchId { get; set; }
        public string ClientName { get; set; }

    }
}
