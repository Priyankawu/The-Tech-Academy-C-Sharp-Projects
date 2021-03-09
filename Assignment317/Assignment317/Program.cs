using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment317
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating a Employee objects that have an instantiated list called things.
            Employee<string> one = new Employee<string>();
            one.things.Add("Priyanka");
            one.things.Add("Sanjeev");
            one.things.Add("Hirsh");
            one.things.Add("Aaria");
            one.things.Add("Eshvin");
            Employee<int> two = new Employee<int>();
            two.things.Add(100);
            two.things.Add(99);
            two.things.Add(78);
            two.things.Add(45);
            two.things.Add(999);
            two.things.Add(42);
            //print the 'things' list of the Employee objects
            one.printAll();
            two.printAll();
            Console.Read();
        }
    }
}
