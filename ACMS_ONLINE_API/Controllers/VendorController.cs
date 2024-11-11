using ACMS_ONLINE_APPLICATION.ApprovalService.Queries.GetApproval;
using ACMS_ONLINE_APPLICATION.VendorService.GetAllVendorServices;
using  ACMS_ONLINE_INFRASTRUCTURE.Utility.ResponseModel;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ACMS_ONLINE_API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class VendorController : Controller
    {
        private readonly IMediator _mediator;
        public VendorController(IMediator mediator)
        {
            _mediator = mediator;
        }



        [HttpGet]
        [HttpGet("GetService/{VendorId}", Name = "GetService")]
        public async Task<ActionResult<ServiceResponse<GetVendorServicesByVendorIdQueryResponse>>> GetService(string VendorId)
        {
            var SwitchClientCommand = new GetVendorServicesByVendorIdQuery() { VendorId = VendorId };
            return Ok(await _mediator.Send(SwitchClientCommand));
        }
    }
}
