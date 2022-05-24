using MC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MC.Domain.Relations
{
    public class MovieGenres : BaseEntity
    {
        public Guid MovieId { get; set; }
        public Movie Movie { get; set; }

        public Guid GenreId { get; set; }
        public Genre Genre { get; set; }



    }
}
