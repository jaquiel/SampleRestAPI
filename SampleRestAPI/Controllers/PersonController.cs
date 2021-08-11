using SampleRestAPI.Data;
using SampleRestAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using SampleRestAPI.Repositories;

namespace SampleRestAPI.Controllers
{
    public class PersonController : ControllerBase
    {
        private readonly PersonRepository _personRepository;

        public PersonController(PersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        [Route("v1/persons")]
        [HttpGet]
        public ActionResult<List<Person>> Get() => _personRepository.Get();

        [Route("v1/persons/{id:int}")]
        [HttpGet]
        public ActionResult<Person> Get(int id)
        {
            Person person = _personRepository.Get(id);

            if (person == null)
            {
                return NotFound();
            }

            return person;
        }

        [Route("v1/persons")]
        [HttpPost]
        public ActionResult<Person> Post([FromBody] Person person)
        {
            Person p = _personRepository.Post(person);

            return p;
        }

        [Route("v1/persons")]
        [HttpPut]
        public IActionResult Put([FromBody] Person person)
        {
            Person p = _personRepository.Get(person.ID);

            if (p == null)
            {
                NotFound();
            }

            _personRepository.Put(p);

            return NoContent();
        }

        [Route("v1/persons")]
        [HttpDelete]
        public IActionResult Delete([FromBody] Person person)
        {
            Person p = _personRepository.Get(person.ID);

            if (p == null)
            {
                NotFound();
            }

            _personRepository.Delete(p);

            return NoContent();
        }
    }
}
