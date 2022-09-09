using System;
namespace PhoneBookConsole
{
    public class Contact
    {
        // Contact Constructor, sets the name and number // 
        public Contact (string name, string number)
        {
            Name = name;
            Number = number; 
        }

        public string Name { get; set;  }

        public string Number { get; set;  }
    }
}

