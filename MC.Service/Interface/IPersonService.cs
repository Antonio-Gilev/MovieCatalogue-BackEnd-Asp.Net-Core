using MC.Domain.DTO;
using MC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MC.Service.Interface
{
    public interface IPersonService
    {
        void CreateNewPerson(PersonDTO m);
        List<Person> GetAllPeople();
        Person GetPerson(Guid? id);
        void UpdatePerson(Person m);
        void DeletePerson(Guid? id);
    }
}
