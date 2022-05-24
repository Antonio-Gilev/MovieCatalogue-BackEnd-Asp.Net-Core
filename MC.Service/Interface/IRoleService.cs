using MC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MC.Service.Interface
{
    public interface IRoleService
    {     
        List<Roles> GetAllRoles();
        Roles GetRole(int id);        
    }
}
