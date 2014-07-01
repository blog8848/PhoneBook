﻿
namespace PhoneBook.Data.Infrastructures
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }
        ICaptchaRepository CaptchaRepository { get; }
        IContactRepository ContactRepository { get; }
        void Commit();
    }
}
