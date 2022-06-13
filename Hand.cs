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

        public Hand()
        {
            hand = new ArrayList();
        }

        public void clear()
        {
            hand.Clear();
        }

        public void addCard(Card c)
        {
            if (c == null)
                throw new Exception("Can't add a null card to hand.");
            hand.Add(c);
        }

        public void removeCard(Card c)
        {
            hand.Remove(c);
        }

        public void removeCard(int position)
        {
            if (position < 0 || position >= hand.Count)
                throw new ArgumentException("Position does not exist in hand: " + position);
            hand.Remove(position);
        }

        public int getCardCount()
        {
            return hand.Count;
        }

        public Card getCard(int position)
        {
            if (position < 0 || position >= hand.Count)
                throw new ArgumentException("Position does not exits in hand: " + position);
            return (Card)hand[position];
        }


        public void sortBySuit()
        {
            ArrayList newHand = new ArrayList();
            while (hand.Count > 0)
            {
                int pos = 0;
                Card c = (Card)hand[0];
                for (int i = 1; i < hand.Count; i++)
                {
                    Card c1 = (Card)hand[i];
                    if (c1.getSuit() < c.getSuit() ||
                            (c1.getSuit() == c.getSuit() && c1.getValue() < c.getValue()))
                    {
                        pos = i;
                        c = c1;
                    }
                }
                hand.Remove(pos);
                newHand.Add(c);
            }
        }

        public void sortByValue()
        {
            ArrayList newHand = new ArrayList();
            while (hand.Count > 0)
            {
                int pos = 0;
                Card c = (Card)hand[0];
                for (int i = 1; i < hand.Count; i++)
                {
                    Card c1 = (Card)hand[i];
                    if (c1.getValue() < c.getValue() ||
                            (c1.getValue() == c.getValue() && c1.getSuit() < c.getSuit()))
                    {
                        pos = i;
                        c = c1;
                    }
                }
                hand.Remove(pos);
                newHand.Add(c);
            }
            hand = newHand;
        }
    }
}
