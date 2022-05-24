using MC.Domain.Models;
using MC.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MC.Repository.Implementation
{
    public class RoleRepository : IRoleRepository
    {

        private readonly ApplicationDbContext context;
        private DbSet<Roles> entities;
        string errorMessage = string.Empty;

        public RoleRepository(ApplicationDbContext context)
        {
            this.context = context;
            entities = context.Set<Roles>();
        }


        public List<Roles> GetAllRoles()
        {
            return entities.AsEnumerable().ToList();
        }

        public Roles GetRole(int id)
        {
            return entities.             
               SingleOrDefault(s => s.Id == id);
        }
    }
}
