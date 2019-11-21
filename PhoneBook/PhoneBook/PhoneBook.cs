using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class PhoneBook
    {
        private Contact[] contacts;

        public PhoneBook() { contacts = new Contact[0]; }

        public void AddContacts(string name, string phone)
        {
            bool flag = false;
            int place;

            for (int i = 0; i < this.contacts.Length; i++)
            {
                if (this.contacts[i].GetName() == name)
                {
                    flag = true;
                    place = i;
                }
            }

            if (flag)
            {
                this.contacts[i].setName(name);
            }

            else
            {
                Contact[] newContacts = new Contact[this.contacts.Length + 1];
                Contact c1 = new Contact(name, phone);
                newContacts[newContacts.Length - 1] = c1;
                for (int i = 0; i < this.contacts.Length; i++)
                {
                    newContacts[i] = this.contacts[i];
                }
                this.contacts = newContacts;
            }
        }

        public void DelContact(string name)
        {
            int count = 0; bool flag = true;

            while (count < this.contacts.Length && flag == true)
            {
                count++;
                if (this.contacts[count].GetName() == name && count == this.contacts.Length - 1)
                {
                    Contact[] newContacts = new Contact[this.contacts.Length - 1];
                    for (int i = 0; i < newContacts.Length; i++)
                    {
                        newContacts[i] = this.contacts[i];
                    }
                    this.contacts = newContacts; 
                }

                if (this.contacts[count].GetName() == name && count != this.contacts.Length - 1)
                {
                    flag = false;
                    Contact[] newContacts = new Contact[this.contacts.Length - 1];
                    for (int i = 0; i < count; i++)
                    {
                        newContacts[i] = this.contacts[i];
                    }

                    for (int i = count; i < newContacts.Length; i++)
                    {
                        newContacts[i] = this.contacts[i + 1];
                    }
                    this.contacts = newContacts;
                }
            }
        }

        public string GetPhone(string name)
        {
            bool flag = true;
            int count = 0;

            while (count < this.contacts.Length && flag == true)
            {
                if (this.contacts[count].GetName() == name) {
                    flag = false;
                    return this.contacts[count].GetPhone();
                }
            }

            return null;
        }

        public string[] GetAllContactsNames()
        {
            if (this.contacts.Length == 0)
            {
                string[] empty = new string[0];
                return empty;
            }
            else
            {
                string[] names = new string[this.contacts.Length - 1];

                for (int i = 0; i < names.Length; i++)
                {
                    names[i] = this.contacts[i].GetName();
                }

                return names;
            }
        }

        public override string ToString()
        {
            Contact holder; bool flag = true;
            while (flag == true)
            {
                flag = false; 
                for (int i = 0; i < this.contacts.Length - 1; i++)
                {
                    if (this.contacts[i].GetName().CompareTo(this.contacts[i + 1].GetName()) > 0)
                    {
                        flag = true;
                        holder = this.contacts[i];
                        this.contacts[i] = this.contacts[i + 1];
                        this.contacts[i + 1] = holder;

                    }
                }
            }

            string str = "";

            for (int i = 0; i < this.contacts.Length; i++)
            {
                str += this.contacts[i].GetName() + "  " + this.contacts[i].GetPhone() + "\n";
            }

            return str;
        }
    }
}
