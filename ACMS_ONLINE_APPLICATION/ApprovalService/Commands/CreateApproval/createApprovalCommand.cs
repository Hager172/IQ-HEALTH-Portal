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
    public class createApprovalCommand : IRequest<ServiceResponse<CreateApprovalCommandRespond>>
    {
        public String InsuredID { get; set; }
        public String ClaimID { get; set; }
        public DateTime ClaimDate { get; set; }
        public List<int> DiagnosesIds { get; set; }
        public string Mobile { get; set; }

        public List<ApprovalService> Services { get; set; }

        //public List<>

    }
    public class ApprovalService
    {
        public int ServiceId { get; set; }
        public int Quintity { get; set; }
        public float Price { get; set; }
        public double Total { get; set; }
        public string Note { get; set; }
        public bool isChronic {  get; set; }

        public float? DoseUnits { get; set; }
        public int? DoseRepeat { get; set; }
        public int? DoseDuration { get; set; }
        public int medItem { get; set; }
    }

  
}
