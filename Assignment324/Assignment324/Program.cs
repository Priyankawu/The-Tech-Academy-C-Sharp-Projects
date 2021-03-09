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
                
                DaysOfTheWeek myVar = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), sday);
                Console.WriteLine("The user typed: "+myVar);
            }
           
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            
            Console.ReadLine();
            
        }
    }

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
