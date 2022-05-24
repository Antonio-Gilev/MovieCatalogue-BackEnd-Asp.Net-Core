using MC.Domain.Models;
using MC.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MC.Web.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {

        private readonly IGenreService genreService;

        public GenresController(IGenreService genreService)
        {
            this.genreService = genreService;
        }


        // GET: api/<GenresController>
        [HttpGet]
        public IEnumerable<Genre> GetAll()
        {
            return this.genreService.GetAllGenres();
        }

        // GET api/<GenresController>/5
        [HttpGet("{id}")]
        public Genre Get(Guid id)
        {
            return this.genreService.GetGenre(id);
        }

        // POST api/<GenresController>
        [HttpPost]
        public void Post([FromBody] Genre genre)
        {
            this.genreService.CreateNewGenre(genre);
        }

        // PUT api/<GenresController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Genre genre)
        {
            this.genreService.UpdateGenre(genre);
        }

        // DELETE api/<GenresController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            this.genreService.DeleteGenre(id);
        }
    }
}
