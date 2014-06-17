using System.Collections.Generic;
using PhoneBook.Domain.Models;

namespace PhoneBook.Service.Contracts
{
    public interface IUserService
    {
        /// <summary>
        /// Retrieves Single user filtered by user id.
        /// </summary>
        /// <param name="userId">Unique id of user.</param>
        /// <returns>T</returns>
        User SelectUserById(int userId);

        /// <summary>
        /// Returns list of all users.
        /// </summary>
        /// <returns>Collection of users.</returns>
        IEnumerable<User> SelectAllUsers();

        /// <summary>
        /// Creates new user. 
        /// </summary>
        /// <param name="user">User object.</param>
        int CreateUser(User user);

        /// <summary>
        /// Updates user's information.
        /// </summary>
        /// <param name="user">User object.</param>
        void UpdateUser(User user);

        /// <summary>
        /// Deletes user.
        /// </summary>
        /// <param name="userId">Unique id of user to be deleted.</param>
        /// <returns></returns>
        void DeleteUser(int userId);

        /// <summary>
        /// Checks if user exists.
        /// </summary>
        /// <param name="user">User object.</param>
        /// <returns>true or false.</returns>
        bool Exists(User user);



    }
}
