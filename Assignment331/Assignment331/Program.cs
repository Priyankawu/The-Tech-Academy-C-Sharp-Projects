using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment331
{
    class Program
    {
        static void Main(string[] args)
        {
            Number n;
            n.Amount = 23.98m;  //Decimal values have m in the end
            Console.WriteLine("Struct Number n has Amount: " + n.Amount);
            Console.ReadLine();
        }
    }
}
