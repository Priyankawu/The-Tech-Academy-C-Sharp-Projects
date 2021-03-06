using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment302
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee emp = new Employee();
            emp.firstName = "Sample";
            emp.lastName = "Student";
            emp.SayName();
            Console.ReadLine();
        }
    }
}
