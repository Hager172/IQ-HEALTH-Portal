using System;
using System.Collections.Generic;

namespace ACMS_ONLINE_INFRASTRUCTURE.Data.Models;

public partial class CustomerContract
{
    public string CustomerContractId { get; set; } = null!;

    public DateTime CustomerContractStartDate { get; set; }

    public DateTime CustomerContractEndDate { get; set; }

    public string CustomerContractCheckIssuance { get; set; } = null!;

    public double? CustomerContractEliminationRatio { get; set; }

    public DateTime CustomerContractMaxDateAddMembers { get; set; }

    public string? CustomerContractNotes { get; set; }

    public int? CustomerContractInsurer { get; set; }

    public int? CustomerContractMembersNumber { get; set; }

    public int CustomerContractCustomerId { get; set; }

    public string CustomerContractCategory { get; set; } = null!;

    public DateTime? ContractPlanChronicDate { get; set; }

    public double? CustomerContractManagementRatio { get; set; }

    public int? ApprovalValid { get; set; }

    public int? ApprovalValidChronic { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public string LastUpdateFrom { get; set; } = null!;

    public bool? Isgross { get; set; }

    public int? ChildrenAge { get; set; }

    public int? FollowersNumber { get; set; }

    public double? StopValue { get; set; }

    public bool? ClacByDays { get; set; }

    public bool? AllowDeleteWithcons { get; set; }

    public short? DeleteOfprimRatio { get; set; }

    public short? MinimumMoths { get; set; }

    public short? EliminationDelation { get; set; }

    public int? PolicyDocument { get; set; }

    public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();

    public virtual ICollection<ContractActivity> ContractActivities { get; set; } = new List<ContractActivity>();

    public virtual ICollection<ContractBroker> ContractBrokers { get; set; } = new List<ContractBroker>();

    public virtual ICollection<ContractInstallment> ContractInstallments { get; set; } = new List<ContractInstallment>();

    public virtual ICollection<ContractPlan> ContractPlans { get; set; } = new List<ContractPlan>();

    public virtual ICollection<ContractPool> ContractPools { get; set; } = new List<ContractPool>();

    public virtual ICollection<CustomerContractCategory> CustomerContractCategories { get; set; } = new List<CustomerContractCategory>();

    public virtual ContractType1 CustomerContractCategoryNavigation { get; set; } = null!;

    public virtual Customer CustomerContractCustomer { get; set; } = null!;

    public virtual Customer? CustomerContractInsurerNavigation { get; set; }

    public virtual ICollection<MemberPlan> MemberPlans { get; set; } = new List<MemberPlan>();

    public virtual CustomerArchive? PolicyDocumentNavigation { get; set; }
}
