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
            Console.WriteLine(parseTime(86399));
            Console.WriteLine(parseTime(30));

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

            strTime = str_hours + ":" + str_minutes + ":" + str_seconds;

            return strTime;
        }
    }
}
