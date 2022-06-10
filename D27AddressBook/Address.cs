using System;
using System.Collections.Generic;

namespace D27AddressBook
{
    public class Address
    {
        public string FirstName;
        public string LastName;
        public string City;
        public string State;
        public string ZipCode;
        public string PhoneNumber;
        public string Email;

        public static List<Address> All = new List<Address>();

        private static void AddAddress()
        {
            Address address = new Address();

            Console.WriteLine("Enter First Name:");
            address.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name:");
            address.LastName = Console.ReadLine();

            Console.WriteLine("Enter city: ");
            address.City = Console.ReadLine();

            Console.WriteLine("Enter the State:");
            address.State = Console.ReadLine();

            Console.WriteLine("Enter the Zipcode:");
            address.ZipCode = Console.ReadLine();

            Console.WriteLine("Enter the PhoneNumber:");
            address.PhoneNumber = Console.ReadLine();

            Console.WriteLine("Enter the Email:");
            address.Email = Console.ReadLine();

        }
    }
}