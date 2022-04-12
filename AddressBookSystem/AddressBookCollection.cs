using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CsvHelper.Configuration;
using Newtonsoft.Json;

namespace AddressBookSystem
{
    class AddressBookCollection
    {
        public Dictionary<string, AddressBook> addressBookDictionary;//Dictionary collection
        public Dictionary<string, List<Person>> cityDictionary;
        public Dictionary<string, List<Person>> stateDictionary;

        // public object cityDictionary;
        // public object stateDictionary;
        public AddressBookCollection()
        {
            addressBookDictionary = new Dictionary<string, AddressBook>();
        }
        public void PrintAllAddressBookNames()
        {
            foreach (var AddressBookItem in addressBookDictionary)
            {
                Console.WriteLine(AddressBookItem.Key);
            }
        }
        public void SearchPersonInCityOrState(string firstName)
        {
            foreach (var addressBookEntry in addressBookDictionary)
            {
                List<Person> PersonInCitiesOrStates = addressBookEntry.Value.addressBook.FindAll(i => (i.firstName == firstName));
                foreach (Person person in PersonInCitiesOrStates)
                {
                    Console.WriteLine($" {person.firstName}  is in {person.city} {person.state}");
                }
            }
        }
        public void ViewPersonByCityOrState(string city, string state)
        {
            foreach (var addressBookEntry in addressBookDictionary)
            {
                List<Person> PersonInCitiesOrStates = addressBookEntry.Value.addressBook.FindAll(i => (i.city == city) && (i.state == state));
                foreach (Person person in PersonInCitiesOrStates)
                {
                    Console.WriteLine($" {person.city} {person.state} is in {person.city} {person.state}");
                }
            }
        }
        public void ViewCountByCityOrState(string city, string state)
        {
            foreach (var addressBookEntry in addressBookDictionary)
            {
                List<Person> ViewCountByCityOrState = addressBookEntry.Value.addressBook.FindAll(i => (i.city == city) && (i.state == state));
                foreach (Person person in ViewCountByCityOrState)
                {
                    Console.WriteLine($"Total person in {city} are : " + ViewCountByCityOrState.Count);
                }
            }
        }
        public void ReadFileFromAddressBook()
        {
            string Path = @"H:\VS\Addressbook\AddressBookSystem\File\PersonInfo.txt";
            if (File.Exists(Path))
            {
                string output = File.ReadAllText(Path);
                Console.WriteLine(output);
            }
            else
                Console.WriteLine("file not exist");
        }
        public void WriteAddressBookCollectionToFiles()
        {
            string folderPath = @"H:\VS\Addressbook\AddressBookSystem\File\";
            foreach (var AddressBookItem in addressBookDictionary)
            {
                string Path = folderPath + AddressBookItem.Key + ".txt";
                using (StreamWriter writer = new StreamWriter(Path))
                {
                    foreach (Person person in AddressBookItem.Value.addressBook)
                    {
                        writer.WriteLine($"First Name : {person.firstName}");
                        writer.WriteLine($"Last Name : {person.lastName}");
                        writer.WriteLine($"Address : {person.address}");
                        writer.WriteLine($"City : {person.city}");
                        writer.WriteLine($"State : {person.state}");
                        writer.WriteLine($"Zip : {person.zip}");
                        writer.WriteLine($"PhoneNumber : {person.phoneNumber}");
                        writer.WriteLine($"Email : {person.email}");

                    }
                }
            }

        }
        public void WriteDataToCSVFiles()
        {
            string Path = @"H:\VS\Addressbook\AddressBookSystem\CsvFile\";
            CsvConfiguration config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                IncludePrivateMembers = true,
            };
            foreach (var AddressBookItem in addressBookDictionary)
            {
                string filePath = Path + AddressBookItem.Key + ".csv";
                using (StreamWriter writer = new StreamWriter(filePath))
              // using var csvWriter=new 
                using (var csvExport = new CsvWriter(writer, config))
                {
                    
                    csvExport.WriteHeader<Person>();
                    csvExport.NextRecord();
                    
                    foreach (Person person in AddressBookItem.Value.addressBook)
                    {
                        
                        csvExport.WriteField($"{person.firstName}");
                        csvExport.WriteField($"{person.lastName}");
                        csvExport.WriteField($"{person.address}");
                        csvExport.WriteField($"{person.city}");
                        csvExport.WriteField($"{person.state}");
                        csvExport.WriteField($"{person.zip}");
                        csvExport.WriteField($"{person.phoneNumber}");
                        csvExport.WriteField($"{person.email}");
                        csvExport.NextRecord();
                    }
                }
            }
        }
        public void ReadDataFromCSVFiles()
        {
            string filePath = @"H:\VS\Addressbook\AddressBookSystem\CsvFile\";
            string[] file = Directory.GetFiles(filePath, "*.csv");
            foreach (var presentFiles in file)
            {
                using (StreamReader streamReader = File.OpenText(presentFiles))
                {
                    string lines = "";
                    while ((lines = streamReader.ReadLine()) != null)
                    {
                        Console.WriteLine(lines);
                    }
                }
            }
        }
       
    }
}
   