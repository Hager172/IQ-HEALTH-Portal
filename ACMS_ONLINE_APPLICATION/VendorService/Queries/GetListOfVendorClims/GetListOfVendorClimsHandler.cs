using ACMS_ONLINE_APPLICATION.ApprovalService.Queries.GetMemberDetails;
using ACMS_ONLINE_INFRASTRUCTURE.Identity.Entities;
using ACMS_ONLINE_INFRASTRUCTURE.Interfaces;
using ACMS_ONLINE_INFRASTRUCTURE.Utility.Helpers;
using ACMS_ONLINE_INFRASTRUCTURE.Utility.ResponseModel;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_APPLICATION.VendorService.Queries.GetListOfVendorClims
{
    public class GetListOfVendorClimsHandler : IRequestHandler<GetListOfVendorClimsQuery, ServiceResponse<List<GetListOfVendorClimsResponse>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<ApplicationUser> _UserManager;
        public GetListOfVendorClimsHandler(IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor, UserManager<ApplicationUser> UserManager)
        {
            _httpContextAccessor = httpContextAccessor;
            _unitOfWork = unitOfWork;
            _UserManager = UserManager;


        }
        public async Task<ServiceResponse<List<GetListOfVendorClimsResponse>>> Handle(GetListOfVendorClimsQuery request, CancellationToken cancellationToken)
        {
            var response = new ServiceResponse<List<GetListOfVendorClimsResponse>>
            {
                Data = new List<GetListOfVendorClimsResponse>(),
                Success = true,
                MessageEn = "Data retrieved successfully"
            };


            try
            {
                var userId = _httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier);

                if (string.IsNullOrEmpty(userId))
                {
                    response.Success = false;
                    response.MessageEn = "User is not authenticated.";
                    return response;
                }
                var connectionString = _unitOfWork.getCurrentConnectionString();

                var vendorIdClaim = _httpContextAccessor.HttpContext?.User?.FindFirst("VendorId");
                if (vendorIdClaim == null || string.IsNullOrEmpty(vendorIdClaim.Value))
                {
                    response.Success = false;
                    response.MessageEn = "VendorId not found for the logged-in user.";
                    return response;
                }

                var vendorId = vendorIdClaim.Value;
                using (AdoHelper adoHelper = new(connectionString))
                {



                    var _user = await _UserManager.FindByIdAsync(userId);
                    var roles = await _UserManager.GetRolesAsync(_user);


                    bool isEditable = roles.Contains("Edit");
                    string fromDate = request.From;
                    string toDate = request.To;

                   

                    string listOfVendorClaimsQuery = $@"
            SELECT 
                a.approval_id,
a.contract_id,
                a.member_id,
m.member_name,
                a.approval_date,
                a.last_update_by AS approval_by,
                a.last_update_from AS approval_from,
                a.last_update_date, 
                m.member_customer_id AS customer_id,
                c.customer_name,
                a.online_status,
                vg.vendor_name,
                vb.vendor_branch_name,
               
                (SELECT SUM(ISNULL(asrv.price, 0)) 
                 FROM approval_services asrv 
                 WHERE asrv.approval_id = a.approval_id) AS total_price ,
          (SELECT value FROM Online_Settings where item='maxDays') AS maxDays,

        CASE 
            WHEN EXISTS (
                SELECT 1 
                FROM approvals_archive AA 
                WHERE a.approval_id = AA.approval_id 
                  AND AA.last_update_by = 'IQ_Health_Portal_System'
            ) THEN 1
            ELSE 0
        END AS IsInArchive
            FROM approvals a
            LEFT JOIN Members m ON m.member_id = a.member_id
            JOIN Customers c ON m.member_customer_id = c.customer_id
            JOIN Vendor_General vg ON vg.vendor_id = a.vendor_id
            LEFT JOIN vendor_branches vb ON vb.old_id = a.online_b_code  
            WHERE a.vendor_id = '{vendorId}' AND a.is_online='1'
            AND a.approval_date BETWEEN '{fromDate}' AND '{toDate}'
            GROUP BY 
                a.approval_id, 
a.contract_id,
                a.member_id, 
m.member_name,
                a.approval_date, 
                a.last_update_by,
                a.last_update_from,
                a.last_update_date, 
                m.member_customer_id, 
                c.customer_name,
                a.online_status, 
                vg.vendor_name, 
                vb.vendor_branch_name";

                    adoHelper.CommandTimeout = 1800;
                    var result = adoHelper.ExecuteQueryList(listOfVendorClaimsQuery, reader =>
                    {
                        var totalPrice = reader["total_price"] != DBNull.Value
                                            ? Convert.ToDouble(reader["total_price"])
                                            : 0;

                        var status = reader["online_status"]?.ToString();
                        var maxDays = reader["maxDays"] != DBNull.Value
                        ? Convert.ToInt32(reader["maxDays"])
                  : 0;
                        var approvalDate = reader["approval_date"] != DBNull.Value
                      ? Convert.ToDateTime(reader["approval_date"])
                      : DateTime.MinValue;
                        var daysSinceApproval = (DateTime.Now - approvalDate).Days;
                        var isDeletable = daysSinceApproval > maxDays;

                        return new GetListOfVendorClimsResponse
                        {
                            ApprovalId = reader["approval_id"]?.ToString(),
                            contract_id = reader["contract_id"]?.ToString(),
                         
                            MemberId = reader["member_id"]?.ToString(),
                            membername = reader["member_name"]?.ToString(),
                            CustomerId = reader["customer_id"]?.ToString(),
                            CustomerName = reader["customer_name"]?.ToString(),
                            Status = status,
                            vendorname = reader["vendor_name"]?.ToString(),
                            vendorbranchname = reader["vendor_branch_name"]?.ToString(),
                            ApprovalDate = reader["approval_date"] != DBNull.Value
                                            ? Convert.ToDateTime(reader["approval_date"])
                                            : DateTime.MinValue,
                            ApprovedBy = reader["approval_by"]?.ToString(),
                            ApprovedFrom = reader["approval_from"]?.ToString(),
                            ApprovedDate = reader["last_update_date"]?.ToString(),

                            IsEditable = isEditable,
                            IsPrintable = (status == "D" && totalPrice > 0),
                            IsDeletable = (isDeletable && status == "P"),
                            IsInArchive = reader["IsInArchive"] != DBNull.Value
                    ? Convert.ToBoolean(reader["IsInArchive"])
                    : false

                        };
                    });

                    response.Data = result;
                }
            }
            catch (SqlException sqlEx)
            
            {
                response.Success = false;
                response.MessageEn = $"A database error occurred: {sqlEx.Message}";

            }
            catch (Exception ex)
            {
                response.Success = false;
                response.MessageEn = $"An error occurred while retrieving data: {ex.Message}";

            }


            return response;
        }


    }
}
