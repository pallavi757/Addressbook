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
        public string toString()
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
        public Program()
        {
            ContactInfoList = new ArrayList();
            ContactInfoMap = new Dictionary<string, contactInfo>();
        }
        public void AddInfo()
        {
            Console.WriteLine("Enter your first name:");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Enter your last name:");
            string LastName = Console.ReadLine();
            Console.WriteLine("Enter your email:");
            string Email = Console.ReadLine();
            Console.WriteLine("Enter your Phone number:");
            int PhoneNumber =Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Enter your Address:");
            string Address = Console.ReadLine();
            Console.WriteLine("Enter your City:");
            string City = Console.ReadLine();
            Console.WriteLine("Enter your State:");
            string State = Console.ReadLine();
            Console.WriteLine("Enter your Zipcode:");
            int ZipCode =Convert.ToInt32(Console.ReadLine());
            contactInfo contactInfo = new contactInfo(FirstName, LastName, Email, PhoneNumber, Address, City, State, ZipCode);
            ContactInfoList.Add(contactInfo);
            ContactInfoMap.Add(FirstName, contactInfo);
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
                contactInfo contactInfo = new contactInfo(FirstName, LastName, Email, PhoneNumber, Address, City, State, ZipCode);
                ContactInfoList.Add(contactInfo);
                ContactInfoMap[key] = contactInfo;
            }
            else
            {
                Console.WriteLine("Key not found");
            }
        }
        public void DisplayInfo()
        {
            foreach (contactInfo contact in ContactInfoList)
                Console.WriteLine(contact.toString());
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book");
            int option = 0;
            Program Info = new Program();
            do
            {
                Console.WriteLine("1 for Adding Infomarmation");
                Console.WriteLine("2 for Display Infomarmation");
                Console.WriteLine("3 for Edit Infomarmation");
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
            


