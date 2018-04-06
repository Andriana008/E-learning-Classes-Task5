using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task5
{
    class MailContact : IContact
    {
        string name;
        string mail;

        public string Name { get => name; set => name = value; }
        public string Info { get => mail; set => mail = value; }

        public MailContact(string _name, string _mail)
        {
            Name = _name;
            Info = _mail;
        }

        public MailContact() : this("", "") { }


        public object Clone()
        {
            MailContact t = new MailContact(this.Name, this.Info);
            return t;
        }

        public int CompareTo(IContact other)
        {
            return String.Compare(this.Name, other.Name);
        }

        public void Input()
        {
            Console.Write("Enter Mail contact. Enter name:");
            Name = Console.ReadLine();
            Console.Write("Enter mail:");
            string input = Console.ReadLine();
            if (input.Contains('@'))
            {
                Info = input;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public void Output()
        {
            Console.WriteLine($"{Name} - {Info}");
        }
    }
}
