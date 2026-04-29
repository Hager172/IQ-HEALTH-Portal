using IQHealthPortal.Application.Features.vendor.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IQ_Health_portal.Controllers
    {
    [Route("api/[controller]")]
    [ApiController]
    public class VendorController : ControllerBase
        {
        private readonly IMediator _mediator;

        public VendorController(IMediator mediator)
            {
            _mediator = mediator;
            }

        [HttpGet("with-services")]
        public async Task<IActionResult> GetAllWithServices()
            {
            var result = await _mediator.Send(
                new GetAllVendorsWithServicesQuery());

            return Ok(result);
            }
        }
    }
