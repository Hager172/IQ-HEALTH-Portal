using ACMS_ONLINE_APPLICATION.VendorService.Queries.GetServices;
using ACMS_ONLINE_INFRASTRUCTURE.Interfaces;
using ACMS_ONLINE_INFRASTRUCTURE.Utility.Helpers;
using ACMS_ONLINE_INFRASTRUCTURE.Utility.ResponseModel;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_APPLICATION.VendorService.Queries.GetPharmaServices
{
    internal class GetPharmaServicesHandler : IRequestHandler<GetPharmaServicesQuery, ServiceResponse<List<GetPharmaServicesResponse>>>
    {

        private readonly IUnitOfWork _unitOfWork;
      

        public GetPharmaServicesHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            
        }
        public async Task<ServiceResponse<List<GetPharmaServicesResponse>>> Handle(GetPharmaServicesQuery request, CancellationToken cancellationToken)
        {
            var response = new ServiceResponse<List<GetPharmaServicesResponse>>
            {
                Data = new List<GetPharmaServicesResponse>(),
                Success = true,
                MessageEn = "Data retrieved successfully"
            };

            try
            {
                var connectionString = _unitOfWork.getCurrentConnectionString();
                var query = $@"SELECT * FROM [acms_migration].[dbo].[acms_pharma] WHERE name LIKE '{request.Name}%'";

                using (var adoHelper = new AdoHelper(connectionString))
                {
                    var pharmaServices = adoHelper.ExecuteQueryList(query, reader => new GetPharmaServicesResponse
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        Name = reader["name"]?.ToString(),
                        Price = reader["price"] == DBNull.Value ? null : (decimal?)Convert.ToDecimal(reader["price"]),
                        Notes = reader["notes"]?.ToString(),
                        PriceUpdateId = reader["price_update_id"].ToString(),
                        LastUpdateBy = reader["LAST_UPDATE_BY"]?.ToString(),
                        LastUpdateDate = reader["LAST_UPDATE_DATE"] == DBNull.Value ? null : (DateTime?)Convert.ToDateTime(reader["LAST_UPDATE_DATE"]),
                        Availability = reader["availability"].ToString(),
                        Source = reader["source"]?.ToString(),
                        UnitSale = reader["unit_sale"]?.ToString(),
                        SubUnitNo = reader["sub_unit_no"] == DBNull.Value ? null : (int?)Convert.ToInt32(reader["sub_unit_no"]),
                        DoseUnitNo = reader["dose_unit_no"] == DBNull.Value ? null : (int?)Convert.ToInt32(reader["dose_unit_no"]),
                        DoseForm = reader["dose_form"]?.ToString(),
                        Active = reader["active"] == DBNull.Value ? null : Convert.ToInt32(reader["active"]),
                        LastPriceDate = reader["last_price_date"] == DBNull.Value ? null : (DateTime?)Convert.ToDateTime(reader["last_price_date"]),
                        Type = reader["type"]?.ToString()
                    });

                    if (pharmaServices != null && pharmaServices.Any())
                    {
                        response.Data = pharmaServices;
                    }
                    else
                    {
                        response.Success = false;
                        response.MessageEn = "No data found matching the criteria.";
                    }
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.MessageEn = "An error occurred while retrieving data.";
                response.MessageAr = ex.Message; 
            }

            return response;
        }

    }
}
