using System;
using System.Collections.Generic;
using System.Text;

namespace Task5
{
    public class Task
    {
        public List<IContact> CloneList(List<IContact> list)
        {
            List<IContact> cloned = new List<IContact>();
            for (int i = 0; i < list.Count; i++)
            {
                cloned.Add((IContact)list[i].Clone());
            }
            return cloned;
        }
        
        public IContact Parse(string str)
        {
            string[] array = str.Split(' ', 2);
            IContact contact;
            if (Convert.ToInt32(array[0]) == 1)
            {
                contact = new MailContact();
            }
            else if(Convert.ToInt32(array[0]) == 2)
            {
                contact = new PhoneContact();
            }
            else
            {
                throw new Exception("invalid data");
            }
            contact.Input(array[1]);

            return contact;
        }

        private List<IContact> GetBaseContacts()
        {
            List<IContact> baseContacts = new List<IContact>();

            baseContacts.Add(new PhoneContact("olya", "043298"));
            baseContacts.Add(new MailContact("bodya", "ervsc@hgfjd"));
            baseContacts.Add(new PhoneContact("oleg", "04e298vds"));
            baseContacts.Add(new MailContact("ira", "tbrervd@vc"));
            baseContacts.Add(new PhoneContact("zenoviy", "4433238"));
        
            return baseContacts;
        }

        public List<IContact> InputList()
        {
            List<IContact> contacts = new List<IContact>();
            List<IContact> baseContacts = GetBaseContacts();
            contacts.AddRange(baseContacts);
            Console.WriteLine("Enter size of contacts:");
            string str = Console.ReadLine();
            int count = Convert.ToInt32(str);
            ShowHead();
            for (int i = 0; i < count; i++)
            {
                string line = Console.ReadLine();
                IContact contact = Parse(line);
                contacts.Add(contact);
            }

            return contacts;
        }
        public void ShowHead()
        {
            Console.WriteLine("Enter contacts(for example, mail contact(1 ira ira@gmail.com) or phone contact(2 ira 0965612345)):");
        }

        public void DoTask()
        {
            List<IContact> contacts = InputList();

            Console.WriteLine("Sort contacts by name: ");
            List<IContact> sortedContacts = CloneList(contacts);

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
