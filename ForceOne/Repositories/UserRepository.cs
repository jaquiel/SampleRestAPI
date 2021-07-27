using ForceOne.Data;

namespace ForceOne.Repositories
{
    public class UserRepository
    {

        private readonly StoreDataContext _context;

        public UserRepository(StoreDataContext context) => _context = context;


    }
}
