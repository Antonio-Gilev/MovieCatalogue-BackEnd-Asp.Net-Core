using MC.Domain.Models;
using MC.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MC.Repository.Implementation
{
    public class PersonRepository : IPersonRepository
    {
        private readonly ApplicationDbContext context;
        private DbSet<Person> entities;
        string errorMessage = string.Empty;

        public PersonRepository(ApplicationDbContext context)
        {
            this.context = context;
            entities = context.Set<Person>();
        }
      

        public List<Person> GetAllPeople()
        {
            return entities
                             
                .Include(z => z.Roles)               
                .Include("Roles.Role")
                .Include(z => z.PeopleOnMovie)
                .Include("PeopleOnMovie.Movie")
                .ToListAsync().Result;
        }

        public Person getPerson(Guid? id)
        {
            return entities
                .Include(z => z.Roles)
                .Include("Roles.Role")
                .Include(z => z.PeopleOnMovie)
                .Include("PeopleOnMovie.Movie")
                .SingleOrDefaultAsync(z => z.Id == id).Result;
        }
       
    }
}
