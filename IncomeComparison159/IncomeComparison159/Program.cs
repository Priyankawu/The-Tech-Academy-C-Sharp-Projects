using System;


namespace IncomeComparison159
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program \nPerson 1");
            Console.WriteLine("Hourly Rate?");
            float rate = float.Parse(Console.ReadLine());
            Console.WriteLine("Hours Worked per week?");
            float hours = float.Parse(Console.ReadLine());

            Console.WriteLine("Person 2 \nHourly Rate?");
            float rate1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Hours Worked per week?");
            float hours1 = float.Parse(Console.ReadLine());

            float salary = rate * hours;
            float salary1 = rate1 * hours1;
            Console.WriteLine("Annual salary of Person 1: " + salary);
            Console.WriteLine("Annual salary of Person 2: " + salary1);
            bool bool_ans = false;
            if(salary > salary1)
            {
                bool_ans = true;
            }
            Console.WriteLine("Does Person 1 make more money than Person 2? \n" + bool_ans);
            Console.Read();
        }
    }
}
