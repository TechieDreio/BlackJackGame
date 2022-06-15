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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            craeteHallListFile();
        }

        private void craeteHallListFile()
        {
            var systemPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var complete = Path.Combine(systemPath, "BlackJack\\Players");
            var lineCount = File.ReadLines(@"" + complete + "\\PlayerList.txt").Count();
            string hallPath = complete + "\\HallOfFame.txt";

            // Creates the HallOfFame.txt
            FileInfo file = new FileInfo(@"" + hallPath);
            file.Create().Dispose();

            string[] readText = File.ReadAllLines(@"" + complete + "\\PlayerList.txt");
            
            for(int i=0; i<readText.Length; i+=2)
            {
                string username = readText[i].Split(' ')[1];
                string coins = "";
                string pass = "";
                string playerFilePath = complete + "\\Player_" + username.Replace(' ', '_') + "_xXx.txt";
                //Open player file
                if (File.Exists(playerFilePath))
                {
                    using (StreamReader sr = new StreamReader(playerFilePath))
                    {
                        coins = sr.ReadLine().Split(' ')[1];
                        username = sr.ReadLine().Split(' ')[1];
                        pass = sr.ReadLine().Split(' ')[1];
                        sr.Close();
                    }
                }
                Player player = new Player(Int32.Parse(coins), username,pass);

                using (StreamWriter sw = File.AppendText(hallPath))
                {
                    sw.WriteLine(player.getUName() + " " + player.getCoins());
                    sw.Close();
                }
            }

            string[] hallList = File.ReadAllLines(@"" + hallPath);

            int n = hallList.Length;
            for (int j = 0; j <= n - 2; j++)
            {
                for (int i = 0; i <= n - 2; i++)
                {
                    if (Int32.Parse(hallList[i].Split(' ')[1]) < Int32.Parse(hallList[i+1].Split(' ')[1]))
                    {
                        string temp = hallList[i+1];
                        hallList[i+1] = hallList[i];
                        hallList[i] = temp;
                    }
                }
            }

                 
            for(int i=0; i<n; i++)
            {
                if (i == 0)
                {
                    userR1.Text = hallList[0].Split(' ')[0];
                    coinsR1.Text = hallList[0].Split(' ')[1];
                }
                else if (i == 1)
                {
                    userR2.Text = hallList[1].Split(' ')[0];
                    coinsR2.Text = hallList[1].Split(' ')[1];
                }
                else if (i == 2)
                {
                    userR3.Text = hallList[2].Split(' ')[0];
                    coinsR3.Text = hallList[2].Split(' ')[1];
                }
                else if (i == 3)
                {
                    userR4.Text = hallList[3].Split(' ')[0];
                    coinsR4.Text = hallList[3].Split(' ')[1];
                }
                else
                {
                    userR5.Text = hallList[4].Split(' ')[0];
                    coinsR5.Text = hallList[4].Split(' ')[1];
                }
            }





        }
    }
}
