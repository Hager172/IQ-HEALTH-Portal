using ACMS_ONLINE_INFRASTRUCTURE.Data.Models;
using ACMS_ONLINE_INFRASTRUCTURE.Interfaces;
using ACMS_ONLINE_INFRASTRUCTURE.Utility.Helpers;
using ACMS_ONLINE_INFRASTRUCTURE.Utility.ResponseModel;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_APPLICATION.ApprovalService.Queries.GetMemberDetails
{
    public class GetMemberDetailsHandler : IRequestHandler<GetMemberByIdDto, GetMemberDetailsDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;

        
        public GetMemberDetailsHandler(IUnitOfWork unitOfWork, IMapper mapper,IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<GetMemberDetailsDto> Handle(GetMemberByIdDto request, CancellationToken cancellationToken)
        {

            var  serviceResponse = new GetMemberDetailsDto();
            if (string.IsNullOrWhiteSpace(request.MemberId))
            {
                throw new ArgumentException("MemberId cannot be null or empty.");
            }
            var memberDetails = new GetMemberDetailsDto();



            try
            {
                var vendorIdClaim = _httpContextAccessor.HttpContext?.User?.FindFirst("VendorId");
                if (vendorIdClaim == null || string.IsNullOrEmpty(vendorIdClaim.Value))
                {

                    return serviceResponse;
                }

                var vendorId = vendorIdClaim.Value;

                var path = _unitOfWork.OnlineSettingRepository.Find(x => x.Item == "PathImage");


                var member = await _unitOfWork.MemberRepository.FindAsync(x => x.MemberId == request.MemberId, new[] { "MemberParentNavigation", "MemberCustomer","MemberPlans.PlanCodeNavigation.Contract" });
                var status = await _unitOfWork.MemberRepository.getMemberStautsAtDate(request.MemberId.Trim(), DateTime.Now);

                var plan = member.MemberPlans
                                  .FirstOrDefault
                                  (x => x.PlanCodeNavigation.Contract.CustomerContractEndDate >= DateTime.Now
                                  && DateTime.Now >= x.PlanCodeNavigation.Contract.CustomerContractStartDate);
                //.PlanItems.ToList();

                if (plan == null || plan.ContractCodeNavigation == null)
                    return null;

                var ApprovalValidDays = plan.ContractCodeNavigation.ApprovalValid??7;

                TimeSpan time = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                var date = DateTime.Now;
                var current_plan = plan;
                var vendor = await _unitOfWork.VendorGeneralRepository.FindAsync(x => x.VendorId == vendorId, new[] { "VendorCategory.VendorCategoryParentNavigation" });

                var category = vendor.VendorCategory != null ? vendor.VendorCategory.VendorCategoryParent == null ? vendor.VendorCategory.VendorCategoryId : vendor.VendorCategory.VendorCategoryParent : null;
                var planitems = await _unitOfWork.MemberRepository.FGetMemberPlanItems("", current_plan.PlanCode, vendorId, category, request.MemberId.Trim());


                var careItem =await _unitOfWork.OnlineSettingRepository.FindAsync(x => x.Item == "Out-PatiantCareItemId");

                //if (status != "V")
                //{

                //    // return ;
                //}

                var consCopy = planitems.FirstOrDefault(x => x.med_item == careItem?.Value);

                var apps = new List<ApprovalDto>();

                var approvalDb =await _unitOfWork.ApprovalRepository.FindAllAsync(x => x.MemberId == member.MemberId && x.VendorId == vendorId && x.ApprovalDate <= DateTime.Now && x.ApprovalDate >= x.ApprovalDate.AddDays(ApprovalValidDays), new[] { "ApprovalServices" });
                if (approvalDb.Count()>0)
                {
                    apps = approvalDb.Select(x => new ApprovalDto()
                                {
                                    ApprovalId = x.ApprovalId,
                                    ApprovalDate = x.ApprovalDate,
                                    Notes = x.Notes,
                                    ApprovalServices= 
                                        x.ApprovalServices.Select( s => new ApprovalServiceDto()
                                        {
                                            item_serial = s.ItemSerial,
                                            price = s.Price,
                                            qty = s?.Qty??0,
                                            ServiceName = "test"
                                        }).ToList(),


                                        
                                    
                                } ).ToList();
                }

                serviceResponse = new GetMemberDetailsDto
                {
                    MemberId = member.MemberId,
                    MemberName = member.MemberName,
                    MemberCustomerId = member.MemberCustomerId,
                    MemberBirthday = member.MemberBirthday,
                    MemberVip = member.MemberVip,
                    MemberTele = member.MemberTele,
                    MemberStatues = status,
                    ParentName = member?.MemberParentNavigation?.MemberName,
                    PlanCode = plan?.PlanCode,
                    ContractCode = plan?.ContractCode,
                    CustomerName = member?.MemberCustomer?.CustomerName,
                    ImagePath = $"{path.Text.TrimEnd('/')}/{plan?.ContractCode}/{request.MemberId}.jpg",
                    ConsCopay = consCopy?.copay??null,
                    ConsMedItemId = consCopy.med_item,
                    InternalClaims = apps
                    
                };
                return serviceResponse;
                //var connectionString = _unitOfWork.getCurrentConnectionString();

                //        using (AdoHelper adoHelper = new(connectionString))
                //        {
                //            string queryMemberAndPlan = $@"
                //                SELECT 
                //                    M.member_id, 
                //                    M.member_name, 
                //                    M.member_customer_id, 
                //                    M.member_birthday, 
                //                    M.member_vip, 
                //                    M.member_tele, 
                //                    dbo.f_member_status_at_date(M.member_id, GETDATE()) AS member_statues,
                //                    MP.plan_code,
                //                    MP.contract_code,
                //                    A.approval_id,
                //                    A.approval_date,
                //                    A.notes,

                //                    M.member_parent, 
                //                    Parent.member_name AS parent_name ,
                //                    Customer.customer_name  

                //                FROM Members M
                //                LEFT JOIN MemberPlan MP ON M.member_id = MP.member_code
                //                LEFT JOIN Approvals A ON M.member_id = A.member_id
                //                LEFT JOIN Approval_Services S ON A.approval_id = S.approval_id
                //                LEFT JOIN Members Parent ON M.member_parent = Parent.member_id 
                //                LEFT JOIN Customers Customer ON M.member_customer_id = Customer.customer_id 
                //                WHERE M.member_id = '{request.MemberId}'";

                //            var result = adoHelper.ExecuteQueryList(queryMemberAndPlan, reader =>
                //            {
                //                var memberDetailsDto = memberDetailsList.FirstOrDefault(m => m.MemberId == reader.GetString(reader.GetOrdinal("member_id")));

                //                if (memberDetailsDto == null)
                //                {
                //                    memberDetailsDto = new GetMemberDetailsDto
                //                    {
                //                        MemberId = !reader.IsDBNull(reader.GetOrdinal("member_id"))
                //                            ? reader.GetString(reader.GetOrdinal("member_id"))
                //                            : null,
                //                        MemberName = !reader.IsDBNull(reader.GetOrdinal("member_name"))
                //                            ? reader.GetString(reader.GetOrdinal("member_name"))
                //                            : null,
                //                        MemberCustomerId = !reader.IsDBNull(reader.GetOrdinal("member_customer_id"))
                //                            ? reader.GetInt32(reader.GetOrdinal("member_customer_id"))
                //                            : (int?)null,
                //                        MemberBirthday = !reader.IsDBNull(reader.GetOrdinal("member_birthday"))
                //                            ? reader.GetDateTime(reader.GetOrdinal("member_birthday"))
                //                            : (DateTime?)null,
                //                        MemberVip = !reader.IsDBNull(reader.GetOrdinal("member_vip"))
                //                            ? reader.GetBoolean(reader.GetOrdinal("member_vip"))
                //                            : false,
                //                        MemberTele = !reader.IsDBNull(reader.GetOrdinal("member_tele"))
                //                            ? reader.GetString(reader.GetOrdinal("member_tele"))
                //                            : null,
                //                        MemberStatues = !reader.IsDBNull(reader.GetOrdinal("member_statues"))
                //                            ? reader.GetString(reader.GetOrdinal("member_statues"))
                //                            : null,
                //                        balance = "1",
                //                        ParentName = !reader.IsDBNull(reader.GetOrdinal("parent_name"))
                //? reader.GetString(reader.GetOrdinal("parent_name"))
                //: null,
                //                        PlanCode = !reader.IsDBNull(reader.GetOrdinal("plan_code"))
                //                           ? reader.GetString(reader.GetOrdinal("plan_code"))
                //                           : null,
                //                        ContractCode = !reader.IsDBNull(reader.GetOrdinal("contract_code"))
                //                           ? reader.GetString(reader.GetOrdinal("contract_code"))
                //                           : null,

                //                        CustomerName = !reader.IsDBNull(reader.GetOrdinal("customer_name"))
                //                           ? reader.GetString(reader.GetOrdinal("customer_name"))
                //                           : null,
                //                        ImagePath = !reader.IsDBNull(reader.GetOrdinal("contract_code")) && !string.IsNullOrEmpty(request.MemberId)
                //                                    ? $"{path.Text.TrimEnd('/')}/{reader.GetString(reader.GetOrdinal("contract_code"))}/{request.MemberId}.jpg"
                //                                    : null,


                //                        InternalClaims = new List<ApprovalDto>()


                //                    };

                //                    memberDetailsList.Add(memberDetailsDto);
                //                }

                //                if (!reader.IsDBNull(reader.GetOrdinal("approval_id")))
                //                {
                //                    var approvalId = reader.GetInt64(reader.GetOrdinal("approval_id"));
                //                    var approvalDto = memberDetailsDto.InternalClaims.FirstOrDefault(a => a.ApprovalId == approvalId);

                //                    if (approvalDto == null)    
                //                    {
                //                        approvalDto = new ApprovalDto
                //                        {
                //                            ApprovalId = approvalId,
                //                            ApprovalDate = reader.GetDateTime(reader.GetOrdinal("approval_date")),
                //                            Notes = !reader.IsDBNull(reader.GetOrdinal("notes"))
                //                                ? reader.GetString(reader.GetOrdinal("notes"))
                //                                : null,
                //                            ApprovalServices = new List<ApprovalServiceDto>()
                //                        };

                //                        memberDetailsDto.InternalClaims.Add(approvalDto);
                //                    }



                //                    string serviceQuery = $@"
                //                                            SELECT ser_id, serial, med_item, qty, price, ser_name 
                //                                            FROM dbo.f_get_app_serv({approvalId})";

                //                    var services = adoHelper.ExecuteQueryListWithoutOpenCloseConnection(serviceQuery, serviceReader =>
                //                    {
                //                        return new ApprovalServiceDto
                //                        {
                //                            item_serial = serviceReader.GetInt32(serviceReader.GetOrdinal("serial")),
                //                            qty = serviceReader.GetDouble(serviceReader.GetOrdinal("qty")),
                //                            price = serviceReader.GetDouble(serviceReader.GetOrdinal("price")),
                //                            ServiceName = serviceReader.GetString(serviceReader.GetOrdinal("ser_name"))
                //                        };
                //                    });

                //                    approvalDto.ApprovalServices.AddRange(services);
                //                }

                //                return memberDetailsDto;
                //            });

                //            memberDetails = memberDetailsList.FirstOrDefault();
                //        }
            }
            catch (Exception ex)
            {
                Console.WriteLine($": {ex.Message}");
                throw;
            }

            return memberDetails;
        }
    }
}
