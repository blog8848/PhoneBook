using PhoneBook.Data.Infrastructures;
using PhoneBook.Domain.Models;

namespace PhoneBook.Data.Repositories
{
    public class ContactRepository : GenericRepository<Contact>, IContactRepository
    {
        public ContactRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
        }
    }
}
