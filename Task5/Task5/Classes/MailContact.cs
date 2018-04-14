using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task5
{
    public class MailContact : IContact
    {
        public string Name { get; set; }
        public string Info { get; set; }

        public MailContact() : this("", "") { }

        public MailContact(string name, string mail)
        {
            this.Name = name;
            this.Info = mail;
        }

        public object Clone()
        {
            return new MailContact(this.Name, this.Info);
        }

        public int CompareTo(IContact other)
        {
            return String.Compare(this.Name, other.Name);
        }

        public void Input(string str)
        {
            if (!str.Contains('@'))
            {
                throw new ArgumentException();
            }
            string[] array = str.Split(' ');
            Name = array[0];
            Info = array[1];
        }
        
        public void Output()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"{Name} - {Info}";
        }
    }
}
