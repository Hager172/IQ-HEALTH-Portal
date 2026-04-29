using IQHealthPortal.Application.DTOs.ApprovalDtos;
using IQHealthPortal.Application.Features.approval.Commands.UpdateApprovalItems;
using IQHealthPortal.Application.Features.approval.Queries.GetAllTodayApproval;
using IQHealthPortal.Application.Features.approval.Queries.GetApprovalForEdit;
using IQHealthPortal.Application.Features.approval.Queries.GetMemberApprovals;
using IQHealthPortal.Application.Features.approval.Queries.GetNotCompeleteApp;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace IQ_Health_portal.Controllers
    {
    [Route("api/[controller]")]
    [ApiController]
    public class ApprovalController : ControllerBase
        {
        private readonly IMediator _mediator;

        public ApprovalController(IMediator mediator)
            {
            _mediator = mediator;
            }

        [HttpGet("approvals/{memberId}")]
        public async Task<IActionResult> GetMemberApprovals(string memberId)
            {
            var result = await _mediator.Send(
                new GetMemberApprovalsQuery(memberId));

            return StatusCode(result.Status ?? 200, result);
            }

        [HttpGet("approvals/{approvalNumber}")]
        public async Task<IActionResult> GetApprovalForEdit(string approvalNumber)
            {
            var result = await _mediator.Send(
                new GetApprovalForEditQuery(approvalNumber));

            return StatusCode(result.Status ?? 200, result);
            }

        [HttpPut("approvalitems/{approvalNumber}")]
        public async Task<IActionResult> UpdateItems(
            string approvalNumber,
            [FromBody] List<ApprovalItemDto> items)
            {
            var result = await _mediator.Send(
                new UpdateApprovalItemsCommand(approvalNumber, items));

            return StatusCode(result.Status ?? 200, result);
            }

        [HttpGet ("allapprovaltoday/{vendor_id}")]
        public async Task<IActionResult> GetTodayApprovals (string vendor_id)
        {
            var res = await _mediator.Send(new GetAllTodayApprovalQuery(vendor_id));
            return StatusCode(res.Status ?? 200, res);

        }
        [HttpGet("allapprovalnottoday/{vendor_id}")]
        public async Task<IActionResult> GetTodayNotcompeletApprovals(string vendor_id)
        {
            var res = await _mediator.Send(new GetNotCompeleteAppQuery(vendor_id));
            return StatusCode(res.Status ?? 200, res);

        }


    }
    }
    
