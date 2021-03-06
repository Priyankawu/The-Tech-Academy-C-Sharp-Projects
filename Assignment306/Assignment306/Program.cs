using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment306
{
    class Program
    {
        static void Main(string[] args)
        {
            //Polymorphism at display here
            IQuittable poly = new Employee();
            poly.Quit();
            Console.Read();
        }
    }
}
