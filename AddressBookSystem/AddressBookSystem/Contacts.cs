using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{/// <summary>
/// Automatic Properties for bring and Store the value
/// </summary>
    class Contacts
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }
        /// <summary>
        /// parametrized constructor
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="address"></param>
        /// <param name="city"></param>
        /// <param name="state"></param>
        /// <param name="email"></param>
        /// <param name="zipCode"></param>
        /// <param name="phoneNumber"></param>
        public Contacts(string firstName, string lastName, string address, string city, string state, string email, int zipCode, long phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            State = state;
            Email = email;
            ZipCode = zipCode;
            PhoneNumber = phoneNumber;
        }
        /// <summary>
        /// specified object is equal to the current object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            Contacts contact = (Contacts)obj;
            if (contact == null)
                return false;
            else
                return FirstName.Equals(contact.FirstName) && LastName.Equals(contact.LastName);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(FirstName, LastName);
        }
    }


}
