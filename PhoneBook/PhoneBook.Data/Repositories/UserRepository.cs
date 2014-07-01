using System;
using System.Linq;
using System.Linq.Expressions;
using PhoneBook.Data.Infrastructures;
using PhoneBook.Domain.Models;

namespace PhoneBook.Data.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(IDatabaseFactory databaseFactory) : base(databaseFactory) { }
        public User GetUserFromUserName(Expression<Func<User, bool>> where)
        {
            return DbContext.Set<User>().Single(where);
        }
    }
}