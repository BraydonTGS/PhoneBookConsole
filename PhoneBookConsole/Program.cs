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
            Console.WriteLine(); 
            Console.Write("Please Enter your Seleciton: "); 
            var userInput = Console.ReadLine();

            var phoneBook = new PhoneBook();

            switch (userInput)
            {
                case "1":
                    Console.Write("Contact name: ");
                    var name = Console.ReadLine();
                    Console.Write("Contact numer: ");
                    var number = Console.ReadLine(); 

                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("Select valid operation");
                    break; 
            }
        }
    }
}

