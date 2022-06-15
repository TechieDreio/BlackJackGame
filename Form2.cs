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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            string username = "";
            string password = "";
            bool regSuccess = false;
            bool nameExist = false;

            if (usernameTxt.Text == "" && passwordTxt.Text == "")
            {
                MessageBox.Show("Please input username and password.");
                regSuccess = false;
            }
            else
            {
                username = usernameTxt.Text;
                password = passwordTxt.Text;
            }

            // Specify the directory you want to manipulate.
            var systemPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var complete = Path.Combine(systemPath, "BlackJack\\Players");

            try
            {
                // Determine whether the directory exists if not create the directory.
                if (!Directory.Exists(complete))
                {
                    DirectoryInfo di = Directory.CreateDirectory(complete);
                }

                Console.WriteLine(complete);

                /*using (FileStream fs = File.Create(complete + "\\PlayerList.txt"))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("This is some text in the file.");
                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                }*/
                
                FileInfo playerListFile = new FileInfo(@"" + complete + "\\PlayerList.txt");

                if (!playerListFile.Exists)
                {
                    playerListFile.Create().Dispose();
                    Console.WriteLine("File \"PlayerList.txt\" created successfully!");
                }


                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(complete + "\\PlayerList.txt"))
                {
                    string line;
                    // Read and display lines from the file until the end of
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        if(line == "Name: " + username)
                        {
                            nameExist = true;
                            break;
                        }
                    }
                }

                if (nameExist)
                {
                    MessageBox.Show("Player username already exist!", "Register");
                    regSuccess = false;
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(complete + "\\PlayerList.txt"))
                    {
                        sw.WriteLine("Name: " + username.Replace(' ','_'));
                        sw.WriteLine("Pass: " + password);
                        sw.Close();
                    }

                    string playerFilePath = complete + "\\Player_" + username.Replace(' ', '_') + "_xXx.txt";

                    // Create User Profile File
                    if (!File.Exists(playerFilePath))
                    {
                        FileInfo files = new FileInfo(@"" + playerFilePath);
                        files.Create().Dispose();
                        Console.WriteLine("File \""+ playerFilePath + "\" created successfully!");
                    }

                    // Append data to file
                    using (StreamWriter sw = File.AppendText(playerFilePath))
                    {
                        sw.WriteLine("Coins: " + "1000");
                        sw.WriteLine("Name: " + username.Replace(' ', '_'));
                        sw.WriteLine("Pass: " + password);
                        sw.Close();
                    }

                    MessageBox.Show("Registered Successfully!", "Register");
                    regSuccess = true;
                }
            }
            catch (Exception ea)
            {
                Console.WriteLine("The process failed: {0}", ea.ToString());
            }


            if (regSuccess)
            {
                this.Close();
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
