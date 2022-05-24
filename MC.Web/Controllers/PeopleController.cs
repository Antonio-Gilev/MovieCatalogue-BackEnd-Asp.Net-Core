using MC.Domain.DTO;
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
    public class PeopleController : ControllerBase
    {
        private readonly IPersonService personService;

        public PeopleController(IPersonService personService)
        {
            this.personService = personService;
        }

        // GET: api/<PeopleController>
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return this.personService.GetAllPeople();
        }

        // GET api/<PeopleController>/5
        [HttpGet("{id}")]
        public Person Get(Guid id)
        {
            return this.personService.GetPerson(id);
        }

        // POST api/<PeopleController>
        [HttpPost]
        public void Post(PersonDTO person)
        {
            this.personService.CreateNewPerson(person);
        }

        // PUT api/<PeopleController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PeopleController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {

            this.personService.DeletePerson(id);
        }
    }
}
