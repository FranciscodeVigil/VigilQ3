using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    sealed class PhoneBook
    {
        public List<PhoneBookItem> PhoneBookEntries { get; set; }

        public PhoneBook()
        {
            PhoneBookEntries = new List<PhoneBookItem>();
        }
        public string GetPhoneBook()
        {
            string phonebook = "";
            //FV Changed string type to PhoneBookItem type
            foreach (PhoneBookItem item in PhoneBookEntries)
            {
                phonebook += item.GetContactSummary() + "\n\n";
            }
            return phonebook;
        }

    }
}
