using IQHealthPortal.Application.Common.Responses;
using IQHealthPortal.Application.DTOs.ApprovalDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.Features.approval.Queries.GetAllTodayApproval
{
    public class GetAllTodayApprovalQuery:IRequest<ServiceResponse<GetTodayapps>>
    {
        
        public string? vendor_id { get; set; }
        public GetAllTodayApprovalQuery(string vendor_idc)
        {
            this.vendor_id = vendor_idc;
        }
    }
}
