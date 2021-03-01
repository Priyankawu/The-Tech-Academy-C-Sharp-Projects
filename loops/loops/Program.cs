using System;


namespace loops
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Guess a number?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 12;

            do
            {
                switch (number)
                {
                    case 62:
                        Console.WriteLine("you guessed 62. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("You guessed 29. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 32:
                        Console.WriteLine("You guessed it right!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        isGuessed = true;
                        break;
                }

            }
            while (!isGuessed);

            Console.Read();
        }

    }
}
