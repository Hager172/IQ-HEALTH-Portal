using ACMS_ONLINE_APPLICATION.VendorService.Queries.GetSetting;
using ACMS_ONLINE_INFRASTRUCTURE.Data.Models;
using ACMS_ONLINE_INFRASTRUCTURE.Interfaces;
using ACMS_ONLINE_INFRASTRUCTURE.Utility.Helpers;
using ACMS_ONLINE_INFRASTRUCTURE.Utility.ResponseModel;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_APPLICATION.VendorService.Queries.GetServices
{
    public class GetServicesHandler : IRequestHandler<GetServicesQuery, ServiceResponse<List<GetServicesResponse>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;

        public GetServicesHandler(IUnitOfWork unitOfWork,IMapper mapper,IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<List<GetServicesResponse>>> Handle(GetServicesQuery request, CancellationToken cancellationToken)
        {
            var response = new ServiceResponse<List<GetServicesResponse>>();


            try
            {

                var connectionString = _unitOfWork.getCurrentConnectionString();
                var vendorIdClaim = _httpContextAccessor.HttpContext?.User?.FindFirst("VendorId");
                if (vendorIdClaim == null || string.IsNullOrEmpty(vendorIdClaim.Value))
                {
                    response.Success = false;
                    response.MessageEn = "VendorId not found for the logged-in user.";
                    response.MessageAr = "كود مقدم الخدمة غير صحيح";

                    throw new Exception("No Vendor Found In Claims");
                }

                var VendorId = vendorIdClaim.Value;
                var services = new List<ContractService>();


                services = await _unitOfWork.ContractServiceRepository.GetVendorServiceByClaimType(request.Type, VendorId);
                


                var dto = _mapper.Map<List<ContractService>, List<GetServicesResponse>>(services);
                response.Data = dto;
            }
            catch (Exception ex)
            {
                response.Success = false;
                
            }

            return response;
        }
    }

}
