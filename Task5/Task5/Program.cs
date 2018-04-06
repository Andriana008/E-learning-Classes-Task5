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
                Task.DoTask();
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
