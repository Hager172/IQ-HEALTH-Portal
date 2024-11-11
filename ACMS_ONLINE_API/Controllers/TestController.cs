using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ACMS_ONLINE_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("ServerWork")]
        public async Task<ActionResult<string>> ServerWork()
        {

            return Ok("Server Is Working");

        }
        [Authorize]
        [HttpGet("GetMemberId")]
        public async Task<ActionResult<string>> getMemberId()
        {

            return Ok("Server Is Working Authorize");

        }

    }
}
