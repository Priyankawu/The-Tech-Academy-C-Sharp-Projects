using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a comment, highlight, control kc, control ku
            Console.WriteLine("What is your favorite number?");
            string favoriteNumber = Console.ReadLine();
            Console.WriteLine("Your favorite number is: " + favoriteNumber);
            int fnum = Convert.ToInt32(favoriteNumber);
            int total = 5 + fnum;
            Console.WriteLine("Your favorite number is: " + total);
            Console.ReadLine();
        }
    }
}
