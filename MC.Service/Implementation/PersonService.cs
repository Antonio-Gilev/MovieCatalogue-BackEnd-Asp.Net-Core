using MC.Domain.DTO;
using MC.Domain.Models;
using MC.Domain.Relations;
using MC.Repository.Interface;
using MC.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MC.Service.Implementation
{
    public class PersonService : IPersonService
    {
        private readonly IRepository<Person> personRepository;
        private readonly IPersonRepository personRepositoryWithInclude;
        private readonly IRepository<PersonHasRoles> personHasRolesRepository;

        public PersonService(IRepository<Person> personRepository, IPersonRepository personRepositoryWithInclude, IRepository<PersonHasRoles> personHasRolesRepository) 
        {
            this.personRepository = personRepository;
            this.personRepositoryWithInclude = personRepositoryWithInclude;
            this.personHasRolesRepository = personHasRolesRepository;
        }

        public void CreateNewPerson(PersonDTO m)
        {
            Person person = new Person
            {
                Id = Guid.NewGuid(),
                FirstName = m.firstName,
                LastName = m.lastName,
                Image = m.Image
            };

            this.personRepository.Insert(person);

            foreach (var item in m.roles)
            {
                PersonHasRoles personHasRoles = new PersonHasRoles
                {
                    Id = Guid.NewGuid(),
                    RoleId = item,
                    Person = person,
                    PersonId = person.Id
                };
                this.personHasRolesRepository.Insert(personHasRoles);
            }


            
        }

        public void DeletePerson(Guid? id)
        {
            var person = this.GetPerson(id);
            this.personRepository.Delete(person);
        }

        public List<Person> GetAllPeople()
        {
            return this.personRepositoryWithInclude.GetAllPeople();
        }

        public Person GetPerson(Guid? id)
        {
            return this.personRepositoryWithInclude.getPerson(id);
        }

        public void UpdatePerson(Person m)
        {
            this.personRepository.Update(m);
        }
    }
}
