
namespace PhoneBook.Data.Infrastructures
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }
        ICaptchaRepository CaptchaRepository { get; }
        void Commit();
    }
}
