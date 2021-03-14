using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment388
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = 0;
            bool validAnswer = false;
            try
            {
                while (!validAnswer)
                {
                    validAnswer = int.TryParse(Console.ReadLine(), out age);
                    // if user does not enter numbers for age
                    if (!validAnswer)
                    {
                        Console.WriteLine("Please write the correct numbers.");
                    }
                    // if user enters 0 or negative numbers
                    if(age <= 0)
                    {
                        Console.WriteLine("Please enter your correct age greater than 0");
                        validAnswer = false;
                    }
                }
            }
            //any other kinds of errors are caught here
            catch (Exception)
            {
                Console.WriteLine("There is something wrong. ");
                Console.ReadLine();
                return;
            }
            DateTime dateTime = new DateTime(2021, 3, 13);

            int year = dateTime.Year - age;
            Console.WriteLine("So, you were born in : "+ year);
            Console.ReadLine();
        }
    }
}
