using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_INFRASTRUCTURE.Identity.Entities
{
    public class OnlineUserClient
    {
        [Key]
        [Column(Order = 1)]
        public string UserId { get; set; } 

        [Key]
        [Column(Order = 2)]
        public int ClientId { get; set; } 

        [Required]
        public bool IsDefault { get; set; } 

        [StringLength(50)]
        public string VendorId { get; set; } 

        public long? BranchId { get; set; } 

        // Navigation properties 
        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; } 

        [ForeignKey("ClientId")]
        public OnlineClient OnlineClient { get; set; }
    }
}
