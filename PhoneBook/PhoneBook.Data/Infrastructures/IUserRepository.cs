using System;
using System.Linq.Expressions;
using PhoneBook.Domain.Models;
namespace PhoneBook.Data.Infrastructures
{
    public interface IUserRepository : IRepository<User>
    {
        User GetUserFromUserName(Expression<Func<User, bool>> where);
    }
}
