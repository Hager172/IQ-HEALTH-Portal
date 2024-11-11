using System;
using System.Collections.Generic;

namespace ACMS_ONLINE_INFRASTRUCTURE.Data.Models;

public partial class AspNetUser
{
    public string Id { get; set; } = null!;

    public string? Email { get; set; }

    public bool EmailConfirmed { get; set; }

    public string? PasswordHash { get; set; }

    public string? SecurityStamp { get; set; }

    public string? PhoneNumber { get; set; }

    public bool PhoneNumberConfirmed { get; set; }

    public bool TwoFactorEnabled { get; set; }

    public DateTime? LockoutEndDateUtc { get; set; }

    public bool LockoutEnabled { get; set; }

    public int AccessFailedCount { get; set; }

    public string UserName { get; set; } = null!;

    public int? DefaultCustomer { get; set; }

    public bool? IsActive { get; set; }

    public string? UserGroup { get; set; }

    public bool? IsGroup { get; set; }

    public string? NormalizedUserName { get; set; }

    public string? NormalizedEmail { get; set; }

    public string? ConcurrencyStamp { get; set; }

    public DateTime? LockoutEnd { get; set; }

    public string? MemberId { get; set; }

    public virtual ICollection<AccFinancialYr> AccFinancialYrs { get; set; } = new List<AccFinancialYr>();

    public virtual ICollection<AcmcPrivilege> AcmcPrivileges { get; set; } = new List<AcmcPrivilege>();

    public virtual ICollection<AspNetUserClaim> AspNetUserClaims { get; set; } = new List<AspNetUserClaim>();

    public virtual ICollection<AspNetUserLogin> AspNetUserLogins { get; set; } = new List<AspNetUserLogin>();

    public virtual ICollection<CustomerAuthorizationRequest> CustomerAuthorizationRequestRequestUsers { get; set; } = new List<CustomerAuthorizationRequest>();

    public virtual ICollection<CustomerAuthorizationRequest> CustomerAuthorizationRequestResponseUsers { get; set; } = new List<CustomerAuthorizationRequest>();

    public virtual ICollection<AspNetUser> InverseUserGroupNavigation { get; set; } = new List<AspNetUser>();

    public virtual Member? Member { get; set; }

    public virtual ICollection<MembersComplaint> MembersComplaints { get; set; } = new List<MembersComplaint>();

    public virtual ICollection<OnlineUserClient> OnlineUserClients { get; set; } = new List<OnlineUserClient>();

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();

    public virtual ICollection<UpdatedNewsAspNetUser> UpdatedNewsAspNetUsers { get; set; } = new List<UpdatedNewsAspNetUser>();

    public virtual UserAdditionalDatum? UserAdditionalDatum { get; set; }

    public virtual ICollection<UserCustomer> UserCustomers { get; set; } = new List<UserCustomer>();

    public virtual AspNetUser? UserGroupNavigation { get; set; }

    public virtual ICollection<UserNotification> UserNotifications { get; set; } = new List<UserNotification>();

    public virtual ICollection<UserPlan> UserPlans { get; set; } = new List<UserPlan>();

    public virtual ICollection<UserReportColumn> UserReportColumns { get; set; } = new List<UserReportColumn>();

    public virtual ICollection<UserVerification> UserVerifications { get; set; } = new List<UserVerification>();

    public virtual ICollection<UserWarehouse> UserWarehouses { get; set; } = new List<UserWarehouse>();

    public virtual ICollection<WafdeenMashEmp> WafdeenMashEmps { get; set; } = new List<WafdeenMashEmp>();

    public virtual ICollection<LocalTicket> LocalReqs { get; set; } = new List<LocalTicket>();

    public virtual ICollection<AspNetRole> Roles { get; set; } = new List<AspNetRole>();

    public virtual ICollection<CustomersVisit> Visits { get; set; } = new List<CustomersVisit>();
}
