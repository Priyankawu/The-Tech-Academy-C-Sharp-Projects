using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    //don't need to change Card. Doesn't need to inherit anything. Therefore, perfect candidate for being a struct not a class.
    public struct Card
    {
        public Suit Suit { get; set; }
        public Face Face { get; set; }
        public override string ToString()   //.net framework has default ToString method
        {
            return string.Format("{0} of {1} ", Face, Suit);
        }
    }
    public enum Suit
    {
        Clubs,
        Diamonds,
        Spades,
        Hearts
    }
    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
