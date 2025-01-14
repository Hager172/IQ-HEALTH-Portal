using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_INFRASTRUCTURE.Identity.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string? PathImage { get; set; }
    }
}
