using ACMS_ONLINE_APPLICATION.User.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_APPLICATION.User.Login
{
    public class LoginResponseDto
    {
        public bool IsPharma { get; set; } = false;
        public string VendorId { get; set; }
        public string BranchId { get; set; }
        public string? Message { get; set; }
        public bool IsAuthenticated { get; set; }
        public string? Username { get; set; }
        public List<UserClientDto> Clients { get; set; }
        public List<string>? Roles { get; set; }
        public string? Token { get; set; }
        public DateTime? ExpiresOn { get; set; }

        //[JsonIgnore]
        public string? RefreshToken { get; set; }

        public DateTime RefreshTokenExpiration { get; set; }
    }
}
