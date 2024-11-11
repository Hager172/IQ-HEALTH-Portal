using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_INFRASTRUCTURE.Utility.ResponseModel
{
    public class ServiceResponse <T>
    {
        public T? Data { get; set; }
        public bool Success { get; set; } = true;
        public int? Status { get; set; }
        public string MessageEn { get; set; } = string.Empty;
        public string MessageAr { get; set; } = string.Empty;
    }
}
