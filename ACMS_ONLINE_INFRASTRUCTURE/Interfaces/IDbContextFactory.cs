using ACMS_ONLINE_INFRASTRUCTURE.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_INFRASTRUCTURE.Interfaces
{
    public interface IDbContextFactory
    {
        ApplicationDbContext  CreateDbContext(string connectionString);
    }
}
