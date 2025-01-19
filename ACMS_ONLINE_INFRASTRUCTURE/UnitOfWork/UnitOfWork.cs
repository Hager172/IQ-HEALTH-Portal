using ACMS_ONLINE_INFRASTRUCTURE.Data;
using ACMS_ONLINE_INFRASTRUCTURE.Data.Models;
using ACMS_ONLINE_INFRASTRUCTURE.Interfaces;
using ACMS_ONLINE_INFRASTRUCTURE.Repositories;
using ACMS_ONLINE_INFRASTRUCTURE.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_INFRASTRUCTURE.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbContextFactory _dbContextFactory;
        private ApplicationDbContext _dbContext;
        private readonly IConnectionStringProvider _connectionStringProvider;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IdentityContext _dbIdentityContext;

        // Repositories for ApplicationDbContext

        public IMemberRepository MemberRepository { get; set; }
        public IBaseRepository<ApprovalService> ApprovalServiceRepository { get; set; }
        public IBaseRepository<VendorGeneral> VendorGeneralRepository { get; set; }


        public IBaseRepository<ApprovalsArchive> ApprovalsArchiveRepository { get; set; }
        public IClaimsTypeRepository ClaimsTypeRepository { get; set; }
        public  IRepApproval ApprovalRepository { get; set; }

        // Repositories for IdentityContext
        public IBaseRepository<Identity.Entities.OnlineClient> OnlineClientRepository { get ; set ; }
        public IBaseRepository<Identity.Entities.OnlineUserClient> OnlineUserClientRepository { get ; set ; }
        public IBaseRepository<Identity.Entities.Page> PagesRepository { get; set; }
        public IBaseRepository<Identity.Entities.Privilege> PrivilegesRepository { get; set; }
        public IBaseRepository<OnlineSetting> OnlineSettingRepository { get; set; }
        public IBaseRepository<OnlineDiagnosis> OnlinediagnosisRepository { get; set; }


        public ContractServicesRepository ContractServiceRepository { get; set; }
 

        public UnitOfWork(IDbContextFactory dbContextFactory, IdentityContext identityContext,
                          IConnectionStringProvider connectionStringProvider, IHttpContextAccessor contextAccessor)
        {
            _dbIdentityContext = identityContext;
            _dbContextFactory = dbContextFactory;
            _connectionStringProvider = connectionStringProvider;
            _contextAccessor = contextAccessor;

            // Initialize both contexts and repositories
            InitializeApplicationDbContext(GetDefaultConnectionString());
            InitializeIdentityDbContext();
        }

        // Initialize ApplicationDbContext and related repositories
        private void InitializeApplicationDbContext(string connectionString)
        {
            _dbContext = _dbContextFactory.CreateDbContext(connectionString);

            MemberRepository = new MemberRepository(_dbContext);
            ApprovalRepository = new RepApproval(_dbContext);
            ContractServiceRepository = new ContractServicesRepository(_dbContext);
            ClaimsTypeRepository = new ClaimsTypeRepository(_dbContext);
            ApprovalsArchiveRepository = new BaseRepository<ApprovalsArchive>(_dbContext);
            OnlineSettingRepository =new BaseRepository<OnlineSetting>(_dbContext);
            ApprovalServiceRepository = new BaseRepository<ApprovalService>(_dbContext);
            VendorGeneralRepository = new BaseRepository<VendorGeneral>(_dbContext);
            OnlinediagnosisRepository = new BaseRepository<OnlineDiagnosis>(_dbContext);

        }

        // Initialize IdentityContext and related repositories
        private void InitializeIdentityDbContext()
        {
            OnlineClientRepository = new BaseRepository<ACMS_ONLINE_INFRASTRUCTURE.Identity.Entities. OnlineClient>(_dbIdentityContext);
            OnlineUserClientRepository = new BaseRepository<ACMS_ONLINE_INFRASTRUCTURE.Identity.Entities.OnlineUserClient>(_dbIdentityContext);
            PagesRepository = new BaseRepository<ACMS_ONLINE_INFRASTRUCTURE.Identity.Entities.Page>(_dbIdentityContext);
            PrivilegesRepository = new BaseRepository<ACMS_ONLINE_INFRASTRUCTURE.Identity.Entities.Privilege>(_dbIdentityContext);
        }

        // Update connection string for ApplicationDbContext
        public void SetConnectionString(string clientId)
        {
            var connectionString = _connectionStringProvider.GetConnectionString(clientId);
            InitializeApplicationDbContext(connectionString);
        }

     
        

        public string GetDefaultConnectionString()
        {
            return _connectionStringProvider.GetDefaultConnectionString();
        }

        // Save changes for both contexts
        public int Save()
        {
            var appContextChanges = _dbContext.SaveChanges();
            var identityContextChanges = _dbIdentityContext.SaveChanges();
            return appContextChanges + identityContextChanges;
        }

        public void Dispose()
        {
            _dbContext?.Dispose();
            _dbIdentityContext?.Dispose();
        }

       

        public string getCurrentConnectionString()
        {
            var clientId = _contextAccessor.HttpContext?.User.Claims.FirstOrDefault(x => x.Type == "ClientId")?.Value;
            return getConnectionStringByClinetId(clientId);
        }
        public string getConnectionStringByClinetId(string clientId = "2")
        {
            return _connectionStringProvider.GetConnectionString(clientId);
        }
    }

}
