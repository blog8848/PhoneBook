using System.Web.Mvc;
using PhoneBook.Service.Contracts;
using PhoneBook.Domain.Models;

namespace PhoneBook.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService _userService;

        public HomeController(IUserService userService)
        {
            _userService = userService;
        }

        #region Create Contact
        public string Index()
        {
            User user = new User
            {
                UserName = "testUser",
                FirstName = "firsName",
                MiddleName = "middleName",
                LastName = "lastName",
                Email = "test@test.com"
            };
            Contact contact1 = new Contact
            {
                FirstName = "contact1",
                MiddleName = "contact1MiddleName",
                LastName = "contact1LastName",
                Address = "Bafal",
            };
            ContactDetail contactDetail = new ContactDetail
            {
                ContactDetailType = "Website",
                ContactDetailValue = "www.contact1.com"
            };
            contact1.ContactDetails.Add(contactDetail); // add contact detail to user
            user.Contacts.Add(contact1); // add contacts to user
            _userService.CreateUser(user); // create new user
            return "New User Created";

        }
        #endregion

        public ViewResult DashBoard()
        {
            return View();
        }

    }
}