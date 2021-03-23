using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeMar22
{
    class Program
    {
        static void Main(string[] args)
        {
            Object[] input = { 0, 1, 0, 4, 5, 6 };
           
            Console.Write(" BEFORE: ");
            printArray(input);
            Console.Write(" AFTER: ");
            printArray(findZeros(input));


            Object[] input1 = { false, 1, 0, 1, 2, 0, 1, 3, "a" };
            Console.Write(" BEFORE: ");
            printArray(input1);
            Console.Write(" AFTER: ");
            printArray(findZeros(input1));
            Console.Write("HOORAY! DID IT!");
            Console.Read();
        }
        //        Challenge
        //Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.

        //Example:
        //moveZeros([0,1,0,4,5,6]) => returns[1, 4, 5, 6, 0, 0]
        //moveZeros([false,1,0,1,2,0,1,3,"a"]) => returns[false, 1, 1, 2, 1, 3, "a", 0, 0]

        //(Keep in mind that false == 0, but we only want actual 0s moved to the end)

        //moveZeros([]) => returns[1,4,5,6,0,0]
        //moveZeros([]) => returns[false,1,1,2,1,3,"a",0,0]
        //Object[] can have different types
        public static Object[] findZeros(Object[] diffTypes)
        {
            List<Object> zeros = new List<Object>();
            List<Object> rest = new List<object>();
            Object[] result = new Object[diffTypes.Length];
            Object z = 0;
            foreach(Object findZero in diffTypes)
            {
                
                if (Equals(findZero, z))
                {
                    zeros.Add(findZero);
                    //Console.WriteLine("FoundZero "+ findZero);
                }
                else
                {
                    rest.Add(findZero);
                    //Console.WriteLine("Found: "+ findZero);
                }
            }
            //Console.WriteLine("Length of result: " + result.Length + "\n length of rest " + rest.Count);
            (rest.ToArray()).CopyTo(result, 0);
            (zeros.ToArray()).CopyTo(result, rest.Count);
            return result;
        }

        public static void printArray(Object[] arr)
        {
           
            foreach(Object o in arr)
            {
                Console.Write(o +" ");
            }
            Console.WriteLine("\n");
        }
    }
}
