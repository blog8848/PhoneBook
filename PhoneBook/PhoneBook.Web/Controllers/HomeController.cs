using System.Web.Mvc;
using AutoMapper;
using PhoneBook.Service.Contracts;
using PhoneBook.Domain.Models;
using PhoneBook.Web.Helpers;
using PhoneBook.Web.ViewModels;

namespace PhoneBook.Web.Controllers
{
    public class HomeController : Controller
    {
        //private readonly IUserService _userService;

        private readonly IContactService _contactService;
        public HomeController(IContactService contactService)
        {
            //_userService = userService;
            _contactService = contactService;
        }

        #region Create Contact
        //public string Index()
        //{
        //    User user = new User
        //    {
        //        UserName = "testUser",
        //        FirstName = "firsName",
        //        MiddleName = "middleName",
        //        LastName = "lastName",
        //        Email = "test@test.com"
        //    };
        //    Contact contact1 = new Contact
        //    {
        //        FirstName = "contact1",
        //        MiddleName = "contact1MiddleName",
        //        LastName = "contact1LastName",
        //        Address = "Bafal",
        //    };
        //    ContactDetail contactDetail = new ContactDetail
        //    {
        //        ContactDetailType = "Website",
        //        ContactDetailValue = "www.contact1.com"
        //    };
        //    contact1.ContactDetails.Add(contactDetail); // add contact detail to user
        //    user.Contacts.Add(contact1); // add contacts to user
        //    _userService.CreateUser(user); // create new user
        //    return "New User Created";

        //}
        #endregion

        public ViewResult DashBoard()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return PartialView();
        }

        public ActionResult NewPopup()
        {
            return PartialView();
        }
        [HttpGet]
        public ActionResult CreateNewContact()
        {
            return PartialView("Contact");
        }
        [HttpPost]
        public ActionResult CreateNewContact(ContactViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Contact");

            }
            // return Json(new { success = false });
            model.UserId = PhoneBookSessionManager.LoggedInUserId;
            Mapper.CreateMap<ContactViewModel, Contact>();
            Contact contact = Mapper.Map<Contact>(model);
            int contactId = _contactService.CreateContact(contact);
            if (contactId > 0)
            {
                TempData["SuccessMessage"] = "New Contact Created";
            }
            return View("Dashboard");
        }

    }
}