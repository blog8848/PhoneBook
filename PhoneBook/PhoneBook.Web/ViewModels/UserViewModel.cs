using System;
using System.ComponentModel.DataAnnotations;

namespace PhoneBook.Web.ViewModels
{
    public class UserViewModel
    {
        [Required(ErrorMessage = "Username is required.")]
        [MinLength(5, ErrorMessage = "Pick username with more than 5 characters.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        [MinLength(8, ErrorMessage = ("Your password is less than 8 characters."))]
        public string Password { get; set; }
        [Required(ErrorMessage = "Email address is required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }
        public DateTime? ModifiedDate { get; set; }

    }
}