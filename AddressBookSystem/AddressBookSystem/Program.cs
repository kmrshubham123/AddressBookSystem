using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Welcome to Address Book System*****");
            AddressBook addressBook = new AddressBook();
            int choice, choice2;          ///Two choices 1. Default AddessBook 2.New Address Book
            string bookName = "default";
            Console.WriteLine("Would You Like To \n1.Work on default AddressBook \n2.Create New AddressBook");
            choice2 = Convert.ToInt32(Console.ReadLine());
            switch (choice2)
            {
                case 1:
                    addressBook.AddAddressBook(bookName);
                    break;
                case 2:
                    Console.WriteLine("Enter Name Of New Addressbook You want to create : ");
                    bookName = Console.ReadLine();
                    addressBook.AddAddressBook(bookName);
                    break;
            }
            do
            {
                Console.WriteLine($"Working On {bookName} AddressBook\n");
                Console.WriteLine("Choose An Option \n1.Add New Contact \n2.Edit Existing Contact \n3.Delete A Contact \n4.View A Contact \n5.View Multiple Contacts \n6.Add New AddressBook \n7.Switch AddressBook \n8.Search Contact by city/state \n9.Exit Application\n");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter First Name :");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("Enter Last Name :");
                        string lastName = Console.ReadLine();
                        //For dupicate Entry
                        Contacts temp = new Contacts(firstName, lastName, null, null, null, null, 0, 0);
                        if (addressBook.CheckDuplicateEntry(temp, bookName))
                        {
                            break;
                        }
                        Console.WriteLine("Enter Address :");
                        string address = Console.ReadLine();
                        Console.WriteLine("Enter City :");
                        string city = Console.ReadLine();
                        Console.WriteLine("Enter State :");
                        string state = Console.ReadLine();                  /// add Contact
                        Console.WriteLine("Enter Email :");
                        string email = Console.ReadLine();
                        Console.WriteLine("Enter Zip :");
                        int zipCode = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Phone Number :");
                        long phoneNumber = Convert.ToInt64(Console.ReadLine());
                        addressBook.AddContact(firstName, lastName, address, city, state, zipCode, phoneNumber, email, bookName);
                        break;
                    case 2:
                        Console.WriteLine("Enter First Name Of Contact To Edit :");
                        string nameToEdit = Console.ReadLine();                         ///Edit contact
                        addressBook.EditContact(nameToEdit, bookName);
                        break;
                    case 3:
                        Console.WriteLine("Enter First Name Of Contact To Delete :");
                        string nameToDelete = Console.ReadLine();                               /// Delete Contacts
                        addressBook.DeleteContact(nameToDelete, bookName);
                        break;
                    case 4:
                        Console.WriteLine("Enter First Name Of Contact To View :");
                        string nameToView = Console.ReadLine();                                ///Contact View
                        addressBook.ViewContact(nameToView, bookName);
                        break;
                    case 5:
                        addressBook.ViewContact(bookName);
                        break;
                    case 6:
                        Console.WriteLine("Enter Name For New AddressBook");
                        string newAddressBook = Console.ReadLine();
                        addressBook.AddAddressBook(newAddressBook);
                        Console.WriteLine("Would you like to Switch to " + newAddressBook);
                        Console.WriteLine("1.Yes \n2.No");
                        int c = Convert.ToInt32(Console.ReadLine());
                        if (c == 1)
                        {
                            bookName = newAddressBook;
                        }
                        break;
                    case 7:
                        Console.WriteLine("Enter Name Of AddressBook From Below List");
                        foreach (KeyValuePair<string, AddressBook> item in addressBook.GetAddressBook())
                        {
                            Console.WriteLine(item.Key);
                        }
                        while (true)
                        {
                            bookName = Console.ReadLine();
                            if (addressBook.GetAddressBook().ContainsKey(bookName))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("No such AddressBook found. Try Again.");
                            }
                        }
                        break;
                    case 8:
                        Console.WriteLine("Would You Like To \n1.Search by city \n2.Search by state");
                        int opt = Convert.ToInt32(Console.ReadLine());
                        switch (opt)
                        {
                            case 1:
                                Console.WriteLine("Enter name of city :");
                                addressBook.SearchPersonByCity(Console.ReadLine());
                                break;
                            case 2:
                                Console.WriteLine("Enter name of state :");
                                addressBook.SearchPersonByState(Console.ReadLine());
                                break;
                            default:
                                Console.WriteLine("Invalid Input.Enter 1 or 2");
                                break;
                        }
                        break;
                    case 9:
                        Console.WriteLine("Thank You For Using Address Book System.");
                        break;
                    default:
                        Console.WriteLine( "----Enter Right Choice(1-9)----" );
                        break;
                }
            } while (choice != 9);
          
        }
    }
}
