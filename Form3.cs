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

namespace BlackJackGame
{
    public partial class Form3 : Form
    {
        Deck deck;
        Hand playerHand;
        Hand dealerHand;
        bool gameInProgress = false;
        bool dealInProgress = false;

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

            deck = new Deck();
            deck.shuffle();
            bet = 0;
            gameInProgress = true;
        }

        private void hitBtn_Click(object sender, EventArgs e)
        {
            if (gameInProgress && dealInProgress)
            {
                if (playerHand.getHandCardCount() >= 2)
                {
                    if(playerHand.getHandCardCount() < 5)
                    {
                        Card addCard = deck.dealCard();
                        playerHand.addCard(addCard);

                        if(playerHand.getHandCardCount() == 3)
                        {
                            setCardImg(pCard3, addCard);
                        }
                        else if (playerHand.getHandCardCount() == 4)
                        {
                            setCardImg(pCard4, addCard);
                        }
                        else
                        {
                            setCardImg(pCard5, addCard);
                        }

                        if (playerHand.getHandTotal() >= 21)
                        {
                            evaluate();
                        }
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
            evaluate();
        }

        private void evaluate()
        {
            if (gameInProgress && dealInProgress)
            {
                int dvalue = dealerHand.getHandTotal();
                while ((dvalue < 17) && (dealerHand.getHandCardCount() < 5))
                {
                    Card dealed = deck.dealCard();
                    dealerHand.addCard(dealed);

                    if (dealerHand.getHandCardCount() == 3)
                    {
                        setCardImg(dCard3, dealed);
                    }
                    else if (dealerHand.getHandCardCount() == 4)
                    {
                        setCardImg(dCard4, dealed);
                    }
                    else
                    {
                        setCardImg(dCard5, dealed);
                    }

                    dvalue = dealerHand.getHandTotal();
                }

                setCardImg(dCard1, dealerHand.getCard(0));

                int pvalue = playerHand.getHandTotal();

                if(dvalue != pvalue)
                {
                    if (dvalue < 22)
                    {
                        if (pvalue > dvalue)
                        {
                            if (pvalue < 22)
                            {
                                gameInProgress = false;
                                resultLabel.Text = "Congratulation! You WIN!    P: " + pvalue + " - D:" + dvalue;
                                player.addCoins(bet);
                            }
                            else
                            {
                                gameInProgress = false;
                                resultLabel.Text = "Busted! You Lose.   P: " + pvalue + " - D:" + dvalue;
                                player.deductCoins(bet);
                            }
                            saveData();
                        }
                        else
                        {
                            gameInProgress = false;
                            resultLabel.Text = "Too bad! You Lose.   P: " + pvalue + " - D:" + dvalue;
                            player.deductCoins(bet); 
                            saveData();
                        }
                    }
                    else
                    {
                        if (pvalue < 22)
                        {
                            gameInProgress = false;
                            resultLabel.Text = "Congratulation! You WIN!    P: " + pvalue + " - D:" + dvalue;
                            player.addCoins(bet);
                        }
                        else
                        {
                            gameInProgress = false;
                            resultLabel.Text = "Both Busted! It's a Tie.   P: " + pvalue + " - D:" + dvalue;
                        }
                        saveData();
                    }
                }
                else
                {
                    gameInProgress = false;
                    resultLabel.Text = "It's a Draw!    P: " + pvalue + " - D:" + dvalue;
                }
                bet = 0;
                gameInProgress = false;
                dealInProgress = false;
            }
        }

        private void newGame()
        {
            if(deck.cardsLeft() <= 10)
            {
                deck = new Deck();
                deck.shuffle();
                bet = 0;
            }
            playerHand = new Hand();
            dealerHand = new Hand();

            Card dealed = deck.dealCard();
            playerHand.addCard(dealed);
            setCardImg(pCard1, dealed);

            dealed = deck.dealCard();
            dealerHand.addCard(dealed);
            dCard1.BackgroundImage = Properties.Resources.B;

            dealed = deck.dealCard();
            playerHand.addCard(dealed);
            setCardImg(pCard2, dealed);

            dealed = deck.dealCard();
            dealerHand.addCard(dealed);
            setCardImg(dCard2, dealed);

            gameInProgress = true;
            if (playerHand.getHandTotal() >= 21)
            {
                evaluate();
            }
        }

        private void dealBtn_Click(object sender, EventArgs e)
        {
            if (gameInProgress)
            {
                if (!(bet == 0))
                {
                    newGame();
                }
                else
                {
                    resultLabel.Text = "Place your bet...";
                    MessageBox.Show("Please make a bet first.", "Deal",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please initiate a new game first.\nPlease click the [ New Game ] button.", "Deal",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
            dealInProgress = true;
        }

        private void newGameBtn_Click(object sender, EventArgs e)
        {
            if (!gameInProgress)
            {

                if (player.getCoins() <= 100)
                {
                    MessageBox.Show("Unfortunately you ran out of coins!\n\n" +
                        "You will now received an additional 1000 coins.", "New Game",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    player.addCoins(1000);
                }

                coinsLabel.Text = player.getCoins().ToString();
                playerLabel.Text = player.getUName();
                pCard1.BackgroundImage = null;
                pCard2.BackgroundImage = null;
                pCard3.BackgroundImage = null;
                pCard4.BackgroundImage = null;
                pCard5.BackgroundImage = null;
                dCard1.BackgroundImage = null;
                dCard2.BackgroundImage = null;
                dCard3.BackgroundImage = null;
                dCard4.BackgroundImage = null;
                dCard5.BackgroundImage = null;
                betLabel.Text = "00000";
                resultLabel.Text = "Place your bet...";

            }
            gameInProgress = true;
        }

        // Bet 10
        private void button1_Click(object sender, EventArgs e)
        {
            if (gameInProgress)
            {
                if(bet + 10 <= player.getCoins())
                {
                    if (bet + 10 <= 1000)
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
                else
                {
                    MessageBox.Show("Unable to add bet.\n\nBet exceeds remaining coins.", "Bet",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please initiate a new game first.\nPlease click the [ New Game ] button.", "Deal",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
        }

        // Bet 50
        private void button2_Click(object sender, EventArgs e)
        {
            if (gameInProgress)
            {

                if (bet + 50 <= player.getCoins())
                {
                    if (bet + 50 <= 1000)
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
                else
                {
                    MessageBox.Show("Unable to add bet.\n\nBet exceeds remaining coins.", "Bet",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please initiate a new game first.\nPlease click the [ New Game ] button.", "Deal",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
        }

        // Bet 100
        private void button3_Click(object sender, EventArgs e)
        {
            if (gameInProgress)
            {

                if (bet + 100 <= player.getCoins())
                {
                    if (bet + 100 <= 1000)
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
                else
                {
                    MessageBox.Show("Unable to add bet.\n\nBet exceeds remaining coins.", "Bet",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please initiate a new game first.\nPlease click the [ New Game ] button.", "Deal",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
        }

        // Bet 500
        private void button4_Click(object sender, EventArgs e)
        {
            if (gameInProgress)
            {

                if (bet + 500 <= player.getCoins())
                {
                    if (bet + 500 <= 1000)
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
                else
                {
                    MessageBox.Show("Unable to add bet.\n\nBet exceeds remaining coins.", "Bet",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please initiate a new game first.\nPlease click the [ New Game ] button.", "Deal",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
        }

        // Update data to CurrentPlayer.txt file
        private void saveData()
        {
            var systemPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var complete = Path.Combine(systemPath, "BlackJack\\Players");
            string currentPlayerPath = complete + "\\Current_Player.txt";
            FileInfo file = new FileInfo(@"" + currentPlayerPath);
            file.Create().Dispose();

            using (StreamWriter sw = File.AppendText(currentPlayerPath))
            {
                sw.WriteLine("Coins: " + player.getCoins());
                sw.WriteLine("Name: " + player.getUName());
                sw.WriteLine("Pass: " + player.getPass());
                sw.Close();
            }
        }

        // Sets images to the panels
        private void setCardImg(Panel cardPanel, Card card)
        {
            switch (card.getValue())
            {
                case 1:
                    switch (card.getSuit())
                    {
                        case "S":
                            cardPanel.BackgroundImage = Properties.Resources.S1;
                            break;
                        case "H":
                            cardPanel.BackgroundImage = Properties.Resources.H1;
                            break;
                        case "C":
                            cardPanel.BackgroundImage = Properties.Resources.C1;
                            break;
                        default:
                            cardPanel.BackgroundImage = Properties.Resources.D1;
                            break;
                    }
                    break;
                case 2:
                    switch (card.getSuit())
                    {
                        case "S":
                            cardPanel.BackgroundImage = Properties.Resources.S2;
                            break;
                        case "H":
                            cardPanel.BackgroundImage = Properties.Resources.H2;
                            break;
                        case "C":
                            cardPanel.BackgroundImage = Properties.Resources.C2;
                            break;
                        default:
                            cardPanel.BackgroundImage = Properties.Resources.D2;
                            break;
                    }
                    break;
                case 3:
                    switch (card.getSuit())
                    {
                        case "S":
                            cardPanel.BackgroundImage = Properties.Resources.S3;
                            break;
                        case "H":
                            cardPanel.BackgroundImage = Properties.Resources.H3;
                            break;
                        case "C":
                            cardPanel.BackgroundImage = Properties.Resources.C3;
                            break;
                        default:
                            cardPanel.BackgroundImage = Properties.Resources.D3;
                            break;
                    }
                    break;
                case 4:
                    switch (card.getSuit())
                    {
                        case "S":
                            cardPanel.BackgroundImage = Properties.Resources.S4;
                            break;
                        case "H":
                            cardPanel.BackgroundImage = Properties.Resources.H4;
                            break;
                        case "C":
                            cardPanel.BackgroundImage = Properties.Resources.C4;
                            break;
                        default:
                            cardPanel.BackgroundImage = Properties.Resources.D4;
                            break;
                    }
                    break;
                case 5:
                    switch (card.getSuit())
                    {
                        case "S":
                            cardPanel.BackgroundImage = Properties.Resources.S5;
                            break;
                        case "H":
                            cardPanel.BackgroundImage = Properties.Resources.H5;
                            break;
                        case "C":
                            cardPanel.BackgroundImage = Properties.Resources.C5;
                            break;
                        default:
                            cardPanel.BackgroundImage = Properties.Resources.D5;
                            break;
                    }
                    break;
                case 6:
                    switch (card.getSuit())
                    {
                        case "S":
                            cardPanel.BackgroundImage = Properties.Resources.S6;
                            break;
                        case "H":
                            cardPanel.BackgroundImage = Properties.Resources.H6;
                            break;
                        case "C":
                            cardPanel.BackgroundImage = Properties.Resources.C6;
                            break;
                        default:
                            cardPanel.BackgroundImage = Properties.Resources.D6;
                            break;
                    }
                    break;
                case 7:
                    switch (card.getSuit())
                    {
                        case "S":
                            cardPanel.BackgroundImage = Properties.Resources.S7;
                            break;
                        case "H":
                            cardPanel.BackgroundImage = Properties.Resources.H7;
                            break;
                        case "C":
                            cardPanel.BackgroundImage = Properties.Resources.C7;
                            break;
                        default:
                            cardPanel.BackgroundImage = Properties.Resources.D7;
                            break;
                    }
                    break;
                case 8:
                    switch (card.getSuit())
                    {
                        case "S":
                            cardPanel.BackgroundImage = Properties.Resources.S8;
                            break;
                        case "H":
                            cardPanel.BackgroundImage = Properties.Resources.H8;
                            break;
                        case "C":
                            cardPanel.BackgroundImage = Properties.Resources.C8;
                            break;
                        default:
                            cardPanel.BackgroundImage = Properties.Resources.D8;
                            break;
                    }
                    break;
                case 9:
                    switch (card.getSuit())
                    {
                        case "S":
                            cardPanel.BackgroundImage = Properties.Resources.S9;
                            break;
                        case "H":
                            cardPanel.BackgroundImage = Properties.Resources.H9;
                            break;
                        case "C":
                            cardPanel.BackgroundImage = Properties.Resources.C9;
                            break;
                        default:
                            cardPanel.BackgroundImage = Properties.Resources.D9;
                            break;
                    }
                    break;
                case 10:
                    switch (card.getSuit())
                    {
                        case "S":
                            cardPanel.BackgroundImage = Properties.Resources.S10;
                            break;
                        case "H":
                            cardPanel.BackgroundImage = Properties.Resources.H10;
                            break;
                        case "C":
                            cardPanel.BackgroundImage = Properties.Resources.C10;
                            break;
                        default:
                            cardPanel.BackgroundImage = Properties.Resources.D10;
                            break;
                    }
                    break;
                case 11:
                    switch (card.getSuit())
                    {
                        case "S":
                            cardPanel.BackgroundImage = Properties.Resources.S11;
                            break;
                        case "H":
                            cardPanel.BackgroundImage = Properties.Resources.H11;
                            break;
                        case "C":
                            cardPanel.BackgroundImage = Properties.Resources.C11;
                            break;
                        default:
                            cardPanel.BackgroundImage = Properties.Resources.D11;
                            break;
                    }
                    break;
                case 12:
                    switch (card.getSuit())
                    {
                        case "S":
                            cardPanel.BackgroundImage = Properties.Resources.S12;
                            break;
                        case "H":
                            cardPanel.BackgroundImage = Properties.Resources.H12;
                            break;
                        case "C":
                            cardPanel.BackgroundImage = Properties.Resources.C12;
                            break;
                        default:
                            cardPanel.BackgroundImage = Properties.Resources.D12;
                            break;
                    }
                    break;

                case 13:
                    switch (card.getSuit())
                    {
                        case "S":
                            cardPanel.BackgroundImage = Properties.Resources.S13;
                            break;
                        case "H":
                            cardPanel.BackgroundImage = Properties.Resources.H13;
                            break;
                        case "C":
                            cardPanel.BackgroundImage = Properties.Resources.C13;
                            break;
                        default:
                            cardPanel.BackgroundImage = Properties.Resources.D13;
                            break;
                    }
                    break;
                default:
                    cardPanel.BackgroundImage = Properties.Resources.B;
                    break;
            }
        }

        // Executes when form is closed
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            var systemPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var complete = Path.Combine(systemPath, "BlackJack\\Players");
            string playerPath = complete + "\\Player_" + player.getUName().Replace(' ', '_') + "_xXx.txt";
            FileInfo file = new FileInfo(@"" + playerPath);
            file.Create().Dispose();

            using (StreamWriter sw = File.AppendText(playerPath))
            {
                sw.WriteLine("Coins: " + player.getCoins());
                sw.WriteLine("Name: " + player.getUName());
                sw.WriteLine("Pass: " + player.getPass());
                sw.Close();
            }
        }
    }
}
