using ACMS_ONLINE_INFRASTRUCTURE.Data;
using ACMS_ONLINE_INFRASTRUCTURE.Data.Models;
using ACMS_ONLINE_INFRASTRUCTURE.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_INFRASTRUCTURE.Services
{
    public class DbContextFactory : IDbContextFactory
    {
        

        public DbContextFactory()
        {
            
        }

     

        public ApplicationDbContext CreateDbContext(string connectionString)
        {
           

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer(connectionString);
            return new ApplicationDbContext(optionsBuilder.Options);
        }
       
       
    }
    public enum DataSource
    {
        Almashreq,
        MediGold
    }
}
