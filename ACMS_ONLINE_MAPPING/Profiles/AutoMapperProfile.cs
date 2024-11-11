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
            // Mapping from Domain model to Data model
            CreateMap<ACMS_ONLINE_DOMAIN.Approval.Entities.Approval, ACMS_ONLINE_INFRASTRUCTURE.Data.Models.Approval >()
                .ForMember(dest => dest.ApprovalServices, opt => opt.MapFrom(src => src.Services))
                .ForMember(dest => dest.Diagnoses, opt => opt.MapFrom(src => src.Diagnoses));

            CreateMap< ACMS_ONLINE_DOMAIN.Approval.Entities.ApprovalService, ACMS_ONLINE_INFRASTRUCTURE.Data.Models.ApprovalService >();
            CreateMap<ACMS_ONLINE_DOMAIN.Medication.Entities.Diagnose, ACMS_ONLINE_INFRASTRUCTURE.Data.Models.OnlineDiagnosis >();

            // Reverse mapping if needed
            CreateMap< ACMS_ONLINE_INFRASTRUCTURE.Data.Models.Approval, ACMS_ONLINE_DOMAIN.Approval.Entities.Approval>();
            CreateMap<ACMS_ONLINE_INFRASTRUCTURE.Data.Models.ApprovalService, ACMS_ONLINE_DOMAIN.Approval.Entities.ApprovalService>();
            CreateMap<ACMS_ONLINE_INFRASTRUCTURE.Data.Models.OnlineDiagnosis, ACMS_ONLINE_DOMAIN.Medication.Entities.Diagnose>();
        }
    }
}
