using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_DOMAIN.Approval.Entities
{
    public partial class OnlineDiagnosis
    {
        public string Id { get; set; } = null!;

        public string? Name { get; set; }

        public int Category { get; set; }

        public int CareItem { get; set; }

        public int? Type { get; set; }

        public virtual ICollection<Approval> Approvals { get; set; } = new List<Approval>();

     
    }

}
