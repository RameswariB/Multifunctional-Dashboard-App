using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Project_420_WebApp;
using System.IO;
/* Rameswari Bhoi,
 Desc: This form is used to convert one temperature  from celcius to ferenhit and vice versa.
Date: 6/7/2021
 */
namespace midTermWindowApp
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        Calc_temperature temp = new Calc_temperature();
        string dir = @"..\TempConversion\";
        string path = @"..\TempConversion\TempConversions.txt";
        FileStream fs = null;
        
        private void btnExitTempConversion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Exit the Temperature Conversion app...?", "Exit", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Hide();
            label3.Hide();
            label2.Show();
            label4.Show();
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "";
            textBox1.Focus();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Hide();
            label4.Hide();
            label1.Show();
            label3.Show();
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "";
            textBox1.Focus();
        }

        private void TempConversion_Load(object sender, EventArgs e)
        {
            label1.Hide();
            label3.Hide();
            label2.Show();
            label4.Show();
            textBox1.Text = temp.Value1.ToString();
            textBox2.Text = temp.Value2.ToString();
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            int val = Convert.ToInt32(textBox1.Text);
            string string_val = "";
            if (radioButton1.Checked)
            {
                textBox2.Text = Convert.ToString(temp.calc_temp(val, true));
                string_val= textBox1.Text + "C = " + textBox2.Text + "F,    ";
            }
            else {
                textBox2.Text = Convert.ToString(temp.calc_temp(val, false));
                string_val = textBox1.Text + "F = " + textBox2.Text + "C,   ";
            }
            textBox3.Text = temp.Desc;
            textBox1.Focus();
            try
            {

                fs = new FileStream(path, FileMode.Append, FileAccess.Write);
                // create the output stream for a text file that exists
                StreamWriter textOut = new StreamWriter(fs);
                // write the fields into text file
                textOut.Write(string_val + DateTime.Now.ToString("MM/dd/yyyy hh:mm tt")+"\n");

                // close the output stream for the text file
                textOut.Close();
                fs.Close();
                textBox1.Focus();
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

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            try
            {

                fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                // create the object for the input stream for a text file
                StreamReader textIn = new StreamReader(fs);
                string textToPrint = "Results for Temperature Conversions are :\n";
                // read the data from the file and store it in the list
                textToPrint += textIn.ReadToEnd();
                MessageBox.Show(textToPrint, "Tempterature Conversation - Rameswari");
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
