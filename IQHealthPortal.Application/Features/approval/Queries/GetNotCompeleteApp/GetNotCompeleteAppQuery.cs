using IQHealthPortal.Application.Common.Responses;
using IQHealthPortal.Application.DTOs.ApprovalDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.Features.approval.Queries.GetNotCompeleteApp
{
    public class GetNotCompeleteAppQuery : IRequest<ServiceResponse<GetTodayapps>>
    
    {
        public string? vendor_id { get; set; }
        public GetNotCompeleteAppQuery(string vendor_idc)
        {
            this.vendor_id = vendor_idc;
        }

    }
}
