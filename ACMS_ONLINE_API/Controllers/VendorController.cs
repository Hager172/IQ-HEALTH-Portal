using ACMS_ONLINE_APPLICATION.ApprovalService.Queries.GetApproval;
using ACMS_ONLINE_APPLICATION.User.SwitchClient;
using ACMS_ONLINE_APPLICATION.VendorService.Commands.AddClaimsType;
using ACMS_ONLINE_APPLICATION.VendorService.Queries.GetAllVendorServices;
using ACMS_ONLINE_APPLICATION.VendorService.Queries.GetApprovalFileAndClaims;
using ACMS_ONLINE_APPLICATION.VendorService.Queries.GetDiagnosis;
using ACMS_ONLINE_APPLICATION.VendorService.Queries.GetListOfVendorClims;
using ACMS_ONLINE_APPLICATION.VendorService.Queries.GetPharmaServices;
using ACMS_ONLINE_APPLICATION.VendorService.Queries.GetServices;
using ACMS_ONLINE_APPLICATION.VendorService.Queries.GetSetting;
using ACMS_ONLINE_INFRASTRUCTURE.Utility.ResponseModel;
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



        //[HttpGet("GetService/{VendorId}", Name = "GetService")]
        //public async Task<ActionResult<ServiceResponse<GetVendorServicesByVendorIdQueryResponse>>> GetService(string VendorId)
        //{
        //    var SwitchClientCommand = new GetVendorServicesByVendorIdQuery() { VendorId = VendorId };
        //    return Ok(await _mediator.Send(SwitchClientCommand));
        //}

        [HttpGet("GetListVendorClims")]


        public async Task<ActionResult<ServiceResponse<List<GetListOfVendorClimsResponse>>>> GetListVendorClims([FromQuery] GetListOfVendorClimsQuery query)
  
        {
            return Ok(await _mediator.Send(query));
        }

        [HttpGet("GetDiagnosis")]
        public async Task<ActionResult<ServiceResponse<List<GetDiagnosisResponse>>>> GetDiagnosis()
        {
            var GetDiagnosisQuery = new GetDiagnosisQuery();

            return Ok(await _mediator.Send(GetDiagnosisQuery));
        }

        [HttpGet("GetSetting")]
        public async Task<ActionResult<List<GetSettingResponse>>> GetSetting()
        {
            var GetSettingQuery = new GetSettingQuery();

            return Ok(await _mediator.Send(GetSettingQuery));
        }
       

        [HttpGet("GetVendorServiceByClaimType/{type}", Name = "GetVendorServiceByClaimType")]
        public async Task<ActionResult<ServiceResponse<List<GetServicesResponse>>>> GetVendorServiceByClaimType(string type)
        {
            var GetServicesQuery = new GetServicesQuery() { Type = type };
            return Ok(await _mediator.Send(GetServicesQuery));
        }

        [HttpGet("GetPharmaServices")]
        public async Task<ActionResult<ServiceResponse<GetPharmaServicesResponse>>> GetPharmaServices([FromQuery] GetPharmaServicesQuery Query)
        {
            var GetPharmaServicesQuery = Query;
            return Ok(await _mediator.Send(GetPharmaServicesQuery));
        }

        [HttpPost("AddClaimsType")]
        public async Task<ActionResult<AddClaimsTypeResponse>> AddClaimsType([FromForm] AddClaimsTypeCommand query)
        {
            var AddClaimsTypeQuery = query;
            return Ok(await _mediator.Send(AddClaimsTypeQuery));

        }

        [HttpGet("GetApprovalFileAndClaims")]

        public async Task<ActionResult<GetApprovalFileAndClaimsResponse>> GetApprovalFileAndClaims([FromQuery] GetApprovalFileAndClaimsQuery query)
        {
            var GetApprovalFileAndClaimsQuery = query;
            return Ok(await _mediator.Send(GetApprovalFileAndClaimsQuery));

        }

    }
}