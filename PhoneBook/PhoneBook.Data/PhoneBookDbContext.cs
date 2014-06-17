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
        public DbSet<Captcha> CaptchaQuestions;

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>();
            modelBuilder.Configurations.Add(new CaptchaConfig());
            //modelBuilder.Entity<Captcha>();
            // modelBuilder.Configurations.Add(new UserConfig());
            //modelBuilder.Entity<User>().HasMany(u => u.Contacts).WithOptional(c => c.User);
            //modelBuilder.Entity<User>().HasMany<Contact>(u => u.Contacts)
            //.WithOptional(u => u.User).HasForeignKey(u => u.UserId);

        }
    }
}
