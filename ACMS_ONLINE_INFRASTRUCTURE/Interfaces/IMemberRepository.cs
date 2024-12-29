using ACMS_ONLINE_INFRASTRUCTURE.Data.Models;
using ACMS_ONLINE_INFRASTRUCTURE.FunctionModels;
using Azure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_INFRASTRUCTURE.Interfaces
{
    public interface IMemberRepository : IBaseRepository<Member>
    {
        //Task<Member> GetMemberByIdAsync(string id);

        Task<string> getMemberStautsAtDate(string MemberId,DateTime validAt);
        Task<List<FGetMemberPlanItemResult>> FGetMemberPlanItems(string q, string planCode, string vendorId, int? category, string memberId);



    }
}
