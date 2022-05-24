using MC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MC.Repository.Interface
{
    public interface IPersonRepository
    {
        public List<Person> GetAllPeople();
        public Person getPerson(Guid? id);

    }
}
