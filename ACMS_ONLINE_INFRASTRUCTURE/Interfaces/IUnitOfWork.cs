using ACMS_ONLINE_INFRASTRUCTURE.Data.Models;
using ACMS_ONLINE_INFRASTRUCTURE.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_INFRASTRUCTURE.Interfaces
{
    public interface IUnitOfWork :IDisposable
    {

        public IBaseRepository<Member> MemberRepository { get; set; }
        public IBaseRepository<Approval> ApprovalRepository { get; set; }
        public IBaseRepository<OnlineClient> OnlineClientRepository { get; set; }
        public IBaseRepository<OnlineUserClient> OnlineUserClientRepository { get; set; }
        public void SetConnectionString(string clientId);
        public string getConnectionStringByClinetId(string clientId);
        public string GetDefaultConnectionString();
        public string getCurrentConnectionString();
        public int Save();
    }
}
