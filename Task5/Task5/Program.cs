using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{    
    class Program
    {
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

                for (int i = 0; i < contacts.Count(); i++)
                {
                    contacts[i].Output();
                }
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
