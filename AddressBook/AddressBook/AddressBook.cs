using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class AddressBooks
    {
        List<Contact> data = new List<Contact>();
        public void CreateContact()
        {
            Contact contact = new Contact();
            Console.WriteLine("Enter Fristname");
            contact.Firstname = Console.ReadLine();
            Console.WriteLine("Enter Lastname");
            contact.Lastname = Console.ReadLine();
            Console.WriteLine("Enter Address");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter City");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter State");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter phoneNumber");
            contact.PhoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Email");
            contact.Email = Console.ReadLine();
            data.Add(contact);
        }
        public void DisplayContact()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("********Contact********");
            Console.ResetColor();
            foreach(Contact records in data)
            {
                Console.WriteLine("Fristname - "+records.Firstname);
                Console.WriteLine("Lastname - "+records.Lastname);
                Console.WriteLine("Address - "+records.Address);
                Console.WriteLine("City - "+records.City);
                Console.WriteLine("State - "+records.State);
                Console.WriteLine("PhoneNumber - "+records.PhoneNumber);
                Console.WriteLine("Emsil - "+records.Email);
            }
        }
        public void EditContact()
        {
            Console.WriteLine("To edit the contact enter contact fristname");
            string name = Console.ReadLine();
            foreach(var record in data)
            {
                if(record.Firstname == name)
                {
                    Console.WriteLine(name +" is exists");
                    Console.WriteLine("To Edit The Details Enter" + " \n1.Lastname\n2.Address\n3.City\n4.Sate\n5.Phonenumber\n7.Email");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter new Lastname");
                            string newLastname = Console.ReadLine();
                            record.Lastname = newLastname;
                            break;
                        case 2:
                            Console.WriteLine("Enter the Address");
                            string newAddress = Console.ReadLine();
                            record.Address = newAddress;
                            break;
                        case 3:
                            Console.WriteLine("Enter the new City");
                            string newCity = Console.ReadLine();
                            record.City = newCity;
                            break;
                        case 5:
                            Console.WriteLine("Enter new State");
                            string newState = Console.ReadLine();
                            record.State = newState;
                            break;
                        case 6:
                            Console.WriteLine("Enter new PhoneNumber");
                            long newPhoneNumber = Convert.ToInt64(Console.ReadLine());
                            record.PhoneNumber = newPhoneNumber;
                            break;
                        case 7:
                            Console.WriteLine("Enter new Email");
                            string newEmail = Console.ReadLine();
                            record.Email = newEmail;
                            break;

                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Name dose not exists");
                    Console.ResetColor();
                }
            }
        }
        public void DeleteContact()
        {
            Console.WriteLine("To delete contact enter contact first");
            string name = Console.ReadLine();
            foreach (var record in data.ToList())
            {
                if (data.Contains(record))
                {
                    if (record.Firstname == name)
                    {
                        try
                        {
                            data.Remove(record);
                            Console.WriteLine("Record Deleted succssied");
                        }
                        catch(Exception w)
                        {
                            Console.WriteLine(w.Message);
                        }
                        

                       
                    }
                       
                }
            }
        }
          
        


    }
}
