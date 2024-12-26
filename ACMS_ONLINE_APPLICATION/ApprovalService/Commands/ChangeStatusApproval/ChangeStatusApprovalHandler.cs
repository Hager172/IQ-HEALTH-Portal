using ACMS_ONLINE_APPLICATION.VendorService.Commands.AddClaimsType;
using ACMS_ONLINE_INFRASTRUCTURE.Interfaces;
using ACMS_ONLINE_INFRASTRUCTURE.Utility.ResponseModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_APPLICATION.ApprovalService.Commands.ChangeStatusApproval
{
    public class ChangeStatusApprovalHandler : IRequestHandler<ChangeStatusApprovalCommand, ServiceResponse<ChangeStatusApprovalResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public ChangeStatusApprovalHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<ServiceResponse<ChangeStatusApprovalResponse>> Handle(ChangeStatusApprovalCommand request, CancellationToken cancellationToken)
        {
            var approval = _unitOfWork.ApprovalRepository.Find(x => x.ApprovalId == request.ApprovalId);
            if (approval == null) {
                return new ServiceResponse<ChangeStatusApprovalResponse>
                {
                    Success = false,
                    MessageEn = "failed approvalid"
                };
            }

            approval.OnlineStatus = "C";
             _unitOfWork.ApprovalRepository.Update(approval);
             _unitOfWork.Save(); 

            
            return new ServiceResponse<ChangeStatusApprovalResponse>
            {
                Success = true,
                MessageEn = "Online status updated successfully.",
                Data = new ChangeStatusApprovalResponse
                {
                    ApprovalId = approval.ApprovalId,
                    OnlineStatus = approval.OnlineStatus
                }
            };

        }
    }
}
