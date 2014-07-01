using Ninject.Modules;
using PhoneBook.Data.Infrastructures;
using PhoneBook.Data.Repositories;
using PhoneBook.Service.Contracts;
using PhoneBook.Service.Services;

namespace PhoneBook.Web.IOC
{
    public class NinjectBindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IDatabaseFactory>().To<DatabaseFactory>();
            Bind<IUnitOfWork>().To<UnitOfWork>();
            Bind<IUserService>().To<UserService>();
            Bind<ICaptchaService>().To<CaptchaService>();
            Bind<IContactService>().To<ContactService>();
        }
    }
}