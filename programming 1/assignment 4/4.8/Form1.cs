using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4._8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            int input = int.Parse(txtInput.Text);
            int count = 0;
            int sum = 0;
            
            while (count<input)
            {
                count++;
                sum = sum + count;
            }
            

            int check = input * (input + 1) / 2;
            if (check==sum)
            {
                lblLast.Text = "The sum and formula are equal.";
            }
            else
            {
                lblLast.Text = "the sum and formula are not equal.";
            }
            lblCheck.Text = check.ToString();
            lblSum.Text = sum.ToString();

        }

        private void lblSum_Click(object sender, EventArgs e)
        {

        }

        private void lblCheck_Click(object sender, EventArgs e)
        {

        }

        private void lblLast_Click(object sender, EventArgs e)
        {

        }
    }
}
