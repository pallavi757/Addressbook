using System;
using System.Collections.Generic;
namespace AddressBookSystem
{//Uc1
    class ContactInfo
    {
        public string FirstName;
        public string LastName;
        public string Email;
        public string PhoneNumber;
        public string Address;
        public string City;
        public string State;
        public string ZipCode;
        public ContactInfo(string FirstName, string LastName, string Email, string PhoneNumber, string Address, string City, string State, string ZipCode)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
            this.Address = Address;
            this.City = City;
            this.State = State;
            this.ZipCode = ZipCode;
        }
      
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book");
            Console.WriteLine("Enter your first name:");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Enter your last name:");
            string LastName = Console.ReadLine();
            Console.WriteLine("Enter your email:");
            string Email = Console.ReadLine();
            Console.WriteLine("Enter your Phone number:");
            string PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter your Address:");
            string Address = Console.ReadLine();
            Console.WriteLine("Enter your City:");
            string City = Console.ReadLine();
            Console.WriteLine("Enter your State:");
            string State = Console.ReadLine();
            Console.WriteLine("Enter your Zipcode:");
            string ZipCode = Console.ReadLine();

        }
    }
}