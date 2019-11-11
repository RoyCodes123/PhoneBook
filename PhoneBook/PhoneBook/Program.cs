using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneBook p1 = new PhoneBook();
            p1.AddContacts("Roy", "053-721-6094");
            p1.AddContacts("Guy", "696-696-6969");
            p1.AddContacts("Koma", "420-420-4200");
            Console.WriteLine(p1);
            p1.AddContacts("AdirKoma", "123-456-7888");
            Console.WriteLine(p1);
            p1.DelContact("Guy");
            Console.WriteLine(p1);
        }
    }
}
