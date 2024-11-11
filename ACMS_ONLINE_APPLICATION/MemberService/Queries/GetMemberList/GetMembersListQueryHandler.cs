using ACMS_ONLINE_INFRASTRUCTURE.Interfaces;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_APPLICATION.ApprovalService.Queries.GetMemberList
{
    public class GetMembersListQueryHandler : IRequestHandler<GetMembersListQuery, List<GetMemberList>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public GetMembersListQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<List<GetMemberList>> Handle(GetMembersListQuery request, CancellationToken cancellationToken)
        {
            var allMembers = await _unitOfWork.MemberRepository.GetAllAsync();
            return _mapper.Map<List<GetMemberList>>(allMembers);
        }
    }
}
