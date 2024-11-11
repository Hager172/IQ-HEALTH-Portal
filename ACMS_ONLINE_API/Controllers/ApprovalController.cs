using ACMS_ONLINE_APPLICATION.ApprovalService.Commands.Approval;
using ACMS_ONLINE_APPLICATION.ApprovalService.Commands.CreateApproval;
using ACMS_ONLINE_APPLICATION.ApprovalService.Queries.GetApproval;
using ACMS_ONLINE_APPLICATION.ApprovalService.Queries.GetMemberDetails;
using ACMS_ONLINE_APPLICATION.ApprovalService.Queries.GetMemberList;
using  ACMS_ONLINE_INFRASTRUCTURE.Utility.ResponseModel;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ACMS_ONLINE_API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ApprovalController : Controller
    {
        private readonly IMediator _mediator;


        public ApprovalController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet("{id}", Name = "GetApprovalById")]
        public async Task<ActionResult<GetApprovalDetailsQuery>> GetPostById(long id)
        {
            var GetApprovalQuery = new GetApprovalQuery() { ApprovalId = id };
            return Ok(await _mediator.Send(GetApprovalQuery));
        }


        [HttpPost("CreateApproval", Name = "CreateApproval")]
        public async Task<ActionResult<ServiceResponse<CreateApprovalCommandRespond>>> CreateApproval([FromBody] createApprovalCommand command)
        {
            var GetApprovalQuery = command;
            return Ok(await _mediator.Send(GetApprovalQuery));
        }

    }
}
