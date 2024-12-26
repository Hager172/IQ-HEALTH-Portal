using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_APPLICATION.VendorService.Queries.GetPharmaServices
{
    public class GetPharmaServicesResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public string Notes { get; set; }
        public string PriceUpdateId { get; set; }
        public string LastUpdateBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string Availability { get; set; }
        public string Source { get; set; }
        public string UnitSale { get; set; }
        public int? SubUnitNo { get; set; }
        public decimal? DoseUnitNo { get; set; }
        public string DoseForm { get; set; }
        public int? Active { get; set; }
        public DateTime? LastPriceDate { get; set; }
        public string Type { get; set; }
    }

}
