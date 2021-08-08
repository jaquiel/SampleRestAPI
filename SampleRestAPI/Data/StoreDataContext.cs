using MongoDB.Driver;
using SampleRestAPI.Models;

namespace SampleRestAPI.Data
{
    public class StoreDataContext
    {

        private IMongoDatabase _database { get; }

        public StoreDataContext(IMongoDatabase database)
        {
            _database = database;
        }

        public IMongoCollection<Person> Person
        {
            get
            {
                return _database.GetCollection<Person>("Person");
            }
        }

    }
}
