using System.Web.Mvc;
using AutoMapper;
using PhoneBook.Data.Infrastructures;
using PhoneBook.Domain.Models;
using PhoneBook.Service.Contracts;
using PhoneBook.Web.ViewModels;

namespace PhoneBook.Web.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUserService _userService;
        public LoginController(IUserService userRepository)
        {
            _userService = userRepository;
        }
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UserLogin(ApplicationUserViewModel model)
        {
            Mapper.CreateMap<ApplicationUserViewModel, User>();
            User user = Mapper.Map<User>(model);
            bool isValidUser = _userService.Exists(user);
            if (isValidUser)
            {
              return  RedirectToAction("Welcome", "Home");
            }
            return   View();
        }

        public ActionResult ForgotPassword()
        {
            return View("ForgotPassword");
        }
    }
}
