using PhoneBook.Data.Infrastructures;
using PhoneBook.Domain.Models;
using PhoneBook.Service.Contracts;
using System.Collections.Generic;

namespace PhoneBook.Service.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public User SelectUserById(int userId)
        {
            return _unitOfWork.UserRepository.Single(userId);
        }

        public IEnumerable<User> SelectAllUsers()
        {
            return _unitOfWork.UserRepository.GetAll();
        }

        public int CreateUser(User user)
        {
            bool userExists = _unitOfWork.UserRepository.Exists(u => u.UserName == user.UserName);
            if (userExists) return 0;
            _unitOfWork.UserRepository.Insert(user);
            _unitOfWork.Commit();
            return user.UserId;
        }

        public void UpdateUser(User user)
        {
            _unitOfWork.UserRepository.Update(user);
            _unitOfWork.Commit();
        }

        public void DeleteUser(int userId)
        {

            _unitOfWork.UserRepository.Delete(SelectUserById(userId));
        }

        public bool Exists(User user)
        {
            return _unitOfWork.UserRepository.Exists(u => u.UserName == user.UserName && u.Password == user.Password);
        }
    }
}
