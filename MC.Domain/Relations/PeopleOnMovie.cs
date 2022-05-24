using MC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MC.Domain.Relations
{
    public class PeopleOnMovie : BaseEntity
    {
        public Guid PersonId { get; set; }
        public Person Person { get; set; }

        public Guid MovieId { get; set; }
        public Movie Movie { get; set; }

    }
}
