using ACMS_ONLINE_INFRASTRUCTURE.Data;
using ACMS_ONLINE_INFRASTRUCTURE.Data.Models;
using ACMS_ONLINE_INFRASTRUCTURE.Interfaces;
using ACMS_ONLINE_INFRASTRUCTURE.UnitOfWork;
using ACMS_ONLINE_INFRASTRUCTURE.Utility.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_INFRASTRUCTURE.Repositories
{
    public class RepApproval : BaseRepository<Approval>, IRepApproval
    {
        public RepApproval(DbContext context) : base(context)
        
        {
            
        }

        public long GenerateApprovalId(string ClientId, string ConnectionString)
        {
           

                //var ClientId = _contextAccessor.HttpContext?.User.Claims.FirstOrDefault(x => x.Type == "ClientId")?.Value;
                //var ConnectionString = _unitOfWork.getConnectionStringByClinetId(ClientId);

                long approvalId = 0;
                using (AdoHelper adoHelper = new(ConnectionString))
                {

                    var year = DateTime.Today.ToString("yy");
                    string query = "SELECT [dbo].[f_get_new_approval_id] (0,10" + year + "0000000)";


                    var clients = adoHelper.ExecuteQuery(query, reader =>
                    {
                        return new
                        {
                            approvalId = reader.GetInt64(0)

                        };
                    });


                    return clients.approvalId + 1;
                }


            
        }
    }
}
