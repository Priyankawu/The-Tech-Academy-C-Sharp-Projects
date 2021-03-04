using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment228
{
    class Program
    {
        static void Main(string[] args)
        {

            Class1 obj = new Class1();
            obj.doMath(56, 43);

            int a = 97;
            int b = 99;
            obj.doMath(a, b);
            Console.Read();
        }
    }
}
