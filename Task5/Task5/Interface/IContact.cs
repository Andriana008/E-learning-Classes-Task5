using System;
using System.Collections.Generic;
using System.Text;

namespace Task5
{
    public interface IContact : ICloneable, IComparable<IContact>
    {
        string Name { get; set; }
        string Info { get; set; }
        void Input(string str);
        void Output();
    }
}
