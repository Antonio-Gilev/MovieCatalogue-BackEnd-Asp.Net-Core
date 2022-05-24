using MC.Domain.DTO;
using MC.Domain.Models;
using MC.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient.Memcached;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MC.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService movieService;

        public MoviesController(IMovieService movieService)
        {
            this.movieService = movieService;
        }

        // GET: api/<MoviesController>
        [HttpGet]
        public List<Movie> GetMoviePage()
        {
            return this.movieService.GetAllMovies();
        }

        // GET api/<MoviesController>/5
        [HttpGet("{id}")]
        public Movie GetMovie(Guid id)
        {
            return this.movieService.GetMovie(id);
        }

        // POST api/<MoviesController>
        [HttpPost]
        public void Post(MovieDto movie)
        {
            this.movieService.CreateNewMovie(movie);
        }

        // PUT api/<MoviesController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] Movie movie)
        {
            this.movieService.UpdateMovie(movie);
        }

        // DELETE api/<MoviesController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            this.movieService.DeleteMovie(id);
        }
    }
}
