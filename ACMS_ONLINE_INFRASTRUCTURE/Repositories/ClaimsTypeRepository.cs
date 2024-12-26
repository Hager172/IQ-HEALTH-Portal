using ACMS_ONLINE_INFRASTRUCTURE.Data;
using ACMS_ONLINE_INFRASTRUCTURE.Data.Models;
using ACMS_ONLINE_INFRASTRUCTURE.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_INFRASTRUCTURE.Repositories
{
    public class ClaimsTypeRepository : BaseRepository<ClaimsType>, IClaimsTypeRepository
    {
        public ClaimsTypeRepository(DbContext context) : base(context)
        {
        }

    }
}
