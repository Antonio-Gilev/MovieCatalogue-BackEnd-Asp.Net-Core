using System;
using System.Collections.Generic;
using System.Text;

namespace MC.Domain.DTO
{
    public class MovieDto
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }


        public ICollection<Guid> movieGenres { get; set; }
        public ICollection<Guid> peopleOnMovie { get; set; }
    }
}
