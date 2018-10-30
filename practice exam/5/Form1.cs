using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int hours = int.Parse(txth.Text);
            int min = int.Parse(txtm.Text);
            int sec = int.Parse(txtsec.Text);
            int time = hours + (min / 60) + (sec / 3600);
            int km = 0;
            if (rbtn1.Checked)
            {
                km = 10;
            }
            if (rbtn2.Checked)
            {
                km = 20;
            }
            if (rbtn3.Checked)
            {
                km = 75;
            }
            lblkm.Text = km.ToString();
        }

        private void Rbtn1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtn2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtn3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txth_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
