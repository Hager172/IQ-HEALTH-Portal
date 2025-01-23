using ACMS_ONLINE_APPLICATION.ApprovalService.Commands.CreateApproval;
using ACMS_ONLINE_INFRASTRUCTURE.Utility.ResponseModel;
using MediatR;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_APPLICATION.ApprovalService.Commands.Approval
{

    public class createApprovalCommand : IRequest<ServiceResponse<CreateApprovalResponse>>
    {
        //public String InsuredID { get; set; }
        //public String ClaimID { get; set; }
        //public DateTime ClaimDate { get; set; }

        //public string Mobile { get; set; }

        public ApprovalReq Approval { get; set; }
        public List<int> DiagnosesIds { get; set; }
        public List<ApprovalService> Services { get; set; }

        //public List<>





    }


    public class ApprovalReq
    {
        //public DateTime ApprovalDate { get; set; }
        ////public string RequestSource { get; set; }
        //public string MemberId { get; set; }
        //public string Notes { get; set; }
        //public string LastUpdateBy { get; set; }
        //public DateTime LastUpdateDate { get; set; }
        //public string LastUpdateFrom { get; set; }
        //public int VendorId { get; set; }
        ////public string ApStatus { get; set; }
        //public string ApType { get; set; }
        //public int? ParentApproval { get; set; }
        //public decimal? Coinsurance { get; set; }
        //public bool? IsOnline { get; set; }
        //public decimal? MaxValue { get; set; }
        //public string PrivateNotes { get; set; }
        //public string OnlineUser { get; set; }
        //public string OnlineStatus { get; set; }
        //public string OnlineBCode { get; set; }
        //public DateTime? OnlineLastUpdateDate { get; set; }
        //public int? FormId { get; set; }
        //public bool? IsNotified { get; set; }                                                
        //public DateTime? FormDate { get; set; }
        //public string CurrentIp { get; set; }
        //public string PlanCode { get; set; }
        //public int? MainApproval { get; set; }
        //public bool? IsExceptional { get; set; }
        //public string ChronicReference { get; set; }
        //public bool? HoldOnReview { get; set; }
        //public int? VendorBranchId { get; set; }
        //public int? ContractId { get; set; }
        //public int RequestId { get; set; }
        //public long ApprovalId { get; set; }

        public DateTime ApprovalDate { get; set; }

        public string? RequestSource { get; set; }

        public string MemberId { get; set; } = null!;

        public string? Notes { get; set; }

        public string? LastUpdateBy { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public string? LastUpdateFrom { get; set; }

        public string? VendorId { get; set; }

        //public string? ApStatus { get; set; }

        //public string ApType { get; set; }

        //public long? ParentApproval { get; set; }

        public double? Coinsurance { get; set; }

        //public char? IsOnline { get; set; }

        public double? MaxValue { get; set; }

        public string? PrivateNotes { get; set; }

        public string? OnlineUser { get; set; }

        //public string? OnlineStatus { get; set; }

        public string? OnlineBCode { get; set; }

        public DateTime? OnlineLud { get; set; }

        public string? FormId { get; set; }

        public bool? Isnotified { get; set; }

        //public DateOnly? FormDate { get; set; }

        public string? Currentip { get; set; }

        //public string? PlanCode { get; set; }

        public long? MainApproval { get; set; }

        public bool? IsExceptional { get; set; }

        public int? ChronicRef { get; set; }

        public bool? HoldOnRev { get; set; }

        //public long? VBranchId { get; set; }

        //public string? ContractId { get; set; }

        //public int? ReqId { get; set; }


    }
    public class ApprovalService
    {
        //public int ServiceId { get; set; }
        //public int Quintity { get; set; }
        //public float Price { get; set; }
        //public double Total { get; set; }
        //public string Note { get; set; }
        //public bool isChronic { get; set; }

        //public float? DoseUnits { get; set; }
        //public int? DoseRepeat { get; set; }
        //public int? DoseDuration { get; set; }
        //public int medItem { get; set; }

        //public long ApprovalId { get; set; }  
        public int ItemSerial { get; set; }
        public int ServiceId { get; set; }
        public int MedItem { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        public string? ItemDescription { get; set; }
        public bool? IsChronic { get; set; }
        public int? ItemRepeat { get; set; }
        public string? Notes { get; set; }
        public string? LastUpdateBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdateFrom { get; set; }
        public int InsurerMedItem { get; set; }
        public double? Coinsurance { get; set; }
        //public string OnlineStatus { get; set; }
        public int? Days { get; set; }
        public int? ApprovalQuantity { get; set; }
        public string? DoseDurationType { get; set; }
        public int? MinUnits { get; set; }
        public float? DoseUnits { get; set; }
        public int? DoseRepeat { get; set; }
        public int? DoseDuration { get; set; }
        public float? OriginalPrice { get; set; }
        public int? EditQuantity { get; set; }
        public bool? IsActualValue { get; set; }

    }


}
