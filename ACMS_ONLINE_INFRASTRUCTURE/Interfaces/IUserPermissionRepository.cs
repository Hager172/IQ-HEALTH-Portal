using ACMS_ONLINE_INFRASTRUCTURE.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACMS_ONLINE_INFRASTRUCTURE.Interfaces
{
    public interface IUserPermissionRepository
    {
        Task<List<PageDto>> GetUserPagesAsync(string userId);

    }
}
