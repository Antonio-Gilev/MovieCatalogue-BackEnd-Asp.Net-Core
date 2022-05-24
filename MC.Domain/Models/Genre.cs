using MC.Domain.Relations;
using System;
using System.Collections.Generic;
using System.Text;

namespace MC.Domain.Models
{
    public class Genre : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<MovieGenres> MovieGenres { get; set; }
    }
}
