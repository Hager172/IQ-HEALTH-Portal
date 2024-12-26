using ACMS_ONLINE_INFRASTRUCTURE.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_APPLICATION.ApprovalService.Queries.GetMemberDetails
{
    public class GetMemberDetailsDto
    {
        public string? MemberId { get; set; } = null!;

        public int? MemberCustomerId { get; set; }

        public string? MemberName { get; set; } = null!;
        public string? ImagePath { get; set; } = null!;

        //public string MemberGender { get; set; } = null!;

        public DateTime? MemberBirthday { get; set; }

        //public string? MemberNationalId { get; set; }

        //public string? MemberJob { get; set; }

        public bool MemberVip { get; set; }

        public string? MemberTele { get; set; }

        //public string? MemberTele2 { get; set; }

        //public string? MemberTele3 { get; set; }

        //public string? MemberCompanyId { get; set; }

        //public string? MemberExternalCode { get; set; }

        public string? MemberNotes { get; set; }

        //public string LastUpdateBy { get; set; } = null!;

        //public string LastUpdateFrom { get; set; } = null!;

        //public DateTime LastUpdateDate { get; set; }

        //public int? MemberCareCardId { get; set; }

        //public DateOnly? MemberCareCardDate { get; set; }

        //public int? MemberCareCardValue { get; set; }

        //public string? MemberCareCardStatus { get; set; }

        //public DateTime? MemberSubDate { get; set; }

        //public DateTime MemberCreationDate { get; set; }

        public string? MemberStatues { get; set; } = null!;

        //public bool? MemberEip { get; set; }

        //public bool? MemberFrequent { get; set; }

        public string? MemberParent { get; set; }

        //public bool? MemberOnlineApprovals { get; set; }

        //public string? MemberClass { get; set; }

        //public string? MobPlatform { get; set; }

        //public string? MobToken { get; set; }

        //public int? MobPushFlag { get; set; }

        //public string? Password { get; set; }

        //public string? MailCode { get; set; }

        //public string? PhoneCode { get; set; }

        //public string? IsRegistered { get; set; }

        //public string? FmcToken { get; set; }

        //public string? AlarmMsg { get; set; }

        //public string? Email { get; set; }

        //public int? AreaId { get; set; }

        //public string? MemberAddress { get; set; }

        //public string? BankNumber { get; set; }

        //public string? AccountNumber { get; set; }
        public string? balance { get; set; }
        public string? ParentName { get; set; }
        public bool? ShowMobProfile { get; set; }
        public string? PlanCode { get; set; }
        public string? ContractCode { get; set; }
        public string? CustomerName { get; set; }

        public List<ApprovalDto> InternalClaims { get; set; } = new List<ApprovalDto>();
    }



    public class ApprovalDto
    {
        public long ApprovalId { get; set; }
        public DateTime ApprovalDate { get; set; }
        public string? Notes { get; set; }
        public List<ApprovalServiceDto> ApprovalServices { get; set; }
    }
    public class ApprovalServiceDto
    {
        public string? ServiceName { get; set; }
        public int item_serial { get; set; }
        public double qty { get; set; }
        public double price { get; set; }
    }

}
