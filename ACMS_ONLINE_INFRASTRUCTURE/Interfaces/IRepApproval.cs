using ACMS_ONLINE_INFRASTRUCTURE.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_INFRASTRUCTURE.Interfaces
{
    public interface IRepApproval :IBaseRepository<Approval>
    {
        //Task<> GetApprovalStatsAsync(string vendorId);

        long GenerateApprovalId(string ClientId, string ConnectionString);
    }
}
