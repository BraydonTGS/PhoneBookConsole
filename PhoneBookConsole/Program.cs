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
            Console.WriteLine("Exit"); 
            Console.WriteLine();
            Console.Write("Please Enter your Seleciton: ");
            var userInput = Console.ReadLine();

            var phoneBook = new PhoneBook();

            while (true)
            {
                switch (userInput)
                {
                    case "1":
                        Console.Write("Contact name: ");
                        var name = Console.ReadLine();
                        Console.Write("Contact number: ");
                        var number = Console.ReadLine();
                        // New Instance of a Contact // 
                        var newContact = new Contact(name, number);
                        // Invoke the Add Contact Method //
                        phoneBook.AddContact(newContact);
                        break;
                    case "2":
                        Console.Write("Contact number to search ");
                        var searchNumber = Console.ReadLine();
                        phoneBook.DisplayContact(searchNumber); 
                        break;
                    case "3":
                        phoneBook.DisplayAllContact(); 
                        break;
                    case "4":
                        Console.Write("Name Search: ");
                        var searchPhrase = Console.ReadLine();
                        phoneBook.DisplayMatchingContact(searchPhrase); 
                        break;
                    case "Exit":
                        return;
                    default:
                        Console.WriteLine("Select valid operation");
                        break;
                }
                Console.Write("Please Enter your Seleciton: ");
                userInput = Console.ReadLine(); 
            }

        }
    }
}

