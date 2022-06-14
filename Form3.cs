using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace BlackJackGame
{
    public partial class Form3 : Form
    {

        Deck deck;
        BlackJackHand playerHand;
        BlackJackHand dealerHand;

        public Form3()
        {
            InitializeComponent();
            newGame();
        }

        private void newGame()
        {
            var systemPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var complete = Path.Combine(systemPath, "BlackJack\\Players");
            string currentPlayerPath = complete + "\\Current_Player.txt";
            string playerName;
            string playerCoins;

            string[] readText = File.ReadAllLines(@"" + currentPlayerPath);
            playerCoins = readText[0].Split(' ')[1];
            playerName = readText[1].Split(' ')[1];

            coinsLabel.Text = playerCoins;
            playerLabel.Text = playerName;



        }





        private void hitBtn_Click(object sender, EventArgs e)
        {

        }

        private void evaluateBtn_Click(object sender, EventArgs e)
        {

        }

        // Bet 10
        private void button1_Click(object sender, EventArgs e)
        {

        }

        // Bet 50
        private void button2_Click(object sender, EventArgs e)
        {

        }

        // Bet 100
        private void button3_Click(object sender, EventArgs e)
        {

        }

        // Bet 500
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dealBtn_Click(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
