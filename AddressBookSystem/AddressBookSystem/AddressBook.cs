using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    class AddressBook : IContacts
    {
        private Dictionary<string, Contacts> addressBook = new Dictionary<string, Contacts>();
        public void AddContact(string firstName, string lastName, string address, string city, string state, int zipCode, long phoneNumber, string email)
        {
            Contacts contact = new Contacts();
            contact.FirstName = firstName;
            contact.LastName = lastName;
            contact.Address = address;
            contact.City = city;
            contact.State = state;
            contact.ZipCode = zipCode;
            contact.PhoneNumber = phoneNumber;
            contact.Email = email;
            addressBook.Add(contact.FirstName, contact);
        }
        public void ViewContact()
        {
            foreach (KeyValuePair<string, Contacts> item in addressBook)
            {
                Console.WriteLine("First Name : " + item.Value.FirstName);
                Console.WriteLine("Last Name : " + item.Value.LastName);
                Console.WriteLine("Address : " + item.Value.Address);
                Console.WriteLine("City : " + item.Value.City);
                Console.WriteLine("State : " + item.Value.State);
                Console.WriteLine("ZipCode : " + item.Value.ZipCode);
                Console.WriteLine("Phone Number : " + item.Value.PhoneNumber);
                Console.WriteLine("Email : " + item.Value.Email);
            }
        }
    }
}
