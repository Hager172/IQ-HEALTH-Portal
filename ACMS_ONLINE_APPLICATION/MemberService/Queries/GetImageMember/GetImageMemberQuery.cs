using ACMS_ONLINE_INFRASTRUCTURE.Utility.ResponseModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_APPLICATION.MemberService.Queries.GetImageMember
{
    public class GetImageMemberQuery: IRequest<ServiceResponse<GetImageMemberResponse>>
    {
        public string MemberId { get; set; }
       
        public string ContractId { get; set; }
       
    
    }
}
