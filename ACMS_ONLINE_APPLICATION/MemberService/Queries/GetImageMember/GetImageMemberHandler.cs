using ACMS_ONLINE_INFRASTRUCTURE.Interfaces;
using ACMS_ONLINE_INFRASTRUCTURE.Utility.Helpers;
using ACMS_ONLINE_INFRASTRUCTURE.Utility.ResponseModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_APPLICATION.MemberService.Queries.GetImageMember
{
    public class GetImageMemberHandler : IRequestHandler<GetImageMemberQuery, ServiceResponse<GetImageMemberResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetImageMemberHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<ServiceResponse<GetImageMemberResponse>> Handle(GetImageMemberQuery request, CancellationToken cancellationToken)
        {
            var response = new ServiceResponse<GetImageMemberResponse>();
            try
            {

              var path=  _unitOfWork.OnlineSettingRepository.Find(x => x.Item == "PathImage");
                

                    var imageUrl = $"{path.Text}/{request.ContractId}/{request.MemberId}.jpg";
                

                using (var httpClient = new HttpClient())
                {
                    // Attempt to fetch the image
                    var httpResponse = await httpClient.GetAsync(imageUrl, cancellationToken);

                    if (httpResponse.IsSuccessStatusCode)
                    {
                        // Read the image content as bytes
                        var fileContent = await httpResponse.Content.ReadAsByteArrayAsync();

                        var getImageMemberResponse = new GetImageMemberResponse
                        {
                            MemberId = request.MemberId,
                            FileContent = fileContent
                        };

                        response.Data = getImageMemberResponse;
                        response.Success = true;
                    }
                    else
                    {
                        // Handle when the image is not found (404 or other errors)
                        response.Success = false;
                        response.MessageEn = $"Image not found at URL: {imageUrl}";
                    }
                }
            }
            catch (Exception ex)
             {
                // Handle exceptions
                response.Success = false;
                response.MessageEn = ex.Message;
            }

            return response;
        }


    }
}
