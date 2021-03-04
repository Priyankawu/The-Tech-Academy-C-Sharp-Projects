using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment227
{
    class Program
    {
        static void Main(string[] args)
        {

            Class1 obj = new Class1();
            Console.WriteLine("Please enter a number.");

            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a second number. You may skip to enter the second number \n" +
                " as it is an optional parameter. We got you covered!");
            int ans;
            int b;
            string s = Console.ReadLine();

            //TryParse method: try to convert string to int -- false if unsuccessful, true will also put number value in b
            bool isNumber = int.TryParse(s, out b);
            if (isNumber)
            {
                ans = obj.doMath(a, b);
            }
            else
            {
                ans = obj.doMath(a);
            }
          

            Console.WriteLine("My experiment with TryParse and out has given the following ans :\n" + ans);
            Console.ReadLine();        
            
        }
    }
}
