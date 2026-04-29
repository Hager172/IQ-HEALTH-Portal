using IQHealthPortal.Application.DTOs.VendorDtos;
using IQHealthPortal.Application.Interfaces.Repositories;
using IQHealthPortal.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Infrastructure.Persistence.Repositories
    {
    public class VendorRepository: IVendorRepository
        {
        private readonly ApplicationDbContext _context;
        public VendorRepository(ApplicationDbContext context) { 
            _context = context;
            }
        public async Task<List<VendorBasicDto>> GetAllAsync()
            {
            return await _context.VendorGenerals
                .Where(v => v.VendorStatus == "A")
                .Select(v => new VendorBasicDto
                    {
                    VendorId = v.VendorId,
                    VendorName = v.VendorName,
                    VendorCategoryId = v.VendorCategoryId
                    })
                .ToListAsync();
            }

        public async Task<List<VendorServiceDto>> GetPharmaServicesAsync(
            string vendorId,
            string vendorName)
            {
            return await _context.AcmsPharmas
                .Where(p => p.Active == 1)
                .Select(p => new VendorServiceDto
                    {
                    VendorId = vendorId,
                    VendorName = vendorName,
                    ServiceId = p.Id.ToString(),
                    ServiceName = p.Name,
                    Price = (decimal)p.Price,
                    Discount = null,
                    Copayment = null
                    })
                .ToListAsync();
            }

        public async Task<List<VendorServiceDto>> GetContractServicesAsync(
            string vendorId,
            string vendorName)
            {
            var today = DateTime.Now;

            var contract = await _context.VendorContracts
                .Where(c =>
                    c.VendorContractVendorId == vendorId &&
                    c.VendorContractStartDate <= today &&
                    c.VendorContractEndDate >= today)
                .FirstOrDefaultAsync();

            if (contract == null)
                return new List<VendorServiceDto>();

            return await _context.ContractServices
                .Where(s => s.ContractServiceContractCode == contract.VendorContractId)
                .Select(s => new VendorServiceDto
                    {
                    VendorId = vendorId,
                    VendorName = vendorName,
                    ServiceId = s.ContractServiceId.ToString(),
                    ServiceName = s.ContractServiceName,
                    Price = (decimal)s.ContractServicePrices,
                    Discount = (decimal?)s.ContractServiceDiscount,
                    Copayment = null
                    })
                .ToListAsync();
            }

        }
    }
