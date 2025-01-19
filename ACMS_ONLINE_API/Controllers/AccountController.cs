using ACMS_ONLINE_APPLICATION.ApprovalService.Queries.GetApproval;
using  ACMS_ONLINE_INFRASTRUCTURE.Utility.ResponseModel;
using ACMS_ONLINE_APPLICATION.User.GetUserClients;
using ACMS_ONLINE_APPLICATION.User.Login;
using ACMS_ONLINE_APPLICATION.User.SwitchClient;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ACMS_ONLINE_INFRASTRUCTURE.Identity.Entities;
using ACMS_ONLINE_APPLICATION.UserService.Queries.GetUserData;
using ACMS_ONLINE_APPLICATION.UserService.Command.RefreshToken;

namespace ACMS_ONLINE_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : Controller
    {
        private readonly IMediator _mediator;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController(UserManager<ApplicationUser> userManager,
                                   SignInManager<ApplicationUser> signInManager, IMediator mediator)
        {
            _mediator = mediator;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginCommandDto command)
        {
            var result = await _mediator.Send(command);

            //if (result.IsSuccessful)
            //{
            //    return Ok(new { Token = result.Token });
            //}
            return Ok(result);

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
        [HttpPost("SwitchClients", Name = "SwitchClients")]
        public async Task<ActionResult<ServiceResponse<GetApprovalDetailsQuery>>> SwitchClients([FromQuery] int ClientId)
        {

     
            var SwitchClientCommand = new SwitchClientCommand() { ClientId = ClientId };
            return Ok(await _mediator.Send(SwitchClientCommand));
        }

        [Authorize]
        [HttpGet("Me", Name = "Me")]
        public async Task<ActionResult<ServiceResponse<GetUserDataQueryResponse>>> Me()
        {
            var GetuserDataQuery = new GetuserDataQuery() {  };
            return Ok(await _mediator.Send(GetuserDataQuery));
        }
        //[Authorize]
        [HttpPost("RefreshToken", Name = "RefreshToken")]
        public async Task<ActionResult<ServiceResponse<GetApprovalDetailsQuery>>> RefreshToken(RefreshTokenCommandDto refreshToken)
        {
            var RefreshTokenCommandDto = new RefreshTokenCommandDto() { RefreshToken = refreshToken.RefreshToken.Trim() };
            return Ok(await _mediator.Send(RefreshTokenCommandDto));
        }

            
        //public class RegisterUserRequest
        //{
        //    public string Email { get; set; }
        //    public string Password { get; set; }
        //}


        //[HttpPost("register")]
        //public async Task<IActionResult> Register([FromBody] RegisterUserRequest request)
        //{
        //    if (request == null || string.IsNullOrWhiteSpace(request.Email) || string.IsNullOrWhiteSpace(request.Password))
        //    {
        //        return BadRequest("Email and password are required.");
        //    }

        //    // Check if the email already exists
        //    var existingUser = await _userManager.FindByEmailAsync(request.Email);
        //    if (existingUser != null)
        //    {
        //        return BadRequest("Email is already taken.");
        //    }

        //    // Create a new user object
        //    var newUser = new ApplicationUser
        //    {
        //        UserName = request.Email,
        //        Email = request.Email
        //    };

        //    // Create the user in the database with the provided password
        //    var result = await _userManager.CreateAsync(newUser, request.Password);

        //    if (!result.Succeeded)
        //    {
        //        // Return validation errors if any
        //        return BadRequest(result.Errors);
        //    }

        //    // Optionally, you can sign in the user after creating them
        //    // await _signInManager.SignInAsync(newUser, isPersistent: false);

        //    return Ok("User created successfully.");
        //}
    }
}
