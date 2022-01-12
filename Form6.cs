using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
/*
 Rameswari, Bhoi
Description: This page is created for checking or validating IP address and this is performed by using regular expression.
Date: 15/7/2021
 */
namespace midTermWindowApp
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Exit the IP Validator app...?", "Exit", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void IP4Validator_Load(object sender, EventArgs e)
        {
            label1.Text = "Today : " + DateTime.Now.ToString("MM-dd-yy");
        }

        private void btnValidateIP_Click(object sender, EventArgs e)
        {
            string Pattern = @"^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])){3}$";
            //Regular Expression object    
            Regex check = new Regex(Pattern);
            if (check.IsMatch(textBox1.Text.Trim()))
            {
                MessageBox.Show(textBox1.Text+
                    "\n The IP is Correct","Valid IP");
            }
            else { 
                MessageBox.Show(textBox1.Text +
                    "\n The IP must have 4 bytes" +
                    "\n integer number between 0 to 255 " +
                    "\n seperated bya dot(255.255.255.255)","Error"); 
                textBox1.Focus();
            }
        }
    }
}
