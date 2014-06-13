using System.Data.Entity.ModelConfiguration;
using PhoneBook.Domain.Models;

namespace PhoneBook.Data.Configurations
{
    public class UserConfig : EntityTypeConfiguration<User>
    {
        public UserConfig()
        {
            HasMany(u => u.Contacts).WithOptional().HasForeignKey(u => u.UserId);
        }
    }
}
