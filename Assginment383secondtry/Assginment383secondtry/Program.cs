using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment383secondtry
{
    class Program
    {
        static void Main(string[] args)
        {
            const string myConstant = "This is a constant string. You cannot change it in the rest of the code, except here.";
            Console.WriteLine("This is my constant string "+myConstant);

            var myDateTime = new DateTime();
            Console.WriteLine(myDateTime);
            var emp = new Employee("Bob", "Matt", 45, 3000);
            Console.WriteLine(emp.ToString());
            Console.ReadLine();
         }
    }
}
