using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double degree = double.Parse(txtnumber.Text);
            double result=0;
            if (rbtnCtoF.Checked==true)
            {
                result = CtoF(degree);
                lblResult.Text = result.ToString("0.00");
            }
            else if (rbtnCtoK.Checked==true)
            {
                result = Ctok(degree);
                lblResult.Text = result.ToString("0.00");
            }
            else if (rbtnFtoC.Checked==true)
            {
                result = FtoC(degree);
                lblResult.Text = result.ToString("0.00");   
            }
        }
        static double CtoF(double number)
        {
            double result = ((number * 9) / 5) + 32;
            return result;
        }
        static double Ctok(double number)
        {
            
            double result = number + 273;
            return result;
        }
        static double FtoC(double number)
        {
            double result = ((number - 32) * (5)) / 9;
            return result;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
