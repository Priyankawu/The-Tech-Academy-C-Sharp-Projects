using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp223
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number you want to do the math operations on?");
            int number = Convert.ToInt32(Console.ReadLine());

            Class1 obj = new Class1();
            int ans_1 = obj.method_multiply5(number);
            int ans_2 = obj.method_add5(number);
            int ans_3 = obj.method_mod5(number);

            Console.WriteLine("Your answers are " + ans_1 + " " + ans_2 + " " + ans_3);
            Console.ReadLine();


        }
    }
}
