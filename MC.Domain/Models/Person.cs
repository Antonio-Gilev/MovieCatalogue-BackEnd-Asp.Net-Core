
using MC.Domain.Relations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MC.Domain.Models
{
    
    public class Person : BaseEntity
    {
        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        public string Image { get; set; }


        public virtual ICollection<PersonHasRoles> Roles { get; set; }

        public virtual ICollection<PeopleOnMovie> PeopleOnMovie { get; set; }
    }
}
