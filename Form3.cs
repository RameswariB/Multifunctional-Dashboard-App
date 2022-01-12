using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Project_420_WebApp;
using System.IO;
using System.Text.RegularExpressions;
/* Rameswari Bhoi,
 Desc: This form is used to convert one currency into another form
Date: 4/7/2021
 */
namespace midTermWindowApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        CurrencyConverter myconverter = new CurrencyConverter();
        string dir = @"..\MoneyExchange\";
        string path = @"..\MoneyExchange\MoneyConversions.txt";
        FileStream fs = null;
        DateTime current = new DateTime();
        private void btnExitMoneyExchange_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Exit the Money Exchange app...?", "Exit", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question).ToString() == "Yes")
            {
                this.Close();
            }
        }
        private RadioButton GetCheckedRadio(Control container)
        {
            foreach (var control in container.Controls)
            {
                RadioButton radio = control as RadioButton;

                if (radio != null && radio.Checked)
                {
                    return radio;
                }
            }

            return null;
        }
        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                double tmpValue = 0.0;
                try
                {
                    tmpValue = Convert.ToDouble(txtVal1.Text);
                }
                catch{
                    MessageBox.Show("The value entered is not a number");
                }
                string fromCurr = this.GetCheckedRadio(groupBox1).Text;
                string toCurr = this.GetCheckedRadio(groupBox2).Text;
                string result_string = tmpValue.ToString() + fromCurr+" = ";
                tmpValue = myconverter.convert(fromCurr, toCurr, tmpValue);
                result_string += tmpValue + toCurr+",   ";
                txtval2.Text = tmpValue.ToString();
                fs = new FileStream(path, FileMode.Append, FileAccess.Write); // create the output stream for a text file that exists

                StreamWriter textOut = new StreamWriter(fs);  // write the fields into text file

                textOut.Write(result_string+ DateTime.Now.ToString("MM/dd/yyyy hh:mm tt")+"\n");

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

        private void MoneyExchange_Load(object sender, EventArgs e)
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
                string textToPrint = "Money Exchange Data's are :\n";
                // read the data from the file and store it in the list
                textToPrint += textIn.ReadToEnd();
                MessageBox.Show(textToPrint, "Money Exchange Records - Rameswari");
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
