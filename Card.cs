using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGame
{
    public class Card
    {

        private string suit;
        private int value;

        public Card(int cardVal, string cardSuit)
        {
            value = cardVal;
            suit = cardSuit;
        }

        public string getSuit()
        {
            return this.suit;
        }

        public void setSuit(string cardSuit)
        {
            this.suit = cardSuit;
        }

        public int getValue()
        {
            return this.value;
        }

        public void setValue(int cardValue)
        {
            this.value = cardValue;
        }

    }
}
