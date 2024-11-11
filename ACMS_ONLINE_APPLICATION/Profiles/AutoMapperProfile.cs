using ACMS_ONLINE_APPLICATION.ApprovalService.Queries.GetMemberDetails;
using ACMS_ONLINE_APPLICATION.User.Dto;
using ACMS_ONLINE_APPLICATION.User.GetUserClients;
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
            CreateMap<ACMS_ONLINE_INFRASTRUCTURE.Data.Models.ClientOnlineUser, UserClientDto>().ReverseMap();
            CreateMap<ACMS_ONLINE_INFRASTRUCTURE.Data.Models.ClientOnlineUser, GetUserClientsResponse>().ReverseMap();


            //<<<
            //CreateMap< GetMemberDetailsDto ,  ACMS_ONLINE_INFRASTRUCTURE.Data.Models.Member > ().ReverseMap();
            //CreateMap<UserClientDto, ACMS_ONLINE_INFRASTRUCTURE.Data.Models.ClientOnlineUser>().ReverseMap();
            //CreateMap<GetUserClientsResponse,  ACMS_ONLINE_INFRASTRUCTURE.Data.Models.ClientOnlineUser > ().ReverseMap();

        }
    }
}
