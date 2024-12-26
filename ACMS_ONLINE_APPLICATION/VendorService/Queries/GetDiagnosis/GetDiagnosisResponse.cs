using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_APPLICATION.VendorService.Queries.GetDiagnosis
{
    public class GetDiagnosisResponse
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public int Type { get; set; }
        public string  ICDTenCode { get; set; }
    }
}
