﻿using ei8.Avatar.Installer.Domain.Model.IdentityAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ei8.Avatar.Installer.Domain.Model.IdentityAccess;

public interface IUserRepository
{
    Task<IEnumerable<User>> GetAllAsync(string access);
    Task UpdateAsync(string access, User user);
}