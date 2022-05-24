using MC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MC.Domain.Relations
{
    public class PersonHasRoles : BaseEntity
    {
        public int RoleId { get; set; }
        public Roles Role { get; set; }

        public Guid PersonId { get; set; }
        public Person Person { get; set; }

    }
}
