using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public abstract class Game                       //SuperClass: others inherit this
    {
        //list of players to be never null. Empty is okay.
        private List<Player> _players = new List<Player>();
        public List<Player> Players { get { return _players; } set { _players = value; } }

        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }    //value is the dictionary

        public string Name { get; set; }
        
        public abstract void Play();    //All inherting classes MUST implement this method

        public virtual void ListPlayers()
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }

        

    }
}
