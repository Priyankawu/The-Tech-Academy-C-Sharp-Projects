using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment292
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.FirstName = "Sample";           //accessing superclass properties.
            emp.LastName = "Student";
            emp.SayName();                      //accessing superclass method.
            Console.ReadLine();
        }
    }
}
