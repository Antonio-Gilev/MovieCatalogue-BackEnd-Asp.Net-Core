using MC.Domain.Models;
using MC.Repository.Interface;
using MC.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MC.Service.Implementation
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository rolesRepository;

        public RoleService(IRoleRepository rolesRepository)
        {
            this.rolesRepository = rolesRepository;
        }

        public List<Roles> GetAllRoles()
        {
            return this.rolesRepository.GetAllRoles().ToList();
        }

        public Roles GetRole(int id)
        {
            return this.rolesRepository.GetRole(id);
        }
    }
}
