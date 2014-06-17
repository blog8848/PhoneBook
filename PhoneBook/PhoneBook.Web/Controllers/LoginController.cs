using System;
using System.Web.Mvc;
using AutoMapper;
using PhoneBook.Domain.Models;
using PhoneBook.Service.Contracts;
using PhoneBook.Web.ViewModels;

namespace PhoneBook.Web.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUserService _userService;
        public LoginController(IUserService userService)
        {
            _userService = userService;
        }
        
        [HttpGet]
        public ActionResult UserLogin(string user)
        {
            ViewBag.UserName = user;
            
            return View();
        }
        [HttpPost]
        public ActionResult UserLogin(ApplicationUserViewModel model)
        {
            if (!ModelState.IsValid) return View("Index");
            Mapper.CreateMap<ApplicationUserViewModel, User>();
            User user = Mapper.Map<User>(model);
            bool isValidUser = _userService.Exists(user);
            if (isValidUser)
            {
                return RedirectToAction("Welcome", "Home");
            }
            return View("Index");
        }
    }
}
