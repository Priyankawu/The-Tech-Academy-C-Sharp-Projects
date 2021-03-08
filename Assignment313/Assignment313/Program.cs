using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment313
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee a = new Employee();
            a.Id = 100;
            
            Employee b = new Employee();
            b.Id = 200;

            bool ans = a == b;
            Console.WriteLine("Boolean answer is " + ans);
            Console.Read();
          
        }
    }
}
