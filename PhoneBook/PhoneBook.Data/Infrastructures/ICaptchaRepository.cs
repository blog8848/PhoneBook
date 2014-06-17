using PhoneBook.Domain.Models;

namespace PhoneBook.Data.Infrastructures
{
    public interface ICaptchaRepository : IRepository<Captcha>
    {
        int MinCaptchaId();
        int MaxCaptchaId();
    }
}
