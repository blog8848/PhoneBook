using System.Web.Mvc;
using AutoMapper;
using PhoneBook.Domain.Models;
using PhoneBook.Service.Contracts;
using PhoneBook.Web.ViewModels;

namespace PhoneBook.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult UserLogin()
        {
            return View("Index");
        }
        [HttpPost]
        public ActionResult UserLogin(ApplicationUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                Mapper.CreateMap<ApplicationUserViewModel, User>();
                User user = Mapper.Map<User>(model);
                bool isValidUser = _userService.Exists(user);
                if (isValidUser)
                {
                    return RedirectToAction("Welcome", "Home");
                }
            }
            return View("Index");
        }

        [HttpPost]
        public ActionResult CreateUser(UserViewModel model)
        {
            if (ModelState.IsValid)
            {
                Mapper.CreateMap<UserViewModel, User>();
                User user = Mapper.Map<User>(model);
                //User user = Mapper.Map<UserViewModel, User>(model);
                _userService.CreateUser(user);
                return Content("Welcome user");
            }
            return View("SignUp");
        }

        public ActionResult ForgotPassword()
        {
            return View("ForgotPassword");
        }

        public ActionResult SignUp()
        {
            return View("SignUp");
        }
    }
}
