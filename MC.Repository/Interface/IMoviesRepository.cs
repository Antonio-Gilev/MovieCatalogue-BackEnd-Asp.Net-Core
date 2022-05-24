using MC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MC.Repository.Interface
{
    public interface IMoviesRepository
    {
        public List<Movie> GetAllMovies();
        public Movie getMovie(Guid? id);

        
    }
}
