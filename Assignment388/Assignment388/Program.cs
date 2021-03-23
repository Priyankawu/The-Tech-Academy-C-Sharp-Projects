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
            try
            {
                Console.WriteLine("What is your age?");
                int age = Convert.ToInt32(Console.ReadLine());

                // if user enters 0 or negative numbers
                if(age <= 0)
                {
                    throw new Exception();
                }
                DateTime dateTime = DateTime.Now;
                int year = dateTime.Year - age;
                Console.WriteLine("So, you were born in : " + year);
                Console.ReadLine();
            }
            //any other kinds of errors are caught here
            catch (Exception)
            {
                Console.WriteLine("ERROR: Invalid Input. Please input only a number. The number must be greater than 0.");
                Console.ReadLine();
            }
            
        }
    }
}
