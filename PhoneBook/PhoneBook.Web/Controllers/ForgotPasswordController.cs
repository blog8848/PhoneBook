using System.Web.Mvc;

namespace PhoneBook.Web.Controllers
{
    public class ForgotPasswordController : Controller
    {
        public ActionResult ForgotPassword()
        {
            return View("ForgotPassword");
        }
    }
}
