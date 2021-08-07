using SampleRestAPI.Data;

namespace SampleRestAPI.Repositories
{
    public class UserRepository
    {

        private readonly StoreDataContext _context;

        public UserRepository(StoreDataContext context) => _context = context;


    }
}
