/*
Author: Zachery Alexander
Date: 10/5/2025
Assignment: Programming Assignment 3 (PA3)
*/
using System;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a phonebook
            PhoneBook phoneBook = new PhoneBook();

            // Add some businesses
            phoneBook.AddBusinessEntity("456 Commerce Blvd", "Seattle", "WA", "98101", "555-1234", "Acme Corporation");
            phoneBook.AddBusinessEntity("789 Industrial Way", "Portland", "OR", "97201", "555-5555", "Tech Solutions Inc");

            // Add some people
            phoneBook.AddPersonEntity("123 Main St", "Eugene", "OR", "97401", "555-7890", "John", "Doe");
            phoneBook.AddPersonEntity("321 Oak Ave", "Salem", "OR", "97301", "555-1111", "Jane", "Smith");
            phoneBook.AddPersonEntity("555 Pine St", "Bend", "OR", "97701", "555-2222", "Bob", "Johnson");

            // Print the entire phonebook
            phoneBook.PrintPhonebook();

            Console.ReadLine();
        }
    }
}