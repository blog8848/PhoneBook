
namespace PhoneBook.Data.Infrastructures
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }
        void Commit();
    }
}
