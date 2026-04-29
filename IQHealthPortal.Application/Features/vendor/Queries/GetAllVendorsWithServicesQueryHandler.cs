using IQHealthPortal.Application.Common.Responses;
using IQHealthPortal.Application.DTOs.VendorDtos;
using IQHealthPortal.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.Features.vendor.Queries
    {
    public class GetAllVendorsWithServicesQueryHandler
       : IRequestHandler<GetAllVendorsWithServicesQuery,
           ServiceResponse<List<VendorWithServicesDto>>>
        {
        private readonly IUnitOfWork _unitOfWork;

        public GetAllVendorsWithServicesQueryHandler(
            IUnitOfWork unitOfWork)
            {
            _unitOfWork = unitOfWork;
            }

        public async Task<ServiceResponse<List<VendorWithServicesDto>>> Handle(
            GetAllVendorsWithServicesQuery request,
            CancellationToken cancellationToken)
            {
            var vendors = await _unitOfWork.VendorRepository.GetAllAsync();

            var result = new List<VendorWithServicesDto>();

            foreach (var vendor in vendors)
                {
                List<VendorServiceDto> services;

                if (vendor.VendorCategoryId == 4) // Pharma
                    {
                    services = await _unitOfWork.VendorRepository
                        .GetPharmaServicesAsync(vendor.VendorId, vendor.VendorName);
                    }
                else
                    {
                    services = await _unitOfWork.VendorRepository
                        .GetContractServicesAsync(vendor.VendorId, vendor.VendorName);
                    }

                result.Add(new VendorWithServicesDto
                    {
                    VendorId = vendor.VendorId,
                    VendorName = vendor.VendorName,
                    VendorCategoryId = vendor.VendorCategoryId,
                    Services = services
                    });
                }

            return new ServiceResponse<List<VendorWithServicesDto>>
                {
                Success = true,
                Data = result
                };
            }
        }
    }
