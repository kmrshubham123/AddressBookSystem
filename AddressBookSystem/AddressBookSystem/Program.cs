using System;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Welcome to Address Book System*****");
          
            AddressBook addressBook = new AddressBook();
            addressBook.AddContact("Kumar", "Shubham", "Nai sarai", "Bihar Sharif", "Bihar",  803101, 5698531895,"Kmrshubham123@gmail.com");
            addressBook.ViewContact();
        }
    }
}
