using System.Data.Entity;
using PhoneBook.Data.Configurations;
using PhoneBook.Domain.Models;

namespace PhoneBook.Data
{
    public class PhoneBookDbContext : DbContext
    {
        public PhoneBookDbContext()
            : base("PhoneBook")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<PhoneBookDbContext>());
        }

        public DbSet<User> Users;
        public DbSet<Contact> Contacts;
        public DbSet<ContactDetail> ContactDetails;

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfig());
        }
    }
}
