using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGame
{
    class BlackJackHand : Hand
    {
        public int getBlackjackValue()
        {
            int val;
            bool ace;
            int cards;

            val = 0;
            ace = false;
            cards = getCardCount();

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
            return val;
        }
    }
}
