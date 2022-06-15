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
    public partial class OptionForm : Form
    {
        public OptionForm()
        {
            InitializeComponent();
        }

        private void NewBTN_Click(object sender, EventArgs e)
        {
            Form2 addNewPlayer = new Form2();
            addNewPlayer.ShowDialog();
        }

        private void PlayBTN_Click(object sender, EventArgs e)
        {
            string username = "";
            string password = "";
            string currentPlayerPath = "";
            string playerFilePath = "";

            if (usernameTxt.Text == "" && passwordTxt.Text == "")
            {
                MessageBox.Show("Please input username and password.","Login",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            else
            {
                username = usernameTxt.Text;
                password = passwordTxt.Text; 
                
                try
                {

                    var systemPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                    var complete = Path.Combine(systemPath, "BlackJack\\Players");
                    var lineCount = File.ReadLines(@"" + complete + "\\PlayerList.txt").Count();
                    bool userExist = false;
                    bool passCorrect = false;

                    // Check if username exist
                    using (StreamReader sr = new StreamReader(complete + "\\PlayerList.txt"))
                    {
                        string line;
                        for (int i = 1; i <= lineCount; i++)
                        {
                            line = sr.ReadLine();
                            if (line == "Name: " + username)
                            {
                                userExist = true;
                                line = sr.ReadLine();
                                if (line == "Pass: " + password)
                                {
                                    passCorrect = true;
                                }
                                else
                                {
                                    passCorrect = false;
                                }
                                break;
                            }
                            else
                            {
                                userExist = false;
                            }
                        }
                    }

                    if (userExist && passCorrect)
                    {
                        currentPlayerPath = complete + "\\Current_Player.txt";
                        playerFilePath = complete + "\\Player_" + username.Replace(' ', '_') + "_xXx.txt";

                        FileInfo file = new FileInfo(@"" + currentPlayerPath);
                        file.Create().Dispose();
                        Console.WriteLine("File \"Current_Player.txt\" created successfully!");

                        if (File.Exists(playerFilePath))
                        {
                            using (StreamReader sr = new StreamReader(playerFilePath))
                            {
                                string line;
                                int ctr = 1;
                                while ((line = sr.ReadLine()) != null)
                                {
                                    using (StreamWriter sw = File.AppendText(currentPlayerPath))
                                    {
                                        sw.WriteLine(line);
                                        sw.Close();
                                    }
                                }
                            }
                        }

                        usernameTxt.Text = "";
                        passwordTxt.Text = "";

                        Form3 playArea = new Form3();
                        this.Hide();
                        playArea.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect username or password!", "Login",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }


                }
                catch (Exception ea)
                {
                    // Let the user know what went wrong.
                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(ea.Message);
                }
            }

        }

        private void HallBTN_Click(object sender, EventArgs e)
        {
            Form4 hall = new Form4();
            this.Hide();
            hall.ShowDialog();
            this.Show();
        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
