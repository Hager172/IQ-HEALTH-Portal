using ACMS_ONLINE_APPLICATION.VendorService.Queries.GetDiagnosis;
using ACMS_ONLINE_APPLICATION.VendorService.Queries.GetListOfVendorClims;
using ACMS_ONLINE_INFRASTRUCTURE.Interfaces;
using ACMS_ONLINE_INFRASTRUCTURE.UnitOfWork;
using ACMS_ONLINE_INFRASTRUCTURE.Utility.Helpers;
using ACMS_ONLINE_INFRASTRUCTURE.Utility.ResponseModel;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_APPLICATION.ApprovalService.Queries.GetApprovalStats
{
    internal class GetApprovalStatsHandler : IRequestHandler<GetApprovalStatsQuery, ServiceResponse<GetApprovalStatsResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public GetApprovalStatsHandler(IUnitOfWork unitOfWork, IHttpContextAccessor contextAccessor)
        { 
            _unitOfWork = unitOfWork;
            _httpContextAccessor = contextAccessor;
        }
        public async Task<ServiceResponse<GetApprovalStatsResponse>> Handle(GetApprovalStatsQuery request, CancellationToken cancellationToken)
        {
            var response = new ServiceResponse<GetApprovalStatsResponse>
            {
                Data = new GetApprovalStatsResponse(),
                Success = true,
                MessageEn = "Data retrieved successfully"
            };
            var vendorIdClaim = _httpContextAccessor.HttpContext?.User?.FindFirst("VendorId");
            if (vendorIdClaim == null || string.IsNullOrEmpty(vendorIdClaim.Value))
            {
                response.Success = false;
                response.MessageEn = "VendorId not found for the logged-in user.";
                return response;
            }
            var vendorId = vendorIdClaim.Value;

             string query = $@"
          SELECT 
  
    COUNT(CASE WHEN DATEDIFF(DAY, approval_date, GETDATE()) = 0 AND online_status = 'D' THEN 1 END) AS ApprovalsTodayD,
    COUNT(CASE WHEN DATEDIFF(WEEK, approval_date, GETDATE()) = 0 AND online_status = 'D' THEN 1 END) AS ApprovalsThisWeekD,
    COUNT(CASE WHEN DATEDIFF(MONTH, approval_date, GETDATE()) = 0 AND online_status = 'D' THEN 1 END) AS ApprovalsThisMonthD,
    
 
    COUNT(CASE WHEN DATEDIFF(DAY, approval_date, GETDATE()) = 0 AND online_status = 'P' THEN 1 END) AS ApprovalsTodayP,
    COUNT(CASE WHEN DATEDIFF(WEEK, approval_date, GETDATE()) = 0 AND online_status = 'P' THEN 1 END) AS ApprovalsThisWeekP,
    COUNT(CASE WHEN DATEDIFF(MONTH, approval_date, GETDATE()) = 0 AND online_status = 'P' THEN 1 END) AS ApprovalsThisMonthP,

	 COUNT(CASE WHEN online_status = 'D' THEN 1 END) AS TotalApprovalsD,


    COUNT(CASE WHEN online_status = 'P' THEN 1 END) AS TotalApprovalsP
FROM 
    [acms_migration].[dbo].[approvals]
WHERE 
    vendor_id = '{vendorId}' 
    AND (online_status = 'D' OR online_status = 'P');";

            try
            {
                var connectionString = _unitOfWork.getCurrentConnectionString();
                using (var adoHelper = new AdoHelper(connectionString))
                {
                    response.Data = adoHelper.ExecuteQuery(query, reader =>
                    {
                        return new GetApprovalStatsResponse
                        {
                            TotalApprovalsD = reader.GetInt32(reader.GetOrdinal("TotalApprovalsD")),
                            TotalApprovalsP = reader.GetInt32(reader.GetOrdinal("TotalApprovalsP")),
                            ApprovalsTodayD = reader.GetInt32(reader.GetOrdinal("ApprovalsTodayD")),
                            ApprovalsThisWeekD = reader.GetInt32(reader.GetOrdinal("ApprovalsThisWeekD")),
                            ApprovalsThisMonthD = reader.GetInt32(reader.GetOrdinal("ApprovalsThisMonthD")),

                            ApprovalsTodayP = reader.GetInt32(reader.GetOrdinal("ApprovalsTodayP")),
                            ApprovalsThisWeekP = reader.GetInt32(reader.GetOrdinal("ApprovalsThisWeekP")),
                            ApprovalsThisMonthP = reader.GetInt32(reader.GetOrdinal("ApprovalsThisMonthP")),

                        };
                    });
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.MessageEn = "Error retrieving data: " + ex.Message;
            }

            return response;
        }
  
    
    }
}
