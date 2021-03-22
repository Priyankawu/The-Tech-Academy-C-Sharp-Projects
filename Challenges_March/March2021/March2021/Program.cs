using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace March2021
{
    class Program
    {
        public static void Main(string[] args)
        {

            //            Challenge 1
            //In one line of code, write a function that takes in a collection of numbers as strings, 
            // and returns a collection of the same numbers as integers.

            //Example: 
            //toNumArray(['1', '2', '3', '4']) => [1,2,3,4]

            Challenges ch = new Challenges();
            List<string> sList = new List<string>(){ "1", "2", "3", "4" };
            ch.toNumArray(sList);
            Console.Read();

        }
    }
}
