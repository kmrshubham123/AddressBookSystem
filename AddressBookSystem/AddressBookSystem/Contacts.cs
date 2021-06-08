using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{/// <summary>
/// Automatic Properties (Short Hand) ||  not have to define the field for the property,
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
    }

}
