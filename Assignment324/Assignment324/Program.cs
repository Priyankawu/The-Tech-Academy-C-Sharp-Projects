using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment324
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the current day of the week");
                string sday = Console.ReadLine();
                //changing the user input string to enum type
                DaysOfTheWeek myVar = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), sday);
                Console.WriteLine("The user typed: "+myVar);
            }
            //throw error if enum's string not entered.
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            
            Console.ReadLine();
            
        }
    }
    
    //enum enumerates the new data type
    public enum DaysOfTheWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}
