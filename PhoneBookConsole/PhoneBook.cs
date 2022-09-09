using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneBookConsole
{
    public class PhoneBook
    {
        // Creating a list //
        private List<Contact> _contacts { get; set; }

        // Private method for displaying contacts // 
        private void DisplayContactDetails(Contact contact)
        {
            Console.WriteLine($"Contact: {contact.Name}, {contact.Number}");
        }

        // Adding contact objects to the list //
        public void AddContact(Contact contact)
        {
            _contacts.Add(contact);
        }

        public void DisplayContact(string number)
        {
            // Searching the List to find a matching phonenumber // 
            var contact = _contacts.FirstOrDefault(c => c.Number == number);
            if (contact == null)
            {
                Console.WriteLine("Contact Not Found");
            }
            else
            {
                DisplayContactDetails(contact);
            }
        }

        public void DisplayAllContact()
        {
            // Looping through the list and displaying all the contacts //
            foreach (var contact in _contacts)
            {
                DisplayContactDetails(contact);
            }
        }

    }
}

