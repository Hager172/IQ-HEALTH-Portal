using ACMS_ONLINE_APPLICATION.VendorService.Queries.GetListOfVendorClims;
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

namespace ACMS_ONLINE_APPLICATION.VendorService.Queries.GetDiagnosis
{
    public class GetDiagnosisHandler : IRequestHandler<GetDiagnosisQuery, ServiceResponse<List<GetDiagnosisResponse>>>
    {


        private readonly IUnitOfWork _unitOfWork;

        public GetDiagnosisHandler(IUnitOfWork unitOfWork)
        {
           
            _unitOfWork = unitOfWork;
           


        }
        public async Task<ServiceResponse<List<GetDiagnosisResponse>>> Handle(GetDiagnosisQuery request, CancellationToken cancellationToken)
        {
            var response = new ServiceResponse<List<GetDiagnosisResponse>>
            {
                Data = new List<GetDiagnosisResponse>(),
                Success = true,
                MessageEn = "Data retrieved successfully"
            };

            try
            {
                var connectionString = _unitOfWork.getCurrentConnectionString();

                using (AdoHelper adoHelper = new(connectionString))
                {
                    string listOfVendorClaimsQuery = $@"
                SELECT id, name, type FROM online_diagnosis";

                    var result = adoHelper.ExecuteQueryList(listOfVendorClaimsQuery, reader =>
                    {
                       
                        var diagnosis = new GetDiagnosisResponse
                        {
                            Id = reader["id"]?.ToString(),
                            Name = reader["name"]?.ToString(),
                            
                            Type = reader["type"] != DBNull.Value && int.TryParse(reader["type"].ToString(), out var type) ? type : 0 
                        };

                        return diagnosis;
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
