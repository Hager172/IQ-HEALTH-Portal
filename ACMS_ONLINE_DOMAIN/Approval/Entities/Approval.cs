using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACMS_ONLINE_DOMAIN.Medication.Entities;
namespace ACMS_ONLINE_DOMAIN.Approval.Entities
{
    public class Approval
    {


        public long ApprovalId { get; private set; }

        public DateTime ApprovalDate { get; set; }

        public string? RequestSource { get; set; }

        public string MemberId { get; set; } = null!;

        public string? Notes { get; set; }

        public string? LastUpdateBy { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public string? LastUpdateFrom { get; set; }

        public string VendorId { get; set; } = null!;

        public string? ApStatus { get; set; }

        public string ApType { get; set; } = null!;

        public long? ParentApproval { get; set; }

        public double? Coinsurance { get; set; }

        public string? IsOnline { get; set; }

        public double? MaxValue { get; set; }

        public string? PrivateNotes { get; set; }

        public string? OnlineUser { get; set; }

        public string? OnlineStatus { get; set; }

        public string? OnlineBCode { get; set; }

        public DateTime? OnlineLud { get; set; }

        public string? FormId { get; set; }

        public bool? Isnotified { get; set; }

        public DateOnly? FormDate { get; set; }

        public string? Currentip { get; set; }

        public string? PlanCode { get; set; }

        public long? MainApproval { get; set; }

        public bool? IsExceptional { get; set; }

        public int? ChronicRef { get; set; }

        public bool? HoldOnRev { get; set; }

        public long? VBranchId { get; set; }

        public string? ContractId { get; set; }



        public int? ReqId { get; set; }
        //public List<ApprovalService> _service;
        //public List<Diagnose> _diagnoses;
        //private static List<ClaimsType> _clamTypes;
        public List<ApprovalService> _service;
        public List<Diagnose> _diagnoses;
        public List<ClaimsType> _clamTypes;
        public ACMS_ONLINE_DOMAIN.Member.Entities.Member _member { get; private set; }


        public float CoPayment { get; private set; }
        //public double SubTotal => _service.Sum(p => p.TotalPrice());
        //public double CoPaymentAmount => SubTotal * (CoPayment / 100);
        // public double NetTotal => SubTotal - CoPaymentAmount;

        //public IReadOnlyCollection<ApprovalService> Services1 => _service.AsReadOnly();
        //public IReadOnlyCollection<Diagnose> Diagnoses1 => _diagnoses.AsReadOnly();
        //public IReadOnlyCollection<ClaimsType> ClamTypes1 => _clamTypes.AsReadOnly();
        public IReadOnlyCollection<ApprovalService> Services1 => _service.AsReadOnly();
        public IReadOnlyCollection<Diagnose> Diagnoses1 => _diagnoses.AsReadOnly();
        public IReadOnlyCollection<ClaimsType> ClamTypes1 => _clamTypes.AsReadOnly();
        private Approval()
        {
            _service = new List<ApprovalService>();
            _diagnoses = new List<Diagnose>();
            _clamTypes = new List<ClaimsType>();
        }
        public static Approval Create(DateTime claimDate)
        {

            //ApprovalId = GetNewApprovalId();
            //ApprovalDate = claimDate;

            //Diagnosis = diagnosis;
            //Prescription = prescription;
            //CoPayment = coPayment;
            // _service = new List<Service>();

            var approval = new Approval()
            {
                ApprovalDate = claimDate,

            };

            return approval;

        }


        // add claimType

        public void AddClaimType(ClaimsType clamType)
        {
            if (clamType == null)
                throw new ArgumentNullException(nameof(clamType));

            if (_clamTypes.Any(p => p.TypeId == clamType.TypeId))
                throw new InvalidOperationException("Service already exists in the claim.");



            _clamTypes.Add(clamType);
        }

        // add service
        public void AddService(ApprovalService service)
        {
            if (service == null)
                throw new ArgumentNullException(nameof(service));

            if (_service.Any(p => p.ServiceId == service.ServiceId))
                throw new InvalidOperationException("Service already exists in the claim.");



            _service.Add(service);
        }

        //  remove service
        public void RemoveService(int itemSerial)
        {
            var service = _service.FirstOrDefault(p => p.ItemSerial == itemSerial);
            if (service != null)
            {
                _service.Remove(service);
            }
            else
            {
                throw new InvalidOperationException("Service not found in the claim.");
            }
        }
        // add service
        public void AddDiagnose(Diagnose diagnose)
        {
            if (diagnose == null)
                throw new ArgumentNullException(nameof(diagnose));

            if (_diagnoses.Any(p => p.Id == diagnose.Id))
                throw new InvalidOperationException("Diagnose already exists in the claim.");

            _diagnoses.Add(diagnose);
        }

        //  remove service
        public void RemoveDiagnose(string diagnoseId)
        {
            var diagnose = _diagnoses.FirstOrDefault(p => p.Id == diagnoseId);
            if (diagnose != null)
            {
                _diagnoses.Remove(diagnose);
            }
            else
            {
                throw new InvalidOperationException("Diagnose not found in the claim.");
            }
        }

        public void UpdateCoPayment(float coPayment)
        {
            CoPayment = coPayment;
        }



        //public void UpdateDiagnosis(string newDiagnosis, string oldDiagnosis)
        //{
        //    if (string.IsNullOrEmpty(newDiagnosis))
        //        throw new ArgumentException("Diagnosis cannot be empty.");
        //    Diagnosis.Remove(oldDiagnosis);
        //    Diagnosis.Add(newDiagnosis);

        //}


        public void SetApprovalId(long approvalId)
        {
            ApprovalId = approvalId;
        }

        private void AddMember(string insuredId)
        {
            // check member id 
            MemberId = insuredId;
        }




    }
}
