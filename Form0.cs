
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 Rameswari, Bhoi
Description: This is a Dashboard page, in which I used group box, buttton and tab control to make my site
more affective and attractive. Additionally i have concern button before closing the app.
Date: 1/7/2021
 */
namespace midTermWindowApp
{
    public partial class Form0 : Form
    {
        public Form0()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Exit the app...?", "Exit", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            Form5 cal = new Form5();
            cal.ShowDialog();
            
        }

        private void btnLotto_Click(object sender, EventArgs e)
        {
            Form1 lottoMx = new Form1();
            lottoMx.ShowDialog();
        }

        private void btnLotto649_Click(object sender, EventArgs e)
        {
            Form2 lot649 = new Form2();
            lot649.ShowDialog();
        }


        private void btnMoneyExchange_Click(object sender, EventArgs e)
        {
            Form3 mnExchange = new Form3();
            mnExchange.ShowDialog();
        }


        private void btnTempConvert_Click(object sender, EventArgs e)
        {
            Form4 tempConvert = new Form4();
            tempConvert.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 ip4Form = new Form6();
            ip4Form.ShowDialog();

        }
    }
}
