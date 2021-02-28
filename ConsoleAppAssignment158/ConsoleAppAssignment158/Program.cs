using System;


namespace ConsoleAppAssignment158
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number to multiply by 50.");
            double number =  Convert.ToDouble(Console.ReadLine());
            double ans = number * 50;
            Console.WriteLine(number + " multiplied by 50 is: " + ans);
            

            Console.WriteLine("Please enter an number to add 25 to.");
            number = Convert.ToDouble(Console.ReadLine());
            ans = number + 25;
            Console.WriteLine(" 25 added to " + number +" : " + ans);

            Console.WriteLine("Please enter a number to divide by 12.5.");
            number = Convert.ToDouble(Console.ReadLine());
            ans = number / 12.5;
            Console.WriteLine(number + " divided by 12.5 is: " + ans);

            Console.WriteLine("Please enter a number so I can check if it's greater than 50.");
            number = Convert.ToDouble(Console.ReadLine());
            bool bool_ans = false;
            if(number > 50)
            {
                bool_ans = true;
            }
            Console.WriteLine(bool_ans);

            Console.WriteLine("Please enter a number to find remainder after dividing by 7.");
            number = Convert.ToDouble(Console.ReadLine());
            ans = number % 7;
            Console.WriteLine("Remainder after dividing "+number + " 7 is: " + ans);

            Console.Read();
        }
    }
}
