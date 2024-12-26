using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_APPLICATION.VendorService.Queries.GetListOfVendorClims
{
    public class GetListOfVendorClimsResponse
    
    {
        public string? ApprovalId { get; set; }
        public string? contract_id { get; set; }
        public string? MemberId { get; set; }
        public string? membername { get; set; }
        public string? CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? vendorname { get; set; }
        public string? vendorbranchname { get; set; }
        public DateTime ApprovalDate { get; set; }
        public string? ApprovedBy { get; set; }
        public string? ApprovedFrom { get; set; }
        public string? ApprovedDate { get; set; }
        public string? Status { get; set; }
        public bool IsEditable { get; set; }
        public bool IsDeletable { get; set; }
        public bool IsPrintable { get; set; }
    }

}
