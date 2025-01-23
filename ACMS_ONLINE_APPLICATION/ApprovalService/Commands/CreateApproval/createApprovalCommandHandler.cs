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
using ACMS_ONLINE_INFRASTRUCTURE.UnitOfWork;
using Azure.Core;

namespace ACMS_ONLINE_APPLICATION.ApprovalService.Commands.CreateApproval
{
    public class createApprovalCommandHandler :IRequestHandler<createApprovalCommand, ServiceResponse<CreateApprovalResponse>>
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
        //public async Task<ServiceResponse<CreateApprovalResponse>> Handle (createApprovalCommand request, CancellationToken cancellationToken)
        //{
        //    var serviceResponse = new ServiceResponse<CreateApprovalResponse>();
        //    try
        //    {
        //        CreateApprovalCommandValidator validator = new CreateApprovalCommandValidator();

        //        var result = await validator.ValidateAsync(request);

        //        if (result.Errors.Any())
        //        {
        //            throw new Exception("Approval is not valid");
        //        }
        //        var vendorIdClaim = _contextAccessor.HttpContext?.User?.FindFirst("VendorId");

        //        var approval = new ACMS_ONLINE_INFRASTRUCTURE.Data.Models.Approval();


        //            _mapper.Map(request.Approval, approval);

        //        var ClientId = _contextAccessor.HttpContext?.User.Claims.FirstOrDefault(x => x.Type == "ClientId")?.Value;
        //        var ConnectionString = _unitOfWork.getConnectionStringByClinetId(ClientId);
        //        approval.ApprovalId=(_unitOfWork.ApprovalRepository.GenerateApprovalId(ClientId, ConnectionString));

        //        approval.LastUpdateDate = DateTime.UtcNow;
        //        approval.LastUpdateBy= _contextAccessor.HttpContext?.User.Identity?.Name;
        //        approval.VendorId = vendorIdClaim.Value;
        //        int count = 0;
        //        foreach (var item in request.Services)
        //        {


        //            item.ItemSerial=++count;
        //            item.LastUpdateDate = DateTime.UtcNow;
        //            item.LastUpdateBy = _contextAccessor.HttpContext?.User.Identity?.Name;
        //            approval.ApprovalServices.Add(_mapper.Map(item,  new ACMS_ONLINE_INFRASTRUCTURE.Data.Models.ApprovalService()));


        //        }



        //        foreach (var id in request.DiagnosesIds)
        //        {

        //            var X = await _unitOfWork.OnlinediagnosisRepository.GetByIdAsync(id.ToString()); 
        //            approval.Diagnoses.Add(X);
        //        }


        //        await _unitOfWork.ApprovalRepository.AddAsync(approval);

        //        try
        //        {

        //            var done = _unitOfWork.Save();
        //        }
        //        catch (Exception)
        //        {

        //            throw;
        //        }
        //        finally {

        //            var x= approval.ApprovalId; 
        //            serviceResponse.Data.ApprovalId = approval.ApprovalId;


        //                }


        //    }
        //    catch (Exception ex) 
        //    {

        //    }
        //    return serviceResponse;
        //}


        public async Task<ServiceResponse<CreateApprovalResponse>> Handle(createApprovalCommand request, CancellationToken cancellationToken)
        {
            var serviceResponse = new ServiceResponse<CreateApprovalResponse>
            {
                Data = new CreateApprovalResponse()
            };

            try
            {
                CreateApprovalCommandValidator validator = new CreateApprovalCommandValidator();
                var result = await validator.ValidateAsync(request);

                if (result.Errors.Any())
                {
                    throw new Exception("Approval is not valid");
                }

                var vendorIdClaim = _contextAccessor.HttpContext?.User?.FindFirst("VendorId");

                var approval = new ACMS_ONLINE_INFRASTRUCTURE.Data.Models.Approval();
                _mapper.Map(request.Approval, approval);

                var ClientId = _contextAccessor.HttpContext?.User.Claims.FirstOrDefault(x => x.Type == "ClientId")?.Value;
                var ConnectionString = _unitOfWork.getConnectionStringByClinetId(ClientId);

                approval.ApprovalId = _unitOfWork.ApprovalRepository.GenerateApprovalId(ClientId, ConnectionString);
                approval.LastUpdateDate = DateTime.UtcNow;
                approval.LastUpdateBy = _contextAccessor.HttpContext?.User.Identity?.Name;


                approval.VendorId = vendorIdClaim?.Value;
                approval.ApType = "Surgical";
                approval.ApStatus = "N";
                approval.RequestSource = "IQ-Health-Portal";
                approval.IsOnline = "1";
                approval.OnlineStatus = "P";
                approval.VBranchId = long.Parse(_contextAccessor.HttpContext?.User.Claims.FirstOrDefault(x => x.Type == "BranchId")?.Value);
                int count = 0;
                foreach (var item in request.Services)
                {
                    item.ItemSerial = ++count;
                    //item.LastUpdateDate = DateTime.UtcNow;
                    //item.LastUpdateBy   = _contextAccessor.HttpContext?.User.Identity?.Name;


                    var ap = new ACMS_ONLINE_INFRASTRUCTURE.Data.Models.ApprovalService();
                    item.LastUpdateDate = DateTime.UtcNow;
                    item.LastUpdateBy = _contextAccessor.HttpContext?.User.Identity?.Name;
                    try
                    {
                        approval.ApprovalServices.Add(_mapper.Map(item, ap));

                    }
                    catch (AutoMapperMappingException ex)
                    {
                        //Console.WriteLine($"Error mapping property: {ex.PropertyMap?.DestinationName}");
                        Console.WriteLine($"Exception Message: {ex.Message}");
                        throw;
                    }
                }

                foreach (var id in request.DiagnosesIds)
                {
                    var diagnosis = await _unitOfWork.OnlinediagnosisRepository.GetByIdAsync(id.ToString());
                    if (diagnosis != null)
                    {
                        approval.Diagnoses.Add(diagnosis);
                    }
                }

                await _unitOfWork.ApprovalRepository.AddAsync(approval);


                var done = _unitOfWork.Save();


                serviceResponse.Data.ApprovalId = approval.ApprovalId;
                serviceResponse.Data.IsSuccess = true;
            }
            catch (Exception ex)
            {

                serviceResponse.Success = false;

            }

            return serviceResponse;
        }


    }
}
