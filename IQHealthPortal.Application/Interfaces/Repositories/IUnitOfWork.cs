using IQHealthPortal.Domain.Identity.Entities;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace IQHealthPortal.Application.Interfaces.Repositories
{
    public interface IUnitOfWork : IDisposable
    {


        //IOnlineUserClientRepository OnlineUserClientRepository { get; set; }
        IPageRepository PageRepository { get; set; }
        IApprovalRepository ApprovalRepository { get; set; }
        IVendorRepository VendorRepository { get; set; }
        IRepository<T> ApplicationRepository<T>() where T : class;
        IRepository<T> IdentityRepository<T>() where T : class;


        public void SetConnectionString(string clientId);
        public string getConnectionStringByClinetId(string clientId);
        public string GetDefaultConnectionString();
        public string getCurrentConnectionString();
        public int Save();
    }
}
