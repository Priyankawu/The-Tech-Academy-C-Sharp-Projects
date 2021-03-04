using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment226
{
    class Program
    {
        static void Main(string[] args)
        {

            Class1 obj = new Class1();
            int ans = obj.doMath(10);
            Console.WriteLine("Answer is " + ans);
            
            Class1 obj1 = new Class1();
            decimal arg = 9.2m;         //m is to denote decimal number: used for banking purposes
            int ans1 = obj1.doMath(arg);
            Console.WriteLine("Answer of decimal overloaded method is "+ans1);

            Class1 obj2 = new Class1();
            int ans2 = obj2.doMath("391");
            Console.WriteLine("Answer of string overloaded method is " + ans2);

            Console.ReadLine();
        }
    }
}
