using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._5
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

        private void btnAverage_Click(object sender, EventArgs e)
        {
            string one = txt1st.Text;
            string two = txt2nd.Text;
            string three = txt3rd.Text;
            double a = double.Parse(one);
            double b = double.Parse(two);
            double c = double.Parse(three);
            double AddAnswer = a + b + c;
            double finalAnswer = AddAnswer / 3;
            lblAverage.Text = finalAnswer.ToString("0.00");

            
        }

        private void txt1st_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt2nd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt3rd_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAverage_Click(object sender, EventArgs e)
        {

        }
    }
}
