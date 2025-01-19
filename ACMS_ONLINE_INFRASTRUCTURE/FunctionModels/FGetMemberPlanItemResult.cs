using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_INFRASTRUCTURE.FunctionModels
{
    public class FGetMemberPlanItemResult
    {
        public string? med_item_name { get; set; }
        public int? copay { get; set; }
        public int? med_item { get; set; }
        public bool? active { get; set; }
        public bool?  pool { get; set; }
        public double? re_discount { get; set; }
    }
}
