using ACMS_ONLINE_APPLICATION.VendorService.Queries.GetListOfVendorClims;
using ACMS_ONLINE_INFRASTRUCTURE.Data.Models;
using ACMS_ONLINE_INFRASTRUCTURE.Interfaces;
using ACMS_ONLINE_INFRASTRUCTURE.Utility.ResponseModel;
using AutoMapper;
using Azure.Core;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_APPLICATION.VendorService.Commands.AddClaimsType
{
    public class AddClaimsTypeHandler : IRequestHandler<AddClaimsTypeCommand, ServiceResponse<AddClaimsTypeResponse>>


    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AddClaimsTypeHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }



        //public async Task<ServiceResponse<AddClaimsTypeResponse>> Handle(AddClaimsTypeCommand request, CancellationToken cancellationToken)
        //{
        //    try
        //    {

        //        var appr = await _unitOfWork.ApprovalRepository.FindAsync(x => x.ApprovalId == request.Approvalid, new[] { "Diagnoses", "ApprovalServices", "Types" });


        //        var claimstype = await _unitOfWork.ClaimsTypeRepository.FindAsync(x => x.TypeId == request.Typeid);


        //        var aaa = _mapper.Map<ACMS_ONLINE_DOMAIN.Approval.Entities.Approval>(appr);


        //        var vv = _mapper.Map<ACMS_ONLINE_DOMAIN.Approval.Entities.ClaimsType>(claimstype);


        //        //aaa.AddClaimType(vv);



        //        appr.Types.Add(claimstype);


        //        _unitOfWork.ApprovalRepository.Update(appr);


        //        // Save the file to a specific directory
        //        if (request.file != null && request.file.Length > 0)
        //        {
        //            var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "UploadedFiles");

        //            if (!Directory.Exists(uploadsFolder))
        //                Directory.CreateDirectory(uploadsFolder);

        //            var uniqueFileName = $"{Guid.NewGuid()}_{Path.GetFileName(request.file.FileName)}";
        //            var filePath = Path.Combine(uploadsFolder, uniqueFileName);

        //            using (var stream = new FileStream(filePath, FileMode.Create))
        //            {
        //                await request.file.CopyToAsync(stream);
        //            }

        //            var archiveEntry = new ApprovalsArchive
        //            {
        //                Name = request.file.FileName,
        //                Path = request.file.FileName,
        //                ApprovalId = request.Approvalid,
        //                LastUpdateBy = "System",
        //                LastUpdateDate = DateTime.UtcNow,


        //            };

        //            _unitOfWork.ApprovalsArchiveRepository.Add(archiveEntry);
        //        }

        //        _unitOfWork.Save();
        //    }
        //    catch (Exception ex)
        //    {

        //        var d = ex.GetBaseException();
        //        throw;
        //    }

        //    // Return a success response
        //    var ServiceResponse = new ServiceResponse<AddClaimsTypeResponse>() { Success = true, MessageEn = "Data Saved successfully" };
        //    return ServiceResponse;
        //}

        public async Task<ServiceResponse<AddClaimsTypeResponse>> Handle(AddClaimsTypeCommand request, CancellationToken cancellationToken)
        {
            try
            {
                // Retrieve the approval record
                var appr = await _unitOfWork.ApprovalRepository.FindAsync(
                    x => x.ApprovalId == request.Approvalid,
                    new[] { "Diagnoses", "ApprovalServices", "Types" }
                );

                if (appr == null)
                {
                    return new ServiceResponse<AddClaimsTypeResponse>
                    {
                        Success = false,
                        MessageEn = "Approval not found."
                    };
                }

                appr.Types.Clear();
                foreach (var typeId in request.Typeid)
                {
                    
                    if (appr.Types.Any(x => x.TypeId == typeId))
                    {
                        continue; 
                    }

                    var claimstype = await _unitOfWork.ClaimsTypeRepository.FindAsync(x => x.TypeId == typeId);

                    if (claimstype == null)
                    {
                        return new ServiceResponse<AddClaimsTypeResponse>
                        {
                            Success = false,
                            MessageEn = $"Claim type with ID {typeId} not found."
                        };
                    }

                   
                    appr.Types.Add(claimstype);
                }

               
                if (request.file != null && request.file.Length > 0)
                {
                    var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "UploadedFiles");

                    if (!Directory.Exists(uploadsFolder))
                        Directory.CreateDirectory(uploadsFolder);

                    
                    var existingArchive = await _unitOfWork.ApprovalsArchiveRepository.FindAllAsync(x => x.ApprovalId == request.Approvalid);
                    foreach (var archive in existingArchive)
                    {
                        var existingFilePath = Path.Combine(uploadsFolder, archive.Path);
                        if (File.Exists(existingFilePath))
                        {
                            File.Delete(existingFilePath);
                        }
                        _unitOfWork.ApprovalsArchiveRepository.Delete(archive);
                    }

                   
                    var uniqueFileName = $"{Path.GetFileName(request.file.FileName)}";
                    var filePath = Path.Combine(uploadsFolder, uniqueFileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await request.file.CopyToAsync(stream);
                    }

                  
                    var archiveEntry = new ApprovalsArchive
                    {
                        Name = request.file.FileName,
                        Path = request.file.FileName,
                        ApprovalId = request.Approvalid,
                        LastUpdateBy = "System",
                        LastUpdateDate = DateTime.UtcNow
                    };

                    _unitOfWork.ApprovalsArchiveRepository.Add(archiveEntry);
                }

                _unitOfWork.ApprovalRepository.Update(appr);
                _unitOfWork.Save();

                return new ServiceResponse<AddClaimsTypeResponse>
                {
                    Success = true,
                    MessageEn = "Data saved successfully."
                };
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while saving data.", ex);
            }
        }

    }
}
