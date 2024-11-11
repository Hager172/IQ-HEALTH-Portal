using ACMS_ONLINE_APPLICATION.User.GetUserClients;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_APPLICATION.User.GetUserClients
{
    public class GetUserClientsQuery : IRequest<List<GetUserClientsResponse>>
    {
        //public string UserId { get; set; } 
        //public string ClaimType { get; set; } 
    }
}
