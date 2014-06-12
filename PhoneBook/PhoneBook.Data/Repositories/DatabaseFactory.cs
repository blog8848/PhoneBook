
using PhoneBook.Data.Infrastructures;

namespace PhoneBook.Data.Repositories
{
    public class DatabaseFactory : IDatabaseFactory
    {
        private PhoneBookDbContext _dbContext;
        public PhoneBookDbContext GetDbContext()
        {
            return _dbContext ?? (_dbContext = new PhoneBookDbContext());
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}