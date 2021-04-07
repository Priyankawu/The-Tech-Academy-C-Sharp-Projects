using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace February25
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(parseTime(86399));
           // Console.WriteLine(parseTime(360000));

            FizzBuzz();

            Console.Read();
        }

        static string parseTime(int allSeconds)
        {
            
            string str_hours = "00";
            string str_minutes = "00";
            string str_seconds = "00";
           
            if (allSeconds >= 3600) //less than 3600 seconds means 0 hours
            {
                int hours = allSeconds / 3600;

                if (hours > 1)
                {
                    str_hours = hours.ToString();
                }
                allSeconds = allSeconds % 3600;
            }

            if (allSeconds >= 60)
            {
                int minutes = allSeconds / 60;
                if (minutes > 1)
                {
                    str_minutes = minutes.ToString();
                }
                allSeconds = allSeconds % 60;
            }
            if (allSeconds > 1)
            {
                str_seconds = allSeconds.ToString();
            }

            string strTime = str_hours + ":" + str_minutes + ":" + str_seconds;

            return strTime;
        }

        // Challenge 2  (aka the fizzbuzz test)

        //Write a program that prints the numbers from 1 to 100. But for multiples of 
        // three print “Fizz” instead of the number and for the multiples of five print “Buzz”.
        // For numbers that are multiples of both three and five print “FizzBuzz”.

        public static void FizzBuzz()
        {
            for(int i = 1; i<101; i++)
            {
                if ((i % 15) == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if ((i % 5) == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
