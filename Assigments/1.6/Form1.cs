using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string time = txtseconds.Text;
            int input = int.Parse(time);
            // print variable hours
            int hours = input / 3600;
            int RemainderMinInSec = hours * 3600;
            int remainderTotalSec = input - RemainderMinInSec;
            // variable min is the num to print in min
            int min = remainderTotalSec / 60;
            int totsec = min * 60;
            // variable sec is the num to print in sec
            int sec = remainderTotalSec - totsec;

            lblTimeIO.Text = hours.ToString() + " : " + min.ToString() + " : " + sec.ToString();
        }
    }
}
