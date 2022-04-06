using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace AddressBookSystem
{//Uc1
    class contactInfo
    {
        public string FirstName;
        public string LastName;
        public string Email;
        public int PhoneNumber;
        public string Address;
        public string City;
        public string State;
        public int ZipCode;

        public contactInfo()
        {
        }

        public contactInfo(string FirstName, string LastName, string Email, int PhoneNumber, string Address, string City, string State, int ZipCode)
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
        //Uc2
        public override string ToString()
        {
            return " Information Of " + FirstName + " " + LastName + " are: " +"\n"
                                                                              + "Email: " + Email +"\n"+ "PhoneNumber: " + PhoneNumber +"\n" 
                                                                                    +"Address: " + Address +"\n"+ "City:" + City+ "\n"+ "State:" + State +"\n" 
                                                                                    + "ZipCode:" + ZipCode + "\n";
        }



    }

    class Program
    {
        private ArrayList ContactInfoList;
        private Dictionary<string, contactInfo> ContactInfoMap;
        private Dictionary<string, contactInfo> addressBookDictionary;

        public Program()
        {
            ContactInfoList = new ArrayList();
            ContactInfoMap = new Dictionary<string, contactInfo>();
           // addressBookDictionary = new Dictionary<string, contactInfo>();
        }
           
        
        public void AddInfo()
        {
            int Person;
            Console.WriteLine("Enter a how many persons to add to Addressbook");
            Person=int.Parse(Console.ReadLine());
            for (int i = 0; i <= Person; i++)
            {
                Console.WriteLine("Enter your first name:");
                string FirstName = Console.ReadLine();
                Console.WriteLine("Enter your last name:");
                string LastName = Console.ReadLine();
                Console.WriteLine("Enter your email:");
                string Email = Console.ReadLine();
                Console.WriteLine("Enter your Phone number:");
                int PhoneNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your Address:");
                string Address = Console.ReadLine();
                Console.WriteLine("Enter your City:");
                string City = Console.ReadLine();
                Console.WriteLine("Enter your State:");
                string State = Console.ReadLine();
                Console.WriteLine("Enter your Zipcode:");
                int ZipCode = Convert.ToInt32(Console.ReadLine());
                contactInfo contact = new contactInfo(FirstName, LastName, Email, PhoneNumber, Address, City, State, ZipCode);
                ContactInfoList.Add(contact);
                ContactInfoMap.Add(FirstName, contact);
            }
               
        }
        //Uc3
        public void EditInfo(string key)
        {
            if(ContactInfoMap.ContainsKey(key))
            {
                Console.WriteLine("Enter your first name:");
                string FirstName = Console.ReadLine();
                Console.WriteLine("Enter your last name:");
                string LastName = Console.ReadLine();
                Console.WriteLine("Enter your email:");
                string Email = Console.ReadLine();
                Console.WriteLine("Enter your Phone number:");
                int PhoneNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your Address:");
                string Address = Console.ReadLine();
                Console.WriteLine("Enter your City:");
                string City = Console.ReadLine();
                Console.WriteLine("Enter your State:");
                string State = Console.ReadLine();
                Console.WriteLine("Enter your Zipcode:");
                int ZipCode = Convert.ToInt32(Console.ReadLine());
                contactInfo contact = new contactInfo(FirstName, LastName, Email, PhoneNumber, Address, City, State, ZipCode);
                ContactInfoList.Add(contact);
                ContactInfoMap[key] = contact;
            }
            else
            {
                Console.WriteLine("Key not found");
            }
        }
        public void DisplayInfo()
        {
            foreach (KeyValuePair<string, contactInfo> item in ContactInfoMap)
            {
                Console.WriteLine(item.Value);
            }
            //foreach (contactInfo contact in ContactInfoList)
            //    Console.WriteLine(contact.toString());
        }
        
        public void DeleteInfo()
        {
            Console.WriteLine("Enter the key to delete contact ");
            string Input = Console.ReadLine();
            if(ContactInfoMap.ContainsKey(Input.ToLower()))
            {
                ContactInfoMap.Remove(Input.ToLower()); 
            }
            else
            {
                Console.WriteLine("Key is not found");
            }
        }
        //UC6
        public class AddressBookCollection   //Add multiple address book
        {
            public Dictionary<string, contactInfo> addressBookDictionary;
            public AddressBookCollection()
            {
                addressBookDictionary = new Dictionary<string, contactInfo>();
            }
            public void AddressBookNames()
            {
                foreach (var item in addressBookDictionary)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book");
            int option = 0;
            AddressBookCollection addressBookCollection = new AddressBookCollection();
            Program Info = new Program();
            do
            {
                Console.WriteLine("1 for Adding Infomarmation");
                Console.WriteLine("2 for Display Infomarmation");
                Console.WriteLine("3 for Edit Infomarmation");
                Console.WriteLine("4 for Delete Infomarmation");
                Console.WriteLine("5 for Add multiple Address book");
                Console.WriteLine("6 for List of address book");
                Console.WriteLine("0 for Exit");
                try
                {
                    option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Info.AddInfo();
                            break;
                        case 2:
                            Info.DisplayInfo();
                            break;
                        case 3:
                            Console.WriteLine("Enter first name to edit");
                            string key=Console.ReadLine();
                            Info.EditInfo(key);
                            break;
                        case 4:
                            Info.DeleteInfo();
                            break;
                        case 5:
                            Console.WriteLine("Enter New Address Book Name");
                            string addresBookName = Console.ReadLine();
                            addressBookCollection.addressBookDictionary.Add(addresBookName, new contactInfo());
                            Console.WriteLine("Address Book {0} selected.", addresBookName);
                            // Info.MultiAddressBook();
                            break;
                        case 6:
                            Console.WriteLine("List of all Address Books");
                            foreach (var item in addressBookCollection.addressBookDictionary)
                            {
                                Console.WriteLine(item.Key);
                            }
                            break;
                        case 0:
                            Console.WriteLine("Exit");
                            break;
                        default:
                            Console.WriteLine("wrong key");
                            break;

                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Please Choose option");
                }
            }
            while (option != 0);
            }
        }
    }
            


