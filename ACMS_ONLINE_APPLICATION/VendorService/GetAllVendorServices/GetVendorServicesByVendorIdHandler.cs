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

namespace ACMS_ONLINE_APPLICATION.VendorService.GetAllVendorServices
{
    public class GetVendorServicesByVendorIdHandler : IRequestHandler<GetVendorServicesByVendorIdQuery,ServiceResponse<List<GetVendorServicesByVendorIdQueryResponse>>>
    {
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IUnitOfWork _unitOfWork;
        public GetVendorServicesByVendorIdHandler(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }


        public async Task<ServiceResponse<List<GetVendorServicesByVendorIdQueryResponse>>> Handle (GetVendorServicesByVendorIdQuery request, CancellationToken cancellationToken)
        {
            var serviceResponse = new ServiceResponse<List<GetVendorServicesByVendorIdQueryResponse>>();

            try
            {
                bool isPharma = request.VendorId.StartsWith("Ph");


                var ConnectionString = _unitOfWork.getCurrentConnectionString();

                using (AdoHelper adoHelper = new(ConnectionString))
                {

                    //var services = db.getMedicines(q).AsQueryable().Select(m => new { id = m.id, Text = m.name + (m.price_update_id!=null&&m.price_update_id!=""?" (Price Updated)":""), price = m.sub_unit_no.HasValue && m.sub_unit_no != 0 ? m.price / m.sub_unit_no : m.price, dose = m.dose_unit_no, sub = m.sub_unit_no.HasValue ? m.sub_unit_no : 1, update_price = m.price_update_id, isOneUnit = m.type.HasValue && m.type == true ? true : false, unit_sale = m.unit_sale });

                    string query = isPharma ? 
                        
                        $"select * from acms_pharma " 
                        :


                    //var services = db.getServices(vid, q).Select(m => new { id = m.contract_service_id, Text = m.contract_service_name, price = isMashCash ? Math.Ceiling(m.contract_service_prices + (m.contract_service_prices * (per / 100))) : m.contract_service_prices }).ToList();

                    "select * from acms_pharma ";

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
