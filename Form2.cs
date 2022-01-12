using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
/*
 Rameswari, Bhoi
Description: In this Lotto 649 application web page is created by using many components like buttons, list and labels
to generate random numbers.
Date: 2/7/2021
 */
namespace midTermWindowApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string dir = @"..\LottoMAX\";
        string path = @"..\LottoMAX\LottoNbrs.txt";
        FileStream fs = null;
        DateTime currentDateTime;
        private void btnExitLotto649_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Exit the Lotto 649 app...?", "Exit", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            int count = 6;
            string maxLottString = "";
            Random random = new Random();
            for (int i = 1; i <= count; i++)

            {
                int randomNumber = random.Next(1, 50);
                textBox1.Text += randomNumber.ToString() + "\r\n";
                if (i == count)
                {
                    maxLottString += randomNumber.ToString();
                }
                else
                {
                    maxLottString += randomNumber.ToString() + ",";
                }
            }
            int Bonus = random.Next(1, 50);
            textBox1.Text += "Bonus\r\n" + Bonus.ToString();
            try
            {

                fs = new FileStream(path, FileMode.Append, FileAccess.Write);
                // create the output stream for a text file that exists
                StreamWriter textOut = new StreamWriter(fs);
                // write the fields into text file
                textOut.Write("\n649," + DateTime.Now.ToString("MM/dd/yyyy hh:mm tt") + ", " + maxLottString + "  BONUS " + Bonus);

                // close the output stream for the text file
                textOut.Close();
                fs.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(path + " not found.", "File Not Found");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show(dir + " not found.", "Directory Not Found");
            }
            catch (IOException ex)
            { MessageBox.Show(ex.Message, "IOException"); }
            finally { if (fs != null) fs.Close(); }

        }

        private void Lotto649_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            try
            {

                fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                // create the object for the input stream for a text file
                StreamReader textIn = new StreamReader(fs);
                string textToPrint = "Winning Numbers Are :\n";
                // read the data from the file and store it in the list
                textToPrint += textIn.ReadToEnd();
                MessageBox.Show(textToPrint, "Lotto 649 Winner Number - Rameswari");
                // close the input stream for the text file
                textIn.Close();

                fs.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(path + " not found.", "File Not Found");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show(dir + " not found.", "Directory Not Found");
            }
            catch (IOException ex)
            { MessageBox.Show(ex.Message, "IOException"); }
            finally { if (fs != null) fs.Close(); }
        }
    }
}
