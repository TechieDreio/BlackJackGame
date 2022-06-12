using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGame
{
    class Deck
    {
        private Card[] deck;
        private int cardsUsed;

        public Deck()
        {
            //this(false);
        }

        public Deck(bool includeJokers)
        {
            int cardCt = (includeJokers) ? 54 : 52;
            deck = new Card[cardCt];
            cardCt = 0;
            for (int suit = 0; suit <= 3; suit++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    deck[cardCt] = new Card(value, suit);
                    cardCt++;
                }
            }
            if (includeJokers)
            {
                deck[52] = new Card(1, Card.JOKER);
                deck[52] = new Card(2, Card.JOKER);
            }
            cardsUsed = 0;
        }

        public void shuffle()
        {
            for (int i = deck.Length - 1; i > 0; i--)
            {
                Random rdm = new Random(Guid.NewGuid().GetHashCode());
                int rand = (int)(rdm.Next() * (i + 1));
                Card temp = deck[i];
                deck[i] = deck[rand];
                deck[rand] = temp;
            }
            cardsUsed = 0;
        }
        public int cardsLeft()
        {
            return deck.Length - cardsUsed;
        }

        public Card dealCard()
        {
            if (cardsUsed == deck.Length)
                throw new Exception("No cards are left in the deck.");
            cardsUsed++;
            return deck[cardsUsed - 1];
        }

        public bool hasJokers()
        {
            return (deck.Length == 54);
        }
    }
}
