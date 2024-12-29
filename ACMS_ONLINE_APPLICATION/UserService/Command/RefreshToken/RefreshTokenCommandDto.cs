using ACMS_ONLINE_APPLICATION.User.Login;
using ACMS_ONLINE_INFRASTRUCTURE.Utility.ResponseModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_APPLICATION.UserService.Command.RefreshToken
{
    public class RefreshTokenCommandDto : IRequest<ServiceResponse<RefreshTokenCommandResponse>>
    {
        public string RefreshToken { get; set; }
    }
}
