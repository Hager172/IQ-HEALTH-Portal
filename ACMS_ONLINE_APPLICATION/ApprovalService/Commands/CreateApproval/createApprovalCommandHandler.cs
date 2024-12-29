using ACMS_ONLINE_APPLICATION.ApprovalService.Commands.Approval;
using ACMS_ONLINE_DOMAIN.Approval;

using ACMS_ONLINE_APPLICATION.ApprovalService.Queries.GetMemberDetails;
using ACMS_ONLINE_DOMAIN.Approval.Entities;
using ACMS_ONLINE_INFRASTRUCTURE.Interfaces;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using ACMS_ONLINE_INFRASTRUCTURE.Data.Models;
using ACMS_ONLINE_INFRASTRUCTURE.Utility.ResponseModel;
using ACMS_ONLINE_INFRASTRUCTURE.Utility.Helpers;
using ACMS_ONLINE_APPLICATION.User.GetUserClients;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace ACMS_ONLINE_APPLICATION.ApprovalService.Commands.CreateApproval
{
    public class createApprovalCommandHandler :IRequestHandler<createApprovalCommand, ServiceResponse<CreateApprovalCommandRespond>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _contextAccessor;
        public createApprovalCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IHttpContextAccessor contextAccessor)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _contextAccessor = contextAccessor;
        }
        public async Task<ServiceResponse<CreateApprovalCommandRespond>> Handle (createApprovalCommand request, CancellationToken cancellationToken)
        {
            var serviceResponse = new ServiceResponse<CreateApprovalCommandRespond>();
            try
            {
                CreateApprovalCommandValidator validator = new CreateApprovalCommandValidator();

                var result = await validator.ValidateAsync(request);

                if (result.Errors.Any())
                {
                    throw new Exception("Approval is not valid");
                }




               
				//if (request == null)
				//    throw new Exception("Your Request is Not Valid");

				//if (request.Services == null)
				//    throw new Exception("Your Request 0 Service !!");

				var approval = ACMS_ONLINE_DOMAIN.Approval.Entities.Approval.Create(request.ClaimDate);

                // set approval Id 
                approval.SetApprovalId(GenerateApprovalId());




                foreach (var item in request.Services)
                {
                    approval.AddService(ACMS_ONLINE_DOMAIN.Approval.Entities.ApprovalService.Create(

                        approvalId: approval.ApprovalId,
                        itemSerial: approval.Services1.Count() + 1,
                        isChronic: item.isChronic,
                        serviceId: item.ServiceId,
                        price: item.Price,
                        itemDescription: item.Note,
                        medItem: item.medItem,
                        dose: new ACMS_ONLINE_DOMAIN.Approval.ValueObjects.Dose(item.DoseUnits, item.DoseRepeat, item.DoseDuration)
                        ));
                }


                var DataModel = _mapper.Map<ACMS_ONLINE_INFRASTRUCTURE.Data.Models.Approval>(approval);


                await _unitOfWork.ApprovalRepository.AddAsync(DataModel);
                var done = _unitOfWork.Save();

                //await _mediator.Publish(new ProductCreatedEvent(product.Id, product.Title, product.Description, product.StockQuantity), cancellationToken);

                //return new CreateApprovalCommandRespond { IsSuccess = true, ApprovalId = approval.ApprovalId.ToString() };
            }
            catch (Exception ex)
            {

            }
            return serviceResponse;
        }
    
        private long GenerateApprovalId()
        {

            var ClientId = _contextAccessor.HttpContext?.User.Claims.FirstOrDefault(x=>x.Type == "ClientId")?.Value;
            var ConnectionString = _unitOfWork.getConnectionStringByClinetId(ClientId);

            long approvalId = 0;
            using (AdoHelper adoHelper = new(ConnectionString))
            {

                var year = DateTime.Today.ToString("yy");
                string query = "SELECT [dbo].[f_get_new_approval_id] (0,10" + year + "0000000)";
                
                
                var clients = adoHelper.ExecuteQuery(query, reader =>
                {
                    return new
                    {
                        approvalId = reader.GetInt64(0)

                    };
                });


                return approvalId + 1;
            } 
        }
    }
}
