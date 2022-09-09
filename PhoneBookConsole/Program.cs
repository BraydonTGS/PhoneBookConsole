using System;

namespace PhoneBookConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello From the Console PhoneBook App!");
            Console.WriteLine("Select operation: ");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Display Contact by Number");
            Console.WriteLine("3. View all Contacts");
            Console.WriteLine("4. Search for contacts for a given name");

            var userInput = Console.ReadLine(); 
        }
    }
}

