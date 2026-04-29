using IQHealthPortal.Application.DTOs.ApprovalDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.Interfaces.Repositories
    {
    public interface IApprovalRepository
        {
        Task<List<MemberApprovalListDto>> GetByMemberIdAsync(string memberId);

        Task<GetApprovalForEditDto?> GetApprovalForEditAsync(string approvalNumber);

        Task UpdateApprovalItemsAsync(string approvalNumber,
            List<ApprovalItemDto> items);
        Task<List<ApprovalTodatDTO>> GetAllTodayApprovals(string vendor_id);
        Task<List<ApprovalTodatDTO>> Getnotcompeleteapp(string vendor_id);

    }
}
