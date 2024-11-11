using ACMS_ONLINE_INFRASTRUCTURE.Utility.Helpers;
using ACMS_ONLINE_APPLICATION.User.GetUserClients;
using ACMS_ONLINE_INFRASTRUCTURE.Data.Models;
using ACMS_ONLINE_INFRASTRUCTURE.Interfaces;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_APPLICATION.User.GetUserClients
{
    public class GetUserClientsHandler : IRequestHandler<GetUserClientsQuery, List<GetUserClientsResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _contextAccessor;
        public GetUserClientsHandler(IUnitOfWork unitOfWork , IMapper mapper,IHttpContextAccessor httpContextAccessor)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _contextAccessor = httpContextAccessor;
        }

        public async Task<List<GetUserClientsResponse>> Handle(GetUserClientsQuery request, CancellationToken cancellationToken)
        {
            var UserId = _contextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);

            

            var ConnectionString = _unitOfWork.GetDefaultConnectionString();

            using (AdoHelper adoHelper = new(ConnectionString))
            {
                string query = $"select us.client_id,vendor_id , branch_id,c.client_name " +
                    $"from online_user_client us join online_client c on us.client_id = c.client_id  where user_id='{UserId}'";

                var clients = adoHelper.ExecuteQueryList(query, reader =>
                {
                    return new GetUserClientsResponse
                    {
                        ClientId = reader.GetInt32(0),
                        VendorId = reader.GetString(1),
                        BranchId = reader.GetInt64(2),
                        ClientName = reader.GetString(3),

                    };
                });

               
                return clients;
            }
        }
    }

}
