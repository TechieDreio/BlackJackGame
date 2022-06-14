using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BlackJackGame
{
    public class Hand
    {
        private ArrayList hand;
        private int handTotal;

        public Hand()
        {
            hand = new ArrayList();
            handTotal = 0;
        }

        public int getHandTotal()
        {
            int val;
            bool ace;
            int cards;

            val = 0;
            ace = false;
            cards = hand.Count;

            for (int i = 0; i < cards; i++)
            {
                Card card;
                int cardVal;
                card = getCard(i);
                cardVal = card.getValue();

                if (cardVal > 10)
                {
                    cardVal = 10;
                }

                if (cardVal == 1)
                {
                    ace = true;
                }

                val += cardVal;
            }
            if (ace == true && (val + 10) <= 21)
            {
                val = val + 10;
            }
            handTotal = val;

            return handTotal;
        }

        public void clearHand()
        {
            hand.Clear();
        }

        public void addCard(Card card)
        {
            hand.Add(card);
        }

        public void removeCard(Card card)
        {
            hand.Remove(card);
        }

        public int getHandCardCount()
        {
            return hand.Count;
        }

        public Card getCard(int pos)
        {
            return (Card)hand[pos];
        }
    }
}
