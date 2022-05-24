using MC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MC.Repository.Interface
{
    public interface IRoleRepository
    {
        Roles GetRole(int id);
        List<Roles> GetAllRoles();
    }
}
