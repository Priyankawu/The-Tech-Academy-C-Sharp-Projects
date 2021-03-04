using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment231
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();
            Console.WriteLine("Please enter a number.");
            int user_n = Convert.ToInt32(Console.ReadLine());

            obj.method1(user_n, out int anotherName );
            Console.WriteLine("The answer : " + anotherName);

            Console.WriteLine("Adding integers " + obj.add(3, 98));
            Console.WriteLine("Adding strings " + obj.add("Hello ", " methodOverloading"));
            Console.ReadLine();

        }
    }
}
