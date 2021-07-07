using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressBookSystem
{
    class AddressBook : IContacts
    {
        private Dictionary<string, Contacts> addressBook = new Dictionary<string, Contacts>();
        private Dictionary<string, AddressBook> addressBookDictionary = new Dictionary<string, AddressBook>();
        public void AddContact(string firstName, string lastName, string address, string city, string state, int zipCode, long phoneNumber, string email, string bookName)
        {
            Contacts contact = new Contacts(firstName, lastName, address, city, state, email, zipCode, phoneNumber);
            addressBookDictionary[bookName].addressBook.Add(contact.FirstName, contact);
            Console.WriteLine("\nAdded Succesfully. \n");

        }
        public void ViewContact(string name, string bookName)
        {
            foreach (KeyValuePair<string, Contacts> item in addressBook)
            {
                if (item.Key.Equals(name))
                {
                    Console.WriteLine("First Name : " + item.Value.FirstName);
                    Console.WriteLine("Last Name : " + item.Value.LastName);
                    Console.WriteLine("Address : " + item.Value.Address);
                    Console.WriteLine("City : " + item.Value.City);
                    Console.WriteLine("State : " + item.Value.State);
                    Console.WriteLine("Phone Number : " + item.Value.PhoneNumber);
                    Console.WriteLine("ZipCode : " + item.Value.ZipCode);
                    Console.WriteLine("Email  : " + item.Value.Email );
                }
            }
        }
        public void ViewContact(string bookname)
        {
            foreach (KeyValuePair<string, Contacts> item in addressBook)
            {
                Console.WriteLine("First Name : " + item.Value.FirstName);
                Console.WriteLine("Last Name : " + item.Value.LastName);
                Console.WriteLine("Address : " + item.Value.Address);
                Console.WriteLine("City : " + item.Value.City);
                Console.WriteLine("State : " + item.Value.State);
                Console.WriteLine("Phone Number : " + item.Value.PhoneNumber);
                Console.WriteLine("ZipCode : " + item.Value.ZipCode);
                Console.WriteLine("Email  : " + item.Value.Email );
            }
        }
        /// <summary>
        /// Method For Edit Contact
        /// </summary>
        /// <param name="name"></param>
        /// <param name="bookName"></param>
        public void EditContact(string name, string bookName)
        {
            foreach (KeyValuePair<string, Contacts> item in addressBook)
            {
                if (item.Key.Equals(name))
                {
                    Console.WriteLine("Choose What to Edit \n1.First Name \n2.Last Name \n3.Address \n4.City \n5.State \n6.Phone Number \n7.Zip \n8.Email");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter New First Name :");
                            item.Value.FirstName = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Enter New Last Name :");
                            item.Value.LastName = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Enter New Address :");
                            item.Value.Address = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Enter New City :");
                            item.Value.City = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Enter New State :");
                            item.Value.State = Console.ReadLine();
                            break;
                        case 6:
                            Console.WriteLine("Enter New Phone Number :");
                            item.Value.PhoneNumber = Convert.ToInt64(Console.ReadLine());
                            break;
                        case 7:
                            Console.WriteLine("Enter New Zip :");
                            item.Value.ZipCode = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 8:
                            Console.WriteLine("Enter New Email :");
                            item.Value.Email = Console.ReadLine();
                            break;

                    }
                    Console.WriteLine("\nEdited Successfully.\n");
                }
            }
     
        }
        /// <summary>
        /// Method for Delete Contact
        /// </summary>
        /// <param name="name"></param>
        /// <param name="bookName"></param>
        public void DeleteContact(string name, string bookName)
        {
            if (addressBook.ContainsKey(name))
            {
                addressBook.Remove(name);
                Console.WriteLine("\nDeleted Succesfully.\n");
            }
            else
            {
                Console.WriteLine("\nNot Found, Try Again.\n");
            }
        }
        /// <summary>
        /// Method for Add AddressBook
        /// </summary>
        /// <param name="bookName"></param>
        public void AddAddressBook(string bookName)
        {
            AddressBook addressBook = new AddressBook();
            addressBookDictionary.Add(bookName, addressBook);
            Console.WriteLine("AddressBook Created.");
        }
        public Dictionary<string, AddressBook> GetAddressBook()
        {
            return addressBookDictionary;
        }
        public List<Contacts> GetListOfDictctionaryKeys(string bookName)
        {
            List<Contacts> book = new List<Contacts>();
            foreach (var value in addressBookDictionary[bookName].addressBook.Values)
            {
                book.Add(value);
            }
            return book;
        }
        public bool CheckDuplicateEntry(Contacts c, string bookName)
        {
            List<Contacts> book = GetListOfDictctionaryKeys(bookName);
            if (book.Any(b => b.Equals(c)))
            {
                Console.WriteLine("Name already Exists.");
                return true;
            }
            return false;
        }
    }

}
