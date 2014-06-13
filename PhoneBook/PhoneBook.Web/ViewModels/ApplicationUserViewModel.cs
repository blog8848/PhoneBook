using System.ComponentModel.DataAnnotations;
namespace PhoneBook.Web.ViewModels
{
    public class ApplicationUserViewModel
    {
        [Required(ErrorMessage = "This field is required.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string Password { get; set; }

    }
}