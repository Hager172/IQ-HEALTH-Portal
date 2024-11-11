using System;
using System.Collections.Generic;

namespace ACMS_ONLINE_INFRASTRUCTURE.Data.Models;

public partial class WafdeenVisit
{
    public int CaseId { get; set; }

    public string MemberId { get; set; } = null!;

    public string ContractId { get; set; } = null!;

    public DateTime ArrivalDate { get; set; }

    public DateTime? TravelDate { get; set; }

    public string? CaseComplain { get; set; }

    public string? InitialDiagnose { get; set; }

    public string? FinalDiagnose { get; set; }

    public string? MedicalRecommendation { get; set; }

    public string? Kafeel { get; set; }

    public string? PassportId { get; set; }

    public DateTime? HospitalEntryDate { get; set; }

    public DateTime? HospitalOutDate { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public string LastUpdateFrom { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public bool CaseStatus { get; set; }

    public int? Age { get; set; }

    public int MedRecommendationStatus { get; set; }

    public string? KafeelRelation { get; set; }

    public string? PhoneEg { get; set; }

    public string? MemberAdmin { get; set; }

    public int? ResponsibleEmp { get; set; }

    public bool? SocialCharity { get; set; }

    public string? CharityNote { get; set; }

    public bool? HostingStatus { get; set; }

    public bool? HostingCharityStatus { get; set; }

    public double? CharityPercentage { get; set; }

    public double? SocialPercentage { get; set; }

    public string? HostingCharityNote { get; set; }

    public string? VendorId { get; set; }

    public string? VendorPlaceResidence { get; set; }

    public virtual Member Member { get; set; } = null!;

    public virtual WafdeenMashEmp? ResponsibleEmpNavigation { get; set; }

    public virtual VendorGeneral? Vendor { get; set; }

    public virtual ICollection<VisitDiagnosis> VisitDiagnoses { get; set; } = new List<VisitDiagnosis>();

    public virtual ICollection<WafdeenMembersSchedule> WafdeenMembersSchedules { get; set; } = new List<WafdeenMembersSchedule>();
}
