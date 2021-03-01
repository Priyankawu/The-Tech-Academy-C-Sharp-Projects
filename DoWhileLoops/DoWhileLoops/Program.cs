using System;

namespace DoWhileLoops
{
    class Program
    {
        static void Main()
        {
            bool play_time = false;
            int count = 0;
            while (play_time == false)
            {
                Console.WriteLine("He is studying for his remote class");
                count = count + 1;
                Console.WriteLine(count);
                if (count == 5)
                {
                    play_time = true;
                }
            }
            
            // Do While Loop: does the loop once, then checks the condition
            play_time = false;
            do {
                Console.WriteLine("This is a do while loop that will print this once for sure. He is studying for his remote class");
                play_time = true;
            }
            while (!play_time);
            Console.Read();
        }
    }
}
