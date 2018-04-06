using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{    
    class Program
    {
        static List<IContact> CloneList(List<IContact> contacts)
        {
            List<IContact> cloned = new List<IContact>(contacts.Count);
            for (int i = 0; i < contacts.Count(); i++)
            {
                cloned.Add((IContact)contacts[i].Clone());
            }
            return cloned;
        }
        static void Main(string[] args)
        {
            try
            {
                List<IContact> contacts = new List<IContact>();
                contacts.Add(new PhoneContact("olya", "043298"));
                contacts.Add(new MailContact("bodya", "ervsc@hgfjd"));
                contacts.Add(new PhoneContact("oleg", "04e298vds"));
                contacts.Add(new MailContact("ira", "tbrervd@vc"));
                contacts.Add(new PhoneContact("zenoviy", "4433238"));
                PhoneContact p = new PhoneContact();
                p.Input();
                MailContact m = new MailContact();
                m.Input();
                contacts.Add(p);
                contacts.Add(m);
                for (int i = 0; i < contacts.Count(); i++)
                {
                    contacts[i].Output();
                }

                Console.WriteLine("Sort by name: ");
                List<IContact> sortedContacts = CloneList(contacts);
                sortedContacts.Sort();
                for (int i = 0; i < sortedContacts.Count(); i++)
                {
                    sortedContacts[i].Output();
                }

                Console.WriteLine("Get phone number by name");
                Console.WriteLine("Enter name: ");
                string vname = Console.ReadLine();
                if (!contacts.Exists(x => x.Name.Contains(vname)))
                {
                    Console.WriteLine("Name doesn't exist in this score");
                }
                else
                {
                    Console.WriteLine("Number is {0}", contacts.Find(x => x.Name.Contains(vname)).Info);
                }
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
