using PhoneBook.Data.Infrastructures;

namespace PhoneBook.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private PhoneBookDbContext _dbContext;
        private readonly IDatabaseFactory _databaseFactory;
        private IUserRepository _userRepository;

        public PhoneBookDbContext DbContext
        {
            get
            {
                return _dbContext ?? (_dbContext = _databaseFactory.GetDbContext());
            }
        }
        public UnitOfWork(IDatabaseFactory databaseFactory)
        {
            _databaseFactory = databaseFactory;
        }
        public void Commit()
        {
            DbContext.SaveChanges();
        }

        public IUserRepository UserRepository
        {
            get
            {
                return _userRepository ?? (_userRepository = new UserRepository(_databaseFactory));
            }
        }
    }
}
