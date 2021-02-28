using System;


namespace BooleanLogic168
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? True/False");
            bool dui = bool.Parse(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            bool bool_ans = false;
            if(age > 15 && dui == false && tickets <= 3)
            {
                bool_ans = true;
            }
            Console.WriteLine("Qualified? \n"+ bool_ans);
            Console.ReadLine();
            

        }
    }
}
