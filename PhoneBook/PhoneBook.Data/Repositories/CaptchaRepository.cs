using System.Linq;
using PhoneBook.Data.Infrastructures;
using PhoneBook.Domain.Models;

namespace PhoneBook.Data.Repositories
{
    public class CaptchaRepository : GenericRepository<Captcha>, ICaptchaRepository
    {
        private readonly IDatabaseFactory _databaseFactory;
        public CaptchaRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
            _databaseFactory = databaseFactory;
        }
        public int MinCaptchaId()
        {
            int minCaptchaId = DbContext.Set<Captcha>().Select(c => c.CaptchaId).Min();
            return minCaptchaId;
        }

        public int MaxCaptchaId()
        {
            int maxCaptchaId = DbContext.Set<Captcha>().Select(c => c.CaptchaId).Max();
            return maxCaptchaId;
        }
    }
}
