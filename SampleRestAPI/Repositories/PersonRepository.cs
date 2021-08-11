using Microsoft.EntityFrameworkCore;
using SampleRestAPI.Data;
using SampleRestAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace SampleRestAPI.Repositories
{
    public class PersonRepository : IPersonRepository
    {

        private readonly StoreDataContext _context;

        public PersonRepository(StoreDataContext context) => _context = context;

        public List<Person> Get() => _context.Persons.AsNoTracking().ToList();

        public Person Get(int id) => _context.Persons.AsNoTracking().Where(x => x.ID == id).FirstOrDefault();

        public Person Post(Person person)
        {
            _context.Persons.Add(person);
            _context.SaveChanges();

            return person;
        }

        public Person Put(Person person)
        {
            _context.Entry<Person>(person).State = EntityState.Modified;
            _context.SaveChanges();

            return person;
        }

        public Person Delete(Person person)
        {
            _context.Persons.Remove(person);
            _context.SaveChanges();

            return person;

        }

        public void Delete(int id)
        {

        }
    }
}
