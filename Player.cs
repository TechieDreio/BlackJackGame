using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGame
{
    public class Player
    {
        private int coins;
        private string uname;
        private string pass;

        public Player(int coins, string uname, string pass)
        {
            this.coins = coins;
            this.uname = uname;
            this.pass = pass;
        }

        public int getCoins()
        {
            return this.coins;
        }
        public string getUName()
        {
            return this.uname;
        }

        public string getPass()
        {
            return this.pass;
        }

        public void addCoins(int coins)
        {
            this.coins += coins;
        }

        public void deductCoins(int coins)
        {
            this.coins -= coins;
        }

        public void setCoins(int coins)
        {
            this.coins = coins;
        }
    }
}
