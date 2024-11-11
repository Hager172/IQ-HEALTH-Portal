using ACMS_ONLINE_APPLICATION.ApprovalService.Queries.GetApproval;
using  ACMS_ONLINE_INFRASTRUCTURE.Utility.ResponseModel;
using ACMS_ONLINE_APPLICATION.User.GetUserClients;
using ACMS_ONLINE_APPLICATION.User.Login;
using ACMS_ONLINE_APPLICATION.User.SwitchClient;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ACMS_ONLINE_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : Controller
    {
        private readonly IMediator _mediator;


        public AccountController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginCommandDto command)
        {
            var result = await _mediator.Send(command);

            //if (result.IsSuccessful)
            //{
            //    return Ok(new { Token = result.Token });
            //}
            return Ok(new { Token = "result.Token" });

            //return Unauthorized(result.ErrorMessage);
        }

        [Authorize]
        [HttpGet("GetUserClients", Name = "GetUserClients")]
        public async Task<ActionResult<GetApprovalDetailsQuery>> GetPostById()
        {
            var GetUserClients = new GetUserClientsQuery() { };
            return Ok(await _mediator.Send(GetUserClients));
        }

        [Authorize]
        [HttpPost("SwitchAccount", Name = "SwitchClients")]
        public async Task<ActionResult<ServiceResponse<GetApprovalDetailsQuery>>> SwitchAccount(int ClientId)
        {
            var SwitchClientCommand = new SwitchClientCommand() { ClientId = ClientId };
            return Ok(await _mediator.Send(SwitchClientCommand));
        }
    }
}
