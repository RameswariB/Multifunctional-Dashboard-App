using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Project_420_WebApp;
using System.IO;
/*
 Rameswari, Bhoi
Description: This is a simple calculator page, in which I used label, text, buttton and  to make my site
more affective and attractive. Additionally i have concern button before closing the app.
and in this page i also envoke external class to make me the calculation.
Date: 2/7/2021
 */
namespace midTermWindowApp
{
    public partial class Form5 : Form
    {
        Calculator calc = new Calculator();
        string dir = @"..\Calculator\";
        string path = @"..\Calculator\Calculator.txt";
        FileStream fs = null;
        DateTime currentDateTime;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
        }

        private void btnExitCalc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Exit the Calculator app...?", "Exit", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void btnVal1_Click(object sender, EventArgs e)
        {
            if (txtcalResult.Text == "0" && txtcalResult.Text != null)
            {
                txtcalResult.Text = "1";
            }
            else
            {
                txtcalResult.Text = txtcalResult.Text + "1";
            }
        }

        private void btnVal2_Click(object sender, EventArgs e)
        {
            if (txtcalResult.Text == "0" && txtcalResult.Text != null)
            {
                txtcalResult.Text = "2";
            }
            else
            {
                txtcalResult.Text = txtcalResult.Text + "2";
            }
        }

        private void btnVal3_Click(object sender, EventArgs e)
        {
            if (txtcalResult.Text == "0" && txtcalResult.Text != null)
            {
                txtcalResult.Text = "3";
            }
            else
            {
                txtcalResult.Text = txtcalResult.Text + "3";
            }
        }

        private void btnVal4_Click(object sender, EventArgs e)
        {
            if (txtcalResult.Text == "0" && txtcalResult.Text != null)
            {
                txtcalResult.Text = "4";
            }
            else
            {
                txtcalResult.Text = txtcalResult.Text + "4";
            }
        }

        private void btnVal5_Click(object sender, EventArgs e)
        {
            if (txtcalResult.Text == "0" && txtcalResult.Text != null)
            {
                txtcalResult.Text = "5";
            }
            else
            {
                txtcalResult.Text = txtcalResult.Text + "5";
            }
        }

        private void btnVal6_Click(object sender, EventArgs e)
        {
            if (txtcalResult.Text == "0" && txtcalResult.Text != null)
            {
                txtcalResult.Text = "6";
            }
            else
            {
                txtcalResult.Text = txtcalResult.Text + "6";
            }
        }

        private void btnVal7_Click(object sender, EventArgs e)
        {
            if (txtcalResult.Text == "0" && txtcalResult.Text != null)
            {
                txtcalResult.Text = "7";
            }
            else
            {
                txtcalResult.Text = txtcalResult.Text + "7";
            }
        }

        private void btnVal8_Click(object sender, EventArgs e)
        {
            if (txtcalResult.Text == "0" && txtcalResult.Text != null)
            {
                txtcalResult.Text = "8";
            }
            else
            {
                txtcalResult.Text = txtcalResult.Text + "8";
            }
        }

        private void btnVal9_Click(object sender, EventArgs e)
        {
            if (txtcalResult.Text == "0" && txtcalResult.Text != null)
            {
                txtcalResult.Text = "9";
            }
            else
            {
                txtcalResult.Text = txtcalResult.Text + "9";
            }
        }

        private void btnValPoint_Click(object sender, EventArgs e)
        {
            if (txtcalResult.Text == "0" && txtcalResult.Text != null)
            {
                txtcalResult.Text = ".";
            }
            else
            {
                txtcalResult.Text = txtcalResult.Text + ".";
            }
        }

        private void btnCalClear_Click(object sender, EventArgs e)
        {
            txtcalResult.Text = "0";
            calc.Clear();
        }

        private void btnCalcadd_Click(object sender, EventArgs e)
        {
            try
            {
                calc.Add(Convert.ToDouble(txtcalResult.Text));
                txtcalResult.Text = "";
            }
            catch
            {
                MessageBox.Show("The value entered is not a number","Error");
            }
        }

        private void btnCalcequal_Click(object sender, EventArgs e)
        {
            
            try
            {
                try
                { txtcalResult.Text = calc.Equals(Convert.ToDouble(txtcalResult.Text)).ToString();}
                catch
                {MessageBox.Show("The value entered is not a number", "Error");}
                fs = new FileStream(path, FileMode.Append, FileAccess.Write);
                StreamWriter textOut = new StreamWriter(fs); // create the output stream for a text file that exists
                textOut.Write("\nCalculations " + DateTime.Now.ToString("MM/dd/yyyy hh:mm tt") + ", " + calc.Result_string);  // write the fields into text file
                textOut.Close(); // close the output stream for the text file
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

        private void btnCalcminus_Click(object sender, EventArgs e)
        {
            try
            {
                calc.Subtract(Convert.ToDouble(txtcalResult.Text));
                txtcalResult.Text = "";
            }
            catch
            {
                MessageBox.Show("The value entered is not a number","Error");
            }
        }

        private void btnCalcMulti_Click(object sender, EventArgs e)
        {
            try
            {
                calc.Multiply(Convert.ToDouble(txtcalResult.Text));
                txtcalResult.Text = "";
            }
            catch
            {
                MessageBox.Show("The value entered is not a number","Error");
            }
        }

        private void btnCalcDiv_Click(object sender, EventArgs e)
        {
            try
            {
                calc.Divide(Convert.ToDouble(txtcalResult.Text));
                txtcalResult.Text = "";
            }
            catch
            {
                MessageBox.Show("The value entered is not a number","Error");
            }
        }

        private void btnVal0_Click(object sender, EventArgs e)
        {
            if (txtcalResult.Text == "0" && txtcalResult.Text != null)
            {
                txtcalResult.Text = "0";
            }
            else
            {
                txtcalResult.Text = txtcalResult.Text + "0";
            }
        }
    }
}
