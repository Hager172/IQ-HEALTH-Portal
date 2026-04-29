using IQHealthPortal.Application.Features.Authentication.Commands.Login;

using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace IQ_Health_portal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IMediator _mediator;
       

        public AccountController( IMediator mediator)
        {
            _mediator = mediator;
      
        }


        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginCommand command)
        {
            var result = await _mediator.Send(command);


            return Ok(result);


        }


    }
}
