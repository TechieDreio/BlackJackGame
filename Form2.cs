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
            bool regSuccess=false;
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

                if (!File.Exists(complete + "\\PlayerList.txt"))
                {
                    FileInfo file = new FileInfo(@"" + complete + "\\PlayerList.txt");
                    file.Create();
                    Console.WriteLine("File \"PlayerList.txt\" created successfully!");
                }

                using (StreamWriter sw = File.AppendText(complete + "\\PlayerList.txt"))
                {
                    sw.WriteLine("Name: " + username);
                    sw.WriteLine("Pass: " + username + "-" + password);
                    sw.Close();
                }

                MessageBox.Show("Registered Successfully!", "Register");
                regSuccess = true;
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
