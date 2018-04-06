using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task5
{
    class PhoneContact : IContact
    {
        string name;
        string phone;

        public string Name { get => name; set => name = value; }
        public string Info { get => phone; set => phone = value; }

        public PhoneContact(string _name, string _phone)
        {
            Name = _name;
            Info = _phone;
        }

        public PhoneContact() : this("", "") { }


        public object Clone()
        {
            PhoneContact t = new PhoneContact(this.Name, this.Info);
            return t;
        }

        public int CompareTo(IContact other)
        {
            return String.Compare(this.Name, other.Name);
        }

        public void Input()
        {           
            Console.Write("Enter Phone contact. Enter name:");
            Name = Console.ReadLine();
            Console.Write("Enter phone:");            
            string input = Console.ReadLine();
            if(input.All(char.IsDigit))
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
