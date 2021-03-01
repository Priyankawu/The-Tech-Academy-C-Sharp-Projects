using System;


namespace Branching
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instrucitons below.");
            Console.WriteLine("Please enter the package weight.");
            float weight = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the package width.");
            float width = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the package height.");
            float height = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the package length.");
            float length = float.Parse(Console.ReadLine());

            float total = width + height + length;
            if (total > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            else
            {
                float quote = (width * height * length * weight)/100;
                Console.WriteLine("Your estimated total for shipping this package is: " + quote);
                Console.ReadLine();

            }

        }
    }
}
