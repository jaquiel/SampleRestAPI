using SampleRestAPI.Data;
using SampleRestAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Driver;
using System;

namespace SampleRestAPI.Controllers
{
    public class PersonController : Controller
    {
        private StoreDataContext _context { get; }

        public PersonController(IMongoDBSettings settings)
        {
            IMongoClient   client = new MongoClient(settings.ConnectionString);
            IMongoDatabase database = client.GetDatabase(settings.DatabaseName);
            _context = new StoreDataContext(database);
        }

        [Route("v1/persons")]
        [HttpGet]
        public List<Person> Get() => _context.Person.Find(p => true).ToList<Person>();


        [Route("v1/persons/{id:int}")]
        [HttpGet]
        public Person Get(string id) => _context.Person.Find<Person>(p => p.ID == id).FirstOrDefault();

        [Route("v1/persons")]
        [HttpPost]
        public Person Post([FromBody] Person person)
        {
            _context.Person.InsertOne(person);
            return person;
        }

        [Route("v1/persons")]
        [HttpPut]
        public Person Put([FromBody] Person person)
        {
            _context.Person.ReplaceOne(p => p.ID == person.ID, person);
            return person;
        }

        [Route("v1/persons")]
        [HttpDelete]
        public Person Delete([FromBody] Person person)
        {
            _context.Person.DeleteOne(p => p.ID == person.ID );

            return person;
        }
    }
}
