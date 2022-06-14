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
        Hand playerHand;
        Hand dealerHand;
        bool gameInProgress = false;

        Player player;
        

        int bet;

        public Form3()
        {
            InitializeComponent();

            var systemPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var complete = Path.Combine(systemPath, "BlackJack\\Players");
            string currentPlayerPath = complete + "\\Current_Player.txt";

            string[] readText = File.ReadAllLines(@"" + currentPlayerPath);

            player = new Player(Int32.Parse(readText[0].Split(' ')[1]),
                readText[1].Split(' ')[1],
                readText[2].Split(' ')[1]);

            coinsLabel.Text = player.getCoins().ToString();
            playerLabel.Text = player.getUName();
            resultLabel.Text = "Place your bet...";
        }

        private void hitBtn_Click(object sender, EventArgs e)
        {
            if (gameInProgress)
            {
                if (playerHand.getHandCardCount() >= 2)
                {
                    if(playerHand.getHandCardCount() <= 5)
                    {
                        playerHand.addCard(deck.dealCard());
                        // Display new card
                    }
                    else
                    {
                        MessageBox.Show("Unable to add card.\n\nCard limit is up to 5 cards only.", "Hit",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void evaluateBtn_Click(object sender, EventArgs e)
        {
            gameInProgress = false;
        }

        private void newGame()
        {
            deck = new Deck();
            deck.shuffle();
            bet = 0;

            playerHand = new Hand();
            dealerHand = new Hand();

            playerHand.addCard(deck.dealCard());
            dealerHand.addCard(deck.dealCard());
            playerHand.addCard(deck.dealCard());
            dealerHand.addCard(deck.dealCard());

            gameInProgress = true;
        }

        private void dealBtn_Click(object sender, EventArgs e)
        {
            if (!(bet == 0))
            {
                newGame();
            }
            else
            {
                MessageBox.Show("Please make a bet first.", "Deal",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
        }

        // Bet 10
        private void button1_Click(object sender, EventArgs e)
        {
            if (bet+10 <= 1000 && bet+10 <= player.getCoins())
            {
                bet += 10;
                betLabel.Text = bet.ToString();
            }
            else
            {
                MessageBox.Show("Unable to add bet.\n\nBet limit is up to 1000 coins only.", "Bet",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
        }

        // Bet 50
        private void button2_Click(object sender, EventArgs e)
        {
            if(bet+50 <= 1000 && bet + 50 <= player.getCoins())
            {
                bet += 50;
                betLabel.Text = bet.ToString();
            }
            else
            {
                MessageBox.Show("Unable to add bet.\n\nBet limit is up to 1000 coins only.", "Bet",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
        }

        // Bet 100
        private void button3_Click(object sender, EventArgs e)
        {
            if (bet+100 <= 1000 && bet + 100 <= player.getCoins())
            {
                bet += 100;
                betLabel.Text = bet.ToString();
            }
            else
            {
                MessageBox.Show("Unable to add bet.\n\nBet limit is up to 1000 coins only.", "Bet",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
        }

        // Bet 500
        private void button4_Click(object sender, EventArgs e)
        {
            if (bet+500 <= 1000 && bet + 500 <= player.getCoins())
            {
                bet += 500;
                betLabel.Text = bet.ToString();
            }
            else
            {
                MessageBox.Show("Unable to add bet.\n\nBet limit is up to 1000 coins only.", "Bet",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
