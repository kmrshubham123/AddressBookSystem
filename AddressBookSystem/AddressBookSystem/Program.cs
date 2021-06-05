using System;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Welcome to Address Book System*****");
            ///putting value in constructor
            Contacts contacts = new Contacts("Kumar", "Shubham", "Bihar", "Bihar Sharif", "Nai Sarai", 803101, 1032602310, "kmrshubham123@gmail.com");
            Console.WriteLine("First Name:" + contacts.FirstName);
            Console.WriteLine("Last Name:" + contacts.LastName);
            Console.WriteLine("State Name:" + contacts.State);
            Console.WriteLine("City Name:" + contacts.City);
            Console.WriteLine("Address Name:" + contacts.Address);
            Console.WriteLine("Phone No:" + contacts.PhoneNumber);
            Console.WriteLine("Zip Code:" + contacts.ZipCode);
            Console.WriteLine("Email Address:" + contacts.Email);
        }
    }
}
