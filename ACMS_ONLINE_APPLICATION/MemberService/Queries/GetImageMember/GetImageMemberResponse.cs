using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_APPLICATION.MemberService.Queries.GetImageMember
{
    public class GetImageMemberResponse
    {
        public string MemberId { get; set; }
      
        public byte[] FileContent { get; set; }

    }
}
