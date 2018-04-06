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
                Task task = new Task();
                task.DoTask();
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.Read();
        }
    }
}
