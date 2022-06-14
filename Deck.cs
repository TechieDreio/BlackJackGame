using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BlackJackGame
{
    public class Deck
    {
        private ArrayList deck;
        private int cardUsed;

        public Deck()
        {
            deck = new ArrayList();

            for(int i=0; i<=3; i++)
            {
                for(int j=1; j<=13; j++)
                {
                    string suit;

                    if (i == 0)
                        suit = "S";
                    else if (i == 1)
                        suit = "H";
                    else if (i == 2)
                        suit = "C";
                    else
                        suit = "D";

                    Card newCard = new Card(j,suit);
                    deck.Add(newCard);
                }
            }
            cardUsed = 0;
        }

        public void shuffle()
        {
            for (int i=0; i<deck.Count-1; i++)
            {
                Random rng = new Random(DateTime.Now.Millisecond / DateTime.Now.Second);
                int pos = rng.Next(0, 51);
                Card temp = (Card)deck[i];
                deck[i] = deck[pos];
                deck[pos] = temp;
            }
            cardUsed = 0;
        }

        public Card dealCard()
        {
            cardUsed++;
            return (Card)deck[cardUsed - 1];
        }

        public int cardsLeft()
        {
            return deck.Count - cardUsed;
        }
    }
}
