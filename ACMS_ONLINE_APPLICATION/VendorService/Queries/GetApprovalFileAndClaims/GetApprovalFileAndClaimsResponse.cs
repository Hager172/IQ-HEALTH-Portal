using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_APPLICATION.VendorService.Queries.GetApprovalFileAndClaims
{
    public class GetApprovalFileAndClaimsResponse
    {

        public string FileName { get; set; }
        public byte[] FileContent { get; set; }
        public List<ClaimTypeDto> ClaimTypes { get; set; }
    }

    public class ClaimTypeDto
    {
        public int TypeId { get; set; }
        public string TypeName { get; set; } 
    }
}
