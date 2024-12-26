

using ACMS_ONLINE_APPLICATION.VendorService.Queries.GetDiagnosis;
using ACMS_ONLINE_INFRASTRUCTURE.Utility.ResponseModel;
using MediatR;

namespace ACMS_ONLINE_APPLICATION.VendorService.Queries.GetSetting
{
    public class GetSettingQuery : IRequest<ServiceResponse<List<GetSettingResponse>>>
    {
    }
}
