using System;
using System.Collections;
using System.Collections.Generic;

namespace PhoneBook.Domain.Models
{
    public class Contact
    {
        public Contact()
        {
            CreatedDate = DateTime.Now;
        }

        public int ContactId { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string HomePhone { get; set; }
        public string MobilePhone { get; set; }

        public DateTime CreatedDate { get; private set; }

        public User User;

        public virtual ICollection<ContactDetail> ContactDetails { get; set; }
    }
}
