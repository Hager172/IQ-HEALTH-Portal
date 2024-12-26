using ACMS_ONLINE_INFRASTRUCTURE.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_APPLICATION.VendorService.Queries.GetServices
{
    public class GetServicesResponse
    {
        public int ContractServiceId { get; set; }
        public decimal ContractServicePrices { get; set; }
        public int? ContractServiceSerRef { get; set; }
        public string ContractServiceName { get; set; }
        public string ContractServiceNotes { get; set; }
        public string LastUpdateBy { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public string LastUpdateFrom { get; set; }
        public string ContractServiceContractCode { get; set; }
        public string OldServiceId { get; set; }
        public decimal? ContractServiceDiscount { get; set; }
        public bool? ContractServiceFlag { get; set; }
        public string ExternalCode { get; set; }
        public bool? IsPackage { get; set; }

    }

}
