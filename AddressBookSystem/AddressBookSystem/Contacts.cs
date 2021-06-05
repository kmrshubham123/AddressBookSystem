using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    
    class Contacts
    {
        //variables
        private string firstName;
        private string lastName;
        private string state;
        private string city;
        private string address;
        private long zipCode;
        private long phoneNumber;
        private string email;
        
        ///created a class Constructor 
        
        public Contacts(string firstName, string lastName, string state, string city, string address, long zipCode, long phoneNumber, string email)
        {
            this.firstName = firstName;    //assign parameter(this=diff b/w global variables and const. parameter)
            this.lastName = lastName;
            this.state = state;
            this.city = city;
            this.address = address;
            this.zipCode = zipCode;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }
        
        public string FirstName //property
        {
            get { return this.firstName; }   //get method
            set { this.firstName = value; }  //set method
        }
        public string LastName //property
        {
            get { return this.lastName; }   //get method
            set { this.lastName = value; }  //set method
        }
        public string State //property
        {
            get { return this.state; }   //get method
            set { this.state = value; }  //set method
        }
        public string City //property
        {
            get { return this.city; }   //get method
            set { this.city = value; }  //set method
        }
        public string Address //property
        {
            get { return this.address; }   //get method
            set { this.address = value; }  //set method
        }
        public long ZipCode //property
        {
            get { return this.zipCode; }   //get method
            set { this.zipCode = value; }  //set method
        }
        public long PhoneNumber //property
        {
            get { return this.phoneNumber; }   //get method
            set { this.phoneNumber = value; }  //set method
        }
        public string Email //property
        {
            get { return this.email; }   //get method
            set { this.email = value; }  //set method
        }
    }

}
