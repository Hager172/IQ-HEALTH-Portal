using IQHealthPortal.Application.DTOs.ApprovalDtos;
using IQHealthPortal.Application.Interfaces.Repositories;
using IQHealthPortal.Infrastructure.Data;
using IQHealthPortal.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Infrastructure.Persistence.Repositories
    {
    public class ApprovalRepository : IApprovalRepository
        {
        private readonly ApplicationDbContext _context;

        public ApprovalRepository(ApplicationDbContext context)
            {
            _context = context;
            }

        public async Task<List<MemberApprovalListDto>> GetByMemberIdAsync(string memberId)
            {
            return await _context.Approvals
                .Where(a => a.MemberId == memberId)
                .OrderByDescending(a => a.ApprovalDate)
                .Select(a => new MemberApprovalListDto
                    {
                    ApprovalNumber = a.ApprovalId,
                    ApprovalDate = a.ApprovalDate,
                    Status = a.ApStatus!
                    })
                .ToListAsync();
            }

        public async Task<GetApprovalForEditDto?> GetApprovalForEditAsync(string approvalNumber)
            {
            return await _context.Approvals
                .Where(a => a.FormId == approvalNumber)
                .Select(a => new GetApprovalForEditDto
                    {
                    ApprovalNumber = a.FormId!,
                    Limit = (decimal?)a.MaxValue,
                    CopaymentPercentage = (decimal?)a.Coinsurance,
                    ExtraCopaymentPercentage = 0,
                    Items = a.ApprovalServices.Select(s => new ApprovalItemDto
                        {
                        Id = s.ServiceId.ToString(),
                        //Description = s.ServiceName,
                        //Quantity = s.Quantity ?? 1,
                        QuantityUnit = "Unit",
                        //UnitPrice = (decimal)s.ServicePrice
                        }).ToList()
                    })
                .FirstOrDefaultAsync();
            }

        public async Task UpdateApprovalItemsAsync(
            string approvalNumber,
            List<ApprovalItemDto> items)
            {
            var approval = await _context.Approvals
                .Include(a => a.ApprovalServices)
                .FirstOrDefaultAsync(a => a.FormId == approvalNumber);

            if (approval == null)
                throw new Exception("Approval not found");

            _context.ApprovalServices.RemoveRange(approval.ApprovalServices);

            approval.ApprovalServices = items.Select((i, index) =>
                new ApprovalService
                    {
                    ApprovalId = approval.ApprovalId,
                    ItemSerial = index + 1,
                    ItemDesc = i.Description,
                    Qty = i.Quantity,
                    Price = (double?)i.UnitPrice,
                    OriginalPrice = (double?)i.UnitPrice,
                    LastUpdateDate = DateTime.Now,
                    LastUpdateFrom = "API"
                    }).ToList();
            }



        public async Task<List<ApprovalTodatDTO>> GetAllTodayApprovals(string vendor_id)
        {
            return  _context.Approvals.Where(a => a.VendorId == vendor_id && a.OnlineStatus=="p" && a.ApStatus=="d"&& a.ApprovalDate>=DateTime.Now.AddHours(-24)).Select(m=> new ApprovalTodatDTO
            {
               id=m.ApprovalId,
               approval_date = m.ApprovalDate,
               note=m.Notes
               
                
            }).ToList();
        }

        public async Task<List<ApprovalTodatDTO>> Getnotcompeleteapp(string vendor_id)
        {
            return _context.Approvals.Where(a => a.VendorId == vendor_id && a.RequestSource=="Online" && a.OnlineStatus == "N" && a.ApStatus != "d" && a.ApprovalDate >= DateTime.Now.AddHours(-24)).Select(m => new ApprovalTodatDTO
            {
                id = m.ApprovalId,
                approval_date = m.ApprovalDate,
                note = m.Notes


            }).ToList();
        }

    }



}
