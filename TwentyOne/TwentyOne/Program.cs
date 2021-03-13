using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.TwentyOne;

//Casino is a library file. TwentyOne is a Console Application
namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //value type : non-nullable struct, 12 constructors to datetime
            DateTime datetime = new DateTime(1995, 5, 23,8, 32, 45 );
            
            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello {0}, Would you like to join a game of TwentyOne right now? ", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;        //caution against while loops as they can run infinitely by your mistake
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                    Console.WriteLine("Thank you for playing!");
                }
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.Read();

        
        }
    }
}
