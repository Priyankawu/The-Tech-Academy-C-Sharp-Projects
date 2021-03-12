using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment365
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a number.");
            string text = Console.ReadLine();
            //File Class has the below method to write the 'text' to a file located at the given path. 
            File.WriteAllText(@"C:\Users\sanjeev\source\repos\The-Tech-Academy-C-Sharp-Projects\Assignment365\log.txt", text);
            //Read the file and store in string text1
            string text1 = File.ReadAllText("C:\\Users\\sanjeev\\source\\repos\\The-Tech-Academy-C-Sharp-Projects\\Assignment365\\log.txt");
            //Write the file on the console for the user to read
            Console.WriteLine(text1);
            //Wait so I can read at my leisure
            Console.Read();
            
        }
    }
}
