using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Deck
    {
        //Total Cards: 52, 13 each 
        public Deck()
        {
            //Notice no type to this property
            Cards = new List<Card>();
            for(int i=0; i<13; i++)
            {
                for (int j = 0; j<4; j++)
                {
                    Card card = new Card();
                    card.Suit = (Suit)j;
                    card.Face = (Face)i;
                    Cards.Add(card);
                }
            }
         
        }
        
        public List<Card> Cards { get; set; }

        public void Shuffle(int times = 1)          //Named Parameter
        { //optional parameters: assign parameter default value

                                          
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);          //what if it is putting it in an index that's already full?? 
                    Cards.RemoveAt(randomIndex);
                }
                Cards = TempList;
            }

          
        }
        
    }

    
}
