using System;

namespace Scores
{
    class Program
    {
        //In .NET Core, you can just create a file studentScores.txt and put it in your folder -- it will show up in your Solution Explorer unlike in .NET Framework ?
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name");
            string date = DateTime.Today.ToShortDateString();
            string uName = Console.ReadLine();
            string msg = $"\nWelcome back {uName}. Today is {date}.";
            Console.WriteLine(msg);
            string path = @"C:\Users\sanjeev\source\repos\The-Tech-Academy-C-Sharp-Projects\Scores\Scores\studentScores.txt";
            string[] lines = System.IO.File.ReadAllLines(path);     //reading from the file on that path and storing as string array

            double tScore = 0.0;

            Console.WriteLine("\nStudent Score: \n");
            foreach (string line in lines)
            {
                Console.Write("\n" + line);
                double score = Convert.ToDouble(line);      //converting string to double
                tScore += score;
            }
            double avgScore = tScore / lines.Length;
            Console.WriteLine("\nTotal of "+ lines.Length+ "student scores. \tAverage score: "+avgScore);
            Console.WriteLine("\n\nPress any key to exit.");
            Console.ReadKey();


        }
    }
}
