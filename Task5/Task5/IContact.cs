using System;
using System.Collections.Generic;
using System.Text;

namespace Task5
{
    interface IContact : ICloneable, IComparable<IContact>
    {
        string Name { get; set; }
        string Info { get; set; }
        void Input();
        void Output();
    }
}
