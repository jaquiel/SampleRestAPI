using MongoDB.Driver;
using SampleRestAPI.Models;

namespace SampleRestAPI.Data.Mapping
{
    public class PersonMapping
    {

        private IMongoDatabase _database { get; }

        public PersonMapping(IMongoDatabase database)
        {
            _database = database;
        }

        
    }
}
