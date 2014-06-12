using System.Data.Entity.ModelConfiguration;
using PhoneBook.Domain.Models;

namespace PhoneBook.Data.Configurations
{
    public class UserConfig : EntityTypeConfiguration<User>
    {
        public UserConfig()
        {
            HasMany(c => c.Contacts).WithOptional(u => u.User).Map(u => u.MapKey("UserId")).WillCascadeOnDelete();
        }
    }
}
