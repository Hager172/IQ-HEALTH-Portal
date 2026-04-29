using ACMS_ONLINE_INFRASTRUCTURE.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_INFRASTRUCTURE.Identity.Entities
{
    public class OnlineClient
    {
        [Key]
        public int ClientId { get; set; } 

        [Required]
        [StringLength(150)]
        public string ClientName { get; set; } 

        [Required]
        [StringLength(1000)]
        public string ConnectionString { get; set; }


        public byte IsActive { get; set; }

        public ICollection<OnlineUserClient> OnlineUserClients { get; set; }
    }
}
