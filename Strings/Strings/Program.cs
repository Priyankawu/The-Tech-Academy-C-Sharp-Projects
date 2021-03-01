using System;
using System.Text;


namespace Strings
{
    class Program
    {
        static void Main()
        {
            string firstName = "Priyanka";
            string lastName = "Thakan";
            string course = "Software Development";
            string total = firstName+" "+lastName+" "+course;
            Console.WriteLine(total);
            string upper_total = total.ToUpper();
            Console.WriteLine(upper_total);
            
            StringBuilder sb = new StringBuilder(); //can expand/collapse unlike immutable strings that can be expensive
            sb.Append("My name is Priyanka");
            sb.Append("I am taking a tech-academy course.");
            sb.Append("C Sharp is fun so far.");
            sb.Append("This is a short paragraph. Bye-Bye!");

            Console.WriteLine(sb);
            Console.Read();
        }
    }
}
