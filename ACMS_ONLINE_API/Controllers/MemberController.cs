using ACMS_ONLINE_APPLICATION.ApprovalService.Queries.GetMemberDetails;
using ACMS_ONLINE_APPLICATION.ApprovalService.Queries.GetMemberList;
using ACMS_ONLINE_APPLICATION.MemberService.Commands.UploadImagePath;
using ACMS_ONLINE_APPLICATION.MemberService.Queries.GetImageMember;
using ACMS_ONLINE_INFRASTRUCTURE.Utility.ResponseModel;
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
        public async Task<ActionResult<GetMemberDetailsDto>> GetPostById([FromQuery] GetMemberByIdDto query)
        {
            var GetMemberByIdDto = query;
            return Ok(await _mediator.Send(GetMemberByIdDto));
        }

        [HttpGet("all", Name = "GetAllMembers")]
        public async Task<ActionResult<List<GetMemberList>>> GetAllPosts()
        {
            var dtos = await _mediator.Send(new GetMembersListQuery());
            return Ok(dtos);
        }


        [HttpGet("GetImageMemberById")]
        public async Task<ActionResult<ServiceResponse< GetImageMemberResponse>>> GetImageMemberById( [FromQuery] GetImageMemberQuery query)
        {
            var GetImageMemberQuery = query;
            return Ok(await _mediator.Send(GetImageMemberQuery));
        }



       



        [HttpPost("UploadImage")]
        public async Task<IActionResult> UploadImage(/*[FromForm] IFormFile file, [FromForm] string folderPath , [FromForm]  string phone , string Email*/UploadImagePathCommand query )
        {
            //if (file == null || file.Length == 0)
            //{
            //    return BadRequest("No file uploaded.");
            //}

            //var command = new UploadImagePathCommand
            //{
            //    file = file,
            //    folderPath = folderPath,
            //    phone = phone
            //};
            var UploadImagePathCommand = query;
            var result = await _mediator.Send(UploadImagePathCommand);

            if (result.Success)
            {
                return Ok(result.Data);
            }

            return StatusCode(500, new { message = result.MessageEn });
        }


    }
}
