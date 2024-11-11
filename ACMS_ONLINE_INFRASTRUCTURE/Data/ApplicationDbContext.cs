using System;
using System.Collections.Generic;
using ACMS_ONLINE_INFRASTRUCTURE.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ACMS_ONLINE_INFRASTRUCTURE.Data;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AccAccountMapping> AccAccountMappings { get; set; }

    public virtual DbSet<AccFinancialYr> AccFinancialYrs { get; set; }

    public virtual DbSet<AccReport> AccReports { get; set; }

    public virtual DbSet<AccVendorClosedYr> AccVendorClosedYrs { get; set; }

    public virtual DbSet<AcmcPage> AcmcPages { get; set; }

    public virtual DbSet<AcmcPrivilege> AcmcPrivileges { get; set; }

    public virtual DbSet<AcmsNotification> AcmsNotifications { get; set; }

    public virtual DbSet<AcmsOption> AcmsOptions { get; set; }

    public virtual DbSet<AcmsPharma> AcmsPharmas { get; set; }

    public virtual DbSet<AcmsSpecialization> AcmsSpecializations { get; set; }

    public virtual DbSet<AcmsWarehouse> AcmsWarehouses { get; set; }

    public virtual DbSet<ACMS_ONLINE_INFRASTRUCTURE.Data.Models.Action> Actions { get; set; }

    public virtual DbSet<ActiveCustomer> ActiveCustomers { get; set; }

    public virtual DbSet<Approval> Approvals { get; set; }

    public virtual DbSet<ApprovalChatSeen> ApprovalChatSeens { get; set; }

    public virtual DbSet<ApprovalRating> ApprovalRatings { get; set; }

    public virtual DbSet<ApprovalService> ApprovalServices { get; set; }

    public virtual DbSet<ApprovalServicesOnline> ApprovalServicesOnlines { get; set; }

    public virtual DbSet<ApprovalsArchive> ApprovalsArchives { get; set; }

    public virtual DbSet<ApprovalsArchiveOnline> ApprovalsArchiveOnlines { get; set; }

    public virtual DbSet<ApprovalsLog> ApprovalsLogs { get; set; }

    public virtual DbSet<ApprovalsLogOnline> ApprovalsLogOnlines { get; set; }

    public virtual DbSet<ApprovalsOnline> ApprovalsOnlines { get; set; }

    public virtual DbSet<ApprovalsPrivateNote> ApprovalsPrivateNotes { get; set; }

    public virtual DbSet<ApprovalsTagsMap> ApprovalsTagsMaps { get; set; }

    public virtual DbSet<Area> Areas { get; set; }

    public virtual DbSet<AspNetRole> AspNetRoles { get; set; }

    public virtual DbSet<AspNetUser> AspNetUsers { get; set; }

    public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }

    public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }

    public virtual DbSet<AttachedDocumentName> AttachedDocumentNames { get; set; }

    public virtual DbSet<Batch> Batches { get; set; }

    public virtual DbSet<BatchDetail> BatchDetails { get; set; }

    public virtual DbSet<BatchGroup> BatchGroups { get; set; }

    public virtual DbSet<BatchLog> BatchLogs { get; set; }

    public virtual DbSet<Bill> Bills { get; set; }

    public virtual DbSet<BillDetail> BillDetails { get; set; }

    public virtual DbSet<BillsLog> BillsLogs { get; set; }

    public virtual DbSet<BlueCode> BlueCodes { get; set; }

    public virtual DbSet<Broker> Brokers { get; set; }

    public virtual DbSet<CardSetting> CardSettings { get; set; }

    public virtual DbSet<CareItem> CareItems { get; set; }

    public virtual DbSet<ChronicLookupTable> ChronicLookupTables { get; set; }

    public virtual DbSet<Claim> Claims { get; set; }

    public virtual DbSet<ClaimFormLot> ClaimFormLots { get; set; }

    public virtual DbSet<ClaimLog> ClaimLogs { get; set; }

    public virtual DbSet<ClaimLotsFormsCode> ClaimLotsFormsCodes { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Contact> Contacts { get; set; }

    public virtual DbSet<ContactsOccupation> ContactsOccupations { get; set; }

    public virtual DbSet<ContactsTemp> ContactsTemps { get; set; }

    public virtual DbSet<ContractActivity> ContractActivities { get; set; }

    public virtual DbSet<ContractBroker> ContractBrokers { get; set; }

    public virtual DbSet<ContractCategory> ContractCategories { get; set; }

    public virtual DbSet<ContractInstallment> ContractInstallments { get; set; }

    public virtual DbSet<ContractPlan> ContractPlans { get; set; }

    public virtual DbSet<ContractPool> ContractPools { get; set; }

    public virtual DbSet<ContractService> ContractServices { get; set; }

    public virtual DbSet<ContractType> ContractTypes { get; set; }

    public virtual DbSet<ContractType1> ContractTypes1 { get; set; }

    public virtual DbSet<Currency> Currencies { get; set; }

    public virtual DbSet<CurrencyExchangable> CurrencyExchangables { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<CustomerArchive> CustomerArchives { get; set; }

    public virtual DbSet<CustomerAuthorizationRequest> CustomerAuthorizationRequests { get; set; }

    public virtual DbSet<CustomerComplaint> CustomerComplaints { get; set; }

    public virtual DbSet<CustomerContact> CustomerContacts { get; set; }

    public virtual DbSet<CustomerContract> CustomerContracts { get; set; }

    public virtual DbSet<CustomerContractCategory> CustomerContractCategories { get; set; }

    public virtual DbSet<CustomerDatasheet> CustomerDatasheets { get; set; }

    public virtual DbSet<CustomerOutpatientService> CustomerOutpatientServices { get; set; }

    public virtual DbSet<CustomerStatusMonitor> CustomerStatusMonitors { get; set; }

    public virtual DbSet<CustomerVendorException> CustomerVendorExceptions { get; set; }

    public virtual DbSet<CustomersVisit> CustomersVisits { get; set; }

    public virtual DbSet<DaysOfTheWeek> DaysOfTheWeeks { get; set; }

    public virtual DbSet<DisRefund> DisRefunds { get; set; }

    public virtual DbSet<DueAttachedFile> DueAttachedFiles { get; set; }

    public virtual DbSet<GroupBatch> GroupBatches { get; set; }

    public virtual DbSet<GroupsLog> GroupsLogs { get; set; }

    public virtual DbSet<InActiveCustomer> InActiveCustomers { get; set; }

    public virtual DbSet<Inquery> Inqueries { get; set; }

    public virtual DbSet<InsurerVendorMap> InsurerVendorMaps { get; set; }

    public virtual DbSet<InvDetail> InvDetails { get; set; }

    public virtual DbSet<ItemCopayment> ItemCopayments { get; set; }

    public virtual DbSet<LocalTicket> LocalTickets { get; set; }

    public virtual DbSet<LocalTicketsReply> LocalTicketsReplies { get; set; }

    public virtual DbSet<LotForm> LotForms { get; set; }

    public virtual DbSet<MailRequest> MailRequests { get; set; }

    public virtual DbSet<MashPayment> MashPayments { get; set; }

    public virtual DbSet<McAuthenticate> McAuthenticates { get; set; }

    public virtual DbSet<McAuthenticateLog> McAuthenticateLogs { get; set; }

    public virtual DbSet<Member> Members { get; set; }

    public virtual DbSet<MemberArchiveDoc> MemberArchiveDocs { get; set; }

    public virtual DbSet<MemberContact> MemberContacts { get; set; }

    public virtual DbSet<MemberFamily> MemberFamilies { get; set; }

    public virtual DbSet<MemberPlan> MemberPlans { get; set; }

    public virtual DbSet<MemberPlanAuthenticateLog> MemberPlanAuthenticateLogs { get; set; }

    public virtual DbSet<MemberPlanLog> MemberPlanLogs { get; set; }

    public virtual DbSet<MemberPlanTemp> MemberPlanTemps { get; set; }

    public virtual DbSet<MemberStatusMonitor> MemberStatusMonitors { get; set; }

    public virtual DbSet<MembersComplaint> MembersComplaints { get; set; }

    public virtual DbSet<MembersLog> MembersLogs { get; set; }

    public virtual DbSet<MembersPlanItem> MembersPlanItems { get; set; }

    public virtual DbSet<MobileNotification> MobileNotifications { get; set; }

    public virtual DbSet<MordeenSupplied> MordeenSupplieds { get; set; }

    public virtual DbSet<Neqabat> Neqabats { get; set; }

    public virtual DbSet<NoteGroup> NoteGroups { get; set; }

    public virtual DbSet<NotesClaimGroup> NotesClaimGroups { get; set; }

    public virtual DbSet<NotesTpaGroup> NotesTpaGroups { get; set; }

    public virtual DbSet<NotificationsSchedule> NotificationsSchedules { get; set; }

    public virtual DbSet<OldUser> OldUsers { get; set; }

    public virtual DbSet<OnlineClient> OnlineClients { get; set; }

    public virtual DbSet<OnlineDiagnoseCategory> OnlineDiagnoseCategories { get; set; }

    public virtual DbSet<OnlineDiagnosis> OnlineDiagnoses { get; set; }

    public virtual DbSet<OnlineHome> OnlineHomes { get; set; }

    public virtual DbSet<OnlineItemCategory> OnlineItemCategories { get; set; }

    public virtual DbSet<OnlineLoginLog> OnlineLoginLogs { get; set; }

    public virtual DbSet<OnlineMedDiagnose> OnlineMedDiagnoses { get; set; }

    public virtual DbSet<OnlineMessage> OnlineMessages { get; set; }

    public virtual DbSet<OnlineOneUnitForm> OnlineOneUnitForms { get; set; }

    public virtual DbSet<OnlineRawMaterial> OnlineRawMaterials { get; set; }

    public virtual DbSet<OnlineServiceItem> OnlineServiceItems { get; set; }

    public virtual DbSet<OnlineSetting> OnlineSettings { get; set; }

    public virtual DbSet<OnlineSubmittedApproval> OnlineSubmittedApprovals { get; set; }

    public virtual DbSet<OnlineUser> OnlineUsers { get; set; }

    public virtual DbSet<OnlineUserClient> OnlineUserClients { get; set; }

    public virtual DbSet<OutlookAttachment> OutlookAttachments { get; set; }

    public virtual DbSet<OutlookEmail> OutlookEmails { get; set; }

    public virtual DbSet<PaymentChannel> PaymentChannels { get; set; }

    public virtual DbSet<PaymentType> PaymentTypes { get; set; }

    public virtual DbSet<PaymentsLog> PaymentsLogs { get; set; }

    public virtual DbSet<PharmaTemp> PharmaTemps { get; set; }

    public virtual DbSet<PlanItem> PlanItems { get; set; }

    public virtual DbSet<PlanItemDiagnosis> PlanItemDiagnoses { get; set; }

    public virtual DbSet<PlanItemRule> PlanItemRules { get; set; }

    public virtual DbSet<PrepareOnlinePatch> PrepareOnlinePatches { get; set; }

    public virtual DbSet<PrivilegeLog> PrivilegeLogs { get; set; }

    public virtual DbSet<PromoCode> PromoCodes { get; set; }

    public virtual DbSet<ProviderLog> ProviderLogs { get; set; }

    public virtual DbSet<RequestAttached> RequestAttacheds { get; set; }

    public virtual DbSet<Residence> Residences { get; set; }

    public virtual DbSet<RndView> RndViews { get; set; }

    public virtual DbSet<SchApproval> SchApprovals { get; set; }

    public virtual DbSet<SchApprovalService> SchApprovalServices { get; set; }

    public virtual DbSet<SchApprovalServicesLog> SchApprovalServicesLogs { get; set; }

    public virtual DbSet<SchApprovalsArchive> SchApprovalsArchives { get; set; }

    public virtual DbSet<SchApprovalsLog> SchApprovalsLogs { get; set; }

    public virtual DbSet<SchCustomerArchive> SchCustomerArchives { get; set; }

    public virtual DbSet<SourceQuery> SourceQueries { get; set; }

    public virtual DbSet<StandardService> StandardServices { get; set; }

    public virtual DbSet<StateRef> StateRefs { get; set; }

    public virtual DbSet<SubscriptionPlan> SubscriptionPlans { get; set; }

    public virtual DbSet<SudanCustomer> SudanCustomers { get; set; }

    public virtual DbSet<SysSetting> SysSettings { get; set; }

    public virtual DbSet<Tag> Tags { get; set; }

    public virtual DbSet<TaxPolicy> TaxPolicies { get; set; }

    public virtual DbSet<Ticket> Tickets { get; set; }

    public virtual DbSet<TicketsReply> TicketsReplies { get; set; }

    public virtual DbSet<TpaMapMeditem> TpaMapMeditems { get; set; }

    public virtual DbSet<TpaMappedMeditem> TpaMappedMeditems { get; set; }

    public virtual DbSet<UpdatedNews> UpdatedNews { get; set; }

    public virtual DbSet<UpdatedNewsAspNetUser> UpdatedNewsAspNetUsers { get; set; }

    public virtual DbSet<UserAdditionalDatum> UserAdditionalData { get; set; }

    public virtual DbSet<UserCustomer> UserCustomers { get; set; }

    public virtual DbSet<UserLog> UserLogs { get; set; }

    public virtual DbSet<UserNotification> UserNotifications { get; set; }

    public virtual DbSet<UserPlan> UserPlans { get; set; }

    public virtual DbSet<UserReportColumn> UserReportColumns { get; set; }

    public virtual DbSet<UserVerification> UserVerifications { get; set; }

    public virtual DbSet<UserWarehouse> UserWarehouses { get; set; }

    public virtual DbSet<VAccBank> VAccBanks { get; set; }

    public virtual DbSet<VAccInvoiceCollection> VAccInvoiceCollections { get; set; }

    public virtual DbSet<VAccVendorOperation> VAccVendorOperations { get; set; }

    public virtual DbSet<VAgentsPerformance> VAgentsPerformances { get; set; }

    public virtual DbSet<VAllBatchDetail> VAllBatchDetails { get; set; }

    public virtual DbSet<VAllBillOldDb> VAllBillOldDbs { get; set; }

    public virtual DbSet<VAllDue> VAllDues { get; set; }

    public virtual DbSet<VAllDues2> VAllDues2s { get; set; }

    public virtual DbSet<VAllDues3> VAllDues3s { get; set; }

    public virtual DbSet<VAllVBatchDetail> VAllVBatchDetails { get; set; }

    public virtual DbSet<VApprovalsDatum> VApprovalsData { get; set; }

    public virtual DbSet<VAuthorizedApproval> VAuthorizedApprovals { get; set; }

    public virtual DbSet<VBatchDetail> VBatchDetails { get; set; }

    public virtual DbSet<VBatchDetailsS> VBatchDetailsSes { get; set; }

    public virtual DbSet<VBillOldDb> VBillOldDbs { get; set; }

    public virtual DbSet<VBlueCode> VBlueCodes { get; set; }

    public virtual DbSet<VBranchesFromSearchVendor> VBranchesFromSearchVendors { get; set; }

    public virtual DbSet<VCashVendor> VCashVendors { get; set; }

    public virtual DbSet<VClientsWorklist> VClientsWorklists { get; set; }

    public virtual DbSet<VClientsWorklistOld> VClientsWorklistOlds { get; set; }

    public virtual DbSet<VCustlist> VCustlists { get; set; }

    public virtual DbSet<VCustomerAllBill> VCustomerAllBills { get; set; }

    public virtual DbSet<VCustomerConsumptionSummary> VCustomerConsumptionSummaries { get; set; }

    public virtual DbSet<VCustomerConsumptionSummaryTpa> VCustomerConsumptionSummaryTpas { get; set; }

    public virtual DbSet<VCustomerContact> VCustomerContacts { get; set; }

    public virtual DbSet<VCustomerContractsQuarterYear> VCustomerContractsQuarterYears { get; set; }

    public virtual DbSet<VCustomerVisit> VCustomerVisits { get; set; }

    public virtual DbSet<VCustomersAllNoteState> VCustomersAllNoteStates { get; set; }

    public virtual DbSet<VCustomersBillState> VCustomersBillStates { get; set; }

    public virtual DbSet<VDocWorklist> VDocWorklists { get; set; }

    public virtual DbSet<VGetAcmsNotificationsDatum> VGetAcmsNotificationsData { get; set; }

    public virtual DbSet<VGetApprovalService> VGetApprovalServices { get; set; }

    public virtual DbSet<VGetBillsDatum> VGetBillsData { get; set; }

    public virtual DbSet<VGetIsPackageContract> VGetIsPackageContracts { get; set; }

    public virtual DbSet<VGetMember> VGetMembers { get; set; }

    public virtual DbSet<VGetVendor> VGetVendors { get; set; }

    public virtual DbSet<VGetVendorService> VGetVendorServices { get; set; }

    public virtual DbSet<VGetallcontractserv> VGetallcontractservs { get; set; }

    public virtual DbSet<VInquery> VInqueries { get; set; }

    public virtual DbSet<VLogInformation> VLogInformations { get; set; }

    public virtual DbSet<VMainVendorsSearch> VMainVendorsSearches { get; set; }

    public virtual DbSet<VMashcachInquery> VMashcachInqueries { get; set; }

    public virtual DbSet<VMcPackageVendor> VMcPackageVendors { get; set; }

    public virtual DbSet<VMcSudanActiveMeber> VMcSudanActiveMebers { get; set; }

    public virtual DbSet<VMcSudanVendorsSearch> VMcSudanVendorsSearches { get; set; }

    public virtual DbSet<VMcVendorsCatGovCity> VMcVendorsCatGovCities { get; set; }

    public virtual DbSet<VMcVendorsSearch> VMcVendorsSearches { get; set; }

    public virtual DbSet<VMemberBill> VMemberBills { get; set; }

    public virtual DbSet<VMemberComplaintsDetail> VMemberComplaintsDetails { get; set; }

    public virtual DbSet<VMemberConsumption> VMemberConsumptions { get; set; }

    public virtual DbSet<VMemberConsumptionSudan> VMemberConsumptionSudans { get; set; }

    public virtual DbSet<VMemberFrequant> VMemberFrequants { get; set; }

    public virtual DbSet<VMembersBillOldDb> VMembersBillOldDbs { get; set; }

    public virtual DbSet<VMembersContractPremium> VMembersContractPremia { get; set; }

    public virtual DbSet<VMembership> VMemberships { get; set; }

    public virtual DbSet<VMobMemberHistory> VMobMemberHistories { get; set; }

    public virtual DbSet<VMobVendorsCatGovCity> VMobVendorsCatGovCities { get; set; }

    public virtual DbSet<VNotActiveContractVendor> VNotActiveContractVendors { get; set; }

    public virtual DbSet<VOnlineBranch> VOnlineBranches { get; set; }

    public virtual DbSet<VOnlineWorklist> VOnlineWorklists { get; set; }

    public virtual DbSet<VPendingReason> VPendingReasons { get; set; }

    public virtual DbSet<VPriceIndex> VPriceIndices { get; set; }

    public virtual DbSet<VRandom> VRandoms { get; set; }

    public virtual DbSet<VRecommendationService> VRecommendationServices { get; set; }

    public virtual DbSet<VReimpWorklist> VReimpWorklists { get; set; }

    public virtual DbSet<VScannedQr> VScannedQrs { get; set; }

    public virtual DbSet<VSearchAllMember> VSearchAllMembers { get; set; }

    public virtual DbSet<VSearchBillsCustomer> VSearchBillsCustomers { get; set; }

    public virtual DbSet<VServicesAnalysis> VServicesAnalyses { get; set; }

    public virtual DbSet<VSrvAnalisi> VSrvAnalises { get; set; }

    public virtual DbSet<VSubscriptionAnalysis> VSubscriptionAnalyses { get; set; }

    public virtual DbSet<VSudanGroupsSummary> VSudanGroupsSummaries { get; set; }

    public virtual DbSet<VSudanMemberConsumption> VSudanMemberConsumptions { get; set; }

    public virtual DbSet<VUsedPharma> VUsedPharmas { get; set; }

    public virtual DbSet<VUser> VUsers { get; set; }

    public virtual DbSet<VVendorBranch> VVendorBranches { get; set; }

    public virtual DbSet<VVendorBranchesMob> VVendorBranchesMobs { get; set; }

    public virtual DbSet<VVendorCurrentService> VVendorCurrentServices { get; set; }

    public virtual DbSet<VVendorLedger> VVendorLedgers { get; set; }

    public virtual DbSet<VVendorPayment> VVendorPayments { get; set; }

    public virtual DbSet<VVendorSearchWeeklyReport> VVendorSearchWeeklyReports { get; set; }

    public virtual DbSet<VVendorService> VVendorServices { get; set; }

    public virtual DbSet<VVendorsAdsLink> VVendorsAdsLinks { get; set; }

    public virtual DbSet<VVendorsAll> VVendorsAlls { get; set; }

    public virtual DbSet<VVendorsSearch> VVendorsSearches { get; set; }

    public virtual DbSet<VVendorsSearchAll> VVendorsSearchAlls { get; set; }

    public virtual DbSet<VWafedMember> VWafedMembers { get; set; }

    public virtual DbSet<VWebMember> VWebMembers { get; set; }

    public virtual DbSet<VWorklist> VWorklists { get; set; }

    public virtual DbSet<VendorArchieve> VendorArchieves { get; set; }

    public virtual DbSet<VendorBranch> VendorBranches { get; set; }

    public virtual DbSet<VendorBranchesTemp> VendorBranchesTemps { get; set; }

    public virtual DbSet<VendorCategory> VendorCategories { get; set; }

    public virtual DbSet<VendorChanged> VendorChangeds { get; set; }

    public virtual DbSet<VendorClaim> VendorClaims { get; set; }

    public virtual DbSet<VendorClaimPool> VendorClaimPools { get; set; }

    public virtual DbSet<VendorContract> VendorContracts { get; set; }

    public virtual DbSet<VendorDoctor> VendorDoctors { get; set; }

    public virtual DbSet<VendorFixedService> VendorFixedServices { get; set; }

    public virtual DbSet<VendorGeneral> VendorGenerals { get; set; }

    public virtual DbSet<VendorGeneralTemp> VendorGeneralTemps { get; set; }

    public virtual DbSet<VendorLog> VendorLogs { get; set; }

    public virtual DbSet<VendorMedCare> VendorMedCares { get; set; }

    public virtual DbSet<VendorMedCareTemp> VendorMedCareTemps { get; set; }

    public virtual DbSet<VendorOnlineUser> VendorOnlineUsers { get; set; }

    public virtual DbSet<VendorRating> VendorRatings { get; set; }

    public virtual DbSet<VendorShift> VendorShifts { get; set; }

    public virtual DbSet<VendorShiftsTemp> VendorShiftsTemps { get; set; }

    public virtual DbSet<VendorSpecialrole> VendorSpecialroles { get; set; }

    public virtual DbSet<VendorStatusMonitor> VendorStatusMonitors { get; set; }

    public virtual DbSet<VendorsCopayment> VendorsCopayments { get; set; }

    public virtual DbSet<VisitDiagnosis> VisitDiagnoses { get; set; }

    public virtual DbSet<WafdeenMashEmp> WafdeenMashEmps { get; set; }

    public virtual DbSet<WafdeenMembersSchedule> WafdeenMembersSchedules { get; set; }

    public virtual DbSet<WafdeenVisit> WafdeenVisits { get; set; }

    public virtual DbSet<WebCustomerRequest> WebCustomerRequests { get; set; }

    public virtual DbSet<WebOrder> WebOrders { get; set; }

    public virtual DbSet<WebOrderDrug> WebOrderDrugs { get; set; }

    public virtual DbSet<WebOrderFile> WebOrderFiles { get; set; }

    public virtual DbSet<WebVClient> WebVClients { get; set; }

    public virtual DbSet<WebVIcustomer> WebVIcustomers { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=150.200.12.7;initial catalog=acms_migration;persist security info=True;user id=acms_login;password=acms@bms;multipleactiveresultsets=True;trustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Arabic_CI_AS");

        modelBuilder.Entity<AccAccountMapping>(entity =>
        {
            entity.ToTable("acc_account_mapping");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("account_number");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_from");
            entity.Property(e => e.LinkId)
                .HasMaxLength(50)
                .HasColumnName("link_id");
        });

        modelBuilder.Entity<AccFinancialYr>(entity =>
        {
            entity.HasKey(e => e.RefCode);

            entity.ToTable("acc_financial_yr");

            entity.HasIndex(e => new { e.ClosedYear, e.RefCode }, "IX_acc_financial_yr").IsUnique();

            entity.Property(e => e.RefCode).HasColumnName("ref_code");
            entity.Property(e => e.BrowserInfo)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("browser_info");
            entity.Property(e => e.ClosedYear).HasColumnName("closed_year");
            entity.Property(e => e.EndTime)
                .HasColumnType("datetime")
                .HasColumnName("end_time");
            entity.Property(e => e.SecurityCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("security_code");
            entity.Property(e => e.StartTime)
                .HasColumnType("datetime")
                .HasColumnName("start_time");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.TransactionBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("transaction_by");
            entity.Property(e => e.TransactionDate)
                .HasColumnType("datetime")
                .HasColumnName("transaction_date");
            entity.Property(e => e.UserId)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("user_id");
            entity.Property(e => e.UserIp)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("user_ip");

            entity.HasOne(d => d.User).WithMany(p => p.AccFinancialYrs)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_acc_financial_yr_AspNetUsers");
        });

        modelBuilder.Entity<AccReport>(entity =>
        {
            entity.ToTable("ACC_Report");

            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.NumericalColumn).HasMaxLength(1000);
            entity.Property(e => e.Title)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AccVendorClosedYr>(entity =>
        {
            entity.HasKey(e => new { e.ClosedYear, e.VendorId });

            entity.ToTable("acc_vendor_closed_yr");

            entity.Property(e => e.ClosedYear).HasColumnName("closed_year");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");
            entity.Property(e => e.ActionDate)
                .HasColumnType("datetime")
                .HasColumnName("action_date");
            entity.Property(e => e.Balance).HasColumnName("balance");
            entity.Property(e => e.ClosedDate)
                .HasColumnType("datetime")
                .HasColumnName("closed_date");
            entity.Property(e => e.RefId).HasColumnName("ref_id");

            entity.HasOne(d => d.Ref).WithMany(p => p.AccVendorClosedYrRefs)
                .HasForeignKey(d => d.RefId)
                .HasConstraintName("FK_acc_vendor_closed_yr_acc_financial_yr");

            entity.HasOne(d => d.Vendor).WithMany(p => p.AccVendorClosedYrs)
                .HasForeignKey(d => d.VendorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_acc_vendor_closed_yr_Vendor_General");

            entity.HasOne(d => d.AccFinancialYr).WithMany(p => p.AccVendorClosedYrAccFinancialYrs)
                .HasPrincipalKey(p => new { p.ClosedYear, p.RefCode })
                .HasForeignKey(d => new { d.ClosedYear, d.RefId })
                .HasConstraintName("FK_acc_vendor_closed_yr_acc_financial_yr1");
        });

        modelBuilder.Entity<AcmcPage>(entity =>
        {
            entity.HasKey(e => e.MenueId);

            entity.ToTable("acmc_Page");

            entity.Property(e => e.MenueId).HasColumnName("menue_id");
            entity.Property(e => e.MenueControl).HasColumnName("menue_control");
            entity.Property(e => e.MenueIcon)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("menue_icon");
            entity.Property(e => e.MenueLink)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("menue_link");
            entity.Property(e => e.MenueName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("menue_name");
            entity.Property(e => e.MenueParent).HasColumnName("menue_parent");
            entity.Property(e => e.MenueType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("menue_type");
        });

        modelBuilder.Entity<AcmcPrivilege>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.PageId });

            entity.ToTable("acmc_privilege");

            entity.Property(e => e.UserId)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("user_id");
            entity.Property(e => e.PageId).HasColumnName("page_id");
            entity.Property(e => e.PrevAdd).HasColumnName("prev_add");
            entity.Property(e => e.PrevCancel).HasColumnName("prev_cancel");
            entity.Property(e => e.PrevEdit).HasColumnName("prev_edit");
            entity.Property(e => e.PrevExport).HasColumnName("prev_export");
            entity.Property(e => e.PrevImport).HasColumnName("prev_import");
            entity.Property(e => e.PrevPrint).HasColumnName("prev_print");
            entity.Property(e => e.PrevSpacialcase).HasColumnName("prev_spacialcase");
            entity.Property(e => e.PrevSubmit).HasColumnName("prev_submit");
            entity.Property(e => e.PrevUnsubmit).HasColumnName("prev_unsubmit");
            entity.Property(e => e.PrevView).HasColumnName("prev_view");

            entity.HasOne(d => d.Page).WithMany(p => p.AcmcPrivileges)
                .HasForeignKey(d => d.PageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_acmc_privilege_acmc_Page");

            entity.HasOne(d => d.User).WithMany(p => p.AcmcPrivileges)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_acmc_privilege_AspNetUsers");
        });

        modelBuilder.Entity<AcmsNotification>(entity =>
        {
            entity.ToTable("acms_notifications");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActionId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("action_id");
            entity.Property(e => e.Body)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("body");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.Link)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("link");
            entity.Property(e => e.Title)
                .HasMaxLength(48)
                .IsUnicode(false)
                .HasColumnName("title");
            entity.Property(e => e.Type)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("type");
        });

        modelBuilder.Entity<AcmsOption>(entity =>
        {
            entity.HasKey(e => e.OptId).HasName("PK__acms_opt__B6850044DDC04D70");

            entity.ToTable("acms_options");

            entity.Property(e => e.OptId).HasColumnName("optId");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.OptGroup).HasColumnName("optGroup");
            entity.Property(e => e.OptName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("optName");
            entity.Property(e => e.OptNameAr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("optNameAr");

            entity.HasOne(d => d.OptGroupNavigation).WithMany(p => p.InverseOptGroupNavigation)
                .HasForeignKey(d => d.OptGroup)
                .HasConstraintName("FK_optGroup");
        });

        modelBuilder.Entity<AcmsPharma>(entity =>
        {
            entity.ToTable("acms_pharma");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Availability)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("availability");
            entity.Property(e => e.DoseForm)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("dose_form");
            entity.Property(e => e.DoseUnitNo).HasColumnName("dose_unit_no");
            entity.Property(e => e.LastPriceDate)
                .HasColumnType("datetime")
                .HasColumnName("last_price_date");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LAST_UPDATE_BY");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATE_DATE");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Notes)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.PriceUpdateId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("price_update_id");
            entity.Property(e => e.Source)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("source");
            entity.Property(e => e.SubUnitNo).HasColumnName("sub_unit_no");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.UnitSale)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("unit_sale");

            entity.HasMany(d => d.IdRaws).WithMany(p => p.IdMeds)
                .UsingEntity<Dictionary<string, object>>(
                    "OnlineMedRaw",
                    r => r.HasOne<OnlineRawMaterial>().WithMany()
                        .HasForeignKey("IdRaw")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_online_med_raw_online_raw_materials"),
                    l => l.HasOne<AcmsPharma>().WithMany()
                        .HasForeignKey("IdMed")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_online_med_raw_acms_pharma"),
                    j =>
                    {
                        j.HasKey("IdMed", "IdRaw");
                        j.ToTable("online_med_raw", tb =>
                            {
                                tb.HasTrigger("trigger_delete_online_med_raw");
                                tb.HasTrigger("trigger_insert_online_med_raw");
                            });
                        j.IndexerProperty<int>("IdMed").HasColumnName("id_med");
                        j.IndexerProperty<int>("IdRaw").HasColumnName("id_raw");
                    });
        });

        modelBuilder.Entity<AcmsSpecialization>(entity =>
        {
            entity.ToTable("acms_specialization");

            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("last_update_from");
            entity.Property(e => e.NameAr)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name_ar");
            entity.Property(e => e.NameEn)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name_en");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<AcmsWarehouse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_acms_stocks");

            entity.ToTable("acms_warehouse");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.IsLocked).HasColumnName("is_locked");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("last_update_from");
            entity.Property(e => e.Manger)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("manger");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Tel).HasColumnName("tel");
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<ACMS_ONLINE_INFRASTRUCTURE.Data.Models.Action>(entity =>
        {
            entity.ToTable("actions");

            entity.Property(e => e.ActionId)
                .ValueGeneratedNever()
                .HasColumnName("action_id");
            entity.Property(e => e.ActionName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("action_name");
        });

        modelBuilder.Entity<ActiveCustomer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ActiveCustomers");

            entity.Property(e => e.CustomerAccountNum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_account_num");
            entity.Property(e => e.CustomerCommission).HasColumnName("customer_commission");
            entity.Property(e => e.CustomerContractEndDate)
                .HasColumnType("datetime")
                .HasColumnName("customer_contract_end_date");
            entity.Property(e => e.CustomerContractId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("customer_contract_id");
            entity.Property(e => e.CustomerContractStartDate)
                .HasColumnType("datetime")
                .HasColumnName("customer_contract_start_date");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("customer_name");
            entity.Property(e => e.CustomerRecordNumber)
                .HasMaxLength(25)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_record_number");
            entity.Property(e => e.CustomerTaxCard)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_tax_card");
            entity.Property(e => e.CustomerTaxFile)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_tax_file");
            entity.Property(e => e.Hotlines)
                .HasMaxLength(63)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("hotlines");
            entity.Property(e => e.MedicineServices)
                .HasMaxLength(63)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("medicine_services");
            entity.Property(e => e.MembersCount).HasColumnName("members_count");
            entity.Property(e => e.Telephones)
                .HasMaxLength(51)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("telephones");
        });

        modelBuilder.Entity<Approval>(entity =>
        {
            entity.HasKey(e => e.ApprovalId)
                .HasName("approvals_temp_pk")
                .IsClustered(false);

            entity.ToTable("approvals", tb =>
                {
                    tb.HasTrigger("trigger_insert_approvals");
                    tb.HasTrigger("trigger_insert_approvals_old");
                    tb.HasTrigger("trigger_update_approvals");
                });

            entity.HasIndex(e => new { e.ApprovalId, e.ReqId }, "approvals_req").IsUnique();

            entity.Property(e => e.ApprovalId)
                .ValueGeneratedNever()
                .HasColumnName("approval_id");
            entity.Property(e => e.ApStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("ap_status");
            entity.Property(e => e.ApType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("public")
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("ap_type");
            entity.Property(e => e.ApprovalDate)
                .HasColumnType("datetime")
                .HasColumnName("approval_date");
            entity.Property(e => e.ChronicRef).HasColumnName("chronic_ref");
            entity.Property(e => e.Coinsurance)
                .HasDefaultValue(0.0)
                .HasColumnName("coinsurance");
            entity.Property(e => e.ContractId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("contract_id");
            entity.Property(e => e.Currentip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("currentip");
            entity.Property(e => e.FormDate).HasColumnName("form_date");
            entity.Property(e => e.FormId)
                .HasMaxLength(22)
                .IsUnicode(false)
                .HasColumnName("form_id");
            entity.Property(e => e.HoldOnRev).HasColumnName("hold_on_rev");
            entity.Property(e => e.IsExceptional).HasColumnName("is_exceptional");
            entity.Property(e => e.IsOnline)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("C")
                .IsFixedLength()
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("is_online");
            entity.Property(e => e.Isnotified).HasColumnName("isnotified");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("last_update_from");
            entity.Property(e => e.MainApproval).HasColumnName("main_approval");
            entity.Property(e => e.MaxValue).HasColumnName("max_value");
            entity.Property(e => e.MemberId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("member_id");
            entity.Property(e => e.Notes)
                .HasMaxLength(700)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.OnlineBCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("online_b_code");
            entity.Property(e => e.OnlineLud)
                .HasColumnType("datetime")
                .HasColumnName("online_lud");
            entity.Property(e => e.OnlineStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("online_status");
            entity.Property(e => e.OnlineUser)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("online_user");
            entity.Property(e => e.ParentApproval).HasColumnName("parent_approval");
            entity.Property(e => e.PlanCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("plan_code");
            entity.Property(e => e.PrivateNotes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("private_notes");
            entity.Property(e => e.ReqId)
                .IsRequired()
                .HasColumnName("req_id");
            entity.Property(e => e.RequestSource)
                .HasMaxLength(16)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("request_source");
            entity.Property(e => e.VBranchId).HasColumnName("v_branch_id");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");

            entity.HasOne(d => d.Member).WithMany(p => p.Approvals)
                .HasForeignKey(d => d.MemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_approvals_Members");

            entity.HasOne(d => d.ParentApprovalNavigation).WithMany(p => p.InverseParentApprovalNavigation)
                .HasForeignKey(d => d.ParentApproval)
                .HasConstraintName("FK_approvals_approvals1");

            entity.HasOne(d => d.PlanCodeNavigation).WithMany(p => p.Approvals)
                .HasForeignKey(d => d.PlanCode)
                .HasConstraintName("FK_approvals_Contract_Plans");

            entity.HasOne(d => d.Req).WithMany(p => p.Approvals)
                .HasForeignKey(d => d.ReqId)
                .HasConstraintName("FK_approvals_inqueries");

            entity.HasOne(d => d.VBranch).WithMany(p => p.Approvals)
                .HasForeignKey(d => d.VBranchId)
                .HasConstraintName("FK_approvals_vendor_branches");

            entity.HasOne(d => d.Vendor).WithMany(p => p.Approvals)
                .HasForeignKey(d => d.VendorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_approvals_Vendor_General");

            entity.HasOne(d => d.MemberPlan).WithMany(p => p.Approvals)
                .HasPrincipalKey(p => new { p.MemberCode, p.ContractCode })
                .HasForeignKey(d => new { d.MemberId, d.ContractId })
                .HasConstraintName("FK_approvals_MemberPlan");

            entity.HasMany(d => d.Diagnoses).WithMany(p => p.Approvals)
                .UsingEntity<Dictionary<string, object>>(
                    "ApprovalDiagnose",
                    r => r.HasOne<OnlineDiagnosis>().WithMany()
                        .HasForeignKey("DiagnoseId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_approval_diagnose_online_diagnosis"),
                    l => l.HasOne<Approval>().WithMany()
                        .HasForeignKey("ApprovalId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_approval_diagnose_approvals"),
                    j =>
                    {
                        j.HasKey("ApprovalId", "DiagnoseId").HasName("PK_approval_diagnose_1");
                        j.ToTable("approval_diagnose");
                        j.IndexerProperty<long>("ApprovalId").HasColumnName("approval_id");
                        j.IndexerProperty<string>("DiagnoseId")
                            .HasMaxLength(50)
                            .IsUnicode(false)
                            .HasColumnName("diagnose_id");
                    });
        });

        modelBuilder.Entity<ApprovalChatSeen>(entity =>
        {
            entity.ToTable("approval_chat_seen");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApprovalId).HasColumnName("approval_id");
            entity.Property(e => e.LastSeen).HasColumnName("last_seen");
            entity.Property(e => e.LastSeenDate)
                .HasColumnType("datetime")
                .HasColumnName("last_seen_date");
            entity.Property(e => e.UserName)
                .HasMaxLength(256)
                .HasColumnName("user_name");

            entity.HasOne(d => d.Approval).WithMany(p => p.ApprovalChatSeens)
                .HasForeignKey(d => d.ApprovalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_approval_chat_seen_approvals");
        });

        modelBuilder.Entity<ApprovalRating>(entity =>
        {
            entity.HasKey(e => e.ApprovalId).HasName("PK_approval_rating_1");

            entity.ToTable("approval_rating");

            entity.Property(e => e.ApprovalId)
                .ValueGeneratedNever()
                .HasColumnName("approval_id");
            entity.Property(e => e.MemberId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("member_id");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("phone_number");
            entity.Property(e => e.Rate).HasColumnName("rate");
            entity.Property(e => e.RatingDate).HasColumnName("rating_date");
            entity.Property(e => e.ReteNote)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("rete_note");

            entity.HasOne(d => d.Approval).WithOne(p => p.ApprovalRating)
                .HasForeignKey<ApprovalRating>(d => d.ApprovalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_approval_rating_approvals");

            entity.HasOne(d => d.Member).WithMany(p => p.ApprovalRatings)
                .HasForeignKey(d => d.MemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_approval_rating_Members");
        });

        modelBuilder.Entity<ApprovalService>(entity =>
        {
            entity.HasKey(e => new { e.ApprovalId, e.ItemSerial })
                .HasName("approvalitemstemp_pk")
                .IsClustered(false);

            entity.ToTable("approval_services", tb =>
                {
                    tb.HasTrigger("trigger_delete_approval_services");
                    tb.HasTrigger("trigger_insert_approval_services");
                    tb.HasTrigger("trigger_update_approval_services");
                });

            entity.Property(e => e.ApprovalId).HasColumnName("approval_id");
            entity.Property(e => e.ItemSerial).HasColumnName("item_serial");
            entity.Property(e => e.ApQty).HasColumnName("ap_qty");
            entity.Property(e => e.Coinsurance)
                .HasDefaultValue(0.0)
                .HasColumnName("coinsurance");
            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.DoseDurType).HasColumnName("dose_dur_type");
            entity.Property(e => e.DoseDuration).HasColumnName("dose_duration");
            entity.Property(e => e.DoseRepeat).HasColumnName("dose_repeat");
            entity.Property(e => e.DoseUnits).HasColumnName("dose_units");
            entity.Property(e => e.Editqty).HasColumnName("editqty");
            entity.Property(e => e.InsurerMeditem).HasColumnName("insurer_meditem");
            entity.Property(e => e.IsActualValue).HasColumnName("is_actual_value");
            entity.Property(e => e.IsChronic).HasColumnName("is_chronic");
            entity.Property(e => e.ItemDesc)
                .HasMaxLength(200)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("item_desc");
            entity.Property(e => e.ItemRepeat).HasColumnName("item_repeat");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(30)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("last_update_from");
            entity.Property(e => e.MedItem).HasColumnName("med_item");
            entity.Property(e => e.MinUnits).HasColumnName("min_units");
            entity.Property(e => e.Notes)
                .HasMaxLength(80)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("notes");
            entity.Property(e => e.OnlineStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("online_status");
            entity.Property(e => e.OriginalPrice).HasColumnName("original_price");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.Qty).HasColumnName("qty");
            entity.Property(e => e.ServiceId).HasColumnName("service_id");

            entity.HasOne(d => d.Approval).WithMany(p => p.ApprovalServices)
                .HasForeignKey(d => d.ApprovalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_approval_services_approvals");

            entity.HasOne(d => d.MedItemNavigation).WithMany(p => p.ApprovalServices)
                .HasForeignKey(d => d.MedItem)
                .HasConstraintName("FK_approval_services_care_items");
        });

        modelBuilder.Entity<ApprovalServicesOnline>(entity =>
        {
            entity.HasKey(e => new { e.ApprovalId, e.ItemSerial });

            entity.ToTable("approval_services_online");

            entity.Property(e => e.ApprovalId).HasColumnName("approval_id");
            entity.Property(e => e.ItemSerial).HasColumnName("item_serial");
            entity.Property(e => e.ApQty).HasColumnName("ap_qty");
            entity.Property(e => e.Coinsurance).HasColumnName("coinsurance");
            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.DoseDurType).HasColumnName("dose_dur_type");
            entity.Property(e => e.DoseDuration).HasColumnName("dose_duration");
            entity.Property(e => e.DoseRepeat).HasColumnName("dose_repeat");
            entity.Property(e => e.DoseUnits).HasColumnName("dose_units");
            entity.Property(e => e.Editqty).HasColumnName("editqty");
            entity.Property(e => e.InsurerMeditem).HasColumnName("insurer_meditem");
            entity.Property(e => e.IsChronic).HasColumnName("is_chronic");
            entity.Property(e => e.ItemDesc)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("item_desc");
            entity.Property(e => e.ItemRepeat).HasColumnName("item_repeat");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("last_update_from");
            entity.Property(e => e.MedItem).HasColumnName("med_item");
            entity.Property(e => e.MinUnits).HasColumnName("min_units");
            entity.Property(e => e.Notes)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.OnlineStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("online_status");
            entity.Property(e => e.OriginalPrice).HasColumnName("original_price");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.Qty).HasColumnName("qty");
            entity.Property(e => e.ServiceId).HasColumnName("service_id");
        });

        modelBuilder.Entity<ApprovalsArchive>(entity =>
        {
            entity.ToTable("approvals_archive");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApprovalId).HasColumnName("approval_id");
            entity.Property(e => e.AttachedNameId).HasColumnName("attached_name_id");
            entity.Property(e => e.FormCategories)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("formCategories");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Path)
                .HasMaxLength(150)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("path");

            entity.HasOne(d => d.Approval).WithMany(p => p.ApprovalsArchives)
                .HasForeignKey(d => d.ApprovalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_approvals_archive_approvals");

            entity.HasOne(d => d.AttachedName).WithMany(p => p.ApprovalsArchives)
                .HasForeignKey(d => d.AttachedNameId)
                .HasConstraintName("FK_approvals_archive_Attached_Document_Names");
        });

        modelBuilder.Entity<ApprovalsArchiveOnline>(entity =>
        {
            entity.ToTable("approvals_archive_online");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApprovalId).HasColumnName("approval_id");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Path)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("path");
        });

        modelBuilder.Entity<ApprovalsLog>(entity =>
        {
            entity.ToTable("approvals_log");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Action).HasColumnName("action");
            entity.Property(e => e.ApprovalDate)
                .HasColumnType("datetime")
                .HasColumnName("approval_date");
            entity.Property(e => e.ApprovalId).HasColumnName("approval_id");
            entity.Property(e => e.ApprovalStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("approval_status");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("last_update_from");
            entity.Property(e => e.MemberId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("member_id");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.NumServices).HasColumnName("num_services");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.PrivateNotes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("private_notes");

            entity.HasOne(d => d.ActionNavigation).WithMany(p => p.ApprovalsLogs)
                .HasForeignKey(d => d.Action)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_approvals_log_actions");

            entity.HasOne(d => d.Approval).WithMany(p => p.ApprovalsLogs)
                .HasForeignKey(d => d.ApprovalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_approvals_log_approvals");
        });

        modelBuilder.Entity<ApprovalsLogOnline>(entity =>
        {
            entity.ToTable("approvals_log_online");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Action).HasColumnName("action");
            entity.Property(e => e.ApprovalDate)
                .HasColumnType("datetime")
                .HasColumnName("approval_date");
            entity.Property(e => e.ApprovalId).HasColumnName("approval_id");
            entity.Property(e => e.ApprovalStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("approval_status");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("last_update_from");
            entity.Property(e => e.MemberId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("member_id");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.NumServices).HasColumnName("num_services");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.PrivateNotes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("private_notes");

            entity.HasOne(d => d.ActionNavigation).WithMany(p => p.ApprovalsLogOnlines)
                .HasForeignKey(d => d.Action)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_approvals_log_online_approvals_log_online");
        });

        modelBuilder.Entity<ApprovalsOnline>(entity =>
        {
            entity.HasKey(e => e.ApprovalId);

            entity.ToTable("approvals_online");

            entity.Property(e => e.ApprovalId)
                .ValueGeneratedNever()
                .HasColumnName("approval_id");
            entity.Property(e => e.ApStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ap_status");
            entity.Property(e => e.ApType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ap_type");
            entity.Property(e => e.ApprovalDate)
                .HasColumnType("datetime")
                .HasColumnName("approval_date");
            entity.Property(e => e.Coinsurance).HasColumnName("coinsurance");
            entity.Property(e => e.Currentip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("currentip");
            entity.Property(e => e.FormDate).HasColumnName("form_date");
            entity.Property(e => e.FormId)
                .HasMaxLength(22)
                .IsUnicode(false)
                .HasColumnName("form_id");
            entity.Property(e => e.IsExceptional).HasColumnName("is_exceptional");
            entity.Property(e => e.IsOnline)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("is_online");
            entity.Property(e => e.Isnotified).HasColumnName("isnotified");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("last_update_from");
            entity.Property(e => e.MainApproval).HasColumnName("main_approval");
            entity.Property(e => e.MaxValue).HasColumnName("max_value");
            entity.Property(e => e.MemberId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("member_id");
            entity.Property(e => e.Notes)
                .HasMaxLength(700)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.OnlineBCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("online_b_code");
            entity.Property(e => e.OnlineLud)
                .HasColumnType("datetime")
                .HasColumnName("online_lud");
            entity.Property(e => e.OnlineStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("online_status");
            entity.Property(e => e.OnlineUser)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("online_user");
            entity.Property(e => e.ParentApproval).HasColumnName("parent_approval");
            entity.Property(e => e.PlanCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("plan_code");
            entity.Property(e => e.PrivateNotes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("private_notes");
            entity.Property(e => e.RequestSource)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("request_source");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");

            entity.HasMany(d => d.Diagnoses).WithMany(p => p.ApprovalsNavigation)
                .UsingEntity<Dictionary<string, object>>(
                    "ApprovalDiagnoseOnline",
                    r => r.HasOne<OnlineDiagnosis>().WithMany()
                        .HasForeignKey("DiagnoseId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_approval_diagnose_online_online_diagnosis"),
                    l => l.HasOne<ApprovalsOnline>().WithMany()
                        .HasForeignKey("ApprovalId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_approval_diagnose_online_approval_diagnose_online"),
                    j =>
                    {
                        j.HasKey("ApprovalId", "DiagnoseId");
                        j.ToTable("approval_diagnose_online");
                        j.IndexerProperty<long>("ApprovalId").HasColumnName("approval_id");
                        j.IndexerProperty<string>("DiagnoseId")
                            .HasMaxLength(50)
                            .IsUnicode(false)
                            .HasColumnName("diagnose_id");
                    });
        });

        modelBuilder.Entity<ApprovalsPrivateNote>(entity =>
        {
            entity.ToTable("approvals_private_notes");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApprovalId).HasColumnName("approval_id");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.PrivateNote)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("private_note");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.WrittenBy)
                .HasMaxLength(256)
                .HasColumnName("written_by");

            entity.HasOne(d => d.Approval).WithMany(p => p.ApprovalsPrivateNotes)
                .HasForeignKey(d => d.ApprovalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_approvals_private_notes_approvals");
        });

        modelBuilder.Entity<ApprovalsTagsMap>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__approval__3213E83F9C076600");

            entity.ToTable("approvals_tags_map");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApprovalId).HasColumnName("approval_id");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("last_update_from");
            entity.Property(e => e.TagId).HasColumnName("tag_id");

            entity.HasOne(d => d.Approval).WithMany(p => p.ApprovalsTagsMaps)
                .HasForeignKey(d => d.ApprovalId)
                .HasConstraintName("FK__approvals__appro__3CA09C71");

            entity.HasOne(d => d.Tag).WithMany(p => p.ApprovalsTagsMaps)
                .HasForeignKey(d => d.TagId)
                .HasConstraintName("FK__approvals__tag_i__3D94C0AA");
        });

        modelBuilder.Entity<Area>(entity =>
        {
            entity.HasKey(e => e.AreaCode);

            entity.ToTable("areas");

            entity.Property(e => e.AreaCode)
                .ValueGeneratedNever()
                .HasColumnName("area_code");
            entity.Property(e => e.AreaNameAr)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("area_name_ar");
            entity.Property(e => e.AreaNameEg)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("area_name_eg");
            entity.Property(e => e.AreaParent).HasColumnName("area_parent");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("last_update_from");

            entity.HasOne(d => d.AreaParentNavigation).WithMany(p => p.InverseAreaParentNavigation)
                .HasForeignKey(d => d.AreaParent)
                .HasConstraintName("FK_areas_areas1");
        });

        modelBuilder.Entity<AspNetRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AspNetRoles");

            entity.Property(e => e.Id).HasMaxLength(128);
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.NormalizedName).HasMaxLength(256);
        });

        modelBuilder.Entity<AspNetUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AspNetUsers");

            entity.Property(e => e.Id)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.LockoutEnd).HasColumnType("datetime");
            entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");
            entity.Property(e => e.MemberId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Member_id");
            entity.Property(e => e.NormalizedEmail).HasMaxLength(256);
            entity.Property(e => e.NormalizedUserName).HasMaxLength(256);
            entity.Property(e => e.UserGroup)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.UserName).HasMaxLength(256);

            entity.HasOne(d => d.Member).WithMany(p => p.AspNetUsers)
                .HasForeignKey(d => d.MemberId)
                .HasConstraintName("FK_AspNetUsers_Members");

            entity.HasOne(d => d.UserGroupNavigation).WithMany(p => p.InverseUserGroupNavigation)
                .HasForeignKey(d => d.UserGroup)
                .HasConstraintName("FK_AspNetUsers_AspNetUsers");

            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "AspNetUserRole",
                    r => r.HasOne<AspNetRole>().WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_AspNetUserRoles_AspNetRoles"),
                    l => l.HasOne<AspNetUser>().WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_AspNetUserRoles_AspNetUsers"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId").HasName("PK_dbo.AspNetUserRoles");
                        j.ToTable("AspNetUserRoles");
                        j.IndexerProperty<string>("UserId")
                            .HasMaxLength(128)
                            .IsUnicode(false);
                        j.IndexerProperty<string>("RoleId").HasMaxLength(128);
                    });
        });

        modelBuilder.Entity<AspNetUserClaim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AspNetUserClaims");

            entity.Property(e => e.ClaimType).UseCollation("Arabic_100_CI_AI");
            entity.Property(e => e.ClaimValue).UseCollation("Arabic_100_CI_AI");
            entity.Property(e => e.UserId)
                .HasMaxLength(128)
                .IsUnicode(false);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserClaims)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AspNetUserClaims_AspNetUsers");
        });

        modelBuilder.Entity<AspNetUserLogin>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId }).HasName("PK_dbo.AspNetUserLogins");

            entity.Property(e => e.LoginProvider)
                .HasMaxLength(128)
                .UseCollation("Arabic_100_CI_AI");
            entity.Property(e => e.ProviderKey)
                .HasMaxLength(128)
                .UseCollation("Arabic_100_CI_AI");
            entity.Property(e => e.UserId)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.ProviderDisplayName)
                .HasMaxLength(128)
                .IsUnicode(false);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserLogins)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AspNetUserLogins_AspNetUsers");
        });

        modelBuilder.Entity<AttachedDocumentName>(entity =>
        {
            entity.HasKey(e => e.AttachedDocId);

            entity.ToTable("Attached_Document_Names");

            entity.Property(e => e.AttachedDocId).HasColumnName("attached_doc_id");
            entity.Property(e => e.AttachedDocName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("attached_doc_name");
        });

        modelBuilder.Entity<Batch>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("TU_batch_submit"));

            entity.HasIndex(e => new { e.BatchId, e.BatchVendorId }, "IX_Batches").IsUnique();

            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("batch_id");
            entity.Property(e => e.BatchCost).HasColumnName("batch_cost");
            entity.Property(e => e.BatchCreationDate).HasColumnName("batch_creation_date");
            entity.Property(e => e.BatchDate).HasColumnName("batch_date");
            entity.Property(e => e.BatchFinancialFlag).HasColumnName("batch_financial_flag");
            entity.Property(e => e.BatchInvoiceNumber).HasColumnName("batch_invoice_number");
            entity.Property(e => e.BatchLockFlag).HasColumnName("batch_lock_flag");
            entity.Property(e => e.BatchMedicalFlag).HasColumnName("batch_medical_flag");
            entity.Property(e => e.BatchNote)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("batch_note");
            entity.Property(e => e.BatchNumber).HasColumnName("batch_number");
            entity.Property(e => e.BatchReceivedDate).HasColumnName("batch_received_date");
            entity.Property(e => e.BatchStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("batch_status");
            entity.Property(e => e.BatchSubmissionDate).HasColumnName("batch_submission_date");
            entity.Property(e => e.BatchVendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("batch_vendor_id");
            entity.Property(e => e.CurrentStep)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("current_step");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.FinancialLock).HasColumnName("financial_lock");
            entity.Property(e => e.FinancialRevisedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("financial_revised_by");
            entity.Property(e => e.FinancialRevisedDate)
                .HasColumnType("datetime")
                .HasColumnName("financial_revised_date");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("last_update_from");
            entity.Property(e => e.MedicallyRevisedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("medically_revised_by");
            entity.Property(e => e.MedicallyRevisedDate)
                .HasColumnType("datetime")
                .HasColumnName("medically_revised_date");
            entity.Property(e => e.MedicalrevNote)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("medicalrev_note");
            entity.Property(e => e.PerentId)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("perent_id");
            entity.Property(e => e.ReimbursementInfo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("reimbursement_info");
            entity.Property(e => e.XtraNote)
                .HasMaxLength(350)
                .IsUnicode(false)
                .HasColumnName("xtra_note");
            entity.Property(e => e.XtraValue).HasColumnName("xtra_value");

            entity.HasOne(d => d.BatchStatusNavigation).WithMany(p => p.Batches)
                .HasForeignKey(d => d.BatchStatus)
                .HasConstraintName("FK_Batches_state_ref");

            entity.HasOne(d => d.BatchVendor).WithMany(p => p.Batches)
                .HasForeignKey(d => d.BatchVendorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Batches_Vendor_General");

            entity.HasOne(d => d.Customer).WithMany(p => p.Batches)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_Batches_Customers1");

            entity.HasOne(d => d.Perent).WithMany(p => p.InversePerent)
                .HasForeignKey(d => d.PerentId)
                .HasConstraintName("FK_Batches_Batches");
        });

        modelBuilder.Entity<BatchDetail>(entity =>
        {
            entity.HasKey(e => e.InvId);

            entity.ToTable("Batch_details");

            entity.HasIndex(e => new { e.BatchId, e.Serial }, "IX_Batch_details").IsUnique();

            entity.HasIndex(e => new { e.BatchId, e.InvId }, "IX_Batch_details_1").IsUnique();

            entity.Property(e => e.InvId).HasColumnName("inv_id");
            entity.Property(e => e.ActivitySerial).HasColumnName("activity_serial");
            entity.Property(e => e.ApprovalNumber).HasColumnName("Approval_number");
            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("batch_id");
            entity.Property(e => e.CashVendor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cash_vendor");
            entity.Property(e => e.CoPayment).HasColumnName("co_payment");
            entity.Property(e => e.ContractActivity)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("contract_activity");
            entity.Property(e => e.ContractCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("contract_code");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.DisNote)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("dis_note");
            entity.Property(e => e.FinRevised).HasColumnName("fin_revised");
            entity.Property(e => e.HasDoc).HasColumnName("has_doc");
            entity.Property(e => e.ImportDis).HasColumnName("import_dis");
            entity.Property(e => e.InsuranceMedItem).HasColumnName("insurance_med_item");
            entity.Property(e => e.Insurer).HasColumnName("insurer");
            entity.Property(e => e.InvNum).HasColumnName("inv_num");
            entity.Property(e => e.IsActualCost)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("is_actual_cost");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LocalDis).HasColumnName("local_dis");
            entity.Property(e => e.MedItem).HasColumnName("med_item");
            entity.Property(e => e.MedRevNote)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("med_rev_note");
            entity.Property(e => e.MedRevised).HasColumnName("med_revised");
            entity.Property(e => e.MemberCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("member_code");
            entity.Property(e => e.Note)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("note");
            entity.Property(e => e.Notified).HasColumnName("notified");
            entity.Property(e => e.Num).HasColumnName("num");
            entity.Property(e => e.OldServid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("old_servid");
            entity.Property(e => e.RevDis).HasColumnName("Rev_dis");
            entity.Property(e => e.Serial).HasColumnName("serial");
            entity.Property(e => e.ServiceCode).HasColumnName("service_code");
            entity.Property(e => e.ServiceDate).HasColumnName("service_date");
            entity.Property(e => e.Tax).HasColumnName("tax");
            entity.Property(e => e.Value).HasColumnName("value");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");

            entity.HasOne(d => d.Batch).WithMany(p => p.BatchDetails)
                .HasForeignKey(d => d.BatchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Batch_details_Batches");

            entity.HasOne(d => d.CashVendorNavigation).WithMany(p => p.BatchDetailCashVendorNavigations)
                .HasForeignKey(d => d.CashVendor)
                .HasConstraintName("FK_Batch_details_Vendor_General1");

            entity.HasOne(d => d.ContractActivityNavigation).WithMany(p => p.BatchDetails)
                .HasForeignKey(d => d.ContractActivity)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Batch_details_Contract_Types");

            entity.HasOne(d => d.MedItemNavigation).WithMany(p => p.BatchDetails)
                .HasForeignKey(d => d.MedItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Batch_details_care_items1");

            entity.HasOne(d => d.MemberCodeNavigation).WithMany(p => p.BatchDetails)
                .HasForeignKey(d => d.MemberCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Batch_details_Members");

            entity.HasOne(d => d.ServiceCodeNavigation).WithMany(p => p.BatchDetails)
                .HasForeignKey(d => d.ServiceCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Batch_details_contract_services");

            entity.HasOne(d => d.Vendor).WithMany(p => p.BatchDetailVendors)
                .HasForeignKey(d => d.VendorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Batch_details_Vendor_General");

            entity.HasOne(d => d.MemberPlan).WithMany(p => p.BatchDetails)
                .HasPrincipalKey(p => new { p.MemberCode, p.ContractCode })
                .HasForeignKey(d => new { d.MemberCode, d.ContractCode })
                .HasConstraintName("FK_Batch_details_MemberPlan");

            entity.HasOne(d => d.ContractActivity1).WithMany(p => p.BatchDetails)
                .HasPrincipalKey(p => new { p.ContractCode, p.Serial, p.CustomerId, p.ActivityId, p.Insurer })
                .HasForeignKey(d => new { d.ContractCode, d.ActivitySerial, d.CustomerId, d.ContractActivity, d.Insurer })
                .HasConstraintName("FK_Batch_details_contract_activities");
        });

        modelBuilder.Entity<BatchGroup>(entity =>
        {
            entity.ToTable("batch_groups");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("end_date");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_from");
            entity.Property(e => e.MaxAvailable).HasColumnName("max_available");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("start_date");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<BatchLog>(entity =>
        {
            entity.ToTable("batch_log");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Action).HasColumnName("action");
            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("batch_id");
            entity.Property(e => e.InvId).HasColumnName("inv_id");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("last_update_from");
            entity.Property(e => e.Note)
                .IsUnicode(false)
                .HasColumnName("note");

            entity.HasOne(d => d.ActionNavigation).WithMany(p => p.BatchLogs)
                .HasForeignKey(d => d.Action)
                .HasConstraintName("FK_batch_log_actions");

            entity.HasOne(d => d.Batch).WithMany(p => p.BatchLogs)
                .HasForeignKey(d => d.BatchId)
                .HasConstraintName("FK_batch_log_Batches");
        });

        modelBuilder.Entity<Bill>(entity =>
        {
            entity.HasKey(e => e.BillId).HasName("PK_customer_bills");

            entity.ToTable("bills");

            entity.Property(e => e.BillId).HasColumnName("bill_id");
            entity.Property(e => e.AccBillId)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("acc_bill_id");
            entity.Property(e => e.BillCreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("bill_created_date");
            entity.Property(e => e.BillDueDate).HasColumnName("bill_due_date");
            entity.Property(e => e.BillPeroidFrom)
                .HasColumnType("datetime")
                .HasColumnName("bill_peroid_from");
            entity.Property(e => e.BillPeroidTo)
                .HasColumnType("datetime")
                .HasColumnName("bill_peroid_to");
            entity.Property(e => e.BillStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("bill_status");
            entity.Property(e => e.BillType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("bill_type");
            entity.Property(e => e.ContractId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("contract_id");
            entity.Property(e => e.CostCentre).HasColumnName("cost_centre");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.CustomerInstallmentId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("customer_installment_id");
            entity.Property(e => e.ExternalCode).HasColumnName("external_code");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_from");
            entity.Property(e => e.MemberId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("member_id");
            entity.Property(e => e.Notes)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.Printed).HasColumnName("printed");

            entity.HasOne(d => d.BillTypeNavigation).WithMany(p => p.Bills)
                .HasForeignKey(d => d.BillType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_bills_payment_types");

            entity.HasOne(d => d.Contract).WithMany(p => p.Bills)
                .HasForeignKey(d => d.ContractId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CONTRACT_ID");

            entity.HasOne(d => d.Customer).WithMany(p => p.Bills)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CUSTOMER_ID");

            entity.HasOne(d => d.Member).WithMany(p => p.Bills)
                .HasForeignKey(d => d.MemberId)
                .HasConstraintName("FK_MEMBER_ID");
        });

        modelBuilder.Entity<BillDetail>(entity =>
        {
            entity.HasKey(e => new { e.Serial, e.BillId });

            entity.ToTable("bill_details");

            entity.Property(e => e.Serial).HasColumnName("serial");
            entity.Property(e => e.BillId).HasColumnName("bill_id");
            entity.Property(e => e.ContractId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("contract_id");
            entity.Property(e => e.Discount).HasColumnName("discount");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_from");
            entity.Property(e => e.MemberId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("member_id");
            entity.Property(e => e.Notes)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.OriginalPrice).HasColumnName("original_price");
            entity.Property(e => e.Qty).HasColumnName("qty");
            entity.Property(e => e.ServiceId).HasColumnName("service_id");
            entity.Property(e => e.Tax).HasColumnName("tax");
            entity.Property(e => e.Value).HasColumnName("value");

            entity.HasOne(d => d.Bill).WithMany(p => p.BillDetails)
                .HasForeignKey(d => d.BillId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_bill_details_bills");

            entity.HasOne(d => d.Member).WithMany(p => p.BillDetails)
                .HasForeignKey(d => d.MemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_bill_details_MemberPlan");
        });

        modelBuilder.Entity<BillsLog>(entity =>
        {
            entity.ToTable("Bills_log");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Action).HasColumnName("action");
            entity.Property(e => e.BillId).HasColumnName("bill_id");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("last_update_from");
            entity.Property(e => e.Note)
                .IsUnicode(false)
                .HasColumnName("note");
            entity.Property(e => e.Serial).HasColumnName("serial");

            entity.HasOne(d => d.ActionNavigation).WithMany(p => p.BillsLogs)
                .HasForeignKey(d => d.Action)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Bills_log_actions");
        });

        modelBuilder.Entity<BlueCode>(entity =>
        {
            entity.ToTable("blue_code");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.Email)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Frequency).HasColumnName("frequency");
            entity.Property(e => e.WarningValue).HasColumnName("warning_value");

            entity.HasOne(d => d.Customer).WithMany(p => p.BlueCodes)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_blue_code_Customers");
        });

        modelBuilder.Entity<Broker>(entity =>
        {
            entity.ToTable("brokers");

            entity.Property(e => e.BrokerId).HasColumnName("broker_id");
            entity.Property(e => e.BankAccount)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("bank_account");
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("bank_name");
            entity.Property(e => e.BrokerAddress)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("broker_address");
            entity.Property(e => e.BrokerMail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("broker_mail");
            entity.Property(e => e.BrokerName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("broker_name");
            entity.Property(e => e.BrokerPhone).HasColumnName("broker_phone");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.NationalId).HasColumnName("national_id");
            entity.Property(e => e.Notes)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("notes");
        });

        modelBuilder.Entity<CardSetting>(entity =>
        {
            entity.HasKey(e => e.ContractId);

            entity.ToTable("card_settings");

            entity.Property(e => e.ContractId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("contract_id");
            entity.Property(e => e.Back)
                .HasMaxLength(150)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("back");
            entity.Property(e => e.BackVip)
                .HasMaxLength(150)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("back_vip");
            entity.Property(e => e.CustomerName).HasColumnName("customer_name");
            entity.Property(e => e.Front)
                .HasMaxLength(150)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("front");
            entity.Property(e => e.FrontVip)
                .HasMaxLength(150)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("front_vip");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.NameInCard)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("name_in_card");
            entity.Property(e => e.NewCard).HasColumnName("new_card");
            entity.Property(e => e.Notes)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("notes");
            entity.Property(e => e.PrintClass).HasColumnName("print_class");
            entity.Property(e => e.ShowAge).HasColumnName("show_age");
            entity.Property(e => e.ShowCompanyCode).HasColumnName("show_company_code");
            entity.Property(e => e.ShowExternalCode).HasColumnName("show_external_code");
            entity.Property(e => e.ShowInsuranceCode).HasColumnName("show_insurance_code");
            entity.Property(e => e.ShowJobTitle).HasColumnName("show_job_title");
            entity.Property(e => e.ShowStatement).HasColumnName("show_statement");
            entity.Property(e => e.ShowWhatsappNumber).HasColumnName("show_whatsapp_number");
            entity.Property(e => e.StaticBack)
                .HasMaxLength(150)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("static_back");
            entity.Property(e => e.StaticBackground).HasColumnName("static_background");
        });

        modelBuilder.Entity<CareItem>(entity =>
        {
            entity.HasKey(e => e.CareItemCode);

            entity.ToTable("care_items", tb =>
                {
                    tb.HasTrigger("trigger_delete_care_items");
                    tb.HasTrigger("trigger_insert_care_items");
                    tb.HasTrigger("trigger_update_care_items");
                });

            entity.Property(e => e.CareItemCode)
                .ValueGeneratedNever()
                .HasColumnName("care_item_code");
            entity.Property(e => e.CareItemName)
                .HasMaxLength(85)
                .IsUnicode(false)
                .HasColumnName("care_item_name");
            entity.Property(e => e.IsMandatory).HasColumnName("is_mandatory");

            entity.HasMany(d => d.Cids).WithMany(p => p.Iids)
                .UsingEntity<Dictionary<string, object>>(
                    "OnlineCareitemCategory",
                    r => r.HasOne<OnlineItemCategory>().WithMany()
                        .HasForeignKey("Cid")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_online_careitem_category_online_Item_categories"),
                    l => l.HasOne<CareItem>().WithMany()
                        .HasForeignKey("Iid")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_online_careitem_category_care_items"),
                    j =>
                    {
                        j.HasKey("Iid", "Cid");
                        j.ToTable("online_careitem_category");
                        j.IndexerProperty<int>("Iid").HasColumnName("iid");
                        j.IndexerProperty<int>("Cid").HasColumnName("cid");
                    });
        });

        modelBuilder.Entity<ChronicLookupTable>(entity =>
        {
            entity.HasKey(e => new { e.PlanCode, e.OldMeditem, e.RefCode });

            entity.ToTable("chronic_lookup_table");

            entity.Property(e => e.PlanCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("plan_code");
            entity.Property(e => e.OldMeditem).HasColumnName("old_meditem");
            entity.Property(e => e.RefCode)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("ref_code");
            entity.Property(e => e.NewMeditem).HasColumnName("new_meditem");

            entity.HasOne(d => d.OldMeditemNavigation).WithMany(p => p.ChronicLookupTables)
                .HasForeignKey(d => d.OldMeditem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_chronic_lookup_table_care_items");
        });

        modelBuilder.Entity<Claim>(entity =>
        {
            entity.HasKey(e => e.CalimId).HasName("PK_Scalability");

            entity.ToTable("Claim");

            entity.Property(e => e.CalimId)
                .ValueGeneratedNever()
                .HasColumnName("calim_id");
            entity.Property(e => e.ClaimEndSerial).HasColumnName("claim_end_serial");
            entity.Property(e => e.ClaimStartSerial).HasColumnName("claim_start_serial");
            entity.Property(e => e.ClaimVendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("claim_vendor_id");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("last_update_from");

            entity.HasOne(d => d.ClaimVendor).WithMany(p => p.Claims)
                .HasForeignKey(d => d.ClaimVendorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Claim_Vendor");
        });

        modelBuilder.Entity<ClaimFormLot>(entity =>
        {
            entity.ToTable("claim_form_lots");

            entity.HasIndex(e => e.StartSerial, "start_serial_unique").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ContentQty).HasColumnName("content_qty");
            entity.Property(e => e.EndSerial).HasColumnName("end_serial");
            entity.Property(e => e.EnteryDate)
                .HasColumnType("datetime")
                .HasColumnName("entery_date");
            entity.Property(e => e.IsLocked).HasColumnName("is_locked");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_from");
            entity.Property(e => e.StartSerial).HasColumnName("start_serial");
            entity.Property(e => e.WerehouseId).HasColumnName("werehouse_id");

            entity.HasOne(d => d.Werehouse).WithMany(p => p.ClaimFormLots)
                .HasForeignKey(d => d.WerehouseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_claim_form_lots_acms_werehouse");
        });

        modelBuilder.Entity<ClaimLog>(entity =>
        {
            entity.ToTable("Claim_logs");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeId).HasColumnName("code_id");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("last_update_from");
            entity.Property(e => e.Note)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("note");
            entity.Property(e => e.TypeId).HasColumnName("type_id");

            entity.HasOne(d => d.Type).WithMany(p => p.ClaimLogs)
                .HasForeignKey(d => d.TypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Claim_logs_actions");
        });

        modelBuilder.Entity<ClaimLotsFormsCode>(entity =>
        {
            entity.ToTable("claim_lots_forms_code");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_from");
            entity.Property(e => e.SendByMail).HasColumnName("send_by_mail");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendorId");

            entity.HasOne(d => d.Vendor).WithMany(p => p.ClaimLotsFormsCodes)
                .HasForeignKey(d => d.VendorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Vendor");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasIndex(e => e.ClientId, "IX_Clients");

            entity.Property(e => e.ClientId)
                .ValueGeneratedNever()
                .HasColumnName("client_id");
            entity.Property(e => e.ClientEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("client_email");
            entity.Property(e => e.ClientMapUrl)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("client_map_url");
            entity.Property(e => e.ClientName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("client_name");
            entity.Property(e => e.ClientRegionCode).HasColumnName("client_region_code");
            entity.Property(e => e.ClientTele)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("client_tele");
            entity.Property(e => e.ClientWebsite)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("client_website");
        });

        modelBuilder.Entity<Contact>(entity =>
        {
            entity.HasKey(e => e.ContactId).HasName("PK_Table_1");

            entity.Property(e => e.ContactId).HasColumnName("contact_id");
            entity.Property(e => e.ContactEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("contact_email");
            entity.Property(e => e.ContactName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_BIN")
                .HasColumnName("contact_name");
            entity.Property(e => e.ContactNotes)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("contact_notes");
            entity.Property(e => e.ContactOccupationId).HasColumnName("contact_occupation_id");
            entity.Property(e => e.ContactTele)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("contact_tele");
            entity.Property(e => e.ContactTele2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("contact_tele2");
            entity.Property(e => e.ContactVendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contact_vendor_id");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("last_update_from");

            entity.HasOne(d => d.ContactOccupation).WithMany(p => p.Contacts)
                .HasForeignKey(d => d.ContactOccupationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Contacts_Contacts");

            entity.HasOne(d => d.ContactVendor).WithMany(p => p.Contacts)
                .HasForeignKey(d => d.ContactVendorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Contacts_Vendor");
        });

        modelBuilder.Entity<ContactsOccupation>(entity =>
        {
            entity.HasKey(e => e.OccupationId);

            entity.ToTable("contacts_occupation");

            entity.Property(e => e.OccupationId)
                .ValueGeneratedNever()
                .HasColumnName("occupation_id");
            entity.Property(e => e.OccupationName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("occupation_name");
        });

        modelBuilder.Entity<ContactsTemp>(entity =>
        {
            entity.HasKey(e => e.ContactId);

            entity.ToTable("Contacts_temp");

            entity.Property(e => e.ContactId).HasColumnName("contact_id");
            entity.Property(e => e.ContactEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("contact_email");
            entity.Property(e => e.ContactName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_BIN")
                .HasColumnName("contact_name");
            entity.Property(e => e.ContactNotes)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("contact_notes");
            entity.Property(e => e.ContactOccupationId).HasColumnName("contact_occupation_id");
            entity.Property(e => e.ContactTele)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("contact_tele");
            entity.Property(e => e.ContactTele2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("contact_tele2");
            entity.Property(e => e.ContactVendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contact_vendor_id");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("last_update_from");

            entity.HasOne(d => d.ContactOccupation).WithMany(p => p.ContactsTemps)
                .HasForeignKey(d => d.ContactOccupationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Contacts_temp_contacts_occupation");

            entity.HasOne(d => d.ContactVendor).WithMany(p => p.ContactsTemps)
                .HasForeignKey(d => d.ContactVendorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Contacts_temp_Vendor_General_temp");
        });

        modelBuilder.Entity<ContractActivity>(entity =>
        {
            entity.HasKey(e => new { e.ContractCode, e.Serial });

            entity.ToTable("contract_activities");

            entity.HasIndex(e => new { e.ContractCode, e.Serial, e.CustomerId, e.ActivityId, e.Insurer }, "IX_contract_activities").IsUnique();

            entity.Property(e => e.ContractCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("contract_code");
            entity.Property(e => e.Serial).HasColumnName("serial");
            entity.Property(e => e.ActivityId)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("activity_id");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("end_date");
            entity.Property(e => e.Insurer)
                .IsRequired()
                .HasColumnName("insurer");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("start_date");

            entity.HasOne(d => d.Activity).WithMany(p => p.ContractActivities)
                .HasForeignKey(d => d.ActivityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_contract_activities_contract_type");

            entity.HasOne(d => d.Customer).WithMany(p => p.ContractActivityCustomers)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_contract_activities_Customers");

            entity.HasOne(d => d.InsurerNavigation).WithMany(p => p.ContractActivityInsurerNavigations)
                .HasForeignKey(d => d.Insurer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_contract_activities_insurer");

            entity.HasOne(d => d.CustomerContract).WithMany(p => p.ContractActivities)
                .HasPrincipalKey(p => new { p.CustomerContractId, p.CustomerContractCustomerId })
                .HasForeignKey(d => new { d.ContractCode, d.CustomerId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_contract_activities_Customer_Contracts");
        });

        modelBuilder.Entity<ContractBroker>(entity =>
        {
            entity.ToTable("contract_brokers");

            entity.HasIndex(e => new { e.ContractId, e.BrokerId }, "IX_contract_brokers").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BrokerId).HasColumnName("broker_id");
            entity.Property(e => e.ContractId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("contract_id");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.Notes)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.Percentage).HasColumnName("percentage");
            entity.Property(e => e.Val).HasColumnName("val");

            entity.HasOne(d => d.Broker).WithMany(p => p.ContractBrokers)
                .HasForeignKey(d => d.BrokerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_contract_brokers_brokers");

            entity.HasOne(d => d.Contract).WithMany(p => p.ContractBrokers)
                .HasForeignKey(d => d.ContractId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_contract_brokers_Customer_Contracts");
        });

        modelBuilder.Entity<ContractCategory>(entity =>
        {
            entity.HasKey(e => e.ContractCategoriesId);

            entity.ToTable("contract_categories");

            entity.Property(e => e.ContractCategoriesId)
                .ValueGeneratedNever()
                .HasColumnName("contract_categories_id");
            entity.Property(e => e.ContractCategoryName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("contract_category_name");
            entity.Property(e => e.ContractCategoryNameEn)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("contract_category_name_en");
        });

        modelBuilder.Entity<ContractInstallment>(entity =>
        {
            entity.HasKey(e => e.InstallmentId);

            entity.ToTable("contract_installments", tb =>
                {
                    tb.HasTrigger("trigger_delete_contract_installments");
                    tb.HasTrigger("trigger_insert_contract_installments");
                    tb.HasTrigger("trigger_update_contract_installments");
                });

            entity.Property(e => e.InstallmentId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("installment_ID");
            entity.Property(e => e.CustomerContractId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("customer_contract_id");
            entity.Property(e => e.InstallmentDate).HasColumnName("installment_Date");
            entity.Property(e => e.InstallmentValue).HasColumnName("installment_value");
            entity.Property(e => e.IsValue).HasColumnName("is_value");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("last_updated_by");
            entity.Property(e => e.LastUpdatedFrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("last_updated_from");
            entity.Property(e => e.Notes)
                .HasMaxLength(200)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("notes");
            entity.Property(e => e.PaymentType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("payment_type");

            entity.HasOne(d => d.CustomerContract).WithMany(p => p.ContractInstallments)
                .HasForeignKey(d => d.CustomerContractId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_contract_installments_Customer_Contracts");

            entity.HasOne(d => d.PaymentTypeNavigation).WithMany(p => p.ContractInstallments)
                .HasForeignKey(d => d.PaymentType)
                .HasConstraintName("FK_contract_installments_payment_types");
        });

        modelBuilder.Entity<ContractPlan>(entity =>
        {
            entity.HasKey(e => e.ContractPlanId).HasName("PK_CONTRACT_PLANS");

            entity.ToTable("Contract_Plans", tb =>
                {
                    tb.HasTrigger("trigger_delete_contract_plans");
                    tb.HasTrigger("trigger_insert_contract_plans");
                    tb.HasTrigger("trigger_update_contract_plans");
                });

            entity.HasIndex(e => new { e.ContractId, e.ContractPlanId }, "IX_Contract_Plans").IsUnique();

            entity.Property(e => e.ContractPlanId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("contract_plan_id");
            entity.Property(e => e.CeilingLevel)
                .HasMaxLength(30)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("ceiling_level");
            entity.Property(e => e.ClassCeiling).HasColumnName("class_ceiling");
            entity.Property(e => e.ContractId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("contract_id");
            entity.Property(e => e.ContractPlanClass)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("contract_plan_class");
            entity.Property(e => e.ContractPlanNotes)
                .HasMaxLength(300)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("contract_plan_notes");
            entity.Property(e => e.ContractPlanReimb).HasColumnName("contract_plan_reimb");
            entity.Property(e => e.ExternalCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("external_code");
            entity.Property(e => e.IsDirect).HasColumnName("is_direct");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("last_update_from");
            entity.Property(e => e.MedicalNetworkClass)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("medical_network_class");
            entity.Property(e => e.ResidenceId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("residence_id");
            entity.Property(e => e.ResidencePercent).HasColumnName("residence_percent");

            entity.HasOne(d => d.Contract).WithMany(p => p.ContractPlans)
                .HasForeignKey(d => d.ContractId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Contract_Plans_Customer_Contracts");

            entity.HasOne(d => d.Residence).WithMany(p => p.ContractPlans)
                .HasForeignKey(d => d.ResidenceId)
                .HasConstraintName("FK_Contract_Plans_Residence");
        });

        modelBuilder.Entity<ContractPool>(entity =>
        {
            entity.HasKey(e => e.ContractPoolsId);

            entity.ToTable("Contract_Pools");

            entity.Property(e => e.ContractPoolsId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("contract_pools_id");
            entity.Property(e => e.AddToCeilling).HasColumnName("addToCeilling");
            entity.Property(e => e.ContractId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("contract_Id");
            entity.Property(e => e.ContractPoolsLabel)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("contract_pools_label");
            entity.Property(e => e.ContractPoolsNotes)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("contract_pools_notes");
            entity.Property(e => e.ContractPoolsPoolValue).HasColumnName("contract_pools_pool_value");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("last_update_from");

            entity.HasOne(d => d.Contract).WithMany(p => p.ContractPools)
                .HasForeignKey(d => d.ContractId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Contract_Pools_Customer_Contracts");
        });

        modelBuilder.Entity<ContractService>(entity =>
        {
            entity.HasKey(e => e.ContractServiceId).HasName("PK_Services");

            entity.ToTable("contract_services", tb =>
                {
                    tb.HasTrigger("InsertContractService");
                    tb.HasTrigger("UpdateContractService");
                });

            entity.Property(e => e.ContractServiceId).HasColumnName("contract_service_id");
            entity.Property(e => e.ContractServiceContractCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contract_service_contract_code");
            entity.Property(e => e.ContractServiceDiscount).HasColumnName("contract_service_discount");
            entity.Property(e => e.ContractServiceFlag).HasColumnName("contract_service_flag");
            entity.Property(e => e.ContractServiceName)
                .IsUnicode(false)
                .HasColumnName("contract_service_name");
            entity.Property(e => e.ContractServiceNotes)
                .IsUnicode(false)
                .HasColumnName("contract_service_notes");
            entity.Property(e => e.ContractServicePrices).HasColumnName("contract_service_prices");
            entity.Property(e => e.ContractServiceSerRef).HasColumnName("contract_service_ser_ref");
            entity.Property(e => e.ExternalCode)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("external_code");
            entity.Property(e => e.IsPackage).HasColumnName("is_package");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("last_update_from");
            entity.Property(e => e.OldServiceId)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("old_service_id");

            entity.HasOne(d => d.ContractServiceContractCodeNavigation).WithMany(p => p.ContractServices)
                .HasForeignKey(d => d.ContractServiceContractCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_contract_services_vendor_contract");

            entity.HasOne(d => d.ContractServiceSerRefNavigation).WithMany(p => p.ContractServices)
                .HasForeignKey(d => d.ContractServiceSerRef)
                .HasConstraintName("FK_contract_services_StandardServices");
        });

        modelBuilder.Entity<ContractType>(entity =>
        {
            entity.ToTable("Contract_type");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NameAr)
                .HasMaxLength(50)
                .HasColumnName("name_ar");
            entity.Property(e => e.NameEn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name_en");
            entity.Property(e => e.Parent).HasColumnName("parent");

            entity.HasOne(d => d.ParentNavigation).WithMany(p => p.InverseParentNavigation)
                .HasForeignKey(d => d.Parent)
                .HasConstraintName("FK_Contract_type_Contract_type1");
        });

        modelBuilder.Entity<ContractType1>(entity =>
        {
            entity.HasKey(e => e.ContractTypeId);

            entity.ToTable("Contract_Types");

            entity.Property(e => e.ContractTypeId)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("contract_type_id");
            entity.Property(e => e.ContractTypeNameAr)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("contract_type_name_ar");
            entity.Property(e => e.ContractTypeNameEn)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("contract_type_name_en");
        });

        modelBuilder.Entity<Currency>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FullNameAr)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("full_name_ar");
            entity.Property(e => e.FullNameEn)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("full_name_en");
            entity.Property(e => e.NameAr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name_ar");
            entity.Property(e => e.NameEn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name_en");
            entity.Property(e => e.Symbol)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("symbol");
        });

        modelBuilder.Entity<CurrencyExchangable>(entity =>
        {
            entity.HasKey(e => e.ExId);

            entity.ToTable("currency_exchangable");

            entity.Property(e => e.ExId).HasColumnName("ex_id");
            entity.Property(e => e.CurrencyId).HasColumnName("currency_id");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("end_date");
            entity.Property(e => e.Factor).HasColumnName("factor");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_from");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("start_date");

            entity.HasOne(d => d.Currency).WithMany(p => p.CurrencyExchangables)
                .HasForeignKey(d => d.CurrencyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_currency_exchangable_Currencies");

            entity.HasOne(d => d.Customer).WithMany(p => p.CurrencyExchangables)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_currency_exchangable_Customers");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK_Customer");

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("insert_customers");
                    tb.HasTrigger("trigger_update_customers");
                });

            entity.Property(e => e.CustomerId)
                .ValueGeneratedNever()
                .HasColumnName("customer_id");
            entity.Property(e => e.CareCard).HasColumnName("care_card");
            entity.Property(e => e.CompanyActivity).HasColumnName("company_activity");
            entity.Property(e => e.CustomerAccountNum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_account_num");
            entity.Property(e => e.CustomerAddress)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_address");
            entity.Property(e => e.CustomerArea).HasColumnName("customer_area");
            entity.Property(e => e.CustomerClientId).HasColumnName("customer_client_id");
            entity.Property(e => e.CustomerCommission).HasColumnName("customer_commission");
            entity.Property(e => e.CustomerContactPerson)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_contact_person");
            entity.Property(e => e.CustomerCreationDate)
                .HasColumnType("datetime")
                .HasColumnName("customer_creation_date");
            entity.Property(e => e.CustomerEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_email");
            entity.Property(e => e.CustomerFax)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_fax");
            entity.Property(e => e.CustomerMedicinesService)
                .HasMaxLength(30)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_medicines_service");
            entity.Property(e => e.CustomerMedicinesService2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_medicines_service2");
            entity.Property(e => e.CustomerMobile)
                .HasMaxLength(15)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_mobile");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("customer_name");
            entity.Property(e => e.CustomerParent).HasColumnName("customer_parent");
            entity.Property(e => e.CustomerRecordNumber)
                .HasMaxLength(25)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_record_number");
            entity.Property(e => e.CustomerServiceEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_service_email");
            entity.Property(e => e.CustomerServiceHotline)
                .HasMaxLength(30)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_service_hotline");
            entity.Property(e => e.CustomerServiceHotline2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_service_hotline2");
            entity.Property(e => e.CustomerServiceVipHotline)
                .HasMaxLength(30)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_service_vip_hotline");
            entity.Property(e => e.CustomerStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_status");
            entity.Property(e => e.CustomerTaxCard)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_tax_card");
            entity.Property(e => e.CustomerTaxFile)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_tax_file");
            entity.Property(e => e.CustomerTele)
                .HasMaxLength(15)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_tele");
            entity.Property(e => e.CustomerTele2)
                .HasMaxLength(15)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_tele2");
            entity.Property(e => e.CustomerTele3)
                .HasMaxLength(15)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_tele3");
            entity.Property(e => e.CustomerWebsite)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_website");
            entity.Property(e => e.DirectChronic).HasColumnName("direct_chronic");
            entity.Property(e => e.IsInsurer).HasColumnName("is_insurer");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("last_update_from");
            entity.Property(e => e.WhatsappNumber)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("whatsapp_number");

            entity.HasOne(d => d.CustomerAreaNavigation).WithMany(p => p.Customers)
                .HasForeignKey(d => d.CustomerArea)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Customers_areas");

            entity.HasOne(d => d.CustomerClient).WithMany(p => p.Customers)
                .HasForeignKey(d => d.CustomerClientId)
                .HasConstraintName("FK_Customers_Clients");

            entity.HasOne(d => d.CustomerParentNavigation).WithMany(p => p.InverseCustomerParentNavigation)
                .HasForeignKey(d => d.CustomerParent)
                .HasConstraintName("FK_Customers_Customers1");

            entity.HasOne(d => d.CustomerStatusNavigation).WithMany(p => p.Customers)
                .HasForeignKey(d => d.CustomerStatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Customers_state_ref");
        });

        modelBuilder.Entity<CustomerArchive>(entity =>
        {
            entity.ToTable("Customer_archive");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("name");

            entity.HasOne(d => d.Customer).WithMany(p => p.CustomerArchives)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Customer_archive_Customer_archive");
        });

        modelBuilder.Entity<CustomerAuthorizationRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_customr_authorization_request");

            entity.ToTable("customer_authorization_request");

            entity.Property(e => e.CreationDate)
                .HasColumnType("datetime")
                .HasColumnName("creation_date");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.Note)
                .IsUnicode(false)
                .HasColumnName("note");
            entity.Property(e => e.RequestDate)
                .HasColumnType("datetime")
                .HasColumnName("request_date");
            entity.Property(e => e.RequestUserId)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("request_user_id");
            entity.Property(e => e.ResponseDate)
                .HasColumnType("datetime")
                .HasColumnName("response_date");
            entity.Property(e => e.ResponseUserId)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("response_user_id");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("status");

            entity.HasOne(d => d.Customer).WithMany(p => p.CustomerAuthorizationRequests)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk__customr_authorization_request_customers");

            entity.HasOne(d => d.RequestUser).WithMany(p => p.CustomerAuthorizationRequestRequestUsers)
                .HasForeignKey(d => d.RequestUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_customer_authorization_request_users");

            entity.HasOne(d => d.ResponseUser).WithMany(p => p.CustomerAuthorizationRequestResponseUsers)
                .HasForeignKey(d => d.ResponseUserId)
                .HasConstraintName("fk_customer_authorization_response_users");
        });

        modelBuilder.Entity<CustomerComplaint>(entity =>
        {
            entity.ToTable("customer_complaints");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Closed)
                .IsRequired()
                .HasDefaultValueSql("('0')")
                .HasColumnName("closed");
            entity.Property(e => e.Complaint)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("complaint");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_from");
            entity.Property(e => e.Respond)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("respond");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");

            entity.HasOne(d => d.Customer).WithMany(p => p.CustomerComplaints)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_customer_complaints_customer_complaints");

            entity.HasOne(d => d.Vendor).WithMany(p => p.CustomerComplaints)
                .HasForeignKey(d => d.VendorId)
                .HasConstraintName("FK_customer_complaints_Vendor_General");
        });

        modelBuilder.Entity<CustomerContact>(entity =>
        {
            entity.HasKey(e => e.ContactId);

            entity.ToTable("customer_contacts");

            entity.Property(e => e.ContactId).HasColumnName("contact_id");
            entity.Property(e => e.ContactCustomerId).HasColumnName("contact_customer_id");
            entity.Property(e => e.ContactEmail)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("contact_email");
            entity.Property(e => e.ContactName)
                .HasMaxLength(50)
                .HasColumnName("contact_name");
            entity.Property(e => e.ContactNotes)
                .HasMaxLength(50)
                .HasColumnName("contact_notes");
            entity.Property(e => e.ContactOccupationId).HasColumnName("contact_occupation_id");
            entity.Property(e => e.ContactTele1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("contact_tele1");
            entity.Property(e => e.ContactTele2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("contact_tele2");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_from");

            entity.HasOne(d => d.ContactCustomer).WithMany(p => p.CustomerContacts)
                .HasForeignKey(d => d.ContactCustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_customer_contacts_Customers");

            entity.HasOne(d => d.ContactOccupation).WithMany(p => p.CustomerContacts)
                .HasForeignKey(d => d.ContactOccupationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_customer_contacts_contacts_occupation");
        });

        modelBuilder.Entity<CustomerContract>(entity =>
        {
            entity.HasKey(e => e.CustomerContractId).HasName("PK_cust_Contract");

            entity.ToTable("Customer_Contracts", tb =>
                {
                    tb.HasTrigger("trigger_insert_customer_contracts");
                    tb.HasTrigger("trigger_update_customer_contracts");
                });

            entity.HasIndex(e => new { e.CustomerContractId, e.CustomerContractCustomerId }, "IX_Customer_Contracts").IsUnique();

            entity.Property(e => e.CustomerContractId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("customer_contract_id");
            entity.Property(e => e.AllowDeleteWithcons).HasColumnName("allow_delete_withcons");
            entity.Property(e => e.ApprovalValid).HasColumnName("approval_valid");
            entity.Property(e => e.ApprovalValidChronic).HasColumnName("approval_valid_chronic");
            entity.Property(e => e.ChildrenAge).HasColumnName("children_age");
            entity.Property(e => e.ClacByDays).HasColumnName("clac_by_days");
            entity.Property(e => e.ContractPlanChronicDate)
                .HasColumnType("datetime")
                .HasColumnName("contract_plan_chronic_date");
            entity.Property(e => e.CustomerContractCategory)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("customer_contract_category");
            entity.Property(e => e.CustomerContractCheckIssuance)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_contract_check_issuance");
            entity.Property(e => e.CustomerContractCustomerId).HasColumnName("customer_contract_customer_id");
            entity.Property(e => e.CustomerContractEliminationRatio).HasColumnName("customer_contract_elimination_ratio");
            entity.Property(e => e.CustomerContractEndDate)
                .HasColumnType("datetime")
                .HasColumnName("customer_contract_end_date");
            entity.Property(e => e.CustomerContractInsurer).HasColumnName("customer_contract_insurer");
            entity.Property(e => e.CustomerContractManagementRatio).HasColumnName("customer_contract_management_ratio");
            entity.Property(e => e.CustomerContractMaxDateAddMembers)
                .HasColumnType("datetime")
                .HasColumnName("customer_contract_max_date_add_members");
            entity.Property(e => e.CustomerContractMembersNumber).HasColumnName("customer_contract_members_number");
            entity.Property(e => e.CustomerContractNotes)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_contract_notes");
            entity.Property(e => e.CustomerContractStartDate)
                .HasColumnType("datetime")
                .HasColumnName("customer_contract_start_date");
            entity.Property(e => e.DeleteOfprimRatio).HasColumnName("delete_ofprim_ratio");
            entity.Property(e => e.EliminationDelation).HasColumnName("elimination_delation");
            entity.Property(e => e.FollowersNumber).HasColumnName("followers_number");
            entity.Property(e => e.Isgross).HasColumnName("isgross");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("last_update_from");
            entity.Property(e => e.MinimumMoths).HasColumnName("minimum_moths");
            entity.Property(e => e.PolicyDocument).HasColumnName("policy_document");
            entity.Property(e => e.StopValue).HasColumnName("stop_value");

            entity.HasOne(d => d.CustomerContractCategoryNavigation).WithMany(p => p.CustomerContracts)
                .HasForeignKey(d => d.CustomerContractCategory)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Customer_Contracts_Contract_Types");

            entity.HasOne(d => d.CustomerContractCustomer).WithMany(p => p.CustomerContractCustomerContractCustomers)
                .HasForeignKey(d => d.CustomerContractCustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Customer_Contracts_Customers");

            entity.HasOne(d => d.CustomerContractInsurerNavigation).WithMany(p => p.CustomerContractCustomerContractInsurerNavigations)
                .HasForeignKey(d => d.CustomerContractInsurer)
                .HasConstraintName("FK_Customer_Contracts_Customers1");

            entity.HasOne(d => d.PolicyDocumentNavigation).WithMany(p => p.CustomerContracts)
                .HasForeignKey(d => d.PolicyDocument)
                .HasConstraintName("FK_Customer_Contracts_Customer_archive");
        });

        modelBuilder.Entity<CustomerContractCategory>(entity =>
        {
            entity.HasKey(e => new { e.ContractCategoryId, e.CustomerContractId }).HasName("PK_customer_contract_category");

            entity.ToTable("customer_contract_categories", tb =>
                {
                    tb.HasTrigger("trigger_delete_customer_contract_categories");
                    tb.HasTrigger("trigger_insert_customers_contract_categories");
                    tb.HasTrigger("trigger_update_customers_contract_categories");
                });

            entity.Property(e => e.ContractCategoryId).HasColumnName("contract_category_id");
            entity.Property(e => e.CustomerContractId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("customer_contract_id");
            entity.Property(e => e.AnnualFees).HasColumnName("annual_fees");
            entity.Property(e => e.IsLevelIndividual).HasColumnName("is_level_individual");
            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("last_updated_by");
            entity.Property(e => e.LastUpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("last_updated_date");
            entity.Property(e => e.LastUpdatedFrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("last_updated_from");
            entity.Property(e => e.MinMemberAllow).HasColumnName("min_member_allow");
            entity.Property(e => e.Notes)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("notes");

            entity.HasOne(d => d.ContractCategory).WithMany(p => p.CustomerContractCategories)
                .HasForeignKey(d => d.ContractCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_customer_contract_categories_contract_categories");

            entity.HasOne(d => d.CustomerContract).WithMany(p => p.CustomerContractCategories)
                .HasForeignKey(d => d.CustomerContractId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_customer_contract_categories_Customer_Contracts1");
        });

        modelBuilder.Entity<CustomerDatasheet>(entity =>
        {
            entity.ToTable("CustomerDatasheet");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Business).HasColumnName("business");
            entity.Property(e => e.CompanyEmail).HasColumnName("company_email");
            entity.Property(e => e.CompanyPosition).HasColumnName("company_position");
            entity.Property(e => e.ContactPerson).HasColumnName("contact_person");
            entity.Property(e => e.CustomerAddressCity).HasColumnName("customer_address_city");
            entity.Property(e => e.CustomerAddressCountry).HasColumnName("customer_address_country");
            entity.Property(e => e.CustomerName).HasColumnName("customer_name");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.LastUpdateBy).HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom).HasColumnName("last_update_from");
            entity.Property(e => e.TelephoneFax).HasColumnName("telephone_fax");
        });

        modelBuilder.Entity<CustomerOutpatientService>(entity =>
        {
            entity.ToTable("Customer_outpatient_services");

            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Labs).HasColumnName("labs");
            entity.Property(e => e.OutpatientPrescribedMedication).HasColumnName("outpatient_prescribed_medication");
            entity.Property(e => e.Outpatientexamination).HasColumnName("outpatientexamination");
            entity.Property(e => e.Physiotherapy).HasColumnName("physiotherapy");
            entity.Property(e => e.Program).HasColumnName("program");
            entity.Property(e => e.Radiology).HasColumnName("radiology");
        });

        modelBuilder.Entity<CustomerStatusMonitor>(entity =>
        {
            entity.HasKey(e => e.StatusMonitorId).HasName("PK_Status_Monitor_1");

            entity.ToTable("Customer_Status_Monitor");

            entity.Property(e => e.StatusMonitorId).HasColumnName("status_monitor_id");
            entity.Property(e => e.CustomerMonitorAction).HasColumnName("customer_monitor_action");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("last_update_from");
            entity.Property(e => e.StatusMonitorNewStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("status_monitor_new_status");
            entity.Property(e => e.StatusMonitorStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("status_monitor_status");
            entity.Property(e => e.StatusMonitorStatusDate)
                .HasColumnType("datetime")
                .HasColumnName("status_monitor_status_date");
        });

        modelBuilder.Entity<CustomerVendorException>(entity =>
        {
            entity.ToTable("customer_vendor_exception");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");

            entity.HasOne(d => d.Customer).WithMany(p => p.CustomerVendorExceptions)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_customer_vendor_exception_Customers");

            entity.HasOne(d => d.Vendor).WithMany(p => p.CustomerVendorExceptions)
                .HasForeignKey(d => d.VendorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_customer_vendor_exception_Vendor_General");
        });

        modelBuilder.Entity<CustomersVisit>(entity =>
        {
            entity.ToTable("Customers_visits");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreationDate)
                .HasColumnType("datetime")
                .HasColumnName("creation_date");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.Notes)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.VisitDate)
                .HasColumnType("datetime")
                .HasColumnName("visit_date");

            entity.HasOne(d => d.Customer).WithMany(p => p.CustomersVisits)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Customers_visits_Customers");

            entity.HasMany(d => d.Users).WithMany(p => p.Visits)
                .UsingEntity<Dictionary<string, object>>(
                    "VisitsUser",
                    r => r.HasOne<AspNetUser>().WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Visits_users_AspNetUsers"),
                    l => l.HasOne<CustomersVisit>().WithMany()
                        .HasForeignKey("VisitId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Visits_users_Customers_visits"),
                    j =>
                    {
                        j.HasKey("VisitId", "UserId");
                        j.ToTable("Visits_users");
                        j.IndexerProperty<int>("VisitId").HasColumnName("Visit_id");
                        j.IndexerProperty<string>("UserId")
                            .HasMaxLength(128)
                            .IsUnicode(false)
                            .HasColumnName("user_id");
                    });
        });

        modelBuilder.Entity<DaysOfTheWeek>(entity =>
        {
            entity.HasKey(e => e.DayId);

            entity.ToTable("days_of_the_week");

            entity.Property(e => e.DayId).HasColumnName("day_id");
            entity.Property(e => e.DayName)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("day_name");
            entity.Property(e => e.DayNameAr)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("day_name_ar");
        });

        modelBuilder.Entity<DisRefund>(entity =>
        {
            entity.ToTable("dis_refund");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActivitySerial).HasColumnName("activity_serial");
            entity.Property(e => e.AsRev).HasColumnName("as_rev");
            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("batch_id");
            entity.Property(e => e.ContractActivity)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("contract_activity");
            entity.Property(e => e.ContractCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("contract_code");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.Insurer).HasColumnName("insurer");
            entity.Property(e => e.InvId).HasColumnName("inv_id");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.MemberId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("member_id");
            entity.Property(e => e.Notes)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.NotficatiohnId).HasColumnName("Notficatiohn_id");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("type");
            entity.Property(e => e.ValFactor).HasColumnName("val_factor");
            entity.Property(e => e.Value).HasColumnName("value");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");

            entity.HasOne(d => d.Batch).WithMany(p => p.DisRefunds)
                .HasForeignKey(d => d.BatchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dis_refund_Batches");

            entity.HasOne(d => d.Customer).WithMany(p => p.DisRefunds)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dis_refund_Customers");

            entity.HasOne(d => d.Inv).WithMany(p => p.DisRefundInvs)
                .HasForeignKey(d => d.InvId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dis_refund_Batch_details1");

            entity.HasOne(d => d.MeditemNavigation).WithMany(p => p.DisRefunds)
                .HasForeignKey(d => d.Meditem)
                .HasConstraintName("FK_dis_refund_care_items");

            entity.HasOne(d => d.Member).WithMany(p => p.DisRefunds)
                .HasForeignKey(d => d.MemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dis_refund_Members");

            entity.HasOne(d => d.Vendor).WithMany(p => p.DisRefunds)
                .HasForeignKey(d => d.VendorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dis_refund_Vendor_General");

            entity.HasOne(d => d.BatchDetail).WithMany(p => p.DisRefundBatchDetails)
                .HasPrincipalKey(p => new { p.BatchId, p.InvId })
                .HasForeignKey(d => new { d.BatchId, d.InvId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dis_refund_Batch_details");

            entity.HasOne(d => d.MemberPlan).WithMany(p => p.DisRefunds)
                .HasPrincipalKey(p => new { p.MemberCode, p.ContractCode })
                .HasForeignKey(d => new { d.MemberId, d.ContractCode })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dis_refund_MemberPlan");

            entity.HasOne(d => d.ContractActivityNavigation).WithMany(p => p.DisRefunds)
                .HasPrincipalKey(p => new { p.ContractCode, p.Serial, p.CustomerId, p.ActivityId, p.Insurer })
                .HasForeignKey(d => new { d.ContractCode, d.ActivitySerial, d.CustomerId, d.ContractActivity, d.Insurer })
                .HasConstraintName("FK_dis_refund_contract_activities");
        });

        modelBuilder.Entity<DueAttachedFile>(entity =>
        {
            entity.HasKey(e => e.DueAttachedId);

            entity.ToTable("Due_attached_files");

            entity.Property(e => e.DueAttachedId).HasColumnName("due_attached_id");
            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("batch_id");
            entity.Property(e => e.DeleteFlag).HasColumnName("delete_flag");
            entity.Property(e => e.DueAttachedName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("due_attached_name");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("last_update_from");

            entity.HasOne(d => d.Batch).WithMany(p => p.DueAttachedFiles)
                .HasForeignKey(d => d.BatchId)
                .HasConstraintName("FK_Due_attached_files_Batches");
        });

        modelBuilder.Entity<GroupBatch>(entity =>
        {
            entity.HasKey(e => new { e.BatchId, e.GroupId });

            entity.ToTable("group_batches");

            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("batch_id");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.ChequeDate).HasColumnName("cheque_date");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_from");
            entity.Property(e => e.Type).HasColumnName("type");

            entity.HasOne(d => d.Batch).WithMany(p => p.GroupBatches)
                .HasForeignKey(d => d.BatchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_group_batches_Batches");

            entity.HasOne(d => d.Group).WithMany(p => p.GroupBatches)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_group_batches_batch_groups");
        });

        modelBuilder.Entity<GroupsLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Groups_L__3214EC078276735C");

            entity.ToTable("Groups_Log");

            entity.Property(e => e.Action).HasColumnName("action");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("last_update_from");
            entity.Property(e => e.NumNotes).HasColumnName("num_notes");

            entity.HasOne(d => d.Customer).WithMany(p => p.GroupsLogs)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("fk_Department");
        });

        modelBuilder.Entity<InActiveCustomer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("InActive_customers");

            entity.Property(e => e.CareCard).HasColumnName("care_card");
            entity.Property(e => e.CustomerAccountNum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_account_num");
            entity.Property(e => e.CustomerAddress)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_address");
            entity.Property(e => e.CustomerArea).HasColumnName("customer_area");
            entity.Property(e => e.CustomerClientId).HasColumnName("customer_client_id");
            entity.Property(e => e.CustomerCommission).HasColumnName("customer_commission");
            entity.Property(e => e.CustomerContactPerson)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_contact_person");
            entity.Property(e => e.CustomerCreationDate)
                .HasColumnType("datetime")
                .HasColumnName("customer_creation_date");
            entity.Property(e => e.CustomerEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_email");
            entity.Property(e => e.CustomerFax)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_fax");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.CustomerMedicinesService)
                .HasMaxLength(30)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_medicines_service");
            entity.Property(e => e.CustomerMedicinesService2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_medicines_service2");
            entity.Property(e => e.CustomerMobile)
                .HasMaxLength(15)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_mobile");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_name");
            entity.Property(e => e.CustomerParent).HasColumnName("customer_parent");
            entity.Property(e => e.CustomerRecordNumber)
                .HasMaxLength(25)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_record_number");
            entity.Property(e => e.CustomerServiceEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_service_email");
            entity.Property(e => e.CustomerServiceHotline)
                .HasMaxLength(30)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_service_hotline");
            entity.Property(e => e.CustomerServiceHotline2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_service_hotline2");
            entity.Property(e => e.CustomerServiceVipHotline)
                .HasMaxLength(30)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_service_vip_hotline");
            entity.Property(e => e.CustomerStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_status");
            entity.Property(e => e.CustomerTaxCard)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_tax_card");
            entity.Property(e => e.CustomerTaxFile)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_tax_file");
            entity.Property(e => e.CustomerTele)
                .HasMaxLength(15)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_tele");
            entity.Property(e => e.CustomerTele2)
                .HasMaxLength(15)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_tele2");
            entity.Property(e => e.CustomerTele3)
                .HasMaxLength(15)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_tele3");
            entity.Property(e => e.CustomerWebsite)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_website");
            entity.Property(e => e.DirectChronic).HasColumnName("direct_chronic");
            entity.Property(e => e.IsInsurer).HasColumnName("is_insurer");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("last_update_from");
        });

        modelBuilder.Entity<Inquery>(entity =>
        {
            entity.HasKey(e => e.ReqId).HasName("PK_users_request");

            entity.ToTable("inqueries");

            entity.Property(e => e.ReqId).HasColumnName("req_id");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_from");
            entity.Property(e => e.ReqAddressId).HasColumnName("req_address_id");
            entity.Property(e => e.ReqCategory).HasColumnName("req_category");
            entity.Property(e => e.ReqDate)
                .HasColumnType("datetime")
                .HasColumnName("req_date");
            entity.Property(e => e.ReqMember)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("req_member");
            entity.Property(e => e.ReqNote)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("req_note");
            entity.Property(e => e.ReqParent)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("req_parent");
            entity.Property(e => e.ReqProvider)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("req_provider");
            entity.Property(e => e.ReqSource).HasColumnName("req_source");
            entity.Property(e => e.ReqStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("req_status");
            entity.Property(e => e.ReqType).HasColumnName("req_type");

            entity.HasOne(d => d.ReqAddress).WithMany(p => p.Inqueries)
                .HasForeignKey(d => d.ReqAddressId)
                .HasConstraintName("FK_inqueries_member_contacts");

            entity.HasOne(d => d.ReqCategoryNavigation).WithMany(p => p.Inqueries)
                .HasForeignKey(d => d.ReqCategory)
                .HasConstraintName("FK_inqueries_vendor_category");

            entity.HasOne(d => d.ReqMemberNavigation).WithMany(p => p.InqueryReqMemberNavigations)
                .HasForeignKey(d => d.ReqMember)
                .HasConstraintName("FK_inqueries_Members");

            entity.HasOne(d => d.ReqParentNavigation).WithMany(p => p.InqueryReqParentNavigations)
                .HasForeignKey(d => d.ReqParent)
                .HasConstraintName("FK_inqueries_Members1");

            entity.HasOne(d => d.ReqProviderNavigation).WithMany(p => p.Inqueries)
                .HasForeignKey(d => d.ReqProvider)
                .HasConstraintName("FK_inqueries_Vendor_General");
        });

        modelBuilder.Entity<InsurerVendorMap>(entity =>
        {
            entity.HasKey(e => new { e.Insurer, e.VendorId });

            entity.ToTable("insurer_vendor_map");

            entity.Property(e => e.Insurer).HasColumnName("insurer");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");
            entity.Property(e => e.LinkId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("link_id");
            entity.Property(e => e.VendorCat).HasColumnName("vendor_cat");

            entity.HasOne(d => d.InsurerNavigation).WithMany(p => p.InsurerVendorMaps)
                .HasForeignKey(d => d.Insurer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_insurer_vendor_map_insurer_vendor_map");

            entity.HasOne(d => d.Vendor).WithMany(p => p.InsurerVendorMaps)
                .HasForeignKey(d => d.VendorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_insurer_vendor_map_Vendor_General");
        });

        modelBuilder.Entity<InvDetail>(entity =>
        {
            entity.ToTable("inv_details");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cprice).HasColumnName("cprice");
            entity.Property(e => e.DisReason)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("dis_reason");
            entity.Property(e => e.InvId).HasColumnName("inv_id");
            entity.Property(e => e.MedFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("med_flag");
            entity.Property(e => e.OurPrice).HasColumnName("our_price");
            entity.Property(e => e.Qty).HasColumnName("qty");
            entity.Property(e => e.SelectFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("select_flag");
            entity.Property(e => e.SrvDis).HasColumnName("srv_dis");
            entity.Property(e => e.SrvId).HasColumnName("srv_id");

            entity.HasOne(d => d.Inv).WithMany(p => p.InvDetails)
                .HasForeignKey(d => d.InvId)
                .HasConstraintName("FK_inv_details_Batch_details");
        });

        modelBuilder.Entity<ItemCopayment>(entity =>
        {
            entity.HasKey(e => new { e.PlanId, e.ItemId, e.VendorCategoryId });

            entity.ToTable("Item_copayments");

            entity.Property(e => e.PlanId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("plan_id");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.VendorCategoryId).HasColumnName("vendor_category_id");
            entity.Property(e => e.Copayment).HasColumnName("copayment");
            entity.Property(e => e.Enabled).HasColumnName("enabled");
            entity.Property(e => e.Isallowed).HasColumnName("isallowed");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");

            entity.HasOne(d => d.VendorCategory).WithMany(p => p.ItemCopayments)
                .HasForeignKey(d => d.VendorCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Item_copayments_vendor_category");

            entity.HasOne(d => d.Vendor).WithMany(p => p.ItemCopayments)
                .HasForeignKey(d => d.VendorId)
                .HasConstraintName("FK_Item_copayments_Vendor_General");

            entity.HasOne(d => d.PlanItem).WithMany(p => p.ItemCopayments)
                .HasForeignKey(d => new { d.PlanId, d.ItemId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Item_copayments_PlanItems");
        });

        modelBuilder.Entity<LocalTicket>(entity =>
        {
            entity.HasKey(e => e.LocalId);

            entity.ToTable("local_tickets");

            entity.Property(e => e.LocalId).HasColumnName("local_Id");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LocalFromGroup)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("local_from_group");
            entity.Property(e => e.LocalNote)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("local_note");
            entity.Property(e => e.LocalStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("local_status");
            entity.Property(e => e.LocalType).HasColumnName("local_type");
            entity.Property(e => e.StimatedTime).HasColumnName("stimated_time");
            entity.Property(e => e.StimatedValue)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("stimated_value");

            entity.HasMany(d => d.LocalGroups).WithMany(p => p.LocalReqs)
                .UsingEntity<Dictionary<string, object>>(
                    "LocalTicketsGroup",
                    r => r.HasOne<AspNetUser>().WithMany()
                        .HasForeignKey("LocalGroupId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_local_tickets_group_AspNetUsers"),
                    l => l.HasOne<LocalTicket>().WithMany()
                        .HasForeignKey("LocalReqId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_local_tickets_group_local_tickets"),
                    j =>
                    {
                        j.HasKey("LocalReqId", "LocalGroupId");
                        j.ToTable("local_tickets_group");
                        j.IndexerProperty<int>("LocalReqId").HasColumnName("local_req_id");
                        j.IndexerProperty<string>("LocalGroupId")
                            .HasMaxLength(128)
                            .IsUnicode(false)
                            .HasColumnName("local_group_id");
                    });
        });

        modelBuilder.Entity<LocalTicketsReply>(entity =>
        {
            entity.HasKey(e => e.ReplyLoaclId);

            entity.ToTable("local_tickets_reply");

            entity.Property(e => e.ReplyLoaclId).HasColumnName("reply_loacl_id");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_from");
            entity.Property(e => e.ReplyFromGroup)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("reply_from_group");
            entity.Property(e => e.ReplyLoaclNote)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("reply_loacl_note");
            entity.Property(e => e.ReplyTicketId).HasColumnName("reply_ticket_id");

            entity.HasOne(d => d.ReplyTicket).WithMany(p => p.LocalTicketsReplies)
                .HasForeignKey(d => d.ReplyTicketId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_local_tickets_reply_local_tickets");
        });

        modelBuilder.Entity<LotForm>(entity =>
        {
            entity.HasKey(e => new { e.ClaimFormLotsId, e.StartSerial }).HasName("PK_lot_forms_1");

            entity.ToTable("lot_forms");

            entity.Property(e => e.ClaimFormLotsId).HasColumnName("claim_form_lots_id");
            entity.Property(e => e.StartSerial).HasColumnName("start_serial");
            entity.Property(e => e.Code).HasColumnName("code");

            entity.HasOne(d => d.ClaimFormLots).WithMany(p => p.LotForms)
                .HasForeignKey(d => d.ClaimFormLotsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_claim_form_lots");

            entity.HasOne(d => d.CodeNavigation).WithMany(p => p.LotForms)
                .HasForeignKey(d => d.Code)
                .HasConstraintName("FK_ClaimLotsFormCode");
        });

        modelBuilder.Entity<MailRequest>(entity =>
        {
            entity.ToTable("mail_requests");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LinkedApproval).HasColumnName("linked_approval");
            entity.Property(e => e.MailBody)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("mail_body");
            entity.Property(e => e.MailFrom)
                .HasMaxLength(48)
                .IsUnicode(false)
                .HasColumnName("mail_from");
            entity.Property(e => e.MailLink)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("mail_link");
            entity.Property(e => e.MailSubj)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("mail_subj");
            entity.Property(e => e.MailTo)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("mail_to");
            entity.Property(e => e.RequestDate)
                .HasColumnType("datetime")
                .HasColumnName("request_date");
        });

        modelBuilder.Entity<MashPayment>(entity =>
        {
            entity.HasKey(e => e.PayId).HasName("PK_mash_payments_1");

            entity.ToTable("mash_payments");

            entity.Property(e => e.PayId).HasColumnName("pay_id");
            entity.Property(e => e.ApprovalId).HasColumnName("approval_id");
            entity.Property(e => e.ExpireDate)
                .HasColumnType("datetime")
                .HasColumnName("expire_date");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_from");
            entity.Property(e => e.PayCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("pay_code");
            entity.Property(e => e.PayDate)
                .HasColumnType("datetime")
                .HasColumnName("pay_date");
            entity.Property(e => e.PayLink)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("pay_link");
            entity.Property(e => e.PayStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("pay_status");
            entity.Property(e => e.PayType).HasColumnName("pay_type");
            entity.Property(e => e.PayValue).HasColumnName("pay_value");
            entity.Property(e => e.ReqId).HasColumnName("req_id");

            entity.HasOne(d => d.Approval).WithMany(p => p.MashPaymentApprovals)
                .HasForeignKey(d => d.ApprovalId)
                .HasConstraintName("FK_mash_payments_approvals1");

            entity.HasOne(d => d.PayTypeNavigation).WithMany(p => p.MashPayments)
                .HasForeignKey(d => d.PayType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_mash_payments_payment_channels");

            entity.HasOne(d => d.Req).WithMany(p => p.MashPayments)
                .HasForeignKey(d => d.ReqId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_mash_payments_inqueries");

            entity.HasOne(d => d.ApprovalNavigation).WithMany(p => p.MashPaymentApprovalNavigations)
                .HasPrincipalKey(p => new { p.ApprovalId, p.ReqId })
                .HasForeignKey(d => new { d.ApprovalId, d.ReqId })
                .HasConstraintName("FK_mash_payments_approvals");
        });

        modelBuilder.Entity<McAuthenticate>(entity =>
        {
            entity.ToTable("mc_authenticate");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Enabled).HasColumnName("enabled");
            entity.Property(e => e.Password)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<McAuthenticateLog>(entity =>
        {
            entity.ToTable("mc_authenticate_log");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActCode).HasColumnName("act_code");
            entity.Property(e => e.AdditionalInfo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("additional_info");
            entity.Property(e => e.AuthenticationId).HasColumnName("authenticationId");
            entity.Property(e => e.Machine)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("machine");
            entity.Property(e => e.Time)
                .HasColumnType("datetime")
                .HasColumnName("time");

            entity.HasOne(d => d.ActCodeNavigation).WithMany(p => p.McAuthenticateLogs)
                .HasForeignKey(d => d.ActCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_authenticate_log_approvals");

            entity.HasOne(d => d.Authentication).WithMany(p => p.McAuthenticateLogs)
                .HasForeignKey(d => d.AuthenticationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_mc_authenticate_log_mc_authenticate");
        });

        modelBuilder.Entity<Member>(entity =>
        {
            entity.HasKey(e => e.MemberId).HasName("PK_MEMBERS");

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("trigger_insert_members");
                    tb.HasTrigger("trigger_update_members");
                });

            entity.HasIndex(e => e.MemberId, "IX_Members");

            entity.Property(e => e.MemberId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("member_id");
            entity.Property(e => e.AccountNumber)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("account_number");
            entity.Property(e => e.AlarmMsg)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("alarm_msg");
            entity.Property(e => e.AreaId).HasColumnName("area_id");
            entity.Property(e => e.BankNumber)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("bank_number");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FmcToken)
                .HasMaxLength(200)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("fmc_token");
            entity.Property(e => e.IsRegistered)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("isRegistered");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("last_update_from");
            entity.Property(e => e.MailCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("mail_code");
            entity.Property(e => e.MemberAddress)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("member_address");
            entity.Property(e => e.MemberBirthday).HasColumnName("member_birthday");
            entity.Property(e => e.MemberCareCardDate).HasColumnName("member_care_card_date");
            entity.Property(e => e.MemberCareCardId).HasColumnName("member_care_card_id");
            entity.Property(e => e.MemberCareCardStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("member_care_card_status");
            entity.Property(e => e.MemberCareCardValue).HasColumnName("member_care_card_value");
            entity.Property(e => e.MemberClass)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("member_class");
            entity.Property(e => e.MemberCompanyId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("member_company_id");
            entity.Property(e => e.MemberCreationDate)
                .HasColumnType("datetime")
                .HasColumnName("member_creation_date");
            entity.Property(e => e.MemberCustomerId).HasColumnName("member_customer_id");
            entity.Property(e => e.MemberEip).HasColumnName("member_eip");
            entity.Property(e => e.MemberExternalCode)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("member_external_code");
            entity.Property(e => e.MemberFrequent).HasColumnName("member_frequent");
            entity.Property(e => e.MemberGender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("member_gender");
            entity.Property(e => e.MemberJob)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("member_job");
            entity.Property(e => e.MemberName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("member_name");
            entity.Property(e => e.MemberNationalId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("member_national_id");
            entity.Property(e => e.MemberNotes)
                .HasMaxLength(256)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("member_notes");
            entity.Property(e => e.MemberOnlineApprovals).HasColumnName("member_online_approvals");
            entity.Property(e => e.MemberParent)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("member_parent");
            entity.Property(e => e.MemberStatues)
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("member_statues");
            entity.Property(e => e.MemberSubDate)
                .HasColumnType("datetime")
                .HasColumnName("member_sub_date");
            entity.Property(e => e.MemberTele)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("member_tele");
            entity.Property(e => e.MemberTele2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("member_tele2");
            entity.Property(e => e.MemberTele3)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("member_tele3");
            entity.Property(e => e.MemberVip).HasColumnName("member_vip");
            entity.Property(e => e.MobPlatform)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("mob_platform");
            entity.Property(e => e.MobPushFlag).HasColumnName("mob_push_flag");
            entity.Property(e => e.MobToken)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("mob_token");
            entity.Property(e => e.Password)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("password");
            entity.Property(e => e.PhoneCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("phone_code");
            entity.Property(e => e.ShowMobProfile).HasColumnName("show_mob_profile");

            entity.HasOne(d => d.Area).WithMany(p => p.Members)
                .HasForeignKey(d => d.AreaId)
                .HasConstraintName("FK_Members_areas");

            entity.HasOne(d => d.MemberCustomer).WithMany(p => p.Members)
                .HasForeignKey(d => d.MemberCustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Members_Customers");

            entity.HasOne(d => d.MemberParentNavigation).WithMany(p => p.InverseMemberParentNavigation)
                .HasForeignKey(d => d.MemberParent)
                .HasConstraintName("FK_Members_Members");

            entity.HasOne(d => d.MemberStatuesNavigation).WithMany(p => p.Members)
                .HasForeignKey(d => d.MemberStatues)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Members_state_ref");

            entity.HasMany(d => d.Diagnoses).WithMany(p => p.Members)
                .UsingEntity<Dictionary<string, object>>(
                    "MemberDiagnose",
                    r => r.HasOne<OnlineDiagnosis>().WithMany()
                        .HasForeignKey("DiagnoseId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_member_diagnose_online_diagnosis"),
                    l => l.HasOne<Member>().WithMany()
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_member_diagnose_member_diagnose"),
                    j =>
                    {
                        j.HasKey("MemberId", "DiagnoseId");
                        j.ToTable("member_diagnose");
                        j.IndexerProperty<string>("MemberId")
                            .HasMaxLength(20)
                            .IsUnicode(false)
                            .HasColumnName("member_id");
                        j.IndexerProperty<string>("DiagnoseId")
                            .HasMaxLength(50)
                            .IsUnicode(false)
                            .HasColumnName("diagnose_id");
                    });
        });

        modelBuilder.Entity<MemberArchiveDoc>(entity =>
        {
            entity.HasKey(e => new { e.MemberId, e.CatId, e.Serial }).HasName("PK_memer_archieve_docs");

            entity.ToTable("member_archive_docs");

            entity.Property(e => e.MemberId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("member_id");
            entity.Property(e => e.CatId).HasColumnName("cat_id");
            entity.Property(e => e.Serial).HasColumnName("serial");
            entity.Property(e => e.FileExtension)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("file_extension");
            entity.Property(e => e.FileName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("file_name");
            entity.Property(e => e.FilePath)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("file_path");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("last_update_from");

            entity.HasOne(d => d.Cat).WithMany(p => p.MemberArchiveDocs)
                .HasForeignKey(d => d.CatId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_memer_archieve_docs_vendor_category");

            entity.HasOne(d => d.Member).WithMany(p => p.MemberArchiveDocs)
                .HasForeignKey(d => d.MemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_memer_archieve_docs_Members");
        });

        modelBuilder.Entity<MemberContact>(entity =>
        {
            entity.HasKey(e => e.AddressId).HasName("PK_member_contacts_1");

            entity.ToTable("member_contacts");

            entity.Property(e => e.AddressId).HasColumnName("address_id");
            entity.Property(e => e.MemberAddress)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("member_address");
            entity.Property(e => e.MemberArea).HasColumnName("member_area");
            entity.Property(e => e.MemberId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("member_id");
            entity.Property(e => e.MemberPhone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("member_phone");

            entity.HasOne(d => d.MemberAreaNavigation).WithMany(p => p.MemberContacts)
                .HasForeignKey(d => d.MemberArea)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_member_contacts_areas");

            entity.HasOne(d => d.Member).WithMany(p => p.MemberContacts)
                .HasForeignKey(d => d.MemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_member_contacts_Members");
        });

        modelBuilder.Entity<MemberFamily>(entity =>
        {
            entity.HasKey(e => e.FamilyId);

            entity.ToTable("Member_Family");

            entity.Property(e => e.FamilyId).HasColumnName("family_id");
            entity.Property(e => e.FamilyBirthday)
                .HasColumnType("datetime")
                .HasColumnName("family_Birthday");
            entity.Property(e => e.FamilyGender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("family_gender");
            entity.Property(e => e.FamilyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("family_name");
            entity.Property(e => e.FamilyNoId)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("family_No_ID");
            entity.Property(e => e.FamilyParent)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("family_parent");
            entity.Property(e => e.FamilyType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("family_type");

            entity.HasOne(d => d.FamilyParentNavigation).WithMany(p => p.MemberFamilies)
                .HasForeignKey(d => d.FamilyParent)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Member_Family_Member_Family");
        });

        modelBuilder.Entity<MemberPlan>(entity =>
        {
            entity.HasKey(e => new { e.MemberCode, e.PlanCode }).HasName("PK_MemberPlan_1");

            entity.ToTable("MemberPlan", tb =>
                {
                    tb.HasTrigger("trigger_delete_memberPlan");
                    tb.HasTrigger("trigger_insert_memberPlan");
                    tb.HasTrigger("trigger_update_memberPlan");
                });

            entity.HasIndex(e => new { e.MemberCode, e.ContractCode }, "IX_MemberPlan").IsUnique();

            entity.Property(e => e.MemberCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("member_code");
            entity.Property(e => e.PlanCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("plan_code");
            entity.Property(e => e.CardPrinted)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("card_printed");
            entity.Property(e => e.ContractCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("contract_code");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("last_update_from");
            entity.Property(e => e.MamberPlanFinancialPlan).HasColumnName("mamber_plan_financial_plan");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("status");

            entity.HasOne(d => d.ContractCodeNavigation).WithMany(p => p.MemberPlans)
                .HasForeignKey(d => d.ContractCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MemberPlan_Customer_Contracts");

            entity.HasOne(d => d.MamberPlanFinancialPlanNavigation).WithMany(p => p.MemberPlans)
                .HasForeignKey(d => d.MamberPlanFinancialPlan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MemberPlan_contract_categories");

            entity.HasOne(d => d.MemberCodeNavigation).WithMany(p => p.MemberPlans)
                .HasForeignKey(d => d.MemberCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MemberPlan_Members");

            entity.HasOne(d => d.PlanCodeNavigation).WithMany(p => p.MemberPlans)
                .HasForeignKey(d => d.PlanCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MemberPlan_Contract_Plans");
        });

        modelBuilder.Entity<MemberPlanAuthenticateLog>(entity =>
        {
            entity.ToTable("memberPlan_authenticate_log");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AuthenticationId).HasColumnName("authenticationId");
            entity.Property(e => e.Machine)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("machine");
            entity.Property(e => e.MemberCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("member_code");
            entity.Property(e => e.MemberPlan)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("member_plan");
            entity.Property(e => e.Time)
                .HasColumnType("datetime")
                .HasColumnName("time");

            entity.HasOne(d => d.Authentication).WithMany(p => p.MemberPlanAuthenticateLogs)
                .HasForeignKey(d => d.AuthenticationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_memberPlan_authenticate_log_mc_authenticate");

            entity.HasOne(d => d.MemberCodeNavigation).WithMany(p => p.MemberPlanAuthenticateLogs)
                .HasForeignKey(d => d.MemberCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_memberPlan_authenticate_log_Members");

            entity.HasOne(d => d.MemberPlanNavigation).WithMany(p => p.MemberPlanAuthenticateLogs)
                .HasForeignKey(d => d.MemberPlan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_memberPlan_authenticate_log_Contract_Plans");
        });

        modelBuilder.Entity<MemberPlanLog>(entity =>
        {
            entity.ToTable("MemberPlan_log");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ContractCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("contract_code");
            entity.Property(e => e.FinancialPlan).HasColumnName("financial_plan");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("last_update_from");
            entity.Property(e => e.MemberCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("member_code");
            entity.Property(e => e.NewPlanId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("new_plan_id");
            entity.Property(e => e.PlanId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("plan_id");
        });

        modelBuilder.Entity<MemberPlanTemp>(entity =>
        {
            entity.HasKey(e => e.PlanCode);

            entity.ToTable("MemberPlan_temp");

            entity.Property(e => e.PlanCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("plan_code");
            entity.Property(e => e.CardPrinted)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("card_printed");
            entity.Property(e => e.ContractCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("contract_code");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("last_update_from");
            entity.Property(e => e.MamberPlanFinancialPlan).HasColumnName("mamber_plan_financial_plan");
            entity.Property(e => e.MemberCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("member_code");
            entity.Property(e => e.OperationCode).HasColumnName("operation_code");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<MemberStatusMonitor>(entity =>
        {
            entity.ToTable("Member_Status_Monitor");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.MemberId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("member_id");
            entity.Property(e => e.NewStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("new_status");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("status");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("update_by");
            entity.Property(e => e.UpdateFrom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("update_from");

            entity.HasOne(d => d.Member).WithMany(p => p.MemberStatusMonitors)
                .HasForeignKey(d => d.MemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Member_Status_Monitor_Members");
        });

        modelBuilder.Entity<MembersComplaint>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_members_complains");

            entity.ToTable("members_complaints");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.ApprovalId).HasColumnName("approval_id");
            entity.Property(e => e.Closed).HasColumnName("closed");
            entity.Property(e => e.Complaint)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("complaint");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.Department)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("department");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_from");
            entity.Property(e => e.MemberId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("member_id");
            entity.Property(e => e.Respond)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("respond");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");

            entity.HasOne(d => d.Approval).WithMany(p => p.MembersComplaints)
                .HasForeignKey(d => d.ApprovalId)
                .HasConstraintName("FK_members_complaints_approvals");

            entity.HasOne(d => d.DepartmentNavigation).WithMany(p => p.MembersComplaints)
                .HasForeignKey(d => d.Department)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_members_complaints_AspNetUsers");

            entity.HasOne(d => d.Member).WithMany(p => p.MembersComplaints)
                .HasForeignKey(d => d.MemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_members_complaints_Members");

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.MembersComplaints)
                .HasForeignKey(d => d.Type)
                .HasConstraintName("FK_members_complaints_actions");

            entity.HasOne(d => d.Vendor).WithMany(p => p.MembersComplaints)
                .HasForeignKey(d => d.VendorId)
                .HasConstraintName("FK_members_complaints_Vendor_General");
        });

        modelBuilder.Entity<MembersLog>(entity =>
        {
            entity.ToTable("Members_log");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Action).HasColumnName("action");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("last_update_from");
            entity.Property(e => e.MemberId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("member_id");
            entity.Property(e => e.Note)
                .IsUnicode(false)
                .HasColumnName("note");

            entity.HasOne(d => d.ActionNavigation).WithMany(p => p.MembersLogs)
                .HasForeignKey(d => d.Action)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Members_log_actions");

            entity.HasOne(d => d.Member).WithMany(p => p.MembersLogs)
                .HasForeignKey(d => d.MemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Members_log_Members");
        });

        modelBuilder.Entity<MembersPlanItem>(entity =>
        {
            entity.HasKey(e => new { e.MemberId, e.PlanId, e.ItemId });

            entity.ToTable("members_planItems");

            entity.Property(e => e.MemberId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("member_id");
            entity.Property(e => e.PlanId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("plan_id");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.AddedAt)
                .HasColumnType("datetime")
                .HasColumnName("added_at");
            entity.Property(e => e.AddedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("added_by");
            entity.Property(e => e.AddedFrom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("added_from");

            entity.HasOne(d => d.Member).WithMany(p => p.MembersPlanItems)
                .HasForeignKey(d => d.MemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_members_planItems_members_planItems");
        });

        modelBuilder.Entity<MobileNotification>(entity =>
        {
            entity.HasKey(e => e.NotificationId).HasName("PK__mobile_n__8C107CBDEAFB1F0E");

            entity.ToTable("mobile_notification");

            entity.Property(e => e.NotificationId).HasColumnName("Notification_id");
            entity.Property(e => e.Body).HasColumnName("body");
            entity.Property(e => e.CreationDate)
                .HasColumnType("datetime")
                .HasColumnName("creation_date");
            entity.Property(e => e.ExpireDate)
                .HasColumnType("datetime")
                .HasColumnName("expire_date");
            entity.Property(e => e.ImagePath).HasColumnName("Image_Path");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_from");
            entity.Property(e => e.NotificationType).HasColumnName("Notification_Type");
            entity.Property(e => e.SendDate)
                .HasColumnType("datetime")
                .HasColumnName("Send_date");
            entity.Property(e => e.ToId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("To_id");
            entity.Property(e => e.TypeId).HasColumnName("type_id");

            entity.HasOne(d => d.NotificationTypeNavigation).WithMany(p => p.MobileNotificationNotificationTypeNavigations)
                .HasForeignKey(d => d.NotificationType)
                .HasConstraintName("FK_mobile_notification_acms_options");

            entity.HasOne(d => d.Type).WithMany(p => p.MobileNotificationTypes)
                .HasForeignKey(d => d.TypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_type");
        });

        modelBuilder.Entity<MordeenSupplied>(entity =>
        {
            entity.ToTable("mordeen_supplied");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("batch_id");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_from");
            entity.Property(e => e.MowredId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("mowred_id");

            entity.HasOne(d => d.Batch).WithMany(p => p.MordeenSupplieds)
                .HasForeignKey(d => d.BatchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_mordeen_supplied_Batches");
        });

        modelBuilder.Entity<Neqabat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Neqabat__3213E83F445F9075");

            entity.ToTable("Neqabat");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("last_update_from");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("name");
            entity.Property(e => e.Type).HasColumnName("type");

            entity.HasOne(d => d.Category).WithMany(p => p.Neqabats)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Neqabat_vendor_category");
        });

        modelBuilder.Entity<NoteGroup>(entity =>
        {
            entity.HasKey(e => e.NoteId).HasName("PK_note_group_1");

            entity.ToTable("note_group");

            entity.HasIndex(e => new { e.GroupId, e.Serial }, "IX_note_group").IsUnique();

            entity.Property(e => e.NoteId)
                .HasColumnType("numeric(12, 0)")
                .HasColumnName("note_id");
            entity.Property(e => e.BillTempId).HasColumnName("bill_temp_id");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.Serial).HasColumnName("serial");
        });

        modelBuilder.Entity<NotesClaimGroup>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.CustomerId }).HasName("PK_notes_claim_groups_1");

            entity.ToTable("notes_claim_groups");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.AdminFees).HasColumnName("admin_fees");
            entity.Property(e => e.EndAt)
                .HasColumnType("datetime")
                .HasColumnName("end_at");
            entity.Property(e => e.EndBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("end_by");
            entity.Property(e => e.FactorAed).HasColumnName("factor_aed");
            entity.Property(e => e.FactorUsd).HasColumnName("factor_usd");
            entity.Property(e => e.GroupEnd)
                .HasColumnType("datetime")
                .HasColumnName("group_end");
            entity.Property(e => e.GroupStart)
                .HasColumnType("datetime")
                .HasColumnName("group_start");
            entity.Property(e => e.StartAt)
                .HasColumnType("datetime")
                .HasColumnName("start_at");
            entity.Property(e => e.StartBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("start_by");

            entity.HasOne(d => d.Customer).WithMany(p => p.NotesClaimGroups)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_notes_claim_groups_Customers");
        });

        modelBuilder.Entity<NotesTpaGroup>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.CustomerId });

            entity.ToTable("notes_tpa_groups");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.EndAt)
                .HasColumnType("datetime")
                .HasColumnName("end_at");
            entity.Property(e => e.EndBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("end_by");
            entity.Property(e => e.GroupEnd)
                .HasColumnType("datetime")
                .HasColumnName("group_end");
            entity.Property(e => e.GroupStart)
                .HasColumnType("datetime")
                .HasColumnName("group_start");
            entity.Property(e => e.StartAt)
                .HasColumnType("datetime")
                .HasColumnName("start_at");
            entity.Property(e => e.StartBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("start_by");

            entity.HasOne(d => d.Customer).WithMany(p => p.NotesTpaGroups)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_notes_tpa_groups_Customers");
        });

        modelBuilder.Entity<NotificationsSchedule>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("notifications_schedule");

            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.ImgUrl)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("imgUrl");
            entity.Property(e => e.Msg)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("msg");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("title");
        });

        modelBuilder.Entity<OldUser>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.UserLogon)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("user_logon");
            entity.Property(e => e.UserPwd)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("user_pwd");
        });

        modelBuilder.Entity<OnlineClient>(entity =>
        {
            entity.HasKey(e => e.ClientId);

            entity.ToTable("online_client");

            entity.Property(e => e.ClientId).HasColumnName("client_id");
            entity.Property(e => e.ClientName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("client_name");
            entity.Property(e => e.ConnectionString)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("connectionString");
        });

        modelBuilder.Entity<OnlineDiagnoseCategory>(entity =>
        {
            entity.ToTable("online_diagnose_category");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CatName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("cat_name");
        });

        modelBuilder.Entity<OnlineDiagnosis>(entity =>
        {
            entity.ToTable("online_diagnosis");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.CareItem).HasColumnName("care_item");
            entity.Property(e => e.Category).HasColumnName("category");
            entity.Property(e => e.Name)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Type).HasColumnName("type");

            entity.HasOne(d => d.CareItemNavigation).WithMany(p => p.OnlineDiagnoses)
                .HasForeignKey(d => d.CareItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_online_diagnosis_care_items");

            entity.HasOne(d => d.CategoryNavigation).WithMany(p => p.OnlineDiagnoses)
                .HasForeignKey(d => d.Category)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_online_diagnosis_online_diagnose_category");

            entity.HasMany(d => d.IdRmatrials).WithMany(p => p.IdDiagnoses)
                .UsingEntity<Dictionary<string, object>>(
                    "DiagnosisRowmaterial",
                    r => r.HasOne<OnlineRawMaterial>().WithMany()
                        .HasForeignKey("IdRmatrial")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_diagnosis_rowmaterials_online_raw_materials"),
                    l => l.HasOne<OnlineDiagnosis>().WithMany()
                        .HasForeignKey("IdDiagnosis")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_diagnosis_rowmaterials_online_diagnosis"),
                    j =>
                    {
                        j.HasKey("IdDiagnosis", "IdRmatrial");
                        j.ToTable("diagnosis_rowmaterials");
                        j.IndexerProperty<string>("IdDiagnosis")
                            .HasMaxLength(50)
                            .IsUnicode(false)
                            .HasColumnName("id_diagnosis");
                        j.IndexerProperty<int>("IdRmatrial").HasColumnName("id_rmatrial");
                    });

            entity.HasMany(d => d.Invs).WithMany(p => p.Dignoses)
                .UsingEntity<Dictionary<string, object>>(
                    "BatchDignose",
                    r => r.HasOne<BatchDetail>().WithMany()
                        .HasForeignKey("InvId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_batch_dignoses_Batch_details"),
                    l => l.HasOne<OnlineDiagnosis>().WithMany()
                        .HasForeignKey("DignoseId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_batch_dignoses_online_diagnosis"),
                    j =>
                    {
                        j.HasKey("DignoseId", "InvId");
                        j.ToTable("batch_dignoses");
                        j.IndexerProperty<string>("DignoseId")
                            .HasMaxLength(50)
                            .IsUnicode(false)
                            .HasColumnName("dignose_id");
                        j.IndexerProperty<long>("InvId").HasColumnName("inv_id");
                    });
        });

        modelBuilder.Entity<OnlineHome>(entity =>
        {
            entity.HasKey(e => e.AreaId);

            entity.ToTable("online_home");

            entity.Property(e => e.AreaId).HasColumnName("areaId");
            entity.Property(e => e.Context)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("context");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Header)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("header");
            entity.Property(e => e.Piriorty).HasColumnName("piriorty");
            entity.Property(e => e.Visable).HasColumnName("visable");
        });

        modelBuilder.Entity<OnlineItemCategory>(entity =>
        {
            entity.ToTable("online_Item_categories");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<OnlineLoginLog>(entity =>
        {
            entity.HasKey(e => e.SessionId);

            entity.ToTable("online_login_log");

            entity.Property(e => e.SessionId)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("session_id");
            entity.Property(e => e.BrowserInf)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("browser_inf");
            entity.Property(e => e.EndTime)
                .HasColumnType("datetime")
                .HasColumnName("end_time");
            entity.Property(e => e.Ip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ip");
            entity.Property(e => e.StartTime)
                .HasColumnType("datetime")
                .HasColumnName("start_time");
            entity.Property(e => e.UserId).HasColumnName("userId");
            entity.Property(e => e.UserName)
                .HasMaxLength(150)
                .IsFixedLength()
                .HasColumnName("userName");
        });

        modelBuilder.Entity<OnlineMedDiagnose>(entity =>
        {
            entity.HasKey(e => new { e.MedId, e.DiaId });

            entity.ToTable("online_med_diagnose", tb =>
                {
                    tb.HasTrigger("trigger_delete_online_med_diagnose");
                    tb.HasTrigger("trigger_insert_online_med_diagnose");
                });

            entity.Property(e => e.MedId).HasColumnName("med_id");
            entity.Property(e => e.DiaId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dia_id");
            entity.Property(e => e.LastUpdateByFrom)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("LAST_UPDATE_BY_FROM");
            entity.Property(e => e.LastUpdateDate).HasColumnName("LAST_UPDATE_DATE");

            entity.HasOne(d => d.Dia).WithMany(p => p.OnlineMedDiagnoses)
                .HasForeignKey(d => d.DiaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_online_med_diagnose_online_med_diagnose");

            entity.HasOne(d => d.Med).WithMany(p => p.OnlineMedDiagnoses)
                .HasForeignKey(d => d.MedId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_online_med_diagnose_acms_pharma");
        });

        modelBuilder.Entity<OnlineMessage>(entity =>
        {
            entity.HasKey(e => e.MessageId);

            entity.ToTable("online_messages");

            entity.Property(e => e.MessageId)
                .ValueGeneratedNever()
                .HasColumnName("messageId");
            entity.Property(e => e.CreationDate)
                .HasColumnType("datetime")
                .HasColumnName("creationDate");
            entity.Property(e => e.FromUserId).HasColumnName("fromUserId");
            entity.Property(e => e.MessageContentText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("messageContentText");
            entity.Property(e => e.MessageStatus).HasColumnName("messageStatus");
            entity.Property(e => e.MessageTitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("messageTitle");
            entity.Property(e => e.ToUserId).HasColumnName("toUserId");

            entity.HasOne(d => d.FromUser).WithMany(p => p.OnlineMessageFromUsers)
                .HasForeignKey(d => d.FromUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_online_messages_online_users");

            entity.HasOne(d => d.ToUser).WithMany(p => p.OnlineMessageToUsers)
                .HasForeignKey(d => d.ToUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_online_messages_online_users1");
        });

        modelBuilder.Entity<OnlineOneUnitForm>(entity =>
        {
            entity.ToTable("online_oneUnitForms");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Form)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("form");
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<OnlineRawMaterial>(entity =>
        {
            entity.ToTable("online_raw_materials");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.RawMaterial)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("raw_material");
            entity.Property(e => e.Type)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("type");
        });

        modelBuilder.Entity<OnlineServiceItem>(entity =>
        {
            entity.HasKey(e => e.ServiceId);

            entity.ToTable("online_Service_Items");

            entity.Property(e => e.ServiceId)
                .ValueGeneratedNever()
                .HasColumnName("serviceID");
            entity.Property(e => e.Abbreviation)
                .HasMaxLength(52)
                .IsUnicode(false);
            entity.Property(e => e.Availabilty)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NameAr)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NameEn)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ServiceType)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("serviceType");
        });

        modelBuilder.Entity<OnlineSetting>(entity =>
        {
            entity.HasKey(e => e.Item);

            entity.ToTable("Online_Settings");

            entity.Property(e => e.Item)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("item");
            entity.Property(e => e.Description)
                .HasMaxLength(350)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Text)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("text");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<OnlineSubmittedApproval>(entity =>
        {
            entity.HasKey(e => new { e.Vcode, e.Serial, e.ActId });

            entity.ToTable("online_submitted_approvals");

            entity.Property(e => e.Vcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vcode");
            entity.Property(e => e.Serial)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("serial");
            entity.Property(e => e.ActId)
                .HasColumnType("numeric(12, 0)")
                .HasColumnName("act_id");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Net).HasColumnName("net");
        });

        modelBuilder.Entity<OnlineUser>(entity =>
        {
            entity.ToTable("online_users", tb =>
                {
                    tb.HasTrigger("InsertOnlineUser");
                    tb.HasTrigger("UpdateOnlineUser");
                });

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.BirthOfDate).HasColumnName("birthOfDate");
            entity.Property(e => e.CountryId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("countryId");
            entity.Property(e => e.CreationDate).HasColumnName("creationDate");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("firstName");
            entity.Property(e => e.JoiningDate).HasColumnName("joiningDate");
            entity.Property(e => e.Lang)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("lang");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("lastName");
            entity.Property(e => e.Mobile)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("mobile");
            entity.Property(e => e.Office)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("office");
            entity.Property(e => e.Password)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("position");
            entity.Property(e => e.ProfilePicDocumentId).HasColumnName("profilePicDocumentId");
            entity.Property(e => e.Salary)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("salary");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Theme)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("theme");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("userName");
            entity.Property(e => e.VType)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("v_type");
            entity.Property(e => e.Vendor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor");
        });

        modelBuilder.Entity<OnlineUserClient>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.ClientId, e.IsDefault });

            entity.ToTable("online_user_client");

            entity.Property(e => e.UserId)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("user_id");
            entity.Property(e => e.ClientId).HasColumnName("client_id");
            entity.Property(e => e.IsDefault).HasColumnName("is_default");
            entity.Property(e => e.BranchId).HasColumnName("branch_id");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");

            entity.HasOne(d => d.Client).WithMany(p => p.OnlineUserClients)
                .HasForeignKey(d => d.ClientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_online_user_client_online_client");

            entity.HasOne(d => d.User).WithMany(p => p.OnlineUserClients)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_online_user_client_AspNetUsers");
        });

        modelBuilder.Entity<OutlookAttachment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Attachme__3214EC07F9F09DEF");

            entity.ToTable("Outlook_Attachments");

            entity.Property(e => e.FileName)
                .HasMaxLength(255)
                .HasColumnName("File_Name");
            entity.Property(e => e.OutlookEmailId).HasColumnName("Outlook_EmailId");

            entity.HasOne(d => d.OutlookEmail).WithMany(p => p.OutlookAttachments)
                .HasForeignKey(d => d.OutlookEmailId)
                .HasConstraintName("FK__Attachmen__Outlo__3648A49D");
        });

        modelBuilder.Entity<OutlookEmail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OutlookE__3214EC07F09955C7");

            entity.ToTable("OutlookEmail");

            entity.Property(e => e.ApprovalId).HasColumnName("approval_id");
            entity.Property(e => e.DateEmail)
                .HasColumnType("datetime")
                .HasColumnName("Date_Email");
            entity.Property(e => e.EmailCc)
                .HasMaxLength(250)
                .HasColumnName("Email_CC");
            entity.Property(e => e.EmailName).HasMaxLength(255);
            entity.Property(e => e.EntryId).HasColumnName("EntryID");
            entity.Property(e => e.Subject).HasMaxLength(255);
        });

        modelBuilder.Entity<PaymentChannel>(entity =>
        {
            entity.ToTable("payment_channels");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<PaymentType>(entity =>
        {
            entity.ToTable("payment_types");

            entity.Property(e => e.PaymentTypeId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("payment_type_id");
            entity.Property(e => e.PaymentType1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("payment_type");
        });

        modelBuilder.Entity<PaymentsLog>(entity =>
        {
            entity.ToTable("Payments_log");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Action).HasColumnName("action");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("last_update_from");
            entity.Property(e => e.NetFees).HasColumnName("net_fees");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.NumBatches).HasColumnName("num_batches");
            entity.Property(e => e.PaymentDate)
                .HasColumnType("datetime")
                .HasColumnName("payment_date");
            entity.Property(e => e.PaymentsId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("payments_id");
            entity.Property(e => e.VendorId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("vendor_id");

            entity.HasOne(d => d.ActionNavigation).WithMany(p => p.PaymentsLogs)
                .HasForeignKey(d => d.Action)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Payments_log_actions");
        });

        modelBuilder.Entity<PharmaTemp>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("pharma_temp");

            entity.Property(e => e.Code)
                .HasMaxLength(255)
                .HasColumnName("CODE");
            entity.Property(e => e.Category)
                .HasMaxLength(255)
                .HasColumnName("CATEGORY");
            entity.Property(e => e.DosageForm)
                .HasMaxLength(255)
                .HasColumnName("DOSAGE FORM");
            entity.Property(e => e.DrugName)
                .HasMaxLength(255)
                .HasColumnName("DRUG NAME");
            entity.Property(e => e.Genericname)
                .HasMaxLength(750)
                .HasColumnName("GENERICNAME");
            entity.Property(e => e.NoOfUnits).HasColumnName("NO# OF UNITS");
            entity.Property(e => e.Price).HasColumnName("PRICE");
            entity.Property(e => e.SmallUnit).HasColumnName("SMALL UNIT");
            entity.Property(e => e.UnitOfSale)
                .HasMaxLength(255)
                .HasColumnName("UNIT OF SALE");
        });

        modelBuilder.Entity<PlanItem>(entity =>
        {
            entity.HasKey(e => new { e.PlanId, e.ItemId });

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("trigger_delete_planitems");
                    tb.HasTrigger("trigger_insert_planitems");
                    tb.HasTrigger("trigger_update_planitems");
                });

            entity.Property(e => e.PlanId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("plan_id");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("last_update_from");
            entity.Property(e => e.MaxValue).HasColumnName("max_value");
            entity.Property(e => e.PlanItemCopaymentLevel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("plan_item_copayment_level");
            entity.Property(e => e.PlanItemCopaymentPaymentType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("plan_item_copayment_payment_type");
            entity.Property(e => e.PlanItemCopaymentValue).HasColumnName("plan_item_copayment_value");
            entity.Property(e => e.PlanItemMaxLevel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("plan_item_max_level");
            entity.Property(e => e.PlanItemMaxPaymentType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("plan_item_max_payment_type");
            entity.Property(e => e.PlanItemMaxPeriod).HasColumnName("plan_item_max_period");
            entity.Property(e => e.PlanItemMaxValue).HasColumnName("plan_item_max_value");
            entity.Property(e => e.PlanItemNotes)
                .HasMaxLength(256)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("plan_item_notes");
            entity.Property(e => e.PlanItemPoolId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("plan_item_pool_id");
            entity.Property(e => e.PlanItemPrimaryLevel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("plan_item_primary_level");
            entity.Property(e => e.PlanItemPrimaryPaymentType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("plan_item_primary_payment_type");
            entity.Property(e => e.PlanItemPrimaryPeriod).HasColumnName("plan_item_primary_period");
            entity.Property(e => e.PlanItemPrimaryValue).HasColumnName("plan_item_primary_value");
            entity.Property(e => e.ValidAfter).HasColumnName("valid_after");
            entity.Property(e => e.WithApproval).HasColumnName("with_approval");

            entity.HasOne(d => d.Item).WithMany(p => p.PlanItems)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PlanItems_care_items");

            entity.HasOne(d => d.Plan).WithMany(p => p.PlanItems)
                .HasForeignKey(d => d.PlanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PlanItems_CONTRACT_PLANS");

            entity.HasOne(d => d.PlanItemPool).WithMany(p => p.PlanItems)
                .HasForeignKey(d => d.PlanItemPoolId)
                .HasConstraintName("FK_PlanItems_Contract_Pools");

            entity.HasMany(d => d.Services).WithMany(p => p.PlanItems)
                .UsingEntity<Dictionary<string, object>>(
                    "PlanItemService",
                    r => r.HasOne<StandardService>().WithMany()
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_plan_item_services_StandardServices"),
                    l => l.HasOne<PlanItem>().WithMany()
                        .HasForeignKey("PlanId", "ItemId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_plan_item_services_PlanItems"),
                    j =>
                    {
                        j.HasKey("PlanId", "ItemId", "ServiceId");
                        j.ToTable("plan_item_services");
                        j.IndexerProperty<string>("PlanId")
                            .HasMaxLength(30)
                            .IsUnicode(false)
                            .HasColumnName("plan_id");
                        j.IndexerProperty<int>("ItemId").HasColumnName("item_id");
                        j.IndexerProperty<int>("ServiceId").HasColumnName("service_id");
                    });
        });

        modelBuilder.Entity<PlanItemDiagnosis>(entity =>
        {
            entity.HasKey(e => new { e.PlanId, e.ItemId, e.DiagnoseId });

            entity.ToTable("plan_item_diagnosis");

            entity.Property(e => e.PlanId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("plan_id");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.DiagnoseId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("diagnose_id");
            entity.Property(e => e.Enabled).HasColumnName("enabled");

            entity.HasOne(d => d.Diagnose).WithMany(p => p.PlanItemDiagnoses)
                .HasForeignKey(d => d.DiagnoseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_plan_item_diagnosis_online_diagnosis");

            entity.HasOne(d => d.PlanItem).WithMany(p => p.PlanItemDiagnoses)
                .HasForeignKey(d => new { d.PlanId, d.ItemId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_plan_item_diagnosis_PlanItems");
        });

        modelBuilder.Entity<PlanItemRule>(entity =>
        {
            entity.HasKey(e => new { e.PlanId, e.ItemId, e.RuleSerial });

            entity.ToTable("plan_item_rules");

            entity.Property(e => e.PlanId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("plan_id");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.RuleSerial).HasColumnName("rule_serial");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.PaymentType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("payment_type");
            entity.Property(e => e.RuleCycle).HasColumnName("rule_cycle");
            entity.Property(e => e.RuleLevel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("rule_level");
            entity.Property(e => e.RuleValue).HasColumnName("rule_value");

            entity.HasOne(d => d.PlanItem).WithMany(p => p.PlanItemRules)
                .HasForeignKey(d => new { d.PlanId, d.ItemId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_plan_item_rules_PlanItems");

            entity.HasMany(d => d.Diagnsoes).WithMany(p => p.PlanItemRules)
                .UsingEntity<Dictionary<string, object>>(
                    "ItemRuleDiagnosis",
                    r => r.HasOne<OnlineDiagnosis>().WithMany()
                        .HasForeignKey("DiagnsoeId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_item_rule_diagnosis_online_diagnosis"),
                    l => l.HasOne<PlanItemRule>().WithMany()
                        .HasForeignKey("PlanId", "ItemId", "RuleSerial")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_item_rule_diagnosis_plan_item_rules"),
                    j =>
                    {
                        j.HasKey("PlanId", "ItemId", "RuleSerial", "DiagnsoeId");
                        j.ToTable("item_rule_diagnosis");
                        j.IndexerProperty<string>("PlanId")
                            .HasMaxLength(30)
                            .IsUnicode(false)
                            .HasColumnName("plan_id");
                        j.IndexerProperty<int>("ItemId").HasColumnName("item_id");
                        j.IndexerProperty<int>("RuleSerial").HasColumnName("rule_serial");
                        j.IndexerProperty<string>("DiagnsoeId")
                            .HasMaxLength(50)
                            .IsUnicode(false)
                            .HasColumnName("diagnsoe_id");
                    });
        });

        modelBuilder.Entity<PrepareOnlinePatch>(entity =>
        {
            entity.ToTable("prepare_online_patch");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActId)
                .HasColumnType("numeric(12, 0)")
                .HasColumnName("act_id");
            entity.Property(e => e.MedItem).HasColumnName("med_item");
            entity.Property(e => e.Member)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("member");
            entity.Property(e => e.Rcode)
                .HasColumnType("numeric(12, 0)")
                .HasColumnName("rcode");
            entity.Property(e => e.Serial).HasColumnName("serial");
            entity.Property(e => e.UserName)
                .HasMaxLength(28)
                .IsUnicode(false)
                .HasColumnName("user_name");
        });

        modelBuilder.Entity<PrivilegeLog>(entity =>
        {
            entity.HasKey(e => e.LogId);

            entity.ToTable("Privilege_log");

            entity.Property(e => e.LogId).HasColumnName("log_id");
            entity.Property(e => e.ActionId).HasColumnName("action_id");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_from");
            entity.Property(e => e.LoggedUser)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("logged_user");
            entity.Property(e => e.Note)
                .IsUnicode(false)
                .HasColumnName("note");
            entity.Property(e => e.PrivilegeName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("privilege_name");
            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("updated_user");
        });

        modelBuilder.Entity<PromoCode>(entity =>
        {
            entity.ToTable("promo_codes");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.CreationDate)
                .HasColumnType("datetime")
                .HasColumnName("creation_date");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.MaxNo).HasColumnName("max_no");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("status");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Value).HasColumnName("value");

            entity.HasMany(d => d.Subscriptions).WithMany(p => p.Promos)
                .UsingEntity<Dictionary<string, object>>(
                    "AppliedPromo",
                    r => r.HasOne<UserPlan>().WithMany()
                        .HasForeignKey("SubscriptionId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_applied_promo_user_plans"),
                    l => l.HasOne<PromoCode>().WithMany()
                        .HasForeignKey("PromoId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_applied_promo_promo_codes"),
                    j =>
                    {
                        j.HasKey("PromoId", "SubscriptionId");
                        j.ToTable("applied_promo");
                        j.IndexerProperty<int>("PromoId").HasColumnName("promo_id");
                        j.IndexerProperty<int>("SubscriptionId").HasColumnName("subscription_id");
                    });
        });

        modelBuilder.Entity<ProviderLog>(entity =>
        {
            entity.ToTable("Provider_log");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Action).HasColumnName("action");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_from");
            entity.Property(e => e.Note)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("note");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Vendor_id");
        });

        modelBuilder.Entity<RequestAttached>(entity =>
        {
            entity.HasKey(e => e.AttachId);

            entity.ToTable("request_attached");

            entity.Property(e => e.AttachId).HasColumnName("attach_id");
            entity.Property(e => e.AttachApprovalId).HasColumnName("attach_approval_id");
            entity.Property(e => e.AttachName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("attach_name");
            entity.Property(e => e.AttachPath)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("attach_path");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
        });

        modelBuilder.Entity<Residence>(entity =>
        {
            entity.HasKey(e => e.ResidenceId).HasName("PK_EXAMINATION_1");

            entity.ToTable("Residence");

            entity.Property(e => e.ResidenceId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("residence_id");
            entity.Property(e => e.ResidenceName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("residence_name");
        });

        modelBuilder.Entity<RndView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("rndView");

            entity.Property(e => e.RndId)
                .HasMaxLength(31)
                .IsUnicode(false)
                .HasColumnName("rndId");
        });

        modelBuilder.Entity<SchApproval>(entity =>
        {
            entity.HasKey(e => e.TempId).HasName("PK_sch_approvals_1");

            entity.ToTable("sch_approvals");

            entity.Property(e => e.TempId).HasColumnName("temp_id");
            entity.Property(e => e.FormId)
                .HasMaxLength(22)
                .IsUnicode(false)
                .HasColumnName("form_id");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("last_update_from");
            entity.Property(e => e.MaxValue).HasColumnName("max_value");
            entity.Property(e => e.MemberId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("member_id");
            entity.Property(e => e.Notes)
                .HasMaxLength(700)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.PlanCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("plan_code");
            entity.Property(e => e.PrivateNotes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("private_notes");

            entity.HasOne(d => d.Member).WithMany(p => p.SchApprovals)
                .HasForeignKey(d => d.MemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sch_approvals_Members");

            entity.HasOne(d => d.PlanCodeNavigation).WithMany(p => p.SchApprovals)
                .HasForeignKey(d => d.PlanCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sch_approvals_Contract_Plans");

            entity.HasMany(d => d.Diagnoses).WithMany(p => p.Temps)
                .UsingEntity<Dictionary<string, object>>(
                    "SchApprovalDiagnose",
                    r => r.HasOne<OnlineDiagnosis>().WithMany()
                        .HasForeignKey("DiagnoseId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_sch_approval_diagnose_online_diagnosis"),
                    l => l.HasOne<SchApproval>().WithMany()
                        .HasForeignKey("TempId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_sch_approval_diagnose_sch_approvals"),
                    j =>
                    {
                        j.HasKey("TempId", "DiagnoseId");
                        j.ToTable("sch_approval_diagnose");
                        j.IndexerProperty<long>("TempId").HasColumnName("temp_id");
                        j.IndexerProperty<string>("DiagnoseId")
                            .HasMaxLength(50)
                            .IsUnicode(false)
                            .HasColumnName("diagnose_id");
                    });
        });

        modelBuilder.Entity<SchApprovalService>(entity =>
        {
            entity.HasKey(e => new { e.TempId, e.ItemSerial }).HasName("PK_sch_approval_services_1");

            entity.ToTable("sch_approval_services");

            entity.Property(e => e.TempId).HasColumnName("temp_id");
            entity.Property(e => e.ItemSerial).HasColumnName("item_serial");
            entity.Property(e => e.Coinsurance).HasColumnName("coinsurance");
            entity.Property(e => e.DoseDuration).HasColumnName("dose_duration");
            entity.Property(e => e.DoseRepeat).HasColumnName("dose_repeat");
            entity.Property(e => e.DoseUnits).HasColumnName("dose_units");
            entity.Property(e => e.ItemRepeat).HasColumnName("item_repeat");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("last_update_from");
            entity.Property(e => e.MedItem).HasColumnName("med_item");
            entity.Property(e => e.Notes)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.Qty).HasColumnName("qty");
            entity.Property(e => e.ServiceId).HasColumnName("service_id");

            entity.HasOne(d => d.MedItemNavigation).WithMany(p => p.SchApprovalServices)
                .HasForeignKey(d => d.MedItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sch_approval_services_care_items");

            entity.HasOne(d => d.Service).WithMany(p => p.SchApprovalServices)
                .HasForeignKey(d => d.ServiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sch_approval_services_acms_pharma");

            entity.HasOne(d => d.Temp).WithMany(p => p.SchApprovalServices)
                .HasForeignKey(d => d.TempId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sch_approval_services_sch_approvals");
        });

        modelBuilder.Entity<SchApprovalServicesLog>(entity =>
        {
            entity.ToTable("sch_approval_services_log");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LAST_UPDATE_BY");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATE_DATE");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LAST_UPDATE_FROM");
        });

        modelBuilder.Entity<SchApprovalsArchive>(entity =>
        {
            entity.ToTable("sch_approvals_archive");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Path)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("path");
            entity.Property(e => e.TempId).HasColumnName("temp_id");

            entity.HasOne(d => d.Temp).WithMany(p => p.SchApprovalsArchives)
                .HasForeignKey(d => d.TempId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sch_approvals_archive_sch_approvals");
        });

        modelBuilder.Entity<SchApprovalsLog>(entity =>
        {
            entity.ToTable("sch_approvals_log");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Action).HasColumnName("action");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("last_update_from");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.NumServices).HasColumnName("num_services");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.PrivateNotes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("private_notes");
            entity.Property(e => e.TempId).HasColumnName("temp_id");

            entity.HasOne(d => d.ActionNavigation).WithMany(p => p.SchApprovalsLogs)
                .HasForeignKey(d => d.Action)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sch_approvals_log_actions");

            entity.HasOne(d => d.Temp).WithMany(p => p.SchApprovalsLogs)
                .HasForeignKey(d => d.TempId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sch_approvals_log_sch_approvals");
        });

        modelBuilder.Entity<SchCustomerArchive>(entity =>
        {
            entity.ToTable("sch_customer_archive");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Path)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("path");

            entity.HasOne(d => d.Customer).WithMany(p => p.SchCustomerArchives)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sch_customer_archive_Customers");
        });

        modelBuilder.Entity<SourceQuery>(entity =>
        {
            entity.HasKey(e => e.SourceId);

            entity.ToTable("Source_query");

            entity.Property(e => e.SourceId).HasColumnName("source_id");
            entity.Property(e => e.SourceName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("source_name");
        });

        modelBuilder.Entity<StandardService>(entity =>
        {
            entity.HasKey(e => e.StandServiceCode);

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("InsertStandService");
                    tb.HasTrigger("UpdateStandService");
                });

            entity.Property(e => e.StandServiceCode).HasColumnName("stand_service_code");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("last_update_from");
            entity.Property(e => e.StandServiceAvailability)
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("stand_service_availability");
            entity.Property(e => e.StandServiceFlag).HasColumnName("stand_service_flag");
            entity.Property(e => e.StandServiceName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("stand_service_name");
            entity.Property(e => e.StandServiceNameAr)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("stand_service_name_ar");
            entity.Property(e => e.StandServiceParent).HasColumnName("stand_service_parent");
            entity.Property(e => e.StandServiceVendorCategoryId).HasColumnName("stand_service_vendor_category_id");

            entity.HasOne(d => d.StandServiceParentNavigation).WithMany(p => p.InverseStandServiceParentNavigation)
                .HasForeignKey(d => d.StandServiceParent)
                .HasConstraintName("FK_StandardServices_StandardServices");

            entity.HasOne(d => d.StandServiceVendorCategory).WithMany(p => p.StandardServices)
                .HasForeignKey(d => d.StandServiceVendorCategoryId)
                .HasConstraintName("FK_StandardServices_vendor_category");
        });

        modelBuilder.Entity<StateRef>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("state_ref");

            entity.Property(e => e.Code)
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("code");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("name");
            entity.Property(e => e.NameE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("name_e");
        });

        modelBuilder.Entity<SubscriptionPlan>(entity =>
        {
            entity.ToTable("subscription_plans");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreationDate)
                .HasColumnType("datetime")
                .HasColumnName("creation_date");
            entity.Property(e => e.Followers).HasColumnName("followers");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.Months).HasColumnName("months");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("status");
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<SudanCustomer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SudanCustomers");

            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
        });

        modelBuilder.Entity<SysSetting>(entity =>
        {
            entity.ToTable("sys_settings");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("description");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(30)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("name");
            entity.Property(e => e.ValInt).HasColumnName("val_int");
            entity.Property(e => e.ValSrt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("val_srt");
        });

        modelBuilder.Entity<Tag>(entity =>
        {
            entity.HasKey(e => e.TagId).HasName("PK__tags__4296A2B69BED253A");

            entity.ToTable("tags");

            entity.Property(e => e.TagId).HasColumnName("tag_id");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("last_update_from");
            entity.Property(e => e.TagText)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("tag_text");
        });

        modelBuilder.Entity<TaxPolicy>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Value });

            entity.ToTable("tax_policies");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Value).HasColumnName("value");
            entity.Property(e => e.ExpireDate).HasColumnName("expire_date");
        });

        modelBuilder.Entity<Ticket>(entity =>
        {
            entity.Property(e => e.AssignedTo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Assigned_to");
            entity.Property(e => e.ClientId).HasColumnName("Client_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.Department)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.DueTime)
                .HasColumnType("datetime")
                .HasColumnName("Due_time");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.MenuId).HasColumnName("menu_id");
            entity.Property(e => e.NeedApproval).HasColumnName("need_approval");
            entity.Property(e => e.Priority)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RequestNote)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("request_note");
            entity.Property(e => e.RequestStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("request_status");
            entity.Property(e => e.RequestType).HasColumnName("request_type");
            entity.Property(e => e.StimatedTime).HasColumnName("stimated_time");
            entity.Property(e => e.StimatedValue)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("stimated_value");

            entity.HasOne(d => d.Client).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.ClientId)
                .HasConstraintName("FK_Tickets_Clients");

            entity.HasOne(d => d.DepartmentNavigation).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.Department)
                .HasConstraintName("FK_Tickets_AspNetUsers");
        });

        modelBuilder.Entity<TicketsReply>(entity =>
        {
            entity.HasKey(e => e.ReplyId);

            entity.ToTable("TicketsReply");

            entity.Property(e => e.ReplyId).HasColumnName("Reply_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.DueTime)
                .HasColumnType("datetime")
                .HasColumnName("Due_time");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_from");
            entity.Property(e => e.NeedApproval).HasColumnName("need_approval");
            entity.Property(e => e.Priority)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReplyClientId).HasColumnName("reply_client_id");
            entity.Property(e => e.ReplyNote)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("reply_note");
            entity.Property(e => e.RequestStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("request_status");
            entity.Property(e => e.TicketId).HasColumnName("ticket_id");

            entity.HasOne(d => d.ReplyClient).WithMany(p => p.TicketsReplies)
                .HasForeignKey(d => d.ReplyClientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TicketsReply_Clients");

            entity.HasOne(d => d.Ticket).WithMany(p => p.TicketsReplies)
                .HasForeignKey(d => d.TicketId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TicketsReply_Tickets");
        });

        modelBuilder.Entity<TpaMapMeditem>(entity =>
        {
            entity.HasKey(e => new { e.Insurer, e.Item });

            entity.ToTable("tpa_map_meditems");

            entity.Property(e => e.Insurer).HasColumnName("insurer");
            entity.Property(e => e.Item).HasColumnName("item");
            entity.Property(e => e.DefaultCat).HasColumnName("default_cat");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<TpaMappedMeditem>(entity =>
        {
            entity.HasKey(e => new { e.ContractCode, e.MedItem });

            entity.ToTable("tpa_mapped_meditems");

            entity.Property(e => e.ContractCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("contract_code");
            entity.Property(e => e.MedItem).HasColumnName("med_item");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.TpaMedItem).HasColumnName("tpa_med_item");

            entity.HasOne(d => d.TpaMapMeditem).WithMany(p => p.TpaMappedMeditems)
                .HasForeignKey(d => new { d.CustomerId, d.TpaMedItem })
                .HasConstraintName("FK_tpa_mapped_meditems_tpa_map_meditems");
        });

        modelBuilder.Entity<UpdatedNews>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Updated___3214EC0729FF6D9E");

            entity.ToTable("Updated_News");

            entity.Property(e => e.CreationDate)
                .HasColumnType("datetime")
                .HasColumnName("creation_date");
            entity.Property(e => e.ExpireDate)
                .HasColumnType("datetime")
                .HasColumnName("expire_date");
            entity.Property(e => e.FilePath)
                .IsUnicode(false)
                .HasColumnName("File_Path");
            entity.Property(e => e.Image).HasColumnName("image");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_from");
        });

        modelBuilder.Entity<UpdatedNewsAspNetUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UpdatedN__3214EC0748A02232");

            entity.Property(e => e.DepartmentId)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.NewsId).HasColumnName("news_id");

            entity.HasOne(d => d.Department).WithMany(p => p.UpdatedNewsAspNetUsers)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UpdatedNe__Depar__3F12F4C8");

            entity.HasOne(d => d.News).WithMany(p => p.UpdatedNewsAspNetUsers)
                .HasForeignKey(d => d.NewsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UpdatedNe__news___3E1ED08F");
        });

        modelBuilder.Entity<UserAdditionalDatum>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK_user_additional_data_1");

            entity.ToTable("user_additional_data");

            entity.Property(e => e.UserId)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("user_id");
            entity.Property(e => e.ChartAccountId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("chart_account_id");

            entity.HasOne(d => d.User).WithOne(p => p.UserAdditionalDatum)
                .HasForeignKey<UserAdditionalDatum>(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_user_additional_data_AspNetUsers");
        });

        modelBuilder.Entity<UserCustomer>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.CustomerId, e.RoleId });

            entity.ToTable("user_customers");

            entity.Property(e => e.UserId)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("userId");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.RoleId)
                .HasMaxLength(128)
                .HasColumnName("roleId");

            entity.HasOne(d => d.Customer).WithMany(p => p.UserCustomers)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_user_customers_Customers");

            entity.HasOne(d => d.Role).WithMany(p => p.UserCustomers)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_user_customers_AspNetRoles");

            entity.HasOne(d => d.User).WithMany(p => p.UserCustomers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_user_customers_AspNetUsers");
        });

        modelBuilder.Entity<UserLog>(entity =>
        {
            entity.ToTable("User_log");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Action).HasColumnName("action");
            entity.Property(e => e.EnteredDate)
                .HasColumnType("datetime")
                .HasColumnName("entered_date");
            entity.Property(e => e.EnteredFrom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("entered_from");
            entity.Property(e => e.LastLoginDate)
                .HasColumnType("datetime")
                .HasColumnName("last_login_date");
            entity.Property(e => e.Note)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("note");
            entity.Property(e => e.UserGroup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("user_group");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("user_name");
        });

        modelBuilder.Entity<UserNotification>(entity =>
        {
            entity.HasKey(e => new { e.NoteId, e.UserId });

            entity.ToTable("user_notifications");

            entity.Property(e => e.NoteId).HasColumnName("note_id");
            entity.Property(e => e.UserId)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("user_id");
            entity.Property(e => e.SeenAt)
                .HasColumnType("datetime")
                .HasColumnName("seen_at");

            entity.HasOne(d => d.Note).WithMany(p => p.UserNotifications)
                .HasForeignKey(d => d.NoteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_user_notifications_acms_notifications");

            entity.HasOne(d => d.User).WithMany(p => p.UserNotifications)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_user_notifications_AspNetUsers");
        });

        modelBuilder.Entity<UserPlan>(entity =>
        {
            entity.ToTable("user_plans");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreationDate)
                .HasColumnType("datetime")
                .HasColumnName("creation_date");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.PaidValue).HasColumnName("paid_value");
            entity.Property(e => e.PaymentId)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("payment_id");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("payment_method");
            entity.Property(e => e.PlanId).HasColumnName("plan_id");
            entity.Property(e => e.SubDate)
                .HasColumnType("datetime")
                .HasColumnName("sub_date");
            entity.Property(e => e.SubEnabled).HasColumnName("sub_enabled");
            entity.Property(e => e.UserId)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("user_id");
            entity.Property(e => e.ValidFrom)
                .HasColumnType("datetime")
                .HasColumnName("valid_from");
            entity.Property(e => e.ValidTo)
                .HasColumnType("datetime")
                .HasColumnName("valid_to");

            entity.HasOne(d => d.Plan).WithMany(p => p.UserPlans)
                .HasForeignKey(d => d.PlanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_user_plans_subscription_plans");

            entity.HasOne(d => d.User).WithMany(p => p.UserPlans)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_user_plans_AspNetUsers");
        });

        modelBuilder.Entity<UserReportColumn>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.ReportId, e.ColumnName });

            entity.ToTable("User_Report_Column");

            entity.Property(e => e.UserId)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.ColumnName).HasMaxLength(250);

            entity.HasOne(d => d.Report).WithMany(p => p.UserReportColumns)
                .HasForeignKey(d => d.ReportId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_User_Report_Column_ACC_Report");

            entity.HasOne(d => d.User).WithMany(p => p.UserReportColumns)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_User_Report_Column_AspNetUsers");
        });

        modelBuilder.Entity<UserVerification>(entity =>
        {
            entity.HasKey(e => new { e.UserCode, e.VerifyCode }).HasName("PK_user_verifications_1");

            entity.ToTable("user_verifications");

            entity.Property(e => e.UserCode)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("user_code");
            entity.Property(e => e.VerifyCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("verify_code");
            entity.Property(e => e.ExpireDate)
                .HasColumnType("datetime")
                .HasColumnName("expire_date");
            entity.Property(e => e.Type).HasColumnName("type");

            entity.HasOne(d => d.UserCodeNavigation).WithMany(p => p.UserVerifications)
                .HasForeignKey(d => d.UserCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_user_verifications_user_verifications");
        });

        modelBuilder.Entity<UserWarehouse>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.WarehouseId }).HasName("PK_user_stock");

            entity.ToTable("user_warehouse");

            entity.Property(e => e.UserId)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("user_id");
            entity.Property(e => e.WarehouseId).HasColumnName("warehouse_id");
            entity.Property(e => e.Export).HasColumnName("export");
            entity.Property(e => e.Import).HasColumnName("import");
            entity.Property(e => e.Show).HasColumnName("show");

            entity.HasOne(d => d.User).WithMany(p => p.UserWarehouses)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_user_stock_AspNetUsers");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.UserWarehouses)
                .HasForeignKey(d => d.WarehouseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_user_stock_acms_stocks");
        });

        modelBuilder.Entity<VAccBank>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_acc_banks");

            entity.Property(e => e.SafeBankSerial).HasColumnName("SAFE_BANK_SERIAL");
            entity.Property(e => e.SbName)
                .HasMaxLength(250)
                .HasColumnName("SB_name");
            entity.Property(e => e.SbType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("sb_type");
        });

        modelBuilder.Entity<VAccInvoiceCollection>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_acc_invoice_collections");

            entity.Property(e => e.AdjDate)
                .HasColumnType("datetime")
                .HasColumnName("ADJ_DATE");
            entity.Property(e => e.AdjNo)
                .HasColumnType("numeric(12, 0)")
                .HasColumnName("ADJ_NO");
            entity.Property(e => e.AmeelNo)
                .HasMaxLength(20)
                .HasColumnName("ameel_no");
            entity.Property(e => e.CashDiscount)
                .HasColumnType("numeric(12, 3)")
                .HasColumnName("CASH_DISCOUNT");
            entity.Property(e => e.DedTaxes)
                .HasColumnType("numeric(12, 3)")
                .HasColumnName("ded_taxes");
            entity.Property(e => e.DocDestName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("doc_dest_name");
            entity.Property(e => e.DocNo1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("doc_no1");
            entity.Property(e => e.InvoiceNumber)
                .HasColumnType("numeric(12, 0)")
                .HasColumnName("INVOICE_NUMBER");
            entity.Property(e => e.Notes)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.PaidValue)
                .HasColumnType("numeric(20, 3)")
                .HasColumnName("PAID_VALUE");
            entity.Property(e => e.Source)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("source");
        });

        modelBuilder.Entity<VAccVendorOperation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_acc_vendor_operations");

            entity.Property(e => e.Credit).HasColumnName("credit");
            entity.Property(e => e.Debit).HasColumnName("debit");
            entity.Property(e => e.OppeningBalance).HasColumnName("oppening_balance");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");
            entity.Property(e => e.VendorName)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("vendor_name");
        });

        modelBuilder.Entity<VAgentsPerformance>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_agents_performance");

            entity.Property(e => e.Agent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("agent");
            entity.Property(e => e.T1).HasColumnName("t1");
            entity.Property(e => e.T2).HasColumnName("t2");
            entity.Property(e => e.T3).HasColumnName("t3");
        });

        modelBuilder.Entity<VAllBatchDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_all_Batch_details");

            entity.Property(e => e.ActivitySerial).HasColumnName("activity_serial");
            entity.Property(e => e.ApprovalNumber).HasColumnName("Approval_number");
            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("batch_id");
            entity.Property(e => e.BatchNumber).HasColumnName("batch_number");
            entity.Property(e => e.CoPayment).HasColumnName("co_payment");
            entity.Property(e => e.ContractActivity)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("contract_activity");
            entity.Property(e => e.ContractCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("contract_code");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("customer_name");
            entity.Property(e => e.DisNote)
                .HasMaxLength(350)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("dis_note");
            entity.Property(e => e.DisReason)
                .IsUnicode(false)
                .HasColumnName("dis_reason");
            entity.Property(e => e.FinRevised).HasColumnName("fin_revised");
            entity.Property(e => e.HasDoc).HasColumnName("has_doc");
            entity.Property(e => e.ImportDis).HasColumnName("import_dis");
            entity.Property(e => e.InsuranceMedItem).HasColumnName("insurance_med_item");
            entity.Property(e => e.Insurer).HasColumnName("insurer");
            entity.Property(e => e.InvId).HasColumnName("inv_id");
            entity.Property(e => e.InvNum).HasColumnName("inv_num");
            entity.Property(e => e.IsActualCost)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("is_actual_cost");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LocalDis).HasColumnName("local_dis");
            entity.Property(e => e.MedItem).HasColumnName("med_item");
            entity.Property(e => e.MedRevNote)
                .HasMaxLength(350)
                .IsUnicode(false)
                .HasColumnName("med_rev_note");
            entity.Property(e => e.MedRevised).HasColumnName("med_revised");
            entity.Property(e => e.MemberCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("member_code");
            entity.Property(e => e.MemberName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("member_name");
            entity.Property(e => e.Note)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("note");
            entity.Property(e => e.Notified).HasColumnName("notified");
            entity.Property(e => e.Num).HasColumnName("num");
            entity.Property(e => e.OldServid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("old_servid");
            entity.Property(e => e.RevDis).HasColumnName("Rev_dis");
            entity.Property(e => e.Serial).HasColumnName("serial");
            entity.Property(e => e.ServiceCode).HasColumnName("service_code");
            entity.Property(e => e.ServiceDate).HasColumnName("service_date");
            entity.Property(e => e.Tax).HasColumnName("tax");
            entity.Property(e => e.Value).HasColumnName("value");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");
        });

        modelBuilder.Entity<VAllBillOldDb>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_all_bill_old_db");

            entity.Property(e => e.BillCat)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Bill_Cat");
            entity.Property(e => e.BillDate)
                .HasColumnType("datetime")
                .HasColumnName("BILL_DATE");
            entity.Property(e => e.BillId)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("BILL_ID");
            entity.Property(e => e.BillStatus).HasColumnName("BILL_STATUS");
            entity.Property(e => e.ContractId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("contract_id");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("customer_id");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.SaEmpid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SA_EMPID");
            entity.Property(e => e.SaRcode)
                .HasColumnType("numeric(16, 0)")
                .HasColumnName("SA_RCODE");
            entity.Property(e => e.SaSerial).HasColumnName("SA_SERIAL");
            entity.Property(e => e.SrvCode)
                .HasMaxLength(18)
                .IsUnicode(false)
                .HasColumnName("srv_code");
        });

        modelBuilder.Entity<VAllDue>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_All_Dues");

            entity.Property(e => e.Area)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BatchCost).HasColumnName("batch_cost");
            entity.Property(e => e.BatchFinancialFlag).HasColumnName("batch_financial_flag");
            entity.Property(e => e.BatchMedicalFlag).HasColumnName("batch_medical_flag");
            entity.Property(e => e.BatchReceivedDate).HasColumnName("batch_received_date");
            entity.Property(e => e.BatchStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("batch_status");
            entity.Property(e => e.BatchVendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("batch_vendor_id");
            entity.Property(e => e.Batchid)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("batchid");
            entity.Property(e => e.ChequeName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("cheque_name");
            entity.Property(e => e.Gov)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.InvNumbers).HasColumnName("inv_numbers");
            entity.Property(e => e.LocDiscount).HasColumnName("loc_discount");
            entity.Property(e => e.MedDiscount).HasColumnName("med_discount");
            entity.Property(e => e.Paid).HasColumnType("numeric(12, 3)");
            entity.Property(e => e.VendorContractAdministrativeDiscount).HasColumnName("vendor_contract_administrative_discount");
            entity.Property(e => e.VendorName)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("vendor_name");
            entity.Property(e => e.XtraNote)
                .HasMaxLength(350)
                .IsUnicode(false)
                .HasColumnName("xtra_note");
            entity.Property(e => e.XtraValue).HasColumnName("xtra_value");
        });

        modelBuilder.Entity<VAllDues2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_All_Dues2");

            entity.Property(e => e.Area)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BatchCost).HasColumnName("batch_cost");
            entity.Property(e => e.BatchFinancialFlag).HasColumnName("batch_financial_flag");
            entity.Property(e => e.BatchMedicalFlag).HasColumnName("batch_medical_flag");
            entity.Property(e => e.BatchReceivedDate).HasColumnName("batch_received_date");
            entity.Property(e => e.BatchStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("batch_status");
            entity.Property(e => e.BatchVendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("batch_vendor_id");
            entity.Property(e => e.Batchid)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("batchid");
            entity.Property(e => e.ChequeName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("cheque_name");
            entity.Property(e => e.Gov)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.InvNumbers).HasColumnName("inv_numbers");
            entity.Property(e => e.LocDiscount).HasColumnName("loc_discount");
            entity.Property(e => e.MedDiscount).HasColumnName("med_discount");
            entity.Property(e => e.Paid).HasColumnType("numeric(12, 3)");
            entity.Property(e => e.Tax).HasColumnType("numeric(12, 3)");
            entity.Property(e => e.VendorContractAdministrativeDiscount).HasColumnName("vendor_contract_administrative_discount");
            entity.Property(e => e.VendorName)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("vendor_name");
            entity.Property(e => e.XtraNote)
                .HasMaxLength(350)
                .IsUnicode(false)
                .HasColumnName("xtra_note");
            entity.Property(e => e.XtraValue).HasColumnName("xtra_value");
        });

        modelBuilder.Entity<VAllDues3>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_All_Dues3");

            entity.Property(e => e.Area)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("bank_name");
            entity.Property(e => e.BatchCost).HasColumnName("batch_cost");
            entity.Property(e => e.BatchFinancialFlag).HasColumnName("batch_financial_flag");
            entity.Property(e => e.BatchMedicalFlag).HasColumnName("batch_medical_flag");
            entity.Property(e => e.BatchNumber).HasColumnName("batch_number");
            entity.Property(e => e.BatchReceivedDate).HasColumnName("batch_received_date");
            entity.Property(e => e.BatchStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("batch_status");
            entity.Property(e => e.BatchVendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("batch_vendor_id");
            entity.Property(e => e.Batchid)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("batchid");
            entity.Property(e => e.ChequeName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("cheque_name");
            entity.Property(e => e.DueDate).HasColumnName("due_date");
            entity.Property(e => e.Gov)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.InvNumbers).HasColumnName("inv_numbers");
            entity.Property(e => e.LocDiscount).HasColumnName("loc_discount");
            entity.Property(e => e.MedDiscount).HasColumnName("med_discount");
            entity.Property(e => e.Paid).HasColumnType("numeric(38, 2)");
            entity.Property(e => e.ReceivedCost).HasColumnName("received_cost");
            entity.Property(e => e.Tax).HasColumnType("numeric(12, 3)");
            entity.Property(e => e.VendorBankAccountNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("vendor_bank_account_number");
            entity.Property(e => e.VendorCheckBeneficiary)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("vendor_check_beneficiary");
            entity.Property(e => e.VendorContractAdministrativeDiscount).HasColumnName("vendor_contract_administrative_discount");
            entity.Property(e => e.VendorName)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("vendor_name");
            entity.Property(e => e.VendorPayPeriod).HasColumnName("vendor_pay_period");
            entity.Property(e => e.XtraNote)
                .HasMaxLength(350)
                .IsUnicode(false)
                .HasColumnName("xtra_note");
            entity.Property(e => e.XtraValue).HasColumnName("xtra_value");
        });

        modelBuilder.Entity<VAllVBatchDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_all_v_Batch_details");

            entity.Property(e => e.ActivitySerial).HasColumnName("activity_serial");
            entity.Property(e => e.ApprovalNumber).HasColumnName("Approval_number");
            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("batch_id");
            entity.Property(e => e.BatchNumber).HasColumnName("batch_number");
            entity.Property(e => e.CoPayment).HasColumnName("co_payment");
            entity.Property(e => e.ContractActivity)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("contract_activity");
            entity.Property(e => e.ContractCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("contract_code");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("customer_name");
            entity.Property(e => e.DisNote)
                .HasMaxLength(350)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("dis_note");
            entity.Property(e => e.DisReason)
                .IsUnicode(false)
                .HasColumnName("dis_reason");
            entity.Property(e => e.FinRevised).HasColumnName("fin_revised");
            entity.Property(e => e.HasDoc).HasColumnName("has_doc");
            entity.Property(e => e.ImportDis).HasColumnName("import_dis");
            entity.Property(e => e.InsuranceMedItem).HasColumnName("insurance_med_item");
            entity.Property(e => e.Insurer).HasColumnName("insurer");
            entity.Property(e => e.InvId).HasColumnName("inv_id");
            entity.Property(e => e.InvNum).HasColumnName("inv_num");
            entity.Property(e => e.IsActualCost)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("is_actual_cost");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LocalDis).HasColumnName("local_dis");
            entity.Property(e => e.MedItem).HasColumnName("med_item");
            entity.Property(e => e.MedRevNote)
                .HasMaxLength(350)
                .IsUnicode(false)
                .HasColumnName("med_rev_note");
            entity.Property(e => e.MedRevised).HasColumnName("med_revised");
            entity.Property(e => e.MemberCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("member_code");
            entity.Property(e => e.MemberName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("member_name");
            entity.Property(e => e.Note)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("note");
            entity.Property(e => e.Notified).HasColumnName("notified");
            entity.Property(e => e.Num).HasColumnName("num");
            entity.Property(e => e.OldServid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("old_servid");
            entity.Property(e => e.RevDis).HasColumnName("Rev_dis");
            entity.Property(e => e.Serial).HasColumnName("serial");
            entity.Property(e => e.ServiceCode).HasColumnName("service_code");
            entity.Property(e => e.ServiceDate).HasColumnName("service_date");
            entity.Property(e => e.Tax).HasColumnName("tax");
            entity.Property(e => e.Value).HasColumnName("value");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");
        });

        modelBuilder.Entity<VApprovalsDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_approvals_data");

            entity.Property(e => e.ApQty).HasColumnName("ap_qty");
            entity.Property(e => e.ApStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("ap_status");
            entity.Property(e => e.ApType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("ap_type");
            entity.Property(e => e.ApprovalDate)
                .HasColumnType("datetime")
                .HasColumnName("approval_date");
            entity.Property(e => e.ApprovalId).HasColumnName("approval_id");
            entity.Property(e => e.ApprovalValue).HasColumnName("approval_value");
            entity.Property(e => e.Coinsurance).HasColumnName("coinsurance");
            entity.Property(e => e.ContractId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("contract_id");
            entity.Property(e => e.Currentip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("currentip");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("customer_name");
            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.DoseDurType).HasColumnName("dose_dur_type");
            entity.Property(e => e.DoseDuration).HasColumnName("dose_duration");
            entity.Property(e => e.DoseRepeat).HasColumnName("dose_repeat");
            entity.Property(e => e.DoseUnits).HasColumnName("dose_units");
            entity.Property(e => e.Editqty).HasColumnName("editqty");
            entity.Property(e => e.FormDate).HasColumnName("form_date");
            entity.Property(e => e.FormId)
                .HasMaxLength(22)
                .IsUnicode(false)
                .HasColumnName("form_id");
            entity.Property(e => e.InsurerMeditem).HasColumnName("insurer_meditem");
            entity.Property(e => e.IsChronic).HasColumnName("is_chronic");
            entity.Property(e => e.IsOnline)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("is_online");
            entity.Property(e => e.Isnotified).HasColumnName("isnotified");
            entity.Property(e => e.ItemDesc)
                .HasMaxLength(200)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("item_desc");
            entity.Property(e => e.ItemRepeat).HasColumnName("item_repeat");
            entity.Property(e => e.ItemSerial).HasColumnName("item_serial");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("last_update_from");
            entity.Property(e => e.MainApproval).HasColumnName("main_approval");
            entity.Property(e => e.MaxValue).HasColumnName("max_value");
            entity.Property(e => e.MedItem).HasColumnName("med_item");
            entity.Property(e => e.MemberCustomer).HasColumnName("member_customer");
            entity.Property(e => e.MemberEip).HasColumnName("member_eip");
            entity.Property(e => e.MemberId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("member_id");
            entity.Property(e => e.MemberName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("member_name");
            entity.Property(e => e.MemberVip).HasColumnName("member_vip");
            entity.Property(e => e.MinUnits).HasColumnName("min_units");
            entity.Property(e => e.Notes)
                .HasMaxLength(700)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.OnlineBCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("online_b_code");
            entity.Property(e => e.OnlineLud)
                .HasColumnType("datetime")
                .HasColumnName("online_lud");
            entity.Property(e => e.OnlineStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("online_status");
            entity.Property(e => e.OnlineUser)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("online_user");
            entity.Property(e => e.OriginalPrice).HasColumnName("original_price");
            entity.Property(e => e.ParentApproval).HasColumnName("parent_approval");
            entity.Property(e => e.ParentCustomerName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("parent_customer_name");
            entity.Property(e => e.ParnetCustomer).HasColumnName("parnet_customer");
            entity.Property(e => e.PlanCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("plan_code");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.PrivateNotes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("private_notes");
            entity.Property(e => e.Qty).HasColumnName("qty");
            entity.Property(e => e.RequestSource)
                .HasMaxLength(16)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("request_source");
            entity.Property(e => e.ServiceCoinsurance).HasColumnName("service_coinsurance");
            entity.Property(e => e.ServiceId).HasColumnName("service_id");
            entity.Property(e => e.ServiceNotes)
                .HasMaxLength(80)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("service_notes");
            entity.Property(e => e.ServiceOnlineStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("service_online_status");
            entity.Property(e => e.ServiceUpdateBy)
                .HasMaxLength(30)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("service_update_by");
            entity.Property(e => e.ServiceUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("service_update_date");
            entity.Property(e => e.ServiceUpdateFrom)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("service_update_from");
            entity.Property(e => e.SumCoinsurance).HasColumnName("sum_coinsurance");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");
            entity.Property(e => e.VendorName)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("vendor_name");
        });

        modelBuilder.Entity<VAuthorizedApproval>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_authorized_approvals");

            entity.Property(e => e.ActCode).HasColumnName("act_code");
            entity.Property(e => e.AdditionalInfo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("additional_info");
            entity.Property(e => e.ApprovalDate)
                .HasColumnType("datetime")
                .HasColumnName("approval_date");
            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("batch_id");
            entity.Property(e => e.BatchValue).HasColumnName("batch_value");
            entity.Property(e => e.ContractId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("contract_id");
            entity.Property(e => e.CurrentStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("current_status");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_name");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("last_update_from");
            entity.Property(e => e.Machine)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("machine");
            entity.Property(e => e.MemberId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("member_id");
            entity.Property(e => e.MemberName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("member_name");
            entity.Property(e => e.Notes)
                .HasMaxLength(700)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.PrivateNotes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("private_notes");
            entity.Property(e => e.Time)
                .HasColumnType("datetime")
                .HasColumnName("time");
            entity.Property(e => e.TotalPrice).HasColumnName("total_price");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");
            entity.Property(e => e.VendorName)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("vendor_name");
        });

        modelBuilder.Entity<VBatchDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Batch_details");

            entity.Property(e => e.ActivitySerial).HasColumnName("activity_serial");
            entity.Property(e => e.ApprovalNumber).HasColumnName("Approval_number");
            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("batch_id");
            entity.Property(e => e.CashVendor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cash_vendor");
            entity.Property(e => e.CoPayment).HasColumnName("co_payment");
            entity.Property(e => e.ContractActivity)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("contract_activity");
            entity.Property(e => e.ContractCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("contract_code");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.DisNote)
                .HasMaxLength(350)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("dis_note");
            entity.Property(e => e.FinRevised).HasColumnName("fin_revised");
            entity.Property(e => e.HasDoc).HasColumnName("has_doc");
            entity.Property(e => e.ImportDis).HasColumnName("import_dis");
            entity.Property(e => e.InsuranceMedItem).HasColumnName("insurance_med_item");
            entity.Property(e => e.Insurer).HasColumnName("insurer");
            entity.Property(e => e.InvId).HasColumnName("inv_id");
            entity.Property(e => e.InvNum).HasColumnName("inv_num");
            entity.Property(e => e.IsActualCost)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("is_actual_cost");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LocalDis).HasColumnName("local_dis");
            entity.Property(e => e.MedItem).HasColumnName("med_item");
            entity.Property(e => e.MedRevNote)
                .HasMaxLength(350)
                .IsUnicode(false)
                .HasColumnName("med_rev_note");
            entity.Property(e => e.MedRevised).HasColumnName("med_revised");
            entity.Property(e => e.MemberCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("member_code");
            entity.Property(e => e.Note)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("note");
            entity.Property(e => e.Notified).HasColumnName("notified");
            entity.Property(e => e.Num).HasColumnName("num");
            entity.Property(e => e.OldServid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("old_servid");
            entity.Property(e => e.RevDis).HasColumnName("Rev_dis");
            entity.Property(e => e.Serial).HasColumnName("serial");
            entity.Property(e => e.ServiceCode).HasColumnName("service_code");
            entity.Property(e => e.ServiceDate).HasColumnName("service_date");
            entity.Property(e => e.Tax).HasColumnName("tax");
            entity.Property(e => e.Value).HasColumnName("value");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");
        });

        modelBuilder.Entity<VBatchDetailsS>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Batch_details_s");

            entity.Property(e => e.ActivitySerial).HasColumnName("activity_serial");
            entity.Property(e => e.ApprovalNumber).HasColumnName("Approval_number");
            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("batch_id");
            entity.Property(e => e.CashVendor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cash_vendor");
            entity.Property(e => e.CoPayment).HasColumnName("co_payment");
            entity.Property(e => e.ContractActivity)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("contract_activity");
            entity.Property(e => e.ContractCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("contract_code");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.DisNote)
                .HasMaxLength(350)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("dis_note");
            entity.Property(e => e.FinRevised).HasColumnName("fin_revised");
            entity.Property(e => e.HasDoc).HasColumnName("has_doc");
            entity.Property(e => e.ImportDis).HasColumnName("import_dis");
            entity.Property(e => e.InsuranceMedItem).HasColumnName("insurance_med_item");
            entity.Property(e => e.Insurer).HasColumnName("insurer");
            entity.Property(e => e.InvId).HasColumnName("inv_id");
            entity.Property(e => e.InvNum).HasColumnName("inv_num");
            entity.Property(e => e.IsActualCost)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("is_actual_cost");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LocalDis).HasColumnName("local_dis");
            entity.Property(e => e.MedItem).HasColumnName("med_item");
            entity.Property(e => e.MedRevNote)
                .HasMaxLength(350)
                .IsUnicode(false)
                .HasColumnName("med_rev_note");
            entity.Property(e => e.MedRevised).HasColumnName("med_revised");
            entity.Property(e => e.MemberCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("member_code");
            entity.Property(e => e.Note)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("note");
            entity.Property(e => e.Notified).HasColumnName("notified");
            entity.Property(e => e.Num).HasColumnName("num");
            entity.Property(e => e.OldServid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("old_servid");
            entity.Property(e => e.RevDis).HasColumnName("Rev_dis");
            entity.Property(e => e.Serial).HasColumnName("serial");
            entity.Property(e => e.ServiceCode).HasColumnName("service_code");
            entity.Property(e => e.ServiceDate).HasColumnName("service_date");
            entity.Property(e => e.Tax).HasColumnName("tax");
            entity.Property(e => e.Value).HasColumnName("value");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");
        });

        modelBuilder.Entity<VBillOldDb>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_bill_old_db");

            entity.Property(e => e.BillCat)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Bill_Cat");
            entity.Property(e => e.BillId)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("BILL_ID");
            entity.Property(e => e.SaEmpid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SA_EMPID");
            entity.Property(e => e.SaRcode)
                .HasColumnType("numeric(16, 0)")
                .HasColumnName("SA_RCODE");
            entity.Property(e => e.SaSerial).HasColumnName("SA_SERIAL");
        });

        modelBuilder.Entity<VBlueCode>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_blue_code");

            entity.Property(e => e.CustomerContractEndDate)
                .HasColumnType("datetime")
                .HasColumnName("customer_contract_end_date");
            entity.Property(e => e.CustomerContractId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("customer_contract_id");
            entity.Property(e => e.CustomerContractStartDate)
                .HasColumnType("datetime")
                .HasColumnName("customer_contract_start_date");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_name");
            entity.Property(e => e.Email)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Frequency).HasColumnName("frequency");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.TotalConsumption).HasColumnName("total_consumption");
            entity.Property(e => e.TotalPremium).HasColumnName("total_premium");
            entity.Property(e => e.WarningValue).HasColumnName("warning_value");
        });

        modelBuilder.Entity<VBranchesFromSearchVendor>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_branches_from_search_vendor");

            entity.Property(e => e.Address)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.BranchId).HasColumnName("branch_id");
            entity.Property(e => e.CarecardText)
                .HasMaxLength(500)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("carecard_text");
            entity.Property(e => e.Cat).HasColumnName("cat");
            entity.Property(e => e.CatName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CatSort).HasColumnName("cat_sort");
            entity.Property(e => e.City).HasColumnName("city");
            entity.Property(e => e.CityName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("city_name");
            entity.Property(e => e.Class)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI");
            entity.Property(e => e.ConsultExp).HasColumnName("consult_exp");
            entity.Property(e => e.ConsultSpe).HasColumnName("consult_spe");
            entity.Property(e => e.Gov).HasColumnName("gov");
            entity.Property(e => e.GovName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.IsCarecard).HasColumnName("is_carecard");
            entity.Property(e => e.Lat)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("lat");
            entity.Property(e => e.Long)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("long");
            entity.Property(e => e.MapLink)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("map_link");
            entity.Property(e => e.Name)
                .HasMaxLength(292)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Parent)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("parent");
            entity.Property(e => e.Phones)
                .HasMaxLength(41)
                .IsUnicode(false)
                .HasColumnName("phones");
            entity.Property(e => e.Spec)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("spec");
            entity.Property(e => e.SubCat).HasColumnName("sub_cat");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");
            entity.Property(e => e.VendorNbe).HasColumnName("vendor_nbe");
            entity.Property(e => e.VipFlag).HasColumnName("vip_flag");
        });

        modelBuilder.Entity<VCashVendor>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_cashVendor");

            entity.Property(e => e.EtaStart).HasColumnName("eta_start");
            entity.Property(e => e.HasEta).HasColumnName("has_eta");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("last_update_from");
            entity.Property(e => e.OldId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("old_id");
            entity.Property(e => e.VendorAddress)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("vendor_address");
            entity.Property(e => e.VendorArea).HasColumnName("vendor_area");
            entity.Property(e => e.VendorCategoryId).HasColumnName("vendor_category_id");
            entity.Property(e => e.VendorCheckBeneficiary)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("vendor_check_beneficiary");
            entity.Property(e => e.VendorClientId).HasColumnName("vendor_client_id");
            entity.Property(e => e.VendorCommercialRecord)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_commercial_record");
            entity.Property(e => e.VendorContractExecutor)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("vendor_contract_executor");
            entity.Property(e => e.VendorCreationDate)
                .HasColumnType("datetime")
                .HasColumnName("vendor_creation_date");
            entity.Property(e => e.VendorEmail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("vendor_email");
            entity.Property(e => e.VendorFax)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("vendor_fax");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");
            entity.Property(e => e.VendorLatitude)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("vendor_latitude");
            entity.Property(e => e.VendorLongitude)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("vendor_longitude");
            entity.Property(e => e.VendorMapUrl)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("vendor_map_url");
            entity.Property(e => e.VendorName)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("vendor_name");
            entity.Property(e => e.VendorPayPeriod).HasColumnName("vendor_pay_period");
            entity.Property(e => e.VendorStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("vendor_status");
            entity.Property(e => e.VendorStatusDate)
                .HasColumnType("datetime")
                .HasColumnName("vendor_status_date");
            entity.Property(e => e.VendorTax).HasColumnName("vendor_tax");
            entity.Property(e => e.VendorTaxArea)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_tax_area");
            entity.Property(e => e.VendorTaxFile)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("vendor_tax_file");
            entity.Property(e => e.VendorTaxId)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("vendor_tax_id");
            entity.Property(e => e.VendorTele)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("vendor_tele");
            entity.Property(e => e.VendorTele1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("vendor_tele1");
            entity.Property(e => e.VendorTele2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("vendor_tele2");
        });

        modelBuilder.Entity<VClientsWorklist>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_clients_worklist");

            entity.Property(e => e.ActStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("act_status");
            entity.Property(e => e.Agent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("agent");
            entity.Property(e => e.ApprovalDate)
                .HasColumnType("datetime")
                .HasColumnName("APPROVAL_DATE");
            entity.Property(e => e.ApprovalType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("Approval_type");
            entity.Property(e => e.Member)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Notes)
                .HasMaxLength(700)
                .IsUnicode(false)
                .HasColumnName("NOTES");
            entity.Property(e => e.Pic)
                .HasMaxLength(102)
                .IsUnicode(false)
                .HasColumnName("pic");
            entity.Property(e => e.PlanCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("plan_code");
            entity.Property(e => e.Source)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("source");
            entity.Property(e => e.Url)
                .HasMaxLength(271)
                .IsUnicode(false)
                .HasColumnName("url");
            entity.Property(e => e.Vendor)
                .HasMaxLength(80)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VClientsWorklistOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_clients_worklist_old");

            entity.Property(e => e.ActStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("act_status");
            entity.Property(e => e.Agent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("agent");
            entity.Property(e => e.ApprovalDate)
                .HasColumnType("datetime")
                .HasColumnName("APPROVAL_DATE");
            entity.Property(e => e.ApprovalType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Approval_type");
            entity.Property(e => e.Code).HasColumnType("numeric(12, 0)");
            entity.Property(e => e.ContractId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("contract_id");
            entity.Property(e => e.Member)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Notes)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasColumnName("NOTES");
            entity.Property(e => e.Pic)
                .HasMaxLength(96)
                .IsUnicode(false)
                .HasColumnName("pic");
            entity.Property(e => e.Source)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("source");
            entity.Property(e => e.Url)
                .HasMaxLength(271)
                .IsUnicode(false)
                .HasColumnName("url");
            entity.Property(e => e.Vendor)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VCustlist>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_custlist");

            entity.Property(e => e.CusParent).HasColumnName("cus_parent");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_name");
        });

        modelBuilder.Entity<VCustomerAllBill>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_customer_all_bill");

            entity.Property(e => e.Balance)
                .HasColumnType("numeric(38, 3)")
                .HasColumnName("balance");
            entity.Property(e => e.BillDate)
                .HasColumnType("datetime")
                .HasColumnName("BILL_DATE");
            entity.Property(e => e.BillValue)
                .HasColumnType("numeric(38, 3)")
                .HasColumnName("bill_value");
            entity.Property(e => e.Billid)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("billid");
            entity.Property(e => e.Collected).HasColumnType("numeric(38, 3)");
            entity.Property(e => e.CustomerContractId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("customer_contract_id");
            entity.Property(e => e.CustomerEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_email");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("customer_name");
            entity.Property(e => e.HasBill).HasColumnName("hasBill");
            entity.Property(e => e.InstallmentDate).HasColumnName("installment_Date");
            entity.Property(e => e.InstallmentId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("installment_ID");
            entity.Property(e => e.InstallmentValue).HasColumnName("installment_value");
        });

        modelBuilder.Entity<VCustomerConsumptionSummary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_customer_consumption_summary");

            entity.Property(e => e.ActiveMembers).HasColumnName("Active_Members");
            entity.Property(e => e.Contract)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.IncomePerDay)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("Income_per_day");
            entity.Property(e => e.MembersWithConsumption).HasColumnName("Members_with_consumption");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RatioStartToEnd).HasColumnName("Ratio_Start_to_End");
            entity.Property(e => e.RemainingDays).HasColumnName("remainingDays");
            entity.Property(e => e.TotalIncome)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("Total_income");
        });

        modelBuilder.Entity<VCustomerConsumptionSummaryTpa>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_customer_consumption_summary_tpa");

            entity.Property(e => e.ActiveMembers).HasColumnName("Active_Members");
            entity.Property(e => e.Consumption).HasColumnType("numeric(38, 2)");
            entity.Property(e => e.Contract)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.IncomePerDay)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("Income_per_day");
            entity.Property(e => e.MembersWithConsumption).HasColumnName("Members_with_consumption");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RatioStartToEnd).HasColumnName("Ratio_Start_to_End");
            entity.Property(e => e.RemainingDays).HasColumnName("remainingDays");
            entity.Property(e => e.TotalIncome)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("Total_income");
        });

        modelBuilder.Entity<VCustomerContact>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_customer_contacts");

            entity.Property(e => e.CustomerContactPerson)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_contact_person");
            entity.Property(e => e.CustomerEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_email");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.CustomerMobile)
                .HasMaxLength(15)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_mobile");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_name");
            entity.Property(e => e.CustomerWebsite)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_website");
            entity.Property(e => e.Satus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("satus");
        });

        modelBuilder.Entity<VCustomerContractsQuarterYear>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Customer_contracts_quarterYear");

            entity.Property(e => e.CustomerContractEndDate)
                .HasColumnType("datetime")
                .HasColumnName("customer_contract_end_date");
            entity.Property(e => e.CustomerContractId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("customer_contract_id");
            entity.Property(e => e.CustomerContractStartDate)
                .HasColumnType("datetime")
                .HasColumnName("customer_contract_start_date");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_name");
        });

        modelBuilder.Entity<VCustomerVisit>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_customer_visits");

            entity.Property(e => e.CreationDate)
                .HasColumnType("datetime")
                .HasColumnName("creation_date");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_name");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.Notes)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.Users)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("users");
            entity.Property(e => e.VisitDate)
                .HasColumnType("datetime")
                .HasColumnName("visit_date");
        });

        modelBuilder.Entity<VCustomersAllNoteState>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_customers_all_note_state");

            entity.Property(e => e.Balance)
                .HasColumnType("numeric(38, 3)")
                .HasColumnName("balance");
            entity.Property(e => e.BillDate)
                .HasColumnType("datetime")
                .HasColumnName("BILL_DATE");
            entity.Property(e => e.BillId)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("BILL_ID");
            entity.Property(e => e.BillValue)
                .HasColumnType("numeric(13, 3)")
                .HasColumnName("bill_value");
            entity.Property(e => e.Collected).HasColumnType("numeric(38, 3)");
            entity.Property(e => e.ContractType)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("contract_type");
            entity.Property(e => e.CustomerContractId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("customer_contract_id");
            entity.Property(e => e.CustomerEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_email");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("customer_name");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.InsurerId).HasColumnName("insurer_id");
            entity.Property(e => e.InsurerName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("insurer_name");
            entity.Property(e => e.PaymentType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("payment_type");
        });

        modelBuilder.Entity<VCustomersBillState>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_customers_bill_state");

            entity.Property(e => e.Balance)
                .HasColumnType("numeric(38, 3)")
                .HasColumnName("balance");
            entity.Property(e => e.BillDate)
                .HasColumnType("datetime")
                .HasColumnName("BILL_DATE");
            entity.Property(e => e.BillId)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("BILL_ID");
            entity.Property(e => e.BillValue)
                .HasColumnType("numeric(12, 3)")
                .HasColumnName("bill_value");
            entity.Property(e => e.Collected).HasColumnType("numeric(38, 3)");
            entity.Property(e => e.ContractType)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("contract_type");
            entity.Property(e => e.CustomerContractId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("customer_contract_id");
            entity.Property(e => e.CustomerEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_email");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("customer_name");
            entity.Property(e => e.InstallmentDate).HasColumnName("installment_Date");
            entity.Property(e => e.InsurerId).HasColumnName("insurer_id");
            entity.Property(e => e.InsurerName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("insurer_name");
            entity.Property(e => e.PaymentType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("payment_type");
        });

        modelBuilder.Entity<VDocWorklist>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_doc_worklist");

            entity.Property(e => e.FormId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("form_id");
            entity.Property(e => e.Value).HasColumnName("value");
            entity.Property(e => e.VendorCategoryId).HasColumnName("vendor_category_id");
        });

        modelBuilder.Entity<VGetAcmsNotificationsDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_getAcmsNotificationsData");

            entity.Property(e => e.ActionId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("action_id");
            entity.Property(e => e.ApprovalId).HasColumnName("approval_id");
            entity.Property(e => e.Body)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("body");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("customer_name");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsConditionTrue).HasColumnName("is_condition_true");
            entity.Property(e => e.Link)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("link");
            entity.Property(e => e.MemberId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("member_id");
            entity.Property(e => e.MemberName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("member_name");
            entity.Property(e => e.Title)
                .HasMaxLength(48)
                .IsUnicode(false)
                .HasColumnName("title");
            entity.Property(e => e.Type)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("type");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");
            entity.Property(e => e.VendorName)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("vendor_name");
        });

        modelBuilder.Entity<VGetApprovalService>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_get_approval_service");

            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.ServiceId).HasColumnName("service_id");
        });

        modelBuilder.Entity<VGetBillsDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_getBillsData");

            entity.Property(e => e.BillDate)
                .HasColumnType("datetime")
                .HasColumnName("BILL_DATE");
            entity.Property(e => e.BillId)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("BILL_ID");
            entity.Property(e => e.BillPeriodFrom)
                .HasColumnType("datetime")
                .HasColumnName("bill_period_from");
            entity.Property(e => e.BillPeriodTo)
                .HasColumnType("datetime")
                .HasColumnName("bill_period_to");
            entity.Property(e => e.CustomerAddress)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_address");
            entity.Property(e => e.CustomerContractId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("customer_contract_id");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("customer_name");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.Insurer)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("insurer");
        });

        modelBuilder.Entity<VGetIsPackageContract>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_getIsPackageContracts");

            entity.Property(e => e.ContractServiceId).HasColumnName("contract_service_id");
            entity.Property(e => e.ContractServiceName)
                .IsUnicode(false)
                .HasColumnName("contract_service_name");
            entity.Property(e => e.ContractServicePrices).HasColumnName("contract_service_prices");
            entity.Property(e => e.IsPackage).HasColumnName("is_package");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");
            entity.Property(e => e.VendorName)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("vendor_name");
        });

        modelBuilder.Entity<VGetMember>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_get_members");

            entity.Property(e => e.Contract)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("contract");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("customer_name");
            entity.Property(e => e.MemberCustomerId).HasColumnName("member_customer_id");
            entity.Property(e => e.MemberId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("member_id");
            entity.Property(e => e.MemberName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("member_name");
        });

        modelBuilder.Entity<VGetVendor>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_get_vendors");

            entity.Property(e => e.AreaNameAr)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("area_name_ar");
            entity.Property(e => e.CatIndex).HasColumnName("cat_index");
            entity.Property(e => e.CatName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cat_name");
            entity.Property(e => e.Gov)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.Phones)
                .HasMaxLength(62)
                .IsUnicode(false);
            entity.Property(e => e.VendorAddress)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("vendor_address");
            entity.Property(e => e.VendorCarecardNotes)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("vendor_carecard_notes");
            entity.Property(e => e.VendorCategoryId).HasColumnName("vendor_category_id");
            entity.Property(e => e.VendorEmail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("vendor_email");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");
            entity.Property(e => e.VendorMapUrl)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("vendor_map_url");
            entity.Property(e => e.VendorName)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("vendor_name");
            entity.Property(e => e.VendorStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("vendor_status");
            entity.Property(e => e.VendormedcareClass)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("vendormedcare_class");
        });

        modelBuilder.Entity<VGetVendorService>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_get_vendor_services");

            entity.Property(e => e.Area)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Cat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI");
            entity.Property(e => e.Gov)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ServiceNo).HasColumnName("Service_No");
            entity.Property(e => e.VendorName)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("vendor_name");
            entity.Property(e => e.VendorStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("vendor_status");
        });

        modelBuilder.Entity<VGetallcontractserv>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_getallcontractservs");

            entity.Property(e => e.ContractServiceId).HasColumnName("contract_service_id");
            entity.Property(e => e.ContractServiceName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("contract_service_name");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");
            entity.Property(e => e.VendorName)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("vendor_name");
        });

        modelBuilder.Entity<VInquery>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_inqueries");

            entity.Property(e => e.AppLastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("app_last_update_by");
            entity.Property(e => e.AppLastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("app_last_update_date");
            entity.Property(e => e.ApprovalId).HasColumnName("approval_id");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_from");
            entity.Property(e => e.MemberAddress)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("member_address");
            entity.Property(e => e.MemberId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("member_id");
            entity.Property(e => e.MemberName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("member_name");
            entity.Property(e => e.ReqAddressId).HasColumnName("req_address_id");
            entity.Property(e => e.ReqCategory).HasColumnName("req_category");
            entity.Property(e => e.ReqDate)
                .HasColumnType("datetime")
                .HasColumnName("req_date");
            entity.Property(e => e.ReqId).HasColumnName("req_id");
            entity.Property(e => e.ReqMember)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("req_member");
            entity.Property(e => e.ReqNote)
                .HasMaxLength(700)
                .IsUnicode(false)
                .HasColumnName("req_note");
            entity.Property(e => e.ReqParent)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("req_parent");
            entity.Property(e => e.ReqProvider)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("req_provider");
            entity.Property(e => e.ReqSource).HasColumnName("req_source");
            entity.Property(e => e.ReqStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("req_status");
            entity.Property(e => e.ReqType).HasColumnName("req_type");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("status");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");
            entity.Property(e => e.VendorName)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("vendor_name");
        });

        modelBuilder.Entity<VLogInformation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_log_information");

            entity.Property(e => e.ActionName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Action Name");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.Event)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Ip)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("IP");
            entity.Property(e => e.Note).IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VMainVendorsSearch>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_main_vendors_search");

            entity.Property(e => e.AreaNameAr)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("area_name_ar");
            entity.Property(e => e.CatCode).HasColumnName("Cat_code");
            entity.Property(e => e.CatName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("Cat_name");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("last_update_from");
            entity.Property(e => e.OldId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("old_id");
            entity.Property(e => e.SubCatCode).HasColumnName("subCat_code");
            entity.Property(e => e.SubCatName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("subCat_name");
            entity.Property(e => e.VendorAddress)
                .HasMaxLength(150)
                .IsUnicode(false)
                .UseCollation("Arabic_BIN")
                .HasColumnName("vendor_address");
            entity.Property(e => e.VendorArea).HasColumnName("vendor_area");
            entity.Property(e => e.VendorCarecard).HasColumnName("vendor_carecard");
            entity.Property(e => e.VendorCarecardNotes)
                .HasMaxLength(150)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("vendor_carecard_notes");
            entity.Property(e => e.VendorCategoryId).HasColumnName("vendor_category_id");
            entity.Property(e => e.VendorCheckBeneficiary)
                .HasMaxLength(150)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("vendor_check_beneficiary");
            entity.Property(e => e.VendorClientId).HasColumnName("vendor_client_id");
            entity.Property(e => e.VendorCommercialRecord)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("vendor_commercial_record");
            entity.Property(e => e.VendorContractExecutor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("vendor_contract_executor");
            entity.Property(e => e.VendorCreationDate)
                .HasColumnType("datetime")
                .HasColumnName("vendor_creation_date");
            entity.Property(e => e.VendorEmail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("vendor_email");
            entity.Property(e => e.VendorFax)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("vendor_fax");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("vendor_id");
            entity.Property(e => e.VendorLatitude)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("vendor_latitude");
            entity.Property(e => e.VendorLongitude)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("vendor_longitude");
            entity.Property(e => e.VendorMapUrl)
                .HasMaxLength(500)
                .IsUnicode(false)
                .UseCollation("Arabic_BIN")
                .HasColumnName("vendor_map_url");
            entity.Property(e => e.VendorName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("vendor_name");
            entity.Property(e => e.VendorPayPeriod).HasColumnName("vendor_pay_period");
            entity.Property(e => e.VendorStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("vendor_status");
            entity.Property(e => e.VendorStatusDate)
                .HasColumnType("datetime")
                .HasColumnName("vendor_status_date");
            entity.Property(e => e.VendorTax).HasColumnName("vendor_tax");
            entity.Property(e => e.VendorTaxArea)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("vendor_tax_area");
            entity.Property(e => e.VendorTaxFile)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("vendor_tax_file");
            entity.Property(e => e.VendorTaxId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("vendor_tax_id");
            entity.Property(e => e.VendorTele)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("vendor_tele");
            entity.Property(e => e.VendorTele1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("vendor_tele1");
            entity.Property(e => e.VendorTele2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("vendor_tele2");
        });

        modelBuilder.Entity<VMashcachInquery>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_mashcach_inqueries");

            entity.Property(e => e.ApStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("ap_status");
            entity.Property(e => e.ApprovalDate)
                .HasColumnType("datetime")
                .HasColumnName("approval_date");
            entity.Property(e => e.ApprovalId).HasColumnName("approval_id");
            entity.Property(e => e.ExpireDate)
                .HasColumnType("datetime")
                .HasColumnName("expire_date");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_from");
            entity.Property(e => e.MemberName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("member_name");
            entity.Property(e => e.PayCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("pay_code");
            entity.Property(e => e.PayLink)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("pay_link");
            entity.Property(e => e.PayStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("pay_status");
            entity.Property(e => e.PayValue).HasColumnName("pay_value");
            entity.Property(e => e.ReqAddressId).HasColumnName("req_address_id");
            entity.Property(e => e.ReqCategory).HasColumnName("req_category");
            entity.Property(e => e.ReqDate)
                .HasColumnType("datetime")
                .HasColumnName("req_date");
            entity.Property(e => e.ReqId).HasColumnName("req_id");
            entity.Property(e => e.ReqMember)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("req_member");
            entity.Property(e => e.ReqNote)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("req_note");
            entity.Property(e => e.ReqParent)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("req_parent");
            entity.Property(e => e.ReqProvider)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("req_provider");
            entity.Property(e => e.ReqSource).HasColumnName("req_source");
            entity.Property(e => e.ReqStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("req_status");
            entity.Property(e => e.ReqType).HasColumnName("req_type");
            entity.Property(e => e.Url)
                .HasMaxLength(217)
                .IsUnicode(false)
                .HasColumnName("url");
            entity.Property(e => e.VendorCategoryName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_category_name");
            entity.Property(e => e.VendorName)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("vendor_name");
        });

        modelBuilder.Entity<VMcPackageVendor>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_mc_package_vendors");

            entity.Property(e => e.Address)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.CarecardText)
                .HasMaxLength(500)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("carecard_text");
            entity.Property(e => e.Cat).HasColumnName("cat");
            entity.Property(e => e.City).HasColumnName("city");
            entity.Property(e => e.CityName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("city_name");
            entity.Property(e => e.Class)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("class");
            entity.Property(e => e.ConsultExp).HasColumnName("consult_exp");
            entity.Property(e => e.ConsultSpe).HasColumnName("consult_spe");
            entity.Property(e => e.ContractServiceName)
                .IsUnicode(false)
                .HasColumnName("contract_service_name");
            entity.Property(e => e.Gov).HasColumnName("gov");
            entity.Property(e => e.Id)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.IsCarecard).HasColumnName("is_carecard");
            entity.Property(e => e.Lat)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("lat");
            entity.Property(e => e.Long)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("long");
            entity.Property(e => e.MapLink)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("map_link");
            entity.Property(e => e.Name)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Parent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("parent");
            entity.Property(e => e.Phones)
                .HasMaxLength(41)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("phones");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.ServId).HasColumnName("serv_id");
            entity.Property(e => e.Spec)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("spec");
            entity.Property(e => e.SubCat).HasColumnName("sub_cat");
            entity.Property(e => e.TodayEshift).HasColumnName("today_Eshift");
            entity.Property(e => e.TodaySshift).HasColumnName("today_Sshift");
            entity.Property(e => e.VendorNbe).HasColumnName("vendor_nbe");
            entity.Property(e => e.VipFlag).HasColumnName("vip_flag");
        });

        modelBuilder.Entity<VMcSudanActiveMeber>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_mc_sudan_active_mebers");

            entity.Property(e => e.ContractCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("contract_code");
            entity.Property(e => e.MemberId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("member_id");
            entity.Property(e => e.MemberName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("member_name");
            entity.Property(e => e.MemberNationalId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("member_national_id");
            entity.Property(e => e.PlanCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("plan_code");
            entity.Property(e => e.VisitId).HasColumnName("visit_id");
        });

        modelBuilder.Entity<VMcSudanVendorsSearch>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_mc_sudan_vendors_search");

            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");
            entity.Property(e => e.VendorName)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("vendor_name");
        });

        modelBuilder.Entity<VMcVendorsCatGovCity>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_mc_vendors_CatGovCity");

            entity.Property(e => e.Cat).HasColumnName("cat");
            entity.Property(e => e.City).HasColumnName("city");
            entity.Property(e => e.CityName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("city_name");
            entity.Property(e => e.Gov).HasColumnName("gov");
            entity.Property(e => e.GovName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("gov_name");
            entity.Property(e => e.Spec)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("spec");
            entity.Property(e => e.SubCat).HasColumnName("sub_cat");
            entity.Property(e => e.VindorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vindorId");
        });

        modelBuilder.Entity<VMcVendorsSearch>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_mc_vendors_search");

            entity.Property(e => e.Address)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.CarecardText)
                .HasMaxLength(500)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("carecard_text");
            entity.Property(e => e.Cat).HasColumnName("cat");
            entity.Property(e => e.City).HasColumnName("city");
            entity.Property(e => e.CityName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("city_name");
            entity.Property(e => e.Class)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("class");
            entity.Property(e => e.ConsultExp).HasColumnName("consult_exp");
            entity.Property(e => e.ConsultSpe).HasColumnName("consult_spe");
            entity.Property(e => e.Gov).HasColumnName("gov");
            entity.Property(e => e.Id)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.IsCarecard).HasColumnName("is_carecard");
            entity.Property(e => e.Lat)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("lat");
            entity.Property(e => e.Long)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("long");
            entity.Property(e => e.MapLink)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("map_link");
            entity.Property(e => e.Name)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Parent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("parent");
            entity.Property(e => e.Phones)
                .HasMaxLength(41)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("phones");
            entity.Property(e => e.Spec)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("spec");
            entity.Property(e => e.SubCat).HasColumnName("sub_cat");
            entity.Property(e => e.TodayEshift).HasColumnName("today_Eshift");
            entity.Property(e => e.TodaySshift).HasColumnName("today_Sshift");
            entity.Property(e => e.VendorNbe).HasColumnName("vendor_nbe");
            entity.Property(e => e.VipFlag).HasColumnName("vip_flag");
        });

        modelBuilder.Entity<VMemberBill>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_member_bills");

            entity.Property(e => e.AnnualFees).HasColumnName("annual_fees");
            entity.Property(e => e.BillId).HasColumnName("bill_id");
            entity.Property(e => e.ContractId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("contract_id");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("customer_name");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.MemberId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("member_id");
            entity.Property(e => e.MemberName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("member_name");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<VMemberComplaintsDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_member_complaints_details");

            entity.Property(e => e.ApprovalId).HasColumnName("approval_id");
            entity.Property(e => e.Closed).HasColumnName("closed");
            entity.Property(e => e.Complaint)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("complaint");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("customer_name");
            entity.Property(e => e.Department)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("department");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_from");
            entity.Property(e => e.MemberId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("member_id");
            entity.Property(e => e.MemberName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("member_name");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("phone_number");
            entity.Property(e => e.Respond)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("respond");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");
        });

        modelBuilder.Entity<VMemberConsumption>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_member_consumption");

            entity.Property(e => e.ApprovalNumber).HasColumnName("Approval_number");
            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("batch_id");
            entity.Property(e => e.CareItemName)
                .HasMaxLength(85)
                .IsUnicode(false)
                .HasColumnName("care_item_name");
            entity.Property(e => e.CoPayment).HasColumnName("co_payment");
            entity.Property(e => e.ContractCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("contract_code");
            entity.Property(e => e.ContractDis).HasColumnName("contract_dis");
            entity.Property(e => e.CustomerContractCategory)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("customer_contract_category");
            entity.Property(e => e.ImportDis).HasColumnName("import_dis");
            entity.Property(e => e.InvId).HasColumnName("inv_id");
            entity.Property(e => e.LocalDis).HasColumnName("local_dis");
            entity.Property(e => e.MemberCustomerId).HasColumnName("member_customer_id");
            entity.Property(e => e.MemberId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("member_id");
            entity.Property(e => e.MemberName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("member_name");
            entity.Property(e => e.Net).HasColumnName("net");
            entity.Property(e => e.Notified).HasColumnName("notified");
            entity.Property(e => e.RevDis).HasColumnName("Rev_dis");
            entity.Property(e => e.Serial).HasColumnName("serial");
            entity.Property(e => e.ServiceDate).HasColumnName("service_date");
            entity.Property(e => e.ServiceName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("service_name");
            entity.Property(e => e.Value).HasColumnName("value");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");
            entity.Property(e => e.VendorName)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("vendor_name");
        });

        modelBuilder.Entity<VMemberConsumptionSudan>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_member_consumption_sudan");

            entity.Property(e => e.ApprovalNumber).HasColumnName("Approval_number");
            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("batch_id");
            entity.Property(e => e.CareItemName)
                .HasMaxLength(85)
                .IsUnicode(false)
                .HasColumnName("care_item_name");
            entity.Property(e => e.CoPayment).HasColumnName("co_payment");
            entity.Property(e => e.ContractCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("contract_code");
            entity.Property(e => e.ContractDis).HasColumnName("contract_dis");
            entity.Property(e => e.CustomerContractCategory)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("customer_contract_category");
            entity.Property(e => e.ImportDis).HasColumnName("import_dis");
            entity.Property(e => e.InvId).HasColumnName("inv_id");
            entity.Property(e => e.LocalDis).HasColumnName("local_dis");
            entity.Property(e => e.MemberCustomerId).HasColumnName("member_customer_id");
            entity.Property(e => e.MemberId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("member_id");
            entity.Property(e => e.MemberName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("member_name");
            entity.Property(e => e.Net).HasColumnName("net");
            entity.Property(e => e.Notified).HasColumnName("notified");
            entity.Property(e => e.RevDis).HasColumnName("Rev_dis");
            entity.Property(e => e.Serial).HasColumnName("serial");
            entity.Property(e => e.ServiceDate).HasColumnName("service_date");
            entity.Property(e => e.ServiceName)
                .IsUnicode(false)
                .HasColumnName("service_name");
            entity.Property(e => e.Value).HasColumnName("value");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");
            entity.Property(e => e.VendorName)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("vendor_name");
        });

        modelBuilder.Entity<VMemberFrequant>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_member_frequant");

            entity.Property(e => e.CustomerName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("customer_name");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasMaxLength(4000)
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateDateTime)
                .HasColumnType("datetime")
                .HasColumnName("last_update_dateTime");
            entity.Property(e => e.MemberId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("member_id");
            entity.Property(e => e.MemberName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("member_name");
            entity.Property(e => e.MemberTele)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("member_tele");
            entity.Property(e => e.Photo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("photo");
        });

        modelBuilder.Entity<VMembersBillOldDb>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_members_bill_old_db");

            entity.Property(e => e.BillId)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("BILL_ID");
            entity.Property(e => e.Contract)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("contract");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("customer");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.MemberId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("member_id");
            entity.Property(e => e.PatientPrice)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("PATIENT_PRICE");
        });

        modelBuilder.Entity<VMembersContractPremium>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_members_contract_premium");

            entity.Property(e => e.AnnualFees).HasColumnName("annual_fees");
            entity.Property(e => e.BillId)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("BILL_ID");
            entity.Property(e => e.Contract)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("contract");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("customer");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.MemberId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("member_id");
            entity.Property(e => e.MemberName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("member_name");
            entity.Property(e => e.PatientPrice)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("PATIENT_PRICE");
        });

        modelBuilder.Entity<VMembership>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Membership");

            entity.Property(e => e.Activity)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("activity");
            entity.Property(e => e.BillId)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("bill_id");
            entity.Property(e => e.BilledMonths).HasColumnName("billed_months");
            entity.Property(e => e.CSubDate)
                .HasColumnType("datetime")
                .HasColumnName("c_sub_date");
            entity.Property(e => e.CardPrinted)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("card_printed");
            entity.Property(e => e.ContractCategoryName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("contract_category_name");
            entity.Property(e => e.ContractEnd)
                .HasColumnType("datetime")
                .HasColumnName("contract_end");
            entity.Property(e => e.ContractStart)
                .HasColumnType("datetime")
                .HasColumnName("contract_start");
            entity.Property(e => e.CustomerContractId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("customer_contract_id");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("customer_name");
            entity.Property(e => e.MemberBirthday).HasColumnName("member_birthday");
            entity.Property(e => e.MemberCareCardId)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("member_care_card_id");
            entity.Property(e => e.MemberClass)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("member_class");
            entity.Property(e => e.MemberCompanyId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("member_company_id");
            entity.Property(e => e.MemberCustomer)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("member_customer");
            entity.Property(e => e.MemberEip).HasColumnName("member_eip");
            entity.Property(e => e.MemberGender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("member_gender");
            entity.Property(e => e.MemberId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("member_id");
            entity.Property(e => e.MemberJob)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("member_job");
            entity.Property(e => e.MemberName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("member_name");
            entity.Property(e => e.MemberNotes)
                .HasMaxLength(256)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("member_notes");
            entity.Property(e => e.MemberSubDate)
                .HasColumnType("datetime")
                .HasColumnName("member_sub_date");
            entity.Property(e => e.MemberTele)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("member_tele");
            entity.Property(e => e.MemberTele2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("member_tele2");
            entity.Property(e => e.MemberTele3)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("member_tele3");
            entity.Property(e => e.MemberVip).HasColumnName("member_vip");
            entity.Property(e => e.MembershipState)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("membership_state");
            entity.Property(e => e.ParentId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("parent_id");
            entity.Property(e => e.ParentName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("parent_name");
            entity.Property(e => e.StoppedDate)
                .HasColumnType("datetime")
                .HasColumnName("stopped_date");
            entity.Property(e => e.SubMonths).HasColumnName("sub_months");
        });

        modelBuilder.Entity<VMobMemberHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_mob_member_history");

            entity.Property(e => e.ADate)
                .HasColumnType("datetime")
                .HasColumnName("a_date");
            entity.Property(e => e.CatCode)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("cat_code");
            entity.Property(e => e.Category)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("category");
            entity.Property(e => e.DocDate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("doc_date");
            entity.Property(e => e.DocName)
                .HasMaxLength(209)
                .IsUnicode(false)
                .HasColumnName("doc_name");
            entity.Property(e => e.MemberId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Member_id");
            entity.Property(e => e.VendorName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("vendor_name");
        });

        modelBuilder.Entity<VMobVendorsCatGovCity>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_mob_vendors_CatGovCity");

            entity.Property(e => e.Cat).HasColumnName("cat");
            entity.Property(e => e.City).HasColumnName("city");
            entity.Property(e => e.CityName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("city_name");
            entity.Property(e => e.Gov).HasColumnName("gov");
            entity.Property(e => e.GovName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("gov_name");
            entity.Property(e => e.Spec)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("spec");
            entity.Property(e => e.SubCat).HasColumnName("sub_cat");
            entity.Property(e => e.VindorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vindorId");
        });

        modelBuilder.Entity<VNotActiveContractVendor>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_not_active_contract_vendor");

            entity.Property(e => e.Cat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI");
            entity.Property(e => e.VendorCategoryId).HasColumnName("vendor_category_id");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");
            entity.Property(e => e.VendorName)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("vendor_name");
        });

        modelBuilder.Entity<VOnlineBranch>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_online_branches");

            entity.Property(e => e.AreaNameAr)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("area_name_ar");
            entity.Property(e => e.AreaNameEg)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("area_name_eg");
            entity.Property(e => e.AreaParent).HasColumnName("area_parent");
            entity.Property(e => e.Gov)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("last_update_from");
            entity.Property(e => e.OnlineUserPassword)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("online_user_password");
            entity.Property(e => e.OnlineUserUserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("online_user_userName");
            entity.Property(e => e.VendorBranchAddress)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("vendor_branch_address");
            entity.Property(e => e.VendorBranchDate)
                .HasColumnType("datetime")
                .HasColumnName("vendor_branch_date");
            entity.Property(e => e.VendorBranchLatitude)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("vendor_branch_latitude");
            entity.Property(e => e.VendorBranchLongitude)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("vendor_branch_longitude");
            entity.Property(e => e.VendorBranchMapUrl)
                .HasMaxLength(500)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("vendor_branch_map_url");
            entity.Property(e => e.VendorBranchName)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("vendor_branch_name");
            entity.Property(e => e.VendorBranchSerial).HasColumnName("vendor_branch_serial");
            entity.Property(e => e.VendorBranchStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("vendor_branch_status");
            entity.Property(e => e.VendorBranchTele)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("vendor_branch_tele");
            entity.Property(e => e.VendorBranchTele2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("vendor_branch_tele2");
            entity.Property(e => e.VendorBranchareaId).HasColumnName("vendor_brancharea_id");
            entity.Property(e => e.VendorEmail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("vendor_email");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");
        });

        modelBuilder.Entity<VOnlineWorklist>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Online_worklist");

            entity.Property(e => e.AddedDate)
                .HasColumnType("datetime")
                .HasColumnName("added_date");
            entity.Property(e => e.ApStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("ap_status");
            entity.Property(e => e.ApType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("ap_type");
            entity.Property(e => e.ApprovalDate)
                .HasColumnType("datetime")
                .HasColumnName("approval_date");
            entity.Property(e => e.ApprovalId).HasColumnName("approval_id");
            entity.Property(e => e.ApprovalValue).HasColumnName("approval_value");
            entity.Property(e => e.ContractId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("contract_id");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("customer_name");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.MemberCustomer).HasColumnName("member_customer");
            entity.Property(e => e.MemberEip).HasColumnName("member_eip");
            entity.Property(e => e.MemberId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("member_id");
            entity.Property(e => e.MemberName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("member_name");
            entity.Property(e => e.MemberVip).HasColumnName("member_vip");
            entity.Property(e => e.Notes)
                .HasMaxLength(700)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.OnlineBCode)
                .HasMaxLength(101)
                .IsUnicode(false)
                .HasColumnName("online_b_code");
            entity.Property(e => e.OnlineLud)
                .HasColumnType("datetime")
                .HasColumnName("online_lud");
            entity.Property(e => e.OnlineStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("online_status");
            entity.Property(e => e.PrivateNotes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("private_notes");
            entity.Property(e => e.ServiceCoinsurance).HasColumnName("service_coinsurance");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");
            entity.Property(e => e.VendorName)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("vendor_name");
        });

        modelBuilder.Entity<VPendingReason>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_pending_reasons");

            entity.Property(e => e.Reason)
                .HasMaxLength(80)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI");
        });

        modelBuilder.Entity<VPriceIndex>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_price_index");

            entity.Property(e => e.Cat).HasColumnName("cat");
            entity.Property(e => e.ContractServiceName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("contract_service_name");
            entity.Property(e => e.ContractServiceSerRef).HasColumnName("contract_service_ser_ref");
            entity.Property(e => e.Gov).HasColumnName("gov");
            entity.Property(e => e.Mapped).HasColumnName("mapped");
            entity.Property(e => e.Price).HasColumnName("price");
        });

        modelBuilder.Entity<VRandom>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vRandom");

            entity.Property(e => e.Randval)
                .HasMaxLength(8000)
                .HasColumnName("randval");
        });

        modelBuilder.Entity<VRecommendationService>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Recommendation_services");

            entity.Property(e => e.Area)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ContractServiceDiscount).HasColumnName("contract_service_discount");
            entity.Property(e => e.ContractServiceId).HasColumnName("contract_service_id");
            entity.Property(e => e.ContractServiceName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("contract_service_name");
            entity.Property(e => e.ContractServicePrices).HasColumnName("contract_service_prices");
            entity.Property(e => e.ContractServiceSerRef).HasColumnName("contract_service_ser_ref");
            entity.Property(e => e.Gov)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("last_update_from");
            entity.Property(e => e.OldId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("old_id");
            entity.Property(e => e.VenCat).HasColumnName("ven_cat");
            entity.Property(e => e.VenName)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("ven_name");
            entity.Property(e => e.VendorBranchAddress)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("vendor_branch_address");
            entity.Property(e => e.VendorBranchDate)
                .HasColumnType("datetime")
                .HasColumnName("vendor_branch_date");
            entity.Property(e => e.VendorBranchLatitude)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("vendor_branch_latitude");
            entity.Property(e => e.VendorBranchLongitude)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("vendor_branch_longitude");
            entity.Property(e => e.VendorBranchMapUrl)
                .HasMaxLength(500)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("vendor_branch_map_url");
            entity.Property(e => e.VendorBranchName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("vendor_branch_name");
            entity.Property(e => e.VendorBranchSerial).HasColumnName("vendor_branch_serial");
            entity.Property(e => e.VendorBranchStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("vendor_branch_status");
            entity.Property(e => e.VendorBranchTele)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("vendor_branch_tele");
            entity.Property(e => e.VendorBranchTele2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("vendor_branch_tele2");
            entity.Property(e => e.VendorBranchareaId).HasColumnName("vendor_brancharea_id");
            entity.Property(e => e.VendorContractEndDate)
                .HasColumnType("datetime")
                .HasColumnName("vendor_contract_end_date");
            entity.Property(e => e.VendorEmail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("vendor_email");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");
        });

        modelBuilder.Entity<VReimpWorklist>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Reimp_worklist");

            entity.Property(e => e.BatchCost).HasColumnName("batch_cost");
            entity.Property(e => e.BatchFinancialFlag).HasColumnName("batch_financial_flag");
            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("batch_id");
            entity.Property(e => e.BatchInvoiceNumber).HasColumnName("batch_invoice_number");
            entity.Property(e => e.BatchMedicalFlag).HasColumnName("batch_medical_flag");
            entity.Property(e => e.BatchReceivedDate).HasColumnName("batch_received_date");
            entity.Property(e => e.BatchStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("batch_status");
            entity.Property(e => e.ContractCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("contract_code");
            entity.Property(e => e.Credit).HasColumnName("credit");
            entity.Property(e => e.CurrentStep)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("current_step");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("customer_name");
            entity.Property(e => e.Debtindays).HasColumnName("debtindays");
            entity.Property(e => e.Dis).HasColumnName("dis");
            entity.Property(e => e.MainCustomerId).HasColumnName("main_customer_id");
            entity.Property(e => e.MedicallyRevisedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("medically_revised_by");
            entity.Property(e => e.MemberName)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("member_name");
            entity.Property(e => e.ND).HasColumnName("n_d");
            entity.Property(e => e.Net).HasColumnName("net");
            entity.Property(e => e.Paid).HasColumnType("numeric(38, 3)");
            entity.Property(e => e.PayInfo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Pay_info");
            entity.Property(e => e.XtraValue).HasColumnName("xtra_value");
        });

        modelBuilder.Entity<VScannedQr>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_scannedQr");

            entity.Property(e => e.ActId)
                .HasColumnType("numeric(12, 0)")
                .HasColumnName("act_id");
            entity.Property(e => e.CareItemName)
                .HasMaxLength(85)
                .IsUnicode(false)
                .HasColumnName("care_item_name");
            entity.Property(e => e.Member)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("member");
            entity.Property(e => e.MemberName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("member_name");
            entity.Property(e => e.Note)
                .HasMaxLength(18)
                .IsUnicode(false)
                .HasColumnName("note");
            entity.Property(e => e.Rcode)
                .HasColumnType("numeric(12, 0)")
                .HasColumnName("rcode");
            entity.Property(e => e.Serial).HasColumnName("serial");
            entity.Property(e => e.VendorName)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("vendor_name");
        });

        modelBuilder.Entity<VSearchAllMember>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_search_all_members");

            entity.Property(e => e.CustomerContractEndDate)
                .HasColumnType("datetime")
                .HasColumnName("customer_contract_end_date");
            entity.Property(e => e.CustomerContractId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("customer_contract_id");
            entity.Property(e => e.CustomerContractStartDate)
                .HasColumnType("datetime")
                .HasColumnName("customer_contract_start_date");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_name");
            entity.Property(e => e.CustomerStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_status");
            entity.Property(e => e.MStatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("m_status");
            entity.Property(e => e.MainCustomerId).HasColumnName("main_customer_id");
            entity.Property(e => e.MemberId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("member_id");
            entity.Property(e => e.MemberName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("member_name");
            entity.Property(e => e.MemberStatues)
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("member_statues");
            entity.Property(e => e.PlanCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("plan_code");
        });

        modelBuilder.Entity<VSearchBillsCustomer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_search_bills_customers");

            entity.Property(e => e.BillDate)
                .HasColumnType("datetime")
                .HasColumnName("BILL_DATE");
            entity.Property(e => e.BillId)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("BILL_ID");
            entity.Property(e => e.BillSerial)
                .HasColumnType("numeric(12, 0)")
                .HasColumnName("Bill_Serial");
            entity.Property(e => e.BillStatus).HasColumnName("BILL_STATUS");
            entity.Property(e => e.Col1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("col1");
            entity.Property(e => e.Col11)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("col1_");
            entity.Property(e => e.Col2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("col2");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("customer_name");
            entity.Property(e => e.Insurer)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("insurer");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LAST_UPDATE_BY");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATE_DATE");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LAST_UPDATE_FROM");
            entity.Property(e => e.PaymentValue)
                .HasColumnType("numeric(12, 3)")
                .HasColumnName("PAYMENT_VALUE");
        });

        modelBuilder.Entity<VServicesAnalysis>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_services_analysis");

            entity.Property(e => e.AreaNameAr)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("area_name_ar");
            entity.Property(e => e.AvgPrice).HasColumnName("avg_price");
            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("batch_id");
            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("category");
            entity.Property(e => e.Gov)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MaxPrice).HasColumnName("max_price");
            entity.Property(e => e.MinPrice).HasColumnName("min_price");
            entity.Property(e => e.ServiceCount).HasColumnName("service_count");
            entity.Property(e => e.ServiceDate)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("service_date");
            entity.Property(e => e.StandServiceName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("stand_service_name");
            entity.Property(e => e.VendorName)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("vendor_name");
        });

        modelBuilder.Entity<VSrvAnalisi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_srv_analisis");

            entity.Property(e => e.Area)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CardType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Card_type");
            entity.Property(e => e.CoPayment).HasColumnName("co_payment");
            entity.Property(e => e.CompanyId).HasColumnName("Company_id");
            entity.Property(e => e.ContractDiscount).HasColumnName("Contract_discount");
            entity.Property(e => e.Gov)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.InvId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Inv_id");
            entity.Property(e => e.MedicalDiscount).HasColumnName("Medical_discount");
            entity.Property(e => e.MemberBirthday).HasColumnName("Member_birthday");
            entity.Property(e => e.MemberId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Member_id");
            entity.Property(e => e.PaymentDate)
                .HasColumnType("datetime")
                .HasColumnName("Payment_date");
            entity.Property(e => e.PolicyId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Policy_id");
            entity.Property(e => e.PolicyStartDate)
                .HasColumnType("datetime")
                .HasColumnName("Policy_start_date");
            entity.Property(e => e.PolicyType)
                .HasMaxLength(203)
                .IsUnicode(false)
                .HasColumnName("Policy_type");
            entity.Property(e => e.ReceivedDate).HasColumnName("Received_date");
            entity.Property(e => e.ServiceDate).HasColumnName("Service_date");
            entity.Property(e => e.ServiceItem)
                .HasMaxLength(85)
                .IsUnicode(false)
                .HasColumnName("Service_item");
            entity.Property(e => e.ServiceType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Service_Type");
            entity.Property(e => e.Type)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.VendorName)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("vendor_name");
        });

        modelBuilder.Entity<VSubscriptionAnalysis>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_subscription_analysis");

            entity.Property(e => e.CardType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Card_type");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("Customer_name");
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.InstallmentsNumber).HasColumnName("Installments_number");
            entity.Property(e => e.MemberId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Member_id");
            entity.Property(e => e.PolicyId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Policy_id");
            entity.Property(e => e.PolicyStartDate)
                .HasColumnType("datetime")
                .HasColumnName("Policy_start_date");
            entity.Property(e => e.PolicyType)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Policy_type");
            entity.Property(e => e.SubscriptionDate)
                .HasColumnType("datetime")
                .HasColumnName("Subscription_date");
        });

        modelBuilder.Entity<VSudanGroupsSummary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_sudan_groups_summary");

            entity.Property(e => e.CollectionsEgp).HasColumnName("collections_egp");
            entity.Property(e => e.ContractCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("contract_code");
            entity.Property(e => e.GroupStart)
                .HasColumnType("datetime")
                .HasColumnName("group_start");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ValEgp).HasColumnName("val_egp");
        });

        modelBuilder.Entity<VSudanMemberConsumption>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_sudan_member_consumption");

            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("batch_id");
            entity.Property(e => e.CareItemName)
                .HasMaxLength(85)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("care_item_name");
            entity.Property(e => e.CoPayment).HasColumnName("co_payment");
            entity.Property(e => e.ContractCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("contract_code");
            entity.Property(e => e.ContractDis).HasColumnName("contract_dis");
            entity.Property(e => e.CustomerContractCategory)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("customer_contract_category");
            entity.Property(e => e.InvId).HasColumnName("inv_id");
            entity.Property(e => e.MemberCustomerId).HasColumnName("member_customer_id");
            entity.Property(e => e.MemberId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("member_id");
            entity.Property(e => e.MemberName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("member_name");
            entity.Property(e => e.Net).HasColumnName("net");
            entity.Property(e => e.Notified).HasColumnName("notified");
            entity.Property(e => e.RevDis).HasColumnName("Rev_dis");
            entity.Property(e => e.Serial).HasColumnName("serial");
            entity.Property(e => e.ServiceDate).HasColumnName("service_date");
            entity.Property(e => e.ServiceName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("service_name");
            entity.Property(e => e.Value).HasColumnName("value");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");
            entity.Property(e => e.VendorName)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("vendor_name");
        });

        modelBuilder.Entity<VUsedPharma>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_used_pharma");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Availability)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("availability");
            entity.Property(e => e.DoseForm)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("dose_form");
            entity.Property(e => e.DoseUnitNo).HasColumnName("dose_unit_no");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.LastPriceDate)
                .HasColumnType("datetime")
                .HasColumnName("last_price_date");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LAST_UPDATE_BY");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATE_DATE");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Notes)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.PriceUpdateId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("price_update_id");
            entity.Property(e => e.Source)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("source");
            entity.Property(e => e.SubUnitNo).HasColumnName("sub_unit_no");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.UnitSale)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("unit_sale");
        });

        modelBuilder.Entity<VUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_users");

            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.Id)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.LockoutEnd).HasColumnType("datetime");
            entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");
            entity.Property(e => e.MemberId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Member_id");
            entity.Property(e => e.NormalizedEmail).HasMaxLength(256);
            entity.Property(e => e.NormalizedUserName).HasMaxLength(256);
            entity.Property(e => e.UserGroup)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.UserName).HasMaxLength(256);
        });

        modelBuilder.Entity<VVendorBranch>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_vendor_branches");

            entity.Property(e => e.AreaNameAr)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("area_name_ar");
            entity.Property(e => e.CatName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("cat_name");
            entity.Property(e => e.CatSort).HasColumnName("cat_sort");
            entity.Property(e => e.Class)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI");
            entity.Property(e => e.Gov)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("last_update_from");
            entity.Property(e => e.OldId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("old_id");
            entity.Property(e => e.Phones)
                .HasMaxLength(41)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.VendorBranchAddress)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("vendor_branch_address");
            entity.Property(e => e.VendorBranchDate)
                .HasColumnType("datetime")
                .HasColumnName("vendor_branch_date");
            entity.Property(e => e.VendorBranchLatitude)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("vendor_branch_latitude");
            entity.Property(e => e.VendorBranchLongitude)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("vendor_branch_longitude");
            entity.Property(e => e.VendorBranchMapUrl)
                .HasMaxLength(500)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("vendor_branch_map_url");
            entity.Property(e => e.VendorBranchName)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("vendor_branch_name");
            entity.Property(e => e.VendorBranchSerial).HasColumnName("vendor_branch_serial");
            entity.Property(e => e.VendorBranchStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("vendor_branch_status");
            entity.Property(e => e.VendorBranchTele)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("vendor_branch_tele");
            entity.Property(e => e.VendorBranchTele2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("vendor_branch_tele2");
            entity.Property(e => e.VendorBranchareaId).HasColumnName("vendor_brancharea_id");
            entity.Property(e => e.VendorEmail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("vendor_email");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");
            entity.Property(e => e.VendorName)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("vendor_name");
        });

        modelBuilder.Entity<VVendorBranchesMob>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_vendor_branches_mob");

            entity.Property(e => e.AreaNameAr)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("area_name_ar");
            entity.Property(e => e.CatCode).HasColumnName("Cat_code");
            entity.Property(e => e.CatName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("Cat_name");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("last_update_from");
            entity.Property(e => e.SubCatCode).HasColumnName("subCat_code");
            entity.Property(e => e.SubCatName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("subCat_name");
            entity.Property(e => e.VendorBranchAddress)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("vendor_branch_address");
            entity.Property(e => e.VendorBranchDate)
                .HasColumnType("datetime")
                .HasColumnName("vendor_branch_date");
            entity.Property(e => e.VendorBranchLatitude)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("vendor_branch_latitude");
            entity.Property(e => e.VendorBranchLongitude)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("vendor_branch_longitude");
            entity.Property(e => e.VendorBranchMapUrl)
                .HasMaxLength(500)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("vendor_branch_map_url");
            entity.Property(e => e.VendorBranchName)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("vendor_branch_name");
            entity.Property(e => e.VendorBranchSerial).HasColumnName("vendor_branch_serial");
            entity.Property(e => e.VendorBranchStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("vendor_branch_status");
            entity.Property(e => e.VendorBranchTele)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("vendor_branch_tele");
            entity.Property(e => e.VendorBranchTele2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("vendor_branch_tele2");
            entity.Property(e => e.VendorBranchareaId).HasColumnName("vendor_brancharea_id");
            entity.Property(e => e.VendorCarecard).HasColumnName("vendor_carecard");
            entity.Property(e => e.VendorCarecardNotes)
                .HasMaxLength(150)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("vendor_carecard_notes");
            entity.Property(e => e.VendorEmail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("vendor_email");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("vendor_id");
            entity.Property(e => e.VendorName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("vendor_name");
        });

        modelBuilder.Entity<VVendorCurrentService>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_vendor_current_services");

            entity.Property(e => e.ContractServiceId).HasColumnName("contract_service_id");
            entity.Property(e => e.ContractServiceName)
                .IsUnicode(false)
                .HasColumnName("contract_service_name");
            entity.Property(e => e.ContractServicePrices).HasColumnName("contract_service_prices");
            entity.Property(e => e.ContractServiceSerRef).HasColumnName("contract_service_ser_ref");
            entity.Property(e => e.StandServiceAvailability)
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("stand_service_availability");
            entity.Property(e => e.StandServiceName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("stand_service_name");
            entity.Property(e => e.StandServiceParent).HasColumnName("stand_service_parent");
            entity.Property(e => e.Vid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vid");
        });

        modelBuilder.Entity<VVendorLedger>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_vendor_ledger");

            entity.Property(e => e.ActionCode)
                .HasColumnType("numeric(12, 0)")
                .HasColumnName("action_code");
            entity.Property(e => e.ActionDate)
                .HasColumnType("datetime")
                .HasColumnName("action_date");
            entity.Property(e => e.ActionDescription)
                .HasMaxLength(91)
                .IsUnicode(false)
                .HasColumnName("action_description");
            entity.Property(e => e.ActionEffect).HasColumnName("action_effect");
            entity.Property(e => e.ActionNotes)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("action_notes");
            entity.Property(e => e.ActiontypeCode).HasColumnName("actiontype_code");
            entity.Property(e => e.Debit).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DocNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("doc_no");
            entity.Property(e => e.ExtCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ext_code");
            entity.Property(e => e.SupplierCode)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("SUPPLIER_CODE");
        });

        modelBuilder.Entity<VVendorPayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_vendor_payments");

            entity.Property(e => e.AFees)
                .HasColumnType("numeric(38, 3)")
                .HasColumnName("a_fees");
            entity.Property(e => e.BankCode).HasColumnName("BANK_CODE");
            entity.Property(e => e.FormDate)
                .HasColumnType("datetime")
                .HasColumnName("FORM_DATE");
            entity.Property(e => e.FormNo)
                .HasColumnType("numeric(12, 0)")
                .HasColumnName("FORM_NO");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LAST_UPDATE_BY");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATE_DATE");
            entity.Property(e => e.OcDueDate)
                .HasColumnType("datetime")
                .HasColumnName("OC_DUE_DATE");
            entity.Property(e => e.OcNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OC_NUMBER");
            entity.Property(e => e.OcType).HasColumnName("OC_TYPE");
            entity.Property(e => e.PayDate)
                .HasColumnType("datetime")
                .HasColumnName("PAY_DATE");
            entity.Property(e => e.SbName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SB_name");
            entity.Property(e => e.SpendType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SPEND_type");
            entity.Property(e => e.Tax)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("tax");
            entity.Property(e => e.Val)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("val");
            entity.Property(e => e.VendorCheckBeneficiary)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("vendor_check_beneficiary");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");
            entity.Property(e => e.VendorName)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("vendor_name");
        });

        modelBuilder.Entity<VVendorSearchWeeklyReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_vendor_search_weekly_report");

            entity.Property(e => e.Address)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI");
            entity.Property(e => e.City)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Gov)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.Phones)
                .HasMaxLength(41)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<VVendorService>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_vendor_services");

            entity.Property(e => e.AreaNameAr)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("area_name_ar");
            entity.Property(e => e.CatName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("cat_name");
            entity.Property(e => e.ContractServiceContractCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contract_service_contract_code");
            entity.Property(e => e.Gov)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MainCat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("main_cat");
            entity.Property(e => e.Mapped).HasColumnName("MApped");
            entity.Property(e => e.NotMapped).HasColumnName("NotMApped");
            entity.Property(e => e.ServiceNumber).HasColumnName("Service_number");
            entity.Property(e => e.VendorCategoryId).HasColumnName("vendor_category_id");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");
            entity.Property(e => e.VendorName)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("vendor_name");
        });

        modelBuilder.Entity<VVendorsAdsLink>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_vendors_ads_link");

            entity.Property(e => e.Cat).HasColumnName("cat");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("code");
            entity.Property(e => e.Link)
                .HasMaxLength(93)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("link");
        });

        modelBuilder.Entity<VVendorsAll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_vendors_all");

            entity.Property(e => e.AreaNameAr)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("area_name_ar");
            entity.Property(e => e.CatIndex).HasColumnName("cat_index");
            entity.Property(e => e.CatName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("cat_name");
            entity.Property(e => e.Gov)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.MainCat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("main_cat");
            entity.Property(e => e.Phones)
                .HasMaxLength(62)
                .IsUnicode(false);
            entity.Property(e => e.VendorAddress)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("vendor_address");
            entity.Property(e => e.VendorCarecardNotes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("vendor_carecard_notes");
            entity.Property(e => e.VendorCategoryId).HasColumnName("vendor_category_id");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");
            entity.Property(e => e.VendorMapUrl)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("vendor_map_url");
            entity.Property(e => e.VendorName)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("vendor_name");
            entity.Property(e => e.VendorStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("vendor_status");
            entity.Property(e => e.VendormedcareClass)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("vendormedcare_class");
        });

        modelBuilder.Entity<VVendorsSearch>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_vendors_search");

            entity.Property(e => e.Address)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.BranchId).HasColumnName("branch_id");
            entity.Property(e => e.CarecardText)
                .HasMaxLength(500)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("carecard_text");
            entity.Property(e => e.Cat).HasColumnName("cat");
            entity.Property(e => e.City).HasColumnName("city");
            entity.Property(e => e.CityName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("city_name");
            entity.Property(e => e.Class)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("class");
            entity.Property(e => e.ConsultExp).HasColumnName("consult_exp");
            entity.Property(e => e.ConsultSpe).HasColumnName("consult_spe");
            entity.Property(e => e.Gov).HasColumnName("gov");
            entity.Property(e => e.Id)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.IsCarecard).HasColumnName("is_carecard");
            entity.Property(e => e.Lat)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("lat");
            entity.Property(e => e.Long)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("long");
            entity.Property(e => e.MapLink)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("map_link");
            entity.Property(e => e.Name)
                .HasMaxLength(292)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Parent)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("parent");
            entity.Property(e => e.Phones)
                .HasMaxLength(41)
                .IsUnicode(false)
                .HasColumnName("phones");
            entity.Property(e => e.Spec)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("spec");
            entity.Property(e => e.SubCat).HasColumnName("sub_cat");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");
            entity.Property(e => e.VendorNbe).HasColumnName("vendor_nbe");
            entity.Property(e => e.VipFlag).HasColumnName("vip_flag");
        });

        modelBuilder.Entity<VVendorsSearchAll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_vendors_search_all");

            entity.Property(e => e.AreaNameAr)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("area_name_ar");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("last_update_from");
            entity.Property(e => e.OldId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("old_id");
            entity.Property(e => e.VendorBranchAddress)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("vendor_branch_address");
            entity.Property(e => e.VendorBranchDate)
                .HasColumnType("datetime")
                .HasColumnName("vendor_branch_date");
            entity.Property(e => e.VendorBranchLatitude)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("vendor_branch_latitude");
            entity.Property(e => e.VendorBranchLongitude)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("vendor_branch_longitude");
            entity.Property(e => e.VendorBranchMapUrl)
                .HasMaxLength(500)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("vendor_branch_map_url");
            entity.Property(e => e.VendorBranchName)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("vendor_branch_name");
            entity.Property(e => e.VendorBranchSerial).HasColumnName("vendor_branch_serial");
            entity.Property(e => e.VendorBranchStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("vendor_branch_status");
            entity.Property(e => e.VendorBranchTele)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("vendor_branch_tele");
            entity.Property(e => e.VendorBranchTele2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("vendor_branch_tele2");
            entity.Property(e => e.VendorBranchareaId).HasColumnName("vendor_brancharea_id");
            entity.Property(e => e.VendorEmail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("vendor_email");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");
        });

        modelBuilder.Entity<VWafedMember>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_wafed_members");

            entity.Property(e => e.CaseId).HasColumnName("case_id");
            entity.Property(e => e.CustomerContractId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("customer_contract_id");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("customer_name");
            entity.Property(e => e.MemberId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("member_id");
            entity.Property(e => e.MemberName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("member_name");
            entity.Property(e => e.PlanCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("plan_code");
        });

        modelBuilder.Entity<VWebMember>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_web_members");

            entity.Property(e => e.Birthdate).HasColumnType("datetime");
            entity.Property(e => e.CareItemComment)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CurrencyType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DefaultCustomer)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.ItemComment)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ItemCreatedBy).HasMaxLength(128);
            entity.Property(e => e.ItemCurrency)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.ItemCustomer)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.ItemDate).HasColumnType("datetime");
            entity.Property(e => e.ItemId).HasColumnName("ItemID");
            entity.Property(e => e.ItemName)
                .HasMaxLength(400)
                .IsUnicode(false);
            entity.Property(e => e.ItemNameAr)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasColumnName("ItemName_Ar");
            entity.Property(e => e.ItemNameFr)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasColumnName("ItemName_Fr");
            entity.Property(e => e.ItemStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");
            entity.Property(e => e.MemberCreatedBy).HasMaxLength(128);
            entity.Property(e => e.MemberCustomer)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.MemberId).HasColumnName("MemberID");
            entity.Property(e => e.MemberItemId).HasColumnName("MemberItemID");
            entity.Property(e => e.MemberStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ResposeBy).HasMaxLength(128);
            entity.Property(e => e.StEmpId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("St_EmpID");
            entity.Property(e => e.UserId).HasMaxLength(128);
            entity.Property(e => e.UserName).HasMaxLength(256);
        });

        modelBuilder.Entity<VWorklist>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_worklist");

            entity.Property(e => e.AddedDate)
                .HasColumnType("datetime")
                .HasColumnName("added_date");
            entity.Property(e => e.ApStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("ap_status");
            entity.Property(e => e.ApType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("ap_type");
            entity.Property(e => e.ApprovalDate)
                .HasColumnType("datetime")
                .HasColumnName("approval_date");
            entity.Property(e => e.ApprovalId).HasColumnName("approval_id");
            entity.Property(e => e.ApprovalValue).HasColumnName("approval_value");
            entity.Property(e => e.ContractId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("contract_id");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("customer_name");
            entity.Property(e => e.IsPrinted).HasColumnName("isPrinted");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.MemberCustomer).HasColumnName("member_customer");
            entity.Property(e => e.MemberEip).HasColumnName("member_eip");
            entity.Property(e => e.MemberId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("member_id");
            entity.Property(e => e.MemberName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("member_name");
            entity.Property(e => e.MemberVip).HasColumnName("member_vip");
            entity.Property(e => e.Notes)
                .HasMaxLength(700)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.OnlineBCode)
                .HasMaxLength(101)
                .IsUnicode(false)
                .HasColumnName("online_b_code");
            entity.Property(e => e.OnlineLud)
                .HasColumnType("datetime")
                .HasColumnName("online_lud");
            entity.Property(e => e.OnlineStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("online_status");
            entity.Property(e => e.PrivateNotes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("private_notes");
            entity.Property(e => e.RequestSource)
                .HasMaxLength(16)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("request_source");
            entity.Property(e => e.ServiceCoinsurance).HasColumnName("service_coinsurance");
            entity.Property(e => e.SourceFrom)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("source_from");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");
            entity.Property(e => e.VendorName)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("vendor_name");
        });

        modelBuilder.Entity<VendorArchieve>(entity =>
        {
            entity.HasKey(e => e.VendorArchieveId).HasName("PK_Archive_1");

            entity.ToTable("vendorArchieve");

            entity.Property(e => e.VendorArchieveId).HasColumnName("vendor_archieve_id");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("last_update_from");
            entity.Property(e => e.VendorArchieveFolderPath)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("vendor_archieve_folder_path");
            entity.Property(e => e.VendorArchieveName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("vendor_archieve_name");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");
        });

        modelBuilder.Entity<VendorBranch>(entity =>
        {
            entity.HasKey(e => e.VendorBranchSerial);

            entity.ToTable("vendor_branches", tb =>
                {
                    tb.HasTrigger("InsertBranch");
                    tb.HasTrigger("UpdateBranch");
                });

            entity.Property(e => e.VendorBranchSerial).HasColumnName("vendor_branch_serial");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("last_update_from");
            entity.Property(e => e.OldId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("old_id");
            entity.Property(e => e.VendorBranchAddress)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("vendor_branch_address");
            entity.Property(e => e.VendorBranchDate)
                .HasColumnType("datetime")
                .HasColumnName("vendor_branch_date");
            entity.Property(e => e.VendorBranchLatitude)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("vendor_branch_latitude");
            entity.Property(e => e.VendorBranchLongitude)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("vendor_branch_longitude");
            entity.Property(e => e.VendorBranchMapUrl)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("vendor_branch_map_url");
            entity.Property(e => e.VendorBranchName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("vendor_branch_name");
            entity.Property(e => e.VendorBranchStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("vendor_branch_status");
            entity.Property(e => e.VendorBranchTele)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("vendor_branch_tele");
            entity.Property(e => e.VendorBranchTele2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("vendor_branch_tele2");
            entity.Property(e => e.VendorBranchareaId).HasColumnName("vendor_brancharea_id");
            entity.Property(e => e.VendorEmail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("vendor_email");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");

            entity.HasOne(d => d.VendorBrancharea).WithMany(p => p.VendorBranches)
                .HasForeignKey(d => d.VendorBranchareaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_vendor_branches_areas");

            entity.HasOne(d => d.Vendor).WithMany(p => p.VendorBranches)
                .HasForeignKey(d => d.VendorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_vendor_branches_Vendor_General");
        });

        modelBuilder.Entity<VendorBranchesTemp>(entity =>
        {
            entity.HasKey(e => e.VendorBranchSerial);

            entity.ToTable("vendor_branches_temp");

            entity.Property(e => e.VendorBranchSerial).HasColumnName("vendor_branch_serial");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("last_update_from");
            entity.Property(e => e.OldId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("old_id");
            entity.Property(e => e.VendorBranchAddress)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("vendor_branch_address");
            entity.Property(e => e.VendorBranchDate)
                .HasColumnType("datetime")
                .HasColumnName("vendor_branch_date");
            entity.Property(e => e.VendorBranchLatitude)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("vendor_branch_latitude");
            entity.Property(e => e.VendorBranchLongitude)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("vendor_branch_longitude");
            entity.Property(e => e.VendorBranchMapUrl)
                .HasMaxLength(500)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("vendor_branch_map_url");
            entity.Property(e => e.VendorBranchName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("vendor_branch_name");
            entity.Property(e => e.VendorBranchStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("vendor_branch_status");
            entity.Property(e => e.VendorBranchTele)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("vendor_branch_tele");
            entity.Property(e => e.VendorBranchTele2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("vendor_branch_tele2");
            entity.Property(e => e.VendorBranchareaId).HasColumnName("vendor_brancharea_id");
            entity.Property(e => e.VendorEmail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("vendor_email");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");

            entity.HasOne(d => d.VendorBrancharea).WithMany(p => p.VendorBranchesTemps)
                .HasForeignKey(d => d.VendorBranchareaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_vendor_branches_temp_areas");

            entity.HasOne(d => d.Vendor).WithMany(p => p.VendorBranchesTemps)
                .HasForeignKey(d => d.VendorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_vendor_branches_temp_Vendor_General_temp");
        });

        modelBuilder.Entity<VendorCategory>(entity =>
        {
            entity.HasKey(e => e.VendorCategoryId).HasName("PK_Category");

            entity.ToTable("vendor_category");

            entity.Property(e => e.VendorCategoryId)
                .ValueGeneratedNever()
                .HasColumnName("vendor_category_id");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("last_update_from");
            entity.Property(e => e.OldId).HasColumnName("old_id");
            entity.Property(e => e.SortIndex).HasColumnName("sort_index");
            entity.Property(e => e.VendorCategoryAlphaCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("vendor_category_alpha_code");
            entity.Property(e => e.VendorCategoryName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_category_name");
            entity.Property(e => e.VendorCategoryParent).HasColumnName("vendor_category_parent");
            entity.Property(e => e.VendorCategoryPolicyTax).HasColumnName("vendor_category_policy_tax");

            entity.HasOne(d => d.VendorCategoryParentNavigation).WithMany(p => p.InverseVendorCategoryParentNavigation)
                .HasForeignKey(d => d.VendorCategoryParent)
                .HasConstraintName("FK_vendor_category_vendor_category");
        });

        modelBuilder.Entity<VendorChanged>(entity =>
        {
            entity.HasKey(e => new { e.OldVendor, e.NewVendor });

            entity.ToTable("vendor_changed");

            entity.Property(e => e.OldVendor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("old_vendor");
            entity.Property(e => e.NewVendor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("new_vendor");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_from");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("start_date");

            entity.HasOne(d => d.NewVendorNavigation).WithMany(p => p.VendorChangedNewVendorNavigations)
                .HasForeignKey(d => d.NewVendor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_vendor_changed_Vendor_General1");

            entity.HasOne(d => d.OldVendorNavigation).WithMany(p => p.VendorChangedOldVendorNavigations)
                .HasForeignKey(d => d.OldVendor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_vendor_changed_Vendor_General");
        });

        modelBuilder.Entity<VendorClaim>(entity =>
        {
            entity.HasKey(e => e.ClaimId);

            entity.ToTable("Vendor_Claims");

            entity.Property(e => e.ClaimId).HasColumnName("claim_id");
            entity.Property(e => e.ClaimSerialEnd).HasColumnName("claim_serial_end");
            entity.Property(e => e.ClaimSerialStart).HasColumnName("claim_serial_start");
            entity.Property(e => e.DeleteStatus).HasColumnName("delete_status");
            entity.Property(e => e.DeliveryDate)
                .HasColumnType("datetime")
                .HasColumnName("delivery_date");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("last_update_from");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");

            entity.HasOne(d => d.Vendor).WithMany(p => p.VendorClaims)
                .HasForeignKey(d => d.VendorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Vendor_Claims_Vendor_Claims");
        });

        modelBuilder.Entity<VendorClaimPool>(entity =>
        {
            entity.ToTable("vendor_claim_pool");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");

            entity.HasMany(d => d.Vendors).WithMany(p => p.Pools)
                .UsingEntity<Dictionary<string, object>>(
                    "PoolVendor",
                    r => r.HasOne<VendorGeneral>().WithMany()
                        .HasForeignKey("VendorId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_pool_vendors_Vendor_General"),
                    l => l.HasOne<VendorClaimPool>().WithMany()
                        .HasForeignKey("PoolId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_pool_vendors_vendor_claim_pool"),
                    j =>
                    {
                        j.HasKey("PoolId", "VendorId");
                        j.ToTable("pool_vendors");
                        j.IndexerProperty<int>("PoolId").HasColumnName("pool_id");
                        j.IndexerProperty<string>("VendorId")
                            .HasMaxLength(50)
                            .IsUnicode(false)
                            .HasColumnName("vendor_id");
                    });
        });

        modelBuilder.Entity<VendorContract>(entity =>
        {
            entity.HasKey(e => e.VendorContractId).HasName("PK_Contract");

            entity.ToTable("vendor_contract", tb =>
                {
                    tb.HasTrigger("InsertContract");
                    tb.HasTrigger("UpdateContract");
                });

            entity.Property(e => e.VendorContractId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_contract_id");
            entity.Property(e => e.ConsultNote)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("consult_note");
            entity.Property(e => e.HasConsult).HasColumnName("has_consult");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("last_update_from");
            entity.Property(e => e.PriceListDoc).HasColumnName("priceList_doc");
            entity.Property(e => e.VendorContractAdministrativeDiscount).HasColumnName("vendor_contract_administrative_discount");
            entity.Property(e => e.VendorContractEndDate)
                .HasColumnType("datetime")
                .HasColumnName("vendor_contract_end_date");
            entity.Property(e => e.VendorContractImportedDiscount).HasColumnName("vendor_contract_imported_discount");
            entity.Property(e => e.VendorContractLocalDiscount).HasColumnName("vendor_contract_local_discount");
            entity.Property(e => e.VendorContractName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("vendor_contract_name");
            entity.Property(e => e.VendorContractNotes)
                .HasMaxLength(85)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("vendor_contract_notes");
            entity.Property(e => e.VendorContractStartDate)
                .HasColumnType("datetime")
                .HasColumnName("vendor_contract_start_date");
            entity.Property(e => e.VendorContractVendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_contract_vendor_id");

            entity.HasOne(d => d.PriceListDocNavigation).WithMany(p => p.VendorContracts)
                .HasForeignKey(d => d.PriceListDoc)
                .HasConstraintName("FK_vendor_contract_vendorArchieve");

            entity.HasOne(d => d.VendorContractVendor).WithMany(p => p.VendorContracts)
                .HasForeignKey(d => d.VendorContractVendorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_vendor_contract_Vendor_General");
        });

        modelBuilder.Entity<VendorDoctor>(entity =>
        {
            entity.ToTable("vendor_doctors");

            entity.Property(e => e.Degree)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("degree");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("last_update_from");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.SpecializationId).HasColumnName("specialization_id");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");

            entity.HasOne(d => d.Specialization).WithMany(p => p.VendorDoctors)
                .HasForeignKey(d => d.SpecializationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_vendor_doctors_acms_specialization");

            entity.HasOne(d => d.Vendor).WithMany(p => p.VendorDoctors)
                .HasForeignKey(d => d.VendorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_vendor_doctors_Vendor_General");
        });

        modelBuilder.Entity<VendorFixedService>(entity =>
        {
            entity.HasKey(e => e.FixedServiceId).HasName("PK__Fixed_Se__A3A36DDD994F4848");

            entity.ToTable("Vendor_Fixed_Service");

            entity.Property(e => e.FixedServiceId).HasColumnName("fixed_service_id");
            entity.Property(e => e.FixedServiceName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("fixed_service_name");
            entity.Property(e => e.FixedServicePrice).HasColumnName("fixed_service_price");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("last_update_from");
            entity.Property(e => e.NeqabaId).HasColumnName("neqaba_id");
            entity.Property(e => e.Notes)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.StandServiceRef).HasColumnName("stand_service_ref");

            entity.HasOne(d => d.Neqaba).WithMany(p => p.VendorFixedServices)
                .HasForeignKey(d => d.NeqabaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Fixed_Ser__Neqab__2FDA0782");

            entity.HasOne(d => d.StandServiceRefNavigation).WithMany(p => p.VendorFixedServices)
                .HasForeignKey(d => d.StandServiceRef)
                .HasConstraintName("FK__Fixed_Ser__stand__30CE2BBB");
        });

        modelBuilder.Entity<VendorGeneral>(entity =>
        {
            entity.HasKey(e => e.VendorId).HasName("PK_Institute");

            entity.ToTable("Vendor_General", tb => tb.HasTrigger("UpdateVendor"));

            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");
            entity.Property(e => e.EtaStart).HasColumnName("eta_start");
            entity.Property(e => e.HasEta).HasColumnName("has_eta");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("last_update_from");
            entity.Property(e => e.OldId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("old_id");
            entity.Property(e => e.VendorAddress)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("vendor_address");
            entity.Property(e => e.VendorArea).HasColumnName("vendor_area");
            entity.Property(e => e.VendorCategoryId).HasColumnName("vendor_category_id");
            entity.Property(e => e.VendorCheckBeneficiary)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("vendor_check_beneficiary");
            entity.Property(e => e.VendorClientId).HasColumnName("vendor_client_id");
            entity.Property(e => e.VendorCommercialRecord)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_commercial_record");
            entity.Property(e => e.VendorContractExecutor)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("vendor_contract_executor");
            entity.Property(e => e.VendorCreationDate)
                .HasColumnType("datetime")
                .HasColumnName("vendor_creation_date");
            entity.Property(e => e.VendorEmail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("vendor_email");
            entity.Property(e => e.VendorFax)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("vendor_fax");
            entity.Property(e => e.VendorLatitude)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("vendor_latitude");
            entity.Property(e => e.VendorLongitude)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("vendor_longitude");
            entity.Property(e => e.VendorMapUrl)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("vendor_map_url");
            entity.Property(e => e.VendorName)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("vendor_name");
            entity.Property(e => e.VendorPayPeriod).HasColumnName("vendor_pay_period");
            entity.Property(e => e.VendorStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("vendor_status");
            entity.Property(e => e.VendorStatusDate)
                .HasColumnType("datetime")
                .HasColumnName("vendor_status_date");
            entity.Property(e => e.VendorTax).HasColumnName("vendor_tax");
            entity.Property(e => e.VendorTaxArea)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_tax_area");
            entity.Property(e => e.VendorTaxFile)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("vendor_tax_file");
            entity.Property(e => e.VendorTaxId)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("vendor_tax_id");
            entity.Property(e => e.VendorTele)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("vendor_tele");
            entity.Property(e => e.VendorTele1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("vendor_tele1");
            entity.Property(e => e.VendorTele2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("vendor_tele2");

            entity.HasOne(d => d.VendorAreaNavigation).WithMany(p => p.VendorGenerals)
                .HasForeignKey(d => d.VendorArea)
                .HasConstraintName("FK_Vendor_areas");

            entity.HasOne(d => d.VendorCategory).WithMany(p => p.VendorGenerals)
                .HasForeignKey(d => d.VendorCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Vendor_vendor_category");

            entity.HasOne(d => d.VendorClient).WithMany(p => p.VendorGenerals)
                .HasForeignKey(d => d.VendorClientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Vendor_Clients");

            entity.HasMany(d => d.Categories).WithMany(p => p.Vendors)
                .UsingEntity<Dictionary<string, object>>(
                    "VendorCat",
                    r => r.HasOne<VendorCategory>().WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_vendor_cats_vendor_category"),
                    l => l.HasOne<VendorGeneral>().WithMany()
                        .HasForeignKey("VendorId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_vendor_cats_Vendor_General"),
                    j =>
                    {
                        j.HasKey("VendorId", "CategoryId");
                        j.ToTable("vendor_cats");
                        j.IndexerProperty<string>("VendorId")
                            .HasMaxLength(50)
                            .IsUnicode(false)
                            .HasColumnName("vendor_id");
                        j.IndexerProperty<int>("CategoryId").HasColumnName("category_id");
                    });

            entity.HasMany(d => d.Specializations).WithMany(p => p.Vendors)
                .UsingEntity<Dictionary<string, object>>(
                    "VendorSpcialization",
                    r => r.HasOne<AcmsSpecialization>().WithMany()
                        .HasForeignKey("SpecializationId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_vendor_spcialization_acms_specialization"),
                    l => l.HasOne<VendorGeneral>().WithMany()
                        .HasForeignKey("VendorId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_vendor_spcialization_Vendor_General"),
                    j =>
                    {
                        j.HasKey("VendorId", "SpecializationId");
                        j.ToTable("vendor_spcialization");
                        j.IndexerProperty<string>("VendorId")
                            .HasMaxLength(50)
                            .IsUnicode(false)
                            .HasColumnName("vendor_id");
                        j.IndexerProperty<int>("SpecializationId").HasColumnName("specialization_id");
                    });
        });

        modelBuilder.Entity<VendorGeneralTemp>(entity =>
        {
            entity.HasKey(e => e.VendorId);

            entity.ToTable("Vendor_General_temp");

            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");
            entity.Property(e => e.EtaStart).HasColumnName("eta_start");
            entity.Property(e => e.HasEta).HasColumnName("has_eta");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("last_update_from");
            entity.Property(e => e.OldId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("old_id");
            entity.Property(e => e.VendorAddress)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("vendor_address");
            entity.Property(e => e.VendorArea).HasColumnName("vendor_area");
            entity.Property(e => e.VendorCategoryId).HasColumnName("vendor_category_id");
            entity.Property(e => e.VendorCheckBeneficiary)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("vendor_check_beneficiary");
            entity.Property(e => e.VendorClientId).HasColumnName("vendor_client_id");
            entity.Property(e => e.VendorCommercialRecord)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_commercial_record");
            entity.Property(e => e.VendorContractExecutor)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("vendor_contract_executor");
            entity.Property(e => e.VendorCreationDate)
                .HasColumnType("datetime")
                .HasColumnName("vendor_creation_date");
            entity.Property(e => e.VendorEmail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("vendor_email");
            entity.Property(e => e.VendorFax)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("vendor_fax");
            entity.Property(e => e.VendorLatitude)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("vendor_latitude");
            entity.Property(e => e.VendorLongitude)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("vendor_longitude");
            entity.Property(e => e.VendorMapUrl)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("vendor_map_url");
            entity.Property(e => e.VendorName)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("vendor_name");
            entity.Property(e => e.VendorPayPeriod).HasColumnName("vendor_pay_period");
            entity.Property(e => e.VendorStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("vendor_status");
            entity.Property(e => e.VendorStatusDate)
                .HasColumnType("datetime")
                .HasColumnName("vendor_status_date");
            entity.Property(e => e.VendorTax).HasColumnName("vendor_tax");
            entity.Property(e => e.VendorTaxArea)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_tax_area");
            entity.Property(e => e.VendorTaxFile)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("vendor_tax_file");
            entity.Property(e => e.VendorTaxId)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("vendor_tax_id");
            entity.Property(e => e.VendorTele)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("vendor_tele");
            entity.Property(e => e.VendorTele1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("vendor_tele1");
            entity.Property(e => e.VendorTele2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("vendor_tele2");

            entity.HasOne(d => d.VendorAreaNavigation).WithMany(p => p.VendorGeneralTemps)
                .HasForeignKey(d => d.VendorArea)
                .HasConstraintName("FK_Vendor_General_temp_areas");

            entity.HasOne(d => d.VendorCategory).WithMany(p => p.VendorGeneralTemps)
                .HasForeignKey(d => d.VendorCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Vendor_General_temp_vendor_category");
        });

        modelBuilder.Entity<VendorLog>(entity =>
        {
            entity.HasKey(e => e.LogId);

            entity.ToTable("Vendor_log");

            entity.Property(e => e.LogId).HasColumnName("log_id");
            entity.Property(e => e.ActionId).HasColumnName("action_id");
            entity.Property(e => e.ChronicDateFrom)
                .HasColumnType("datetime")
                .HasColumnName("chronic_date_from");
            entity.Property(e => e.ChronicDateTo)
                .HasColumnType("datetime")
                .HasColumnName("chronic_date_to");
            entity.Property(e => e.CustomerCode).HasColumnName("customer_code");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_from");
            entity.Property(e => e.Note)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("note");

            entity.HasOne(d => d.Action).WithMany(p => p.VendorLogs)
                .HasForeignKey(d => d.ActionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Vendor_log_actions");

            entity.HasOne(d => d.CustomerCodeNavigation).WithMany(p => p.VendorLogs)
                .HasForeignKey(d => d.CustomerCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Vendor_log_Customers");
        });

        modelBuilder.Entity<VendorMedCare>(entity =>
        {
            entity.ToTable("Vendor_MedCare", tb => tb.HasTrigger("InsertVendor"));

            entity.Property(e => e.VendormedcareId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendormedcare_id");
            entity.Property(e => e.BankName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("bank_name");
            entity.Property(e => e.BankName2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("bank_name2");
            entity.Property(e => e.BatchEnabled).HasColumnName("batch_enabled");
            entity.Property(e => e.HaveLabRad).HasColumnName("have_lab_rad");
            entity.Property(e => e.OpeningBalance).HasColumnName("opening_balance");
            entity.Property(e => e.ServiceCash).HasColumnName("service_cash");
            entity.Property(e => e.VendorAdvertiseFlag).HasColumnName("vendor_advertise_flag");
            entity.Property(e => e.VendorBankAccountNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("vendor_bank_account_number");
            entity.Property(e => e.VendorBankAccountNumber2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("vendor_bank_account_number2");
            entity.Property(e => e.VendorCarecard).HasColumnName("vendor_carecard");
            entity.Property(e => e.VendorCarecardNotes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("vendor_carecard_notes");
            entity.Property(e => e.VendorFinanNotes)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("vendor_finan_notes");
            entity.Property(e => e.VendorNbe).HasColumnName("vendor_nbe");
            entity.Property(e => e.VendorNbeNotes).HasColumnName("vendor_nbe_notes");
            entity.Property(e => e.VendorNotes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("vendor_notes");
            entity.Property(e => e.VendorOnlineUsername)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("vendor_online_username");
            entity.Property(e => e.VendorVip).HasColumnName("vendor_vip");
            entity.Property(e => e.VendormedcareClass)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("vendormedcare_class");
            entity.Property(e => e.Website)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.Vendormedcare).WithOne(p => p.VendorMedCare)
                .HasForeignKey<VendorMedCare>(d => d.VendormedcareId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Vendor_MedCare_Vendor_General1");
        });

        modelBuilder.Entity<VendorMedCareTemp>(entity =>
        {
            entity.HasKey(e => e.VendormedcareId);

            entity.ToTable("Vendor_MedCare_temp");

            entity.Property(e => e.VendormedcareId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendormedcare_id");
            entity.Property(e => e.BankName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("bank_name");
            entity.Property(e => e.BankName2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("bank_name2");
            entity.Property(e => e.BatchEnabled).HasColumnName("batch_enabled");
            entity.Property(e => e.HaveLabRad).HasColumnName("have_lab_rad");
            entity.Property(e => e.OpeningBalance).HasColumnName("opening_balance");
            entity.Property(e => e.ServiceCash).HasColumnName("service_cash");
            entity.Property(e => e.VendorAdvertiseFlag).HasColumnName("vendor_advertise_flag");
            entity.Property(e => e.VendorBankAccountNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("vendor_bank_account_number");
            entity.Property(e => e.VendorBankAccountNumber2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("vendor_bank_account_number2");
            entity.Property(e => e.VendorCarecard).HasColumnName("vendor_carecard");
            entity.Property(e => e.VendorCarecardNotes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("vendor_carecard_notes");
            entity.Property(e => e.VendorFinanNotes)
                .HasMaxLength(600)
                .IsUnicode(false)
                .HasColumnName("vendor_finan_notes");
            entity.Property(e => e.VendorNbe).HasColumnName("vendor_nbe");
            entity.Property(e => e.VendorNbeNotes).HasColumnName("vendor_nbe_notes");
            entity.Property(e => e.VendorNotes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("vendor_notes");
            entity.Property(e => e.VendorOnlineUsername)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("vendor_online_username");
            entity.Property(e => e.VendorVip).HasColumnName("vendor_vip");
            entity.Property(e => e.VendormedcareClass)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("vendormedcare_class");
            entity.Property(e => e.Website)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.Vendormedcare).WithOne(p => p.VendorMedCareTemp)
                .HasForeignKey<VendorMedCareTemp>(d => d.VendormedcareId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Vendor_MedCare_temp_Vendor_General_temp");
        });

        modelBuilder.Entity<VendorOnlineUser>(entity =>
        {
            entity.HasKey(e => e.OnlineUserId);

            entity.ToTable("vendor_online_users");

            entity.HasIndex(e => e.OnlineUserId, "IX_vendor_online_users").IsUnique();

            entity.Property(e => e.OnlineUserId).HasColumnName("online_user_id");
            entity.Property(e => e.OnlineUserAddress)
                .HasMaxLength(150)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("online_user_address");
            entity.Property(e => e.OnlineUserCreationDate)
                .HasColumnType("datetime")
                .HasColumnName("online_user_creationDate");
            entity.Property(e => e.OnlineUserEmail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("online_user_email");
            entity.Property(e => e.OnlineUserFirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("online_user_firstName");
            entity.Property(e => e.OnlineUserJoiningDate).HasColumnName("online_user_joiningDate");
            entity.Property(e => e.OnlineUserLang)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("online_user_lang");
            entity.Property(e => e.OnlineUserLastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("online_user_lastName");
            entity.Property(e => e.OnlineUserMobile)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("online_user_mobile");
            entity.Property(e => e.OnlineUserOffice).HasColumnName("online_user_office");
            entity.Property(e => e.OnlineUserPassword)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("online_user_password");
            entity.Property(e => e.OnlineUserProfilePicPath)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("online_user_profile_pic_path");
            entity.Property(e => e.OnlineUserRoleId).HasColumnName("online_user_role_id");
            entity.Property(e => e.OnlineUserStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("online_user_status");
            entity.Property(e => e.OnlineUserTheme)
                .HasMaxLength(150)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("online_user_theme");
            entity.Property(e => e.OnlineUserUserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("online_user_userName");
            entity.Property(e => e.OnlineUserVType)
                .HasMaxLength(8)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("online_user_v_type");
            entity.Property(e => e.OnlineUserVendor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("online_user_vendor");

            entity.HasOne(d => d.OnlineUserVendorNavigation).WithMany(p => p.VendorOnlineUsers)
                .HasForeignKey(d => d.OnlineUserVendor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_online_users_Vendor_General");
        });

        modelBuilder.Entity<VendorRating>(entity =>
        {
            entity.HasKey(e => e.VendorRateId);

            entity.ToTable("VendorRating");

            entity.Property(e => e.VendorRateId).HasColumnName("vendor_rate_id");
            entity.Property(e => e.MemberId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("member_id");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("phone_number");
            entity.Property(e => e.Rate).HasColumnName("rate");
            entity.Property(e => e.RatingDate).HasColumnName("rating_date");
            entity.Property(e => e.ReteNote)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("rete_note");
            entity.Property(e => e.VendorBranchSerial).HasColumnName("vendor_branch_serial");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");

            entity.HasOne(d => d.Member).WithMany(p => p.VendorRatings)
                .HasForeignKey(d => d.MemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VendorRating_Members");

            entity.HasOne(d => d.VendorBranchSerialNavigation).WithMany(p => p.VendorRatings)
                .HasForeignKey(d => d.VendorBranchSerial)
                .HasConstraintName("FK_VendorRating_vendor_branches");

            entity.HasOne(d => d.Vendor).WithMany(p => p.VendorRatings)
                .HasForeignKey(d => d.VendorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VendorRating_Vendors");
        });

        modelBuilder.Entity<VendorShift>(entity =>
        {
            entity.HasKey(e => e.ShiftId).HasName("PK_WorkingHours");

            entity.ToTable("vendor_shifts");

            entity.Property(e => e.ShiftId).HasColumnName("shift_id");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("last_update_from");
            entity.Property(e => e.ShiftDays).HasColumnName("shift_days");
            entity.Property(e => e.ShiftEnd).HasColumnName("shift_end");
            entity.Property(e => e.ShiftStart).HasColumnName("shift_start");
            entity.Property(e => e.VendorBranchSerial).HasColumnName("vendor_branch_serial");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");

            entity.HasOne(d => d.ShiftDaysNavigation).WithMany(p => p.VendorShifts)
                .HasForeignKey(d => d.ShiftDays)
                .HasConstraintName("FK_vendor_shifts_days_of_the_week");

            entity.HasOne(d => d.VendorBranchSerialNavigation).WithMany(p => p.VendorShifts)
                .HasForeignKey(d => d.VendorBranchSerial)
                .HasConstraintName("FK_vendor_shifts_vendor_branches");

            entity.HasOne(d => d.Vendor).WithMany(p => p.VendorShifts)
                .HasForeignKey(d => d.VendorId)
                .HasConstraintName("FK_vendor_shifts_Vendor");
        });

        modelBuilder.Entity<VendorShiftsTemp>(entity =>
        {
            entity.HasKey(e => e.ShiftId);

            entity.ToTable("vendor_shifts_temp");

            entity.Property(e => e.ShiftId).HasColumnName("shift_id");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("last_update_from");
            entity.Property(e => e.ShiftDays).HasColumnName("shift_days");
            entity.Property(e => e.ShiftEnd).HasColumnName("shift_end");
            entity.Property(e => e.ShiftStart).HasColumnName("shift_start");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");

            entity.HasOne(d => d.ShiftDaysNavigation).WithMany(p => p.VendorShiftsTemps)
                .HasForeignKey(d => d.ShiftDays)
                .HasConstraintName("FK_vendor_shifts_temp_days_of_the_week");

            entity.HasOne(d => d.Vendor).WithMany(p => p.VendorShiftsTemps)
                .HasForeignKey(d => d.VendorId)
                .HasConstraintName("FK_vendor_shifts_temp_Vendor_General");
        });

        modelBuilder.Entity<VendorSpecialrole>(entity =>
        {
            entity.HasKey(e => new { e.VendorId, e.Exception });

            entity.ToTable("vendor_specialrole");

            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");
            entity.Property(e => e.Exception)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("exception");

            entity.HasOne(d => d.Vendor).WithMany(p => p.VendorSpecialroles)
                .HasForeignKey(d => d.VendorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_vendor_specialrole_Vendor_General");
        });

        modelBuilder.Entity<VendorStatusMonitor>(entity =>
        {
            entity.HasKey(e => e.StatusMonitorId);

            entity.ToTable("vendor_status_monitor");

            entity.Property(e => e.StatusMonitorId).HasColumnName("status_monitor_id");
            entity.Property(e => e.ActionId).HasColumnName("action_id");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_from");
            entity.Property(e => e.Note)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("note");
            entity.Property(e => e.StatusMonitorBranchId).HasColumnName("status_monitor_branch_id");
            entity.Property(e => e.StatusMonitorNewStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("status_monitor_new_status");
            entity.Property(e => e.StatusMonitorStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("status_monitor_status");
            entity.Property(e => e.StatusMonitorStatusDate)
                .HasColumnType("datetime")
                .HasColumnName("status_monitor_status_date");
            entity.Property(e => e.StatusMonitorVendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("status_monitor_vendor_id");

            entity.HasOne(d => d.Action).WithMany(p => p.VendorStatusMonitors)
                .HasForeignKey(d => d.ActionId)
                .HasConstraintName("FK_vendor_status_monitor_actions");

            entity.HasOne(d => d.StatusMonitorBranch).WithMany(p => p.VendorStatusMonitors)
                .HasForeignKey(d => d.StatusMonitorBranchId)
                .HasConstraintName("FK_vendor_status_monitor_vendor_branches");

            entity.HasOne(d => d.StatusMonitorVendor).WithMany(p => p.VendorStatusMonitors)
                .HasForeignKey(d => d.StatusMonitorVendorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_vendor_status_monitor_Vendor_General");
        });

        modelBuilder.Entity<VendorsCopayment>(entity =>
        {
            entity.HasKey(e => new { e.PlanId, e.ItemId, e.VendorId });

            entity.ToTable("Vendors_copayments");

            entity.Property(e => e.PlanId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("plan_id");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");
            entity.Property(e => e.Copayment).HasColumnName("copayment");
            entity.Property(e => e.Enabled).HasColumnName("enabled");
            entity.Property(e => e.Isallowed).HasColumnName("isallowed");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.VendorCategoryId).HasColumnName("vendor_category_id");

            entity.HasOne(d => d.VendorCategory).WithMany(p => p.VendorsCopayments)
                .HasForeignKey(d => d.VendorCategoryId)
                .HasConstraintName("FK_Vendors_copayments_vendor_category");

            entity.HasOne(d => d.Vendor).WithMany(p => p.VendorsCopayments)
                .HasForeignKey(d => d.VendorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Vendors_copayments_Vendor_General");

            entity.HasOne(d => d.PlanItem).WithMany(p => p.VendorsCopayments)
                .HasForeignKey(d => new { d.PlanId, d.ItemId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Vendors_copayments_PlanItems");
        });

        modelBuilder.Entity<VisitDiagnosis>(entity =>
        {
            entity.HasKey(e => new { e.DiagnoseId, e.VisitId });

            entity.ToTable("visit_diagnoses");

            entity.Property(e => e.DiagnoseId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("diagnose_id");
            entity.Property(e => e.VisitId).HasColumnName("visit_id");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Type)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("type");

            entity.HasOne(d => d.Diagnose).WithMany(p => p.VisitDiagnoses)
                .HasForeignKey(d => d.DiagnoseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_visit_diagnoses_visit_diagnoses");

            entity.HasOne(d => d.Visit).WithMany(p => p.VisitDiagnoses)
                .HasForeignKey(d => d.VisitId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_visit_diagnoses_wafdeen_visits");
        });

        modelBuilder.Entity<WafdeenMashEmp>(entity =>
        {
            entity.HasKey(e => e.EmpId);

            entity.ToTable("Wafdeen_mash_emp");

            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.EmpName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("emp_name");
            entity.Property(e => e.EmpStatus).HasColumnName("emp_status");
            entity.Property(e => e.UserId)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.WafdeenMashEmps)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Wafdeen_mash_emp_AspNetUsers");
        });

        modelBuilder.Entity<WafdeenMembersSchedule>(entity =>
        {
            entity.HasKey(e => e.ScheduleId).HasName("PK__wafdeenM__C46A8A6F832B20E7");

            entity.ToTable("wafdeenMembers_schedule");

            entity.Property(e => e.ScheduleId).HasColumnName("schedule_id");
            entity.Property(e => e.Comment).HasColumnName("comment");
            entity.Property(e => e.ConfirmDate)
                .HasColumnType("datetime")
                .HasColumnName("confirm_date");
            entity.Property(e => e.IsDone).HasColumnName("is_done");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_from");
            entity.Property(e => e.MemberId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("member_id");
            entity.Property(e => e.ResponsibleEmp).HasColumnName("responsible_emp");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.TaskDate).HasColumnName("task_date");
            entity.Property(e => e.TaskTime).HasColumnName("task_time");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");
            entity.Property(e => e.VisitId).HasColumnName("visit_id");

            entity.HasOne(d => d.Member).WithMany(p => p.WafdeenMembersSchedules)
                .HasForeignKey(d => d.MemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_member_id_schedule");

            entity.HasOne(d => d.ResponsibleEmpNavigation).WithMany(p => p.WafdeenMembersSchedules)
                .HasForeignKey(d => d.ResponsibleEmp)
                .HasConstraintName("FK_responsible_emp_id");

            entity.HasOne(d => d.Vendor).WithMany(p => p.WafdeenMembersSchedules)
                .HasForeignKey(d => d.VendorId)
                .HasConstraintName("FK_vendor_id");

            entity.HasOne(d => d.Visit).WithMany(p => p.WafdeenMembersSchedules)
                .HasForeignKey(d => d.VisitId)
                .HasConstraintName("FK_visitId");
        });

        modelBuilder.Entity<WafdeenVisit>(entity =>
        {
            entity.HasKey(e => e.CaseId);

            entity.ToTable("wafdeen_visits");

            entity.Property(e => e.CaseId).HasColumnName("case_id");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.ArrivalDate)
                .HasColumnType("datetime")
                .HasColumnName("arrival_date");
            entity.Property(e => e.CaseComplain)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("case_complain");
            entity.Property(e => e.CaseStatus).HasColumnName("case_status");
            entity.Property(e => e.CharityNote)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("charity_note");
            entity.Property(e => e.CharityPercentage).HasColumnName("charity_percentage");
            entity.Property(e => e.ContractId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("contract_id");
            entity.Property(e => e.FinalDiagnose)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("final_diagnose");
            entity.Property(e => e.HospitalEntryDate)
                .HasColumnType("datetime")
                .HasColumnName("hospital_entry_date");
            entity.Property(e => e.HospitalOutDate)
                .HasColumnType("datetime")
                .HasColumnName("hospital_out_date");
            entity.Property(e => e.HostingCharityNote)
                .HasMaxLength(50)
                .HasColumnName("hosting_charity_note");
            entity.Property(e => e.HostingCharityStatus).HasColumnName("hosting_charity_status");
            entity.Property(e => e.HostingStatus).HasColumnName("hosting_status");
            entity.Property(e => e.InitialDiagnose)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("initial_diagnose");
            entity.Property(e => e.Kafeel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kafeel");
            entity.Property(e => e.KafeelRelation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kafeel_relation");
            entity.Property(e => e.LastUpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_by");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("last_update_date");
            entity.Property(e => e.LastUpdateFrom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_update_from");
            entity.Property(e => e.MedRecommendationStatus).HasColumnName("med_recommendation_status");
            entity.Property(e => e.MedicalRecommendation)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("medical_recommendation");
            entity.Property(e => e.MemberAdmin)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("member_admin");
            entity.Property(e => e.MemberId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("member_id");
            entity.Property(e => e.PassportId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("passport_id");
            entity.Property(e => e.PhoneEg)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("phone_eg");
            entity.Property(e => e.ResponsibleEmp).HasColumnName("responsible_emp");
            entity.Property(e => e.SocialCharity).HasColumnName("social_charity");
            entity.Property(e => e.SocialPercentage).HasColumnName("social_percentage");
            entity.Property(e => e.TravelDate)
                .HasColumnType("datetime")
                .HasColumnName("travel_date");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor_id");
            entity.Property(e => e.VendorPlaceResidence)
                .IsUnicode(false)
                .HasColumnName("vendor_place_residence");

            entity.HasOne(d => d.Member).WithMany(p => p.WafdeenVisits)
                .HasForeignKey(d => d.MemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_wafdeen_visits_Members");

            entity.HasOne(d => d.ResponsibleEmpNavigation).WithMany(p => p.WafdeenVisits)
                .HasForeignKey(d => d.ResponsibleEmp)
                .HasConstraintName("FK_wafdeen_visits_wafdeen_visits");

            entity.HasOne(d => d.Vendor).WithMany(p => p.WafdeenVisits)
                .HasForeignKey(d => d.VendorId)
                .HasConstraintName("FK_wafdeen_visits_Vendor_General");
        });

        modelBuilder.Entity<WebCustomerRequest>(entity =>
        {
            entity.HasKey(e => e.Serial);

            entity.ToTable("Web_CustomerRequest");

            entity.Property(e => e.Serial).HasColumnName("serial");
            entity.Property(e => e.CoverageLimit).HasColumnName("coverage_limit");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.Currency)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("currency");
            entity.Property(e => e.Customer)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("customer");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.MemberName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("member_name");
            entity.Property(e => e.MemberPhone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("member_phone");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.ResposeBy)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("respose_by");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("type");
        });

        modelBuilder.Entity<WebOrder>(entity =>
        {
            entity.HasKey(e => e.OrderId);

            entity.ToTable("Web_Orders");

            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.CoverageLimitApproved)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("coverage_limit_approved");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(128)
                .HasColumnName("created_by");
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("customer_code");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Note)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("note");
            entity.Property(e => e.PatientName)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("patient_name");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<WebOrderDrug>(entity =>
        {
            entity.HasKey(e => e.DrugId);

            entity.ToTable("Web_OrderDrugs");

            entity.Property(e => e.DrugId).HasColumnName("drug_id");
            entity.Property(e => e.Attachment)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("attachment");
            entity.Property(e => e.Comments)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("comments");
            entity.Property(e => e.DrugConcentration)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("drug_concentration");
            entity.Property(e => e.DrugName)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("drug_name");
            entity.Property(e => e.OrderDate).HasColumnName("order_date");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.PackagesCount)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("packages_count");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("type");

            entity.HasOne(d => d.Order).WithMany(p => p.WebOrderDrugs)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Web_OrderDrugs_Web_Orders");
        });

        modelBuilder.Entity<WebOrderFile>(entity =>
        {
            entity.HasKey(e => e.FileId);

            entity.ToTable("Web_OrderFiles");

            entity.Property(e => e.FileId).HasColumnName("file_id");
            entity.Property(e => e.FileName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("file_name");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.Url)
                .IsUnicode(false)
                .HasColumnName("url");

            entity.HasOne(d => d.Order).WithMany(p => p.WebOrderFiles)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK_Web_OrderFiles_Web_Orders");
        });

        modelBuilder.Entity<WebVClient>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("web_v_client");

            entity.Property(e => e.CustomerContractId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("customer_contract_id");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_name");
        });

        modelBuilder.Entity<WebVIcustomer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("web_v_icustomer");

            entity.Property(e => e.CustomerContractId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("customer_contract_id");
            entity.Property(e => e.CustomerContractInsurer).HasColumnName("customer_contract_insurer");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .UseCollation("Arabic_100_CI_AI")
                .HasColumnName("customer_name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
