using AutoMapper;
using MC.Domain.DTO;
using MC.Domain.Models;
using MC.Domain.Relations;
using MC.Repository.Interface;
using MC.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MC.Service.Implementation
{
    public class MovieService : IMovieService
    {
        private readonly IRepository<Movie> movieRepository;
        private readonly IMoviesRepository moviesRepositoryWithInclude;
        private readonly IRepository<Genre> genreRepository;
        private readonly IRepository<Person> personRepository;
        private readonly IRepository<MovieGenres> movieGenresRepository;
        private readonly IRepository<PeopleOnMovie> peopleOnMovieRepository;

        public MovieService(IRepository<Movie> movieRepository, IRepository<PeopleOnMovie> peopleOnMovieRepository, IRepository<MovieGenres> movieGenresRepository, IMoviesRepository moviesRepositoryWithInclude, IRepository<Genre> genreRepository, IRepository<Person> personRepository)
        {
            this.movieRepository = movieRepository;
            this.moviesRepositoryWithInclude = moviesRepositoryWithInclude;
            this.genreRepository = genreRepository;
            this.personRepository = personRepository;
            this.movieGenresRepository = movieGenresRepository;
            this.peopleOnMovieRepository = peopleOnMovieRepository;
        }


        public void CreateNewMovie(MovieDto m)
        {
            Movie movie = new Movie();
            movie.Id = Guid.NewGuid();
            movie.Image = m.Image;
            movie.Name = m.Name;
            movie.Description = m.Description;

            this.movieRepository.Insert(movie);

            foreach (var item in m.movieGenres)
            {
                MovieGenres movieGenres = new MovieGenres
                {
                    Id = Guid.NewGuid(),
                    Movie = movie,
                    MovieId = movie.Id,
                    GenreId = item,
                    Genre = this.genreRepository.Get(item)
                };
                this.movieGenresRepository.Insert(movieGenres);
            }

            foreach (var item in m.peopleOnMovie)
            {
                PeopleOnMovie people = new PeopleOnMovie
                {
                    Id = Guid.NewGuid(),
                    MovieId = movie.Id,
                    Movie = movie,
                    Person = this.personRepository.Get(item),
                    PersonId = item
                };
                this.peopleOnMovieRepository.Insert(people);
            }





            
        }

        public void DeleteMovie(Guid? id)
        {
            var movie = this.GetMovie(id);
            this.movieRepository.Delete(movie);
        }

        public List<Movie> GetAllMovies()
        {
            return this.moviesRepositoryWithInclude.GetAllMovies();
        }

        public Movie GetMovie(Guid? id)
        {
            return this.moviesRepositoryWithInclude.getMovie(id);
        }

        public void UpdateMovie(Movie m)
        {
            this.movieRepository.Update(m);
        }
    }
}
