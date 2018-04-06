using System;
using System.Collections.Generic;
using System.Text;

namespace Task5
{
    class Task
    {
        static List<IContact> contacts = new List<IContact>();

        public static List<IContact> CloneList()
        {
            List<IContact> cloned = new List<IContact>(contacts.Count);
            for (int i = 0; i < contacts.Count; i++)
            {
                cloned.Add((IContact)contacts[i].Clone());
            }
            return cloned;
        }

        public static void InputList()
        {
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
        }
        
        public static void DoTask()
        {
            InputList();           
            
            Console.WriteLine("Sort contacts by name: ");
            List<IContact> sortedContacts = CloneList();
            sortedContacts.Sort();
            for (int i = 0; i < sortedContacts.Count; i++)
            {
                sortedContacts[i].Output();
            }

            Console.WriteLine("Get info by name");
            Console.Write("Enter name: ");
            string vname = Console.ReadLine();
            if (!contacts.Exists(x => x.Name.Contains(vname)))
            {
                Console.WriteLine("Name doesn't exist in this score");
            }
            else
            {
                Console.WriteLine("Info: {0}", contacts.Find(x => x.Name.Contains(vname)).Info);
            }
        }

    }
}
