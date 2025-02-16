using ACMS_ONLINE_INFRASTRUCTURE.Data;
using ACMS_ONLINE_INFRASTRUCTURE.Data.Models;
using ACMS_ONLINE_INFRASTRUCTURE.Utility.Helpers;
using ACMS_ONLINE_INFRASTRUCTURE.Utility.ResponseModel;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_INFRASTRUCTURE.Repositories
{
    public class ContractServicesRepository  : BaseRepository<ContractService>
    {
        private readonly DbContext _context;
        public ContractServicesRepository(DbContext context) : base(context)
        {
            _context = context;
        }

        
        public async Task<List<ContractService>> GetVendorServiceByClaimType(string Type ,  string VendorId)
        {

            //VendorId = "Hp00536";
            var Sqltype = (Type == "Out Patient" || Type == "مرضى خارجيون") ? "كشف" : "";
            var services = new List<ContractService>();
            using (AdoHelper adoHelper = new AdoHelper (_context.Database.GetConnectionString()))
            {

                // Step 2: Retrieve contract services based on vendor contract ID
                var query2 = $@"
                 SELECT 
                    [contract_service_id],
                    [contract_service_prices],
                    [contract_service_ser_ref],
                    [contract_service_name],
                    [contract_service_notes],
                    cs.[last_update_by],
	                cs. [last_update_date],
                    cs.[last_update_from],
                    [contract_service_contract_code],
                    [old_service_id],
                    [contract_service_discount],
                    [contract_service_flag],
                    [external_code],
                    [is_package]
                 FROM contract_services cs
                 join vendor_contract vc on cs.contract_service_contract_code = vc.vendor_contract_id
                 WHERE
	 	            contract_service_name LIKE '%{Sqltype}%'
	                And vc.vendor_contract_vendor_id ='{VendorId}'
	                And GETDATE() between vc.vendor_contract_start_date and vc.vendor_contract_end_date";

                services = adoHelper.ExecuteQueryList(query2, reader => new ContractService
                {
                    ContractServiceId = Convert.ToInt32(reader["contract_service_id"]),
                    ContractServicePrices = Convert.ToDouble(reader["contract_service_prices"]),
                    ContractServiceSerRef = reader["contract_service_ser_ref"] == DBNull.Value ? null : Convert.ToInt32(reader["contract_service_ser_ref"]),
                    ContractServiceName = reader["contract_service_name"]?.ToString(),
                    ContractServiceNotes = reader["contract_service_notes"]?.ToString(),
                    LastUpdateBy = reader["last_update_by"]?.ToString(),
                    LastUpdateDate = Convert.ToDateTime(reader["last_update_date"]),
                    LastUpdateFrom = reader["last_update_from"]?.ToString(),
                    ContractServiceContractCode = reader["contract_service_contract_code"]?.ToString(),
                    OldServiceId = reader["old_service_id"] == DBNull.Value ? null : reader["old_service_id"].ToString(),
                    ContractServiceDiscount = reader["contract_service_discount"] == DBNull.Value ? null : (double?)Convert.ToDecimal(reader["contract_service_discount"]),
                    ContractServiceFlag = reader["contract_service_flag"] == DBNull.Value ? false : (bool)Convert.ToBoolean(reader["contract_service_flag"]),
                    ExternalCode = reader["external_code"]?.ToString(),
                    IsPackage = reader["is_package"] == DBNull.Value ? null : (bool?)Convert.ToBoolean(reader["is_package"]),
                });

                
               
            }
            return services;
        }
    }
}
