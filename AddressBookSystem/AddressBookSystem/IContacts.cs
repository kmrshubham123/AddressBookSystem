using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    interface IContacts
    {
        public void AddContact(string firstName, string lastName, string address, string city, string state,  int zipCode, long phoneNumber, string email);
        public void EditContact(string name);
        public void DeleteContact(string name);
        public void ViewContact(string name);
    }
    
}
