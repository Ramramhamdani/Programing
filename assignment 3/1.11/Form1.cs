using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double first = Double.Parse(txtfirst.Text);
            Double second = Double.Parse(txtsecond.Text);

            Double ave = (first + second) / 2;
            Double dif;
            if (first > second)
            {
                lblhighest.Text = first.ToString();
                dif = first - ave;
                lbldifference.Text = dif.ToString();
                lblAverage.Text = ave.ToString();
            }
            else
            {
                lblhighest.Text = second.ToString();
                dif = second - ave;
                lbldifference.Text = dif.ToString();
                lblAverage.Text = ave.ToString();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
