using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment369
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("The time now is " + now.ToString());
            Console.WriteLine("Please enter a number that I will use to add hours to the current time.");

            int addHours = Convert.ToInt32(Console.ReadLine());
            int hour = now.Hour+addHours;
            int minutes = now.Minute;
            int seconds = now.Second;

            Console.WriteLine("The time after adding your hours is:\n Hours: " + hour + "\n Minutes: " + minutes + "\n Seconds: " + seconds);
            Console.WriteLine(hour + ":" + minutes + ":" + seconds);

            //DateTime modified = new DateTime(2021, 3, 13, hour, minutes, seconds);   //?? how do I print the time from this easily
            Console.Read();
            

        }
    }
}
