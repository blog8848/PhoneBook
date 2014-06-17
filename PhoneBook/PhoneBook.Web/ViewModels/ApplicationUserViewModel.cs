using System.ComponentModel.DataAnnotations;
namespace PhoneBook.Web.ViewModels
{
    public class ApplicationUserViewModel
    {
        [Required(ErrorMessage = "Please enter your user name.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please enter your password.")]
        public string Password { get; set; }

    }
}