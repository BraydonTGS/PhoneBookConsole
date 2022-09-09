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
        // Private method for displaying contact details //
        private void DisplayContactsDetails(List<Contact> contacts)
        {
            foreach (var contact in contacts)
            {
                DisplayContactDetails(contact);
            }
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
            DisplayContactsDetails(_contacts);
        }

        public void DisplayMatchingContact(string searchPhrase)
        {
            // Filter the existing List using Where and Contains & creating a list //
            var matchingContacts = _contacts.Where(c => c.Name.Contains(searchPhrase)).ToList();
            DisplayContactsDetails(matchingContacts);

        }

    }
}

