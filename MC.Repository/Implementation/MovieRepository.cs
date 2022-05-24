using MC.Domain.Models;
using MC.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MC.Repository.Implementation
{
    public class MovieRepository : IMoviesRepository
    {
        private readonly ApplicationDbContext context;
        private DbSet<Movie> entities;
        string errorMessage = string.Empty;

        public MovieRepository(ApplicationDbContext context)
        {
            this.context = context;
            entities = context.Set<Movie>();
        }

        public List<Movie> GetAllMovies()
        {
            return entities
                .Include(z => z.MovieGenres)
                .Include("MovieGenres.Genre")
                .Include(z => z.PeopleOnMovie)
                .Include("PeopleOnMovie.Person")
                .ToListAsync().Result;
        }

        public Movie getMovie(Guid? id)
        {
            return entities
                .Include(z => z.MovieGenres)
                .Include("MovieGenres.Genre")
                .Include(z => z.PeopleOnMovie)
                .Include("PeopleOnMovie.Person")
                .SingleOrDefaultAsync(z => z.Id == id).Result;
        }
    }
}
