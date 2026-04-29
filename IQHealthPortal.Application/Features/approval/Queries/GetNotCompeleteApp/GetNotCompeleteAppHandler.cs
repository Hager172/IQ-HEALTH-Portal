using IQHealthPortal.Application.Common.Responses;
using IQHealthPortal.Application.DTOs.ApprovalDtos;
using IQHealthPortal.Application.Features.approval.Queries.GetAllTodayApproval;
using IQHealthPortal.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.Features.approval.Queries.GetNotCompeleteApp
{
    public class GetNotCompeleteAppHandler : IRequestHandler<GetNotCompeleteAppQuery, ServiceResponse<GetTodayapps>>
    {
        private readonly IUnitOfWork _uow;

            public GetNotCompeleteAppHandler(IUnitOfWork uow)
        {
            this._uow = uow;
        }
        public async Task<ServiceResponse<GetTodayapps>> Handle(
        GetNotCompeleteAppQuery request,
         CancellationToken cancellationToken)
        {
            var response = new ServiceResponse<GetTodayapps>();
            var approval = await _uow.ApprovalRepository.Getnotcompeleteapp(request.vendor_id);

            if (approval == null)
            {
                response.Success = false;
                response.Status = 404;
                return response;
            }
            var result = new GetTodayapps
            {
                vendor_id = int.TryParse(request.vendor_id, out var v) ? v : null,
                Approvals = approval
            };
            response.Data = result;
            response.Success = true;
            response.Status = 200;

            return response;
        }
    }
}
