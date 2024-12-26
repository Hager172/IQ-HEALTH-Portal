using ACMS_ONLINE_INFRASTRUCTURE.Identity.Entities;
using ACMS_ONLINE_INFRASTRUCTURE.Interfaces;
using ACMS_ONLINE_INFRASTRUCTURE.Utility.ResponseModel;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_APPLICATION.VendorService.Queries.GetApprovalFileAndClaims
{
    public class GetApprovalFileAndClaimsHandler : IRequestHandler<GetApprovalFileAndClaimsQuery, ServiceResponse<GetApprovalFileAndClaimsResponse>>
    {

        private readonly IUnitOfWork _unitOfWork;
      
        public GetApprovalFileAndClaimsHandler(IUnitOfWork unitOfWork)
        {
          
            _unitOfWork = unitOfWork;
        


        }
        public async Task<ServiceResponse<GetApprovalFileAndClaimsResponse>> Handle(GetApprovalFileAndClaimsQuery request, CancellationToken cancellationToken)
        {
            try
            {
                // Retrieve the approval record
                var approval = await _unitOfWork.ApprovalRepository.FindAsync(
                    x => x.ApprovalId == request.approvalid,
                    new[] { "Types" }
                );

                var claimTypes = approval.Types.Select(t => new ClaimTypeDto
                {
                    TypeId = t.TypeId,
                    TypeName = t.Type // Replace with the actual property name for claim type name
                }).ToList();
                var response = new GetApprovalFileAndClaimsResponse
                {



                    ClaimTypes = claimTypes
                };
                if (approval == null)
                {

                    return new ServiceResponse<GetApprovalFileAndClaimsResponse>
                    {
                        Data = response,
                        Success = false,
                        MessageEn = "Approval not found."
                    };
                }

                // Retrieve the associated file
                var archiveEntry = await _unitOfWork.ApprovalsArchiveRepository.FindAsync(x => x.ApprovalId == request.approvalid);
                // Create the response

                if (archiveEntry == null)
                {
                    return new ServiceResponse<GetApprovalFileAndClaimsResponse>
                    {
                        Data = response,
                        Success = false,
                        MessageEn = "No file found for this approval."
                    };
                }

                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "UploadedFiles", archiveEntry.Path);
                if (!System.IO.File.Exists(filePath))
                {
                    return new ServiceResponse<GetApprovalFileAndClaimsResponse>
                    {
                        Data = response,
                        Success = false,
                        MessageEn = "The file does not exist on the server."
                    };
                }

                // Read the file content
                var fileContent = await System.IO.File.ReadAllBytesAsync(filePath);

                // Map claim types to DTO


                response = new GetApprovalFileAndClaimsResponse
                {
                    FileContent = fileContent,


                    ClaimTypes = claimTypes
                };

                return new ServiceResponse<GetApprovalFileAndClaimsResponse>
                {
                    Success = true,
                    MessageEn = "Data retrieved successfully.",
                    Data = response
                };
            }
            catch (Exception ex)
            {
                return new ServiceResponse<GetApprovalFileAndClaimsResponse>
                {
                    Success = false,
                    MessageEn = "An error occurred while processing the request.",
                    Data = null
                };
            }
        }

    }
}
