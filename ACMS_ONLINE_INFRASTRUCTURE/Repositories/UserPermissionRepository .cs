using ACMS_ONLINE_INFRASTRUCTURE.Data;
using ACMS_ONLINE_INFRASTRUCTURE.Dtos;
using ACMS_ONLINE_INFRASTRUCTURE.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACMS_ONLINE_INFRASTRUCTURE.Repositories
{
    public class UserPermissionRepository : IUserPermissionRepository
    {
        private readonly IdentityContext _context;

        public UserPermissionRepository(IdentityContext context)
        {
            _context = context;
        }

        public async Task<List<PageDto>> GetUserPagesAsync(string userId)
        {
            return await
                (from ur in _context.UserRoles
                 join pr in _context.Privileges on ur.RoleId equals pr.RoleId
                 join p in _context.Pages on pr.PageId equals p.Id
                 where ur.UserId == userId 
                 select new PageDto
                 {
                     PageId = p.Id,
                     NameAr = p.NameAr,
                     NameEn = p.NameEn,
                     Add= pr.Add,
                     View = pr.View,
                     Edit = pr.Edit,
                     Submit = pr.Submit,
                     Unsubmit = pr.Unsubmit,
                     Cancel = pr.Cancel,
                     Import = pr.Import,
                     Export = pr.Export,
                     Print = pr.Print,
                     SpacialCase = pr.SpacialCase, 


                 })
                 .Distinct()
                 .ToListAsync();
        }
    }

}
