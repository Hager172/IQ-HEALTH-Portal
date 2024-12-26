using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_DOMAIN.Approval.Entities
{
    public class ClaimsType
    {
        public int TypeId { get; set; }

        public string Type { get; set; } = null!;

        public virtual ICollection<Approval> Approvals { get; set; } = new List<Approval>();

    }
}
