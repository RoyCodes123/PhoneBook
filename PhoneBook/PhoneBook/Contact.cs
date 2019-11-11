using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Contact
    {
        private string name;
        private string phone;

        public Contact(string name, string phone)
        {
            this.name = name;
            this.phone = phone;
        }

        public string GetPhone() { return this.phone; }
        public string GetName() { return this.name; }
        public void SetName(string name) { this.name = name; }
        public void SetPhone(string phone) { this.phone = phone; }
    }
}
