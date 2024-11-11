using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_APPLICATION.ApprovalService.Queries.GetMemberDetails
{
    public class GetMemberByIdDto :IRequest<GetMemberDetailsDto>   
    {
        public string MemberId { get; set; }
    }
}
