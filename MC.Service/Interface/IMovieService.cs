using MC.Domain.DTO;
using MC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MC.Service.Interface
{
    public interface IMovieService
    {
        void CreateNewMovie(MovieDto m);
        List<Movie> GetAllMovies();
        Movie GetMovie(Guid? id);
        void UpdateMovie(Movie m);
        void DeleteMovie(Guid? id);
    }
}
