using System.Web;

namespace PhoneBook.Web.Helpers
{
    public class PhoneBookSessionManager
    {
        private const string LoggedInUserNameSession = "LoggedInUserName";
        private const string LoggedInUserIdSession = "LoggedInUserId";

        public static string LoggedInUserId
        {
            get
            {
                return HttpContext.Current.Session[LoggedInUserIdSession] as string;
            }
            set
            {
                HttpContext.Current.Session[LoggedInUserIdSession] = value;
            }
        }
        public static string LoggedInUserName
        {
            get
            {
                return HttpContext.Current.Session[LoggedInUserNameSession] as string;
            }
            set
            {
                HttpContext.Current.Session[LoggedInUserNameSession] = value;
            }
        }

    }
}
