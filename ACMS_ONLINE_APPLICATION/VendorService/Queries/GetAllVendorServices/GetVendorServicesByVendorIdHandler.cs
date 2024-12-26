using ACMS_ONLINE_INFRASTRUCTURE.Data.Models;
using ACMS_ONLINE_INFRASTRUCTURE.Interfaces;
using ACMS_ONLINE_INFRASTRUCTURE.Utility.Helpers;
using ACMS_ONLINE_INFRASTRUCTURE.Utility.ResponseModel;
using Azure;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_APPLICATION.VendorService.Queries.GetAllVendorServices
{
    public class GetVendorServicesByVendorIdHandler : IRequestHandler<GetVendorServicesByVendorIdQuery, ServiceResponse<List<GetVendorServicesByVendorIdQueryResponse>>>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IUnitOfWork _unitOfWork;
        public GetVendorServicesByVendorIdHandler(IUnitOfWork unitOfWork, IHttpContextAccessor contextAccessor)
        {
            _httpContextAccessor = contextAccessor;
            _unitOfWork = unitOfWork;
        }


        public async Task<ServiceResponse<List<GetVendorServicesByVendorIdQueryResponse>>> Handle(GetVendorServicesByVendorIdQuery request, CancellationToken cancellationToken)
        {
            var serviceResponse = new ServiceResponse<List<GetVendorServicesByVendorIdQueryResponse>>();

            try
            {


                var vendorIdClaim = _httpContextAccessor.HttpContext?.User?.FindFirst("VendorId");
                if (vendorIdClaim == null || string.IsNullOrEmpty(vendorIdClaim.Value))
                {
                    serviceResponse.Success = false;
                    serviceResponse.MessageEn = "VendorId not found for the logged-in user.";
                    return serviceResponse;
                }

                var vendorId = vendorIdClaim.Value;
                bool isPharma = request.VendorId.StartsWith("Ph");


                var ConnectionString = _unitOfWork.getCurrentConnectionString();

                using (AdoHelper adoHelper = new(ConnectionString))
                {


                    string query = isPharma ?

                        $"select * from acms_pharma "
                        :



                   $@"
                    SELECT 
                        [contract_service_id],
                        [contract_service_prices],
                        [contract_service_ser_ref],
                        [contract_service_name],
                        [contract_service_notes],
                        [last_update_by],
                        [last_update_date],
                        [last_update_from],
                        [contract_service_contract_code],
                        [old_service_id],
                        [contract_service_discount],
                        [contract_service_flag],
                        [external_code],
                        [is_package]
                    FROM contract_services 
                    WHERE contract_service_contract_code = '{vendorId}' ";

                    var services = adoHelper.ExecuteQueryList(query, reader =>
                    {
                        return new GetVendorServicesByVendorIdQueryResponse();

                    });

                    serviceResponse.Data = services;

                    // return services;
                }

            }
            catch (Exception ex)
            {

            }
            return serviceResponse;
        }
    }
}
