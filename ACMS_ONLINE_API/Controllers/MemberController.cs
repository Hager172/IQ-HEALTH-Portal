using ACMS_ONLINE_APPLICATION.ApprovalService.Queries.GetMemberDetails;
using ACMS_ONLINE_APPLICATION.ApprovalService.Queries.GetMemberList;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ACMS_ONLINE_API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : Controller
    {

        private readonly IMediator _mediator;
        public MemberController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        [HttpGet("{id}", Name = "GetMemberById")]
        public async Task<ActionResult<GetMemberDetailsDto>> GetPostById(string id)
        {
            var GetMemberByIdDto = new GetMemberByIdDto() { MemberId = id };
            return Ok(await _mediator.Send(GetMemberByIdDto));
        }
        [HttpGet("all", Name = "GetAllMembers")]
        public async Task<ActionResult<List<GetMemberList>>> GetAllPosts()
        {
            var dtos = await _mediator.Send(new GetMembersListQuery());
            return Ok(dtos);
        }

    }
}
