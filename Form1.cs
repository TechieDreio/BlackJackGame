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
            /*try
            {
                var systemPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                var complete = Path.Combine(systemPath, "BlackJack\\Players");

                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("TestFile.txt"))
                {
                    string line;
                    // Read and add to combobox the usernames lines from the file until the end of
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {

                    }
                }
            }
            catch (Exception ea)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(ea.Message);
            }*/

        }

        private void HallBTN_Click(object sender, EventArgs e)
        {

        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {

        }

        private void SettingsBTN_Click(object sender, EventArgs e)
        {

        }
    }
}
