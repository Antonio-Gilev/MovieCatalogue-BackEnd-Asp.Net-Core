using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using MC.Domain.Relations;

namespace MC.Domain.Models
{
    public class Movie : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }


        public virtual ICollection<MovieGenres> MovieGenres { get; set; }
        public virtual ICollection<PeopleOnMovie> PeopleOnMovie { get; set; }

    }
}
