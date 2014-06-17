using System;
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
        private readonly ICaptchaService _captchaService;
        public UserController(IUserService userService, ICaptchaService captchaService)
        {
            _userService = userService;
            _captchaService = captchaService;
        }
        [HttpGet]
        public ActionResult CreateUser()
        {
            // _captchaService.CreateQuestion(new Captcha { Question = "2+2=?", Answer = "four", IsActive = true });
            Captcha captcha = _captchaService.GenerateCaptcha();
            Session["CaptchaQuestion"] = captcha.Question;
            Session["CaptchaAnswer"] = captcha.Answer;
            return View();
        }

        [HttpPost]
        public ActionResult CreateUser(UserViewModel model)
        {
            if (!ModelState.IsValid) return View(model);
            string captchaAnswer = Session["CaptchaAnswer"] as string;
            if (model.CaptchaAnswer.Equals(captchaAnswer))
            {
                Mapper.CreateMap<UserViewModel, User>();
                User user = Mapper.Map<User>(model);
                //User user = Mapper.Map<UserViewModel, User>(model);
                _userService.CreateUser(user);
                TempData["UserCreated"] = string.Concat(model.FirstName, ", your account has been created.");
                TempData["UserName"] = model.UserName;
                return RedirectToAction("CreateUser");
            }
            ModelState.AddModelError("invalidCaptcha", "Invalid answer.");
            return View(model);
        }
    }
}