using ACMS_ONLINE_INFRASTRUCTURE.Data;
using ACMS_ONLINE_INFRASTRUCTURE.Data.Models;
using ACMS_ONLINE_INFRASTRUCTURE.Interfaces;
using ACMS_ONLINE_INFRASTRUCTURE.Services;
using Microsoft.AspNetCore.Http;
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



        public IBaseRepository<Member> MemberRepository { get; set; }
        public IBaseRepository<Approval> ApprovalRepository { get; set; }
        public IBaseRepository<OnlineClient> OnlineClientRepository { get; set; }
        public IBaseRepository<OnlineUserClient> OnlineUserClientRepository { get; set; }



        public UnitOfWork(IDbContextFactory dbContextFactory , IConnectionStringProvider connectionStringProvider, IHttpContextAccessor contextAccessor) 
        {

            _dbContextFactory = dbContextFactory;
            _connectionStringProvider = connectionStringProvider;
            _contextAccessor = contextAccessor;
            InitializeRepositories(GetDefaultConnectionString());
            
        }

        private void InitializeRepositories(string connectionString)
        {
            
            _dbContext = _dbContextFactory.CreateDbContext(connectionString);

            MemberRepository = new BaseRepository<Member>(_dbContext);
            ApprovalRepository = new BaseRepository<Approval>(_dbContext);
            OnlineClientRepository = new BaseRepository<OnlineClient>(_dbContext);
            OnlineUserClientRepository = new BaseRepository<OnlineUserClient>(_dbContext);
        }

        public void SetConnectionString(string clientId)
        {
            
            var connectionString = _connectionStringProvider.GetConnectionString(clientId);

            
            InitializeRepositories(connectionString);
        }




        public string getCurrentConnectionString()
        {
            var ClientId = _contextAccessor.HttpContext?.User.Claims.FirstOrDefault(x => x.Type == "ClientId")?.Value;
            return getConnectionStringByClinetId(ClientId);
        }

        public string getConnectionStringByClinetId(string clientId ="2")
        {
            return _connectionStringProvider.GetConnectionString(clientId);
        }

        public string GetDefaultConnectionString()
        {
            return _connectionStringProvider.GetDefaultConnectionString();
        }
       
        public int Save ()
        {
            return _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
