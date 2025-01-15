using ACMS_ONLINE_INFRASTRUCTURE.Data.Models;

using ACMS_ONLINE_INFRASTRUCTURE.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACMS_ONLINE_INFRASTRUCTURE.Repositories;

namespace ACMS_ONLINE_INFRASTRUCTURE.Interfaces
{
    public interface IUnitOfWork :IDisposable
    {

        IBaseRepository<Member> MemberRepository { get; set; }
        //IBaseRepository<Approval> ApprovalRepository { get; set; }
        IBaseRepository<ACMS_ONLINE_INFRASTRUCTURE.Identity.Entities.OnlineClient> OnlineClientRepository { get; set; }
        IBaseRepository<ACMS_ONLINE_INFRASTRUCTURE.Identity.Entities.OnlineUserClient> OnlineUserClientRepository { get; set; }
        IBaseRepository<Identity.Entities.Page> PagesRepository { get; set; }
        IBaseRepository<Identity.Entities.Privilege> PrivilegesRepository { get; set; }
        IBaseRepository<OnlineSetting> OnlineSettingRepository { get; set; }
        IBaseRepository<OnlineDiagnosis> OnlinediagnosisRepository { get; set; }
        public IClaimsTypeRepository ClaimsTypeRepository { get; set; }
        public IBaseRepository<ApprovalsArchive> ApprovalsArchiveRepository { get; set; }
        ContractServicesRepository ContractServiceRepository { get; set; }
        public IRepApproval ApprovalRepository { get; set; }
        public void SetConnectionString(string clientId);
        public string getConnectionStringByClinetId(string clientId);
        public string GetDefaultConnectionString();
        public string getCurrentConnectionString();
        public int Save();
    }
}
