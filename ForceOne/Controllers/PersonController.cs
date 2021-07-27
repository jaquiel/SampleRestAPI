using ForceOne.Data;
using ForceOne.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ForceOne.Controllers
{
    public class PersonController : Controller
    {
        private readonly StoreDataContext _context;

        public PersonController(StoreDataContext context)
        {
            _context = context;
        }

        [Route("v1/persons")]
        [HttpGet]
        public IEnumerable<Person> Get() => _context.Persons.AsNoTracking().ToList();

        [Route("v1/persons/{id:int}")]
        [HttpGet]
        public Person Get(int id) => _context.Persons.AsNoTracking().Where(x => x.ID == id).FirstOrDefault();

        [Route("v1/persons")]
        [HttpPost]
        public Person Post([FromBody] Person person)
        {
            _context.Persons.Add(person);
            _context.SaveChanges();

            return person;
        }

        [Route("v1/persons")]
        [HttpPut]
        public Person Put([FromBody] Person person)
        {
            _context.Entry<Person>(person).State = EntityState.Modified;
            _context.SaveChanges();

            return person;
        }

        [Route("v1/persons")]
        [HttpDelete]
        public Person Delete([FromBody] Person person)
        {
            _context.Persons.Remove(person);
            _context.SaveChanges();

            return person;
        }
    }
}
