using System.Collections;
using System.Collections.Generic;
using PhoneBook.Domain.Models;

namespace PhoneBook.Service.Contracts
{
    public interface IContactService
    {
        /// <summary>
        /// Creates new contact of current user.
        /// </summary>
        /// <param name="contact">Contact object.</param>
        int CreateContact(Contact contact);
        Contact SelectContactById(int contactId);
        IEnumerable<Contact> SelectAllContact();
        void EditContact(Contact contact);
        void DeleteContact(int contactId);
    }
}
