﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task5
{
    public class PhoneContact : IContact
    {
        public string Name { get; set; }
        public string Info { get; set; }

        public PhoneContact() : this("", "") { }

        public PhoneContact(string name, string phone)
        {
            this.Name = name;
            this.Info = phone;
        }

        public object Clone()
        {
            return new PhoneContact(this.Name, this.Info);
        }

        public int CompareTo(IContact other)
        {
            return String.Compare(this.Name, other.Name);
        }

        public void Input(string str)
        {           
            string[] array = str.Split(' ');
            Name = array[0];
            if (!array[1].All(char.IsDigit))
            {
                throw new ArgumentException();
            }
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
