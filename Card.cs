using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGame
{
    public class Card
    {
        public const int SPADES = 3;
        public const int HEARTS = 2;
        public const int DIAMONDS = 1;
        public const int CLUBS = 0;
        public const int JOKER = 4;
        public const int ACE = 1;
        public const int JACK = 11;
        public const int QUEEN = 12;
        public const int KING = 13;
        private int suit;
        private int value;

        public Card()
        {
            this.suit = JOKER;
            this.value = 1;
        }

        public Card(int theValue, int theSuit)
        {
            if (theSuit != SPADES && theSuit != HEARTS && theSuit != DIAMONDS && theSuit != CLUBS && theSuit != JOKER)
            {
                throw new ArgumentException("Illegal playing card suit");
            }

            if (theSuit != JOKER && (theValue < 1 || theValue > 13))
            {
                throw new ArgumentException("Illegal playing card value");
            }

            this.value = theValue;
            this.suit = theSuit;
        }

        public int getSuit()
        {
            return this.suit;
        }

        public int getValue()
        {
            return this.value;
        }

        public String getSuitAsString()
        {
            switch (this.suit)
            {
                case SPADES:
                    return "Spades";
                case HEARTS:
                    return "Hearts";
                case DIAMONDS:
                    return "Diamonds";
                case CLUBS:
                    return "Clubs";
                default:
                    return "Joker";
            }
        }

        public String getValueAsString()
        {
            if (this.suit == JOKER)
            {
                return "" + this.value.ToString();
            }
            else
            {
                switch (this.value)
                {
                    case 1:
                        return "Ace";
                    case 2:
                        return "2";
                    case 3:
                        return "3";
                    case 4:
                        return "4";
                    case 5:
                        return "5";
                    case 6:
                        return "6";
                    case 7:
                        return "7";
                    case 8:
                        return "8";
                    case 9:
                        return "9";
                    case 10:
                        return "10";
                    case 11:
                        return "Jack";
                    case 12:
                        return "Queen";
                    default:
                        return "King";
                }
            }
        }

        public String toString()
        {
            if (this.suit == JOKER)
            {
                if (this.value == 1)
                {
                    return "Joker";
                }
                else
                {
                    return "Joker #" + this.value.ToString();
                }
            }
            else
            {
                return this.getValueAsString() + " of " + this.getSuitAsString();
            }
        }
    }
}
