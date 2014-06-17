using System.Data.Entity.ModelConfiguration;
using PhoneBook.Domain.Models;

namespace PhoneBook.Data.Configurations
{
    public class CaptchaConfig : EntityTypeConfiguration<Captcha>
    {
        public CaptchaConfig()
        {
            HasKey(m => m.CaptchaId);
        }
    }
}
