using ACMS_ONLINE_INFRASTRUCTURE.Interfaces;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_APPLICATION.ApprovalService.Queries.GetMemberDetails
{
    public class GetMemberDetailsHandler : IRequestHandler <GetMemberByIdDto,GetMemberDetailsDto>
    {
        private readonly IUnitOfWork _unitOfWork ;
        private readonly IMapper _mapper;
        public GetMemberDetailsHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<GetMemberDetailsDto> Handle (GetMemberByIdDto request, CancellationToken cancellationToken)
        {
            var member = await _unitOfWork.MemberRepository.GetByIdAsync(request.MemberId);

            return _mapper.Map<GetMemberDetailsDto>(member);
        }
    }
}
