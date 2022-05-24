using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using MC.Domain.Relations;

namespace MC.Domain.Models
{
    public class Roles
    {
        
        public int Id { get; set; }

        public string Role { get; set; }

        public virtual ICollection<PersonHasRoles> PeopleWithRoles { get; set; }
    }
}
