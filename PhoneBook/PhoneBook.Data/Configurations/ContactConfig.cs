using PhoneBook.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace PhoneBook.Data.Configurations
{
    public class ContactConfig : EntityTypeConfiguration<Contact>
    {
        public ContactConfig()
        {
        }
    }
}
