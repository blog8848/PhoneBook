using System;

namespace PhoneBook.Domain.Models
{
    public class Captcha
    {
        public Captcha()
        {
            CreatedDate = DateTime.Now;
        }
        public int CaptchaId { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; private set; }
    }
}
