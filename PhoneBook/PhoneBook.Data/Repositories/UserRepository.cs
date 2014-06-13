using PhoneBook.Data.Infrastructures;
using PhoneBook.Domain.Models;

namespace PhoneBook.Data.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(IDatabaseFactory databaseFactory) : base(databaseFactory) { }
    }
}
