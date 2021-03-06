using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Address Book");
            Console.WriteLine("Enter Address Book Name");
            string addressBookName = Console.ReadLine();
            AddressBookCollection addressBookCollection = new AddressBookCollection();
            AddressBook addressBook = new AddressBook();
            addressBookCollection.addressBookDictionary.Add(addressBookName, addressBook);
            int choice;
            do
            {
                Console.WriteLine("Enter 1 for Display All Contact");
                Console.WriteLine("Enter 2 Add new Contact");
                Console.WriteLine("Enter 3 Edit Contact");
                Console.WriteLine("Enter 4 Delete Contact");
                Console.WriteLine("Enter 5 Add New Address Book");
                Console.WriteLine("Enter 6 List of all Address Book");
                Console.WriteLine("Enter 7 Search Person in City or State");
                Console.WriteLine("Enter 8  View Person by City or State");
                Console.WriteLine("Enter 9 Count Contact by city or state");
                Console.WriteLine("Enter 10 Contact sort by Person Name");
                Console.WriteLine("Enter 11 sort by city state and zip");
                Console.WriteLine("Enter 12 Read data from file");
                Console.WriteLine("Enter 13 Write data into file");
                Console.WriteLine("Enter 14 Read data from csv file");
                Console.WriteLine("Enter 15 Write data into csv file");
                Console.WriteLine("Enter 16 Read data from JSON file");
                Console.WriteLine("Enter 17 Write data into JSON file");
                Console.WriteLine("Enter 0 to Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        addressBookCollection.addressBookDictionary[addressBookName].DisplayNamesInAddresBook();
                        break;
                    case 2:
                        addressBookCollection.addressBookDictionary[addressBookName].AddAddressBookEntry();
                        break;
                    case 3:
                        Console.WriteLine("Enter First Name");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("Enter Last Name");
                        string lastName = Console.ReadLine();
                        addressBookCollection.addressBookDictionary[addressBookName].EditContact(firstName, lastName);
                        break;
                    case 4:
                        Console.WriteLine("Enter First Name");
                        firstName = Console.ReadLine();
                        Console.WriteLine("Enter Last Name");
                        lastName = Console.ReadLine();
                        addressBookCollection.addressBookDictionary[addressBookName].DeleteContact(firstName, lastName);
                        break;
                    case 5:
                        Console.WriteLine("Enter New Address Book Name");
                        addressBookName = Console.ReadLine();
                        addressBookCollection.addressBookDictionary.Add(addressBookName, new AddressBook());
                        Console.WriteLine("Address Book selected: " + addressBookName);
                        break;
                    case 6:
                        Console.WriteLine("Listing all Address Books");
                        foreach (var addressBookEntry in addressBookCollection.addressBookDictionary)
                        {
                            Console.WriteLine(addressBookEntry.Key);
                        }
                        
                        break;
                    case 7:
                        Console.WriteLine("Enter First Name");
                        firstName = Console.ReadLine();                     
                        addressBookCollection.SearchPersonInCityOrState(firstName);
                        break;
                    case 8:
                        Console.WriteLine("Enter City Name");
                        string cityName = Console.ReadLine();
                        Console.WriteLine("Enter State Name");
                        string stateName = Console.ReadLine();
                        addressBookCollection.ViewPersonByCityOrState(cityName, stateName);
                        break;
                    case 9:
                        Console.WriteLine("Enter City name");
                        cityName = Console.ReadLine();
                        Console.WriteLine("Enter state name");
                        stateName = Console.ReadLine();
                        addressBookCollection.ViewCountByCityOrState(cityName, stateName);
                        break;
                    case 10:
                        addressBook.SortByPersonName();
                        break;
                    case 11:
                        addressBook.SortByCityStateZip();
                        break;
                    case 12:
                        addressBookCollection.ReadFileFromAddressBook();
                        break;
                    case 13:
                        addressBookCollection.WriteAddressBookCollectionToFiles();
                        break;
                    case 14:
                        addressBookCollection.WriteDataToCSVFiles();
                        break;
                    case 15:
                        addressBookCollection.ReadDataFromCSVFiles();
                        break;
                    case 16:
                        addressBookCollection.ReadFromJsonFiles();
                        break;
                    case 17:
                        addressBookCollection.WriteToJsonFiles();
                        break;
                    case 0:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            } while (choice !=0);


        }
    }
    
}


