using ACMS_ONLINE_APPLICATION.ApprovalService.Queries.GetMemberDetails;
using ACMS_ONLINE_APPLICATION.User.Dto;
using ACMS_ONLINE_APPLICATION.User.GetUserClients;
using ACMS_ONLINE_APPLICATION.UserService.Queries.GetUserData;
using ACMS_ONLINE_APPLICATION.VendorService.Queries.GetServices;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ACMS_ONLINE_APPLICATION.Profiles
{
    internal class AutoMapperProfile :Profile
    {
        public AutoMapperProfile()
        {

            //>>>
            CreateMap<ACMS_ONLINE_INFRASTRUCTURE.Data.Models.Member, GetMemberDetailsDto>().ReverseMap();
            CreateMap<ACMS_ONLINE_INFRASTRUCTURE.Data.Models.ContractService, GetServicesResponse > ().ReverseMap();
            CreateMap<ACMS_ONLINE_INFRASTRUCTURE.Identity.Entities.Page,ACMS_ONLINE_APPLICATION.UserService.Queries.GetUserData. Page>()
                //.ForMember(dest => dest.SubPages, opt => opt.MapFrom(src => src.SubPages));
                .ReverseMap();

            //CreateMap<ACMS_ONLINE_INFRASTRUCTURE.Data.Models.ClientOnlineUser, UserClientDto>().ReverseMap();
            //CreateMap<ACMS_ONLINE_INFRASTRUCTURE.Data.Models.ClientOnlineUser, GetUserClientsResponse>().ReverseMap();


            //<<<
            //CreateMap< GetMemberDetailsDto ,  ACMS_ONLINE_INFRASTRUCTURE.Data.Models.Member > ().ReverseMap();
            //CreateMap<UserClientDto, ACMS_ONLINE_INFRASTRUCTURE.Data.Models.ClientOnlineUser>().ReverseMap();
            //CreateMap<GetUserClientsResponse,  ACMS_ONLINE_INFRASTRUCTURE.Data.Models.ClientOnlineUser > ().ReverseMap();
            CreateMap<ACMS_ONLINE_INFRASTRUCTURE.Data.Models.Approval, ACMS_ONLINE_DOMAIN.Approval.Entities.Approval>()
    .ForMember(dest => dest._service, opt => opt.MapFrom(src => src.ApprovalServices))
    .ForMember(dest => dest._diagnoses, opt => opt.MapFrom(src => src.Diagnoses))
    .ForMember(dest => dest._member, opt => opt.MapFrom(src => src.Member))
    .ForMember(dest => dest._clamTypes, opt => opt.MapFrom(src => src.Types))
    .ReverseMap() // Reverse map configuration
    .ForMember(dest => dest.ApprovalServices, opt => opt.MapFrom(src => src._service))
    .ForMember(dest => dest.Diagnoses, opt => opt.MapFrom(src => src._diagnoses)).ReverseMap();

            CreateMap<ACMS_ONLINE_INFRASTRUCTURE.Data.Models.ApprovalService, ACMS_ONLINE_DOMAIN.Approval.Entities.ApprovalService>()
    .ReverseMap();

            CreateMap<ACMS_ONLINE_INFRASTRUCTURE.Data.Models.OnlineDiagnosis, ACMS_ONLINE_DOMAIN.Approval.Entities.OnlineDiagnosis>()
                .ReverseMap();

            CreateMap<ACMS_ONLINE_INFRASTRUCTURE.Data.Models.ClaimsType, ACMS_ONLINE_DOMAIN.Approval.Entities.ClaimsType>().ReverseMap();
        }
    }
}
