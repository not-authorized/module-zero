﻿using Abp.Domain.Repositories;

namespace Abp.Authorization.Permissions
{
    /// <summary>
    /// Used to perform database operations for <see cref="PermissionSetting"/> entity.
    /// </summary>
    public interface IPermissionSettingRepository : IRepository<PermissionSetting, long>
    {

    }
}
