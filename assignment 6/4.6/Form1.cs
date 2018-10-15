using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(txtnr1.Text);
            int number2 = int.Parse(txtnr2.Text);
            int answer = Multiple(number1, number2);
            lblResult.Text = answer.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(txtnr1.Text);
            int number2 = int.Parse(txtnr2.Text);
            int answer = Addition(number1, number2);
            lblResult.Text = answer.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(txtnr1.Text);
            int number2 = int.Parse(txtnr2.Text);
            int answer = Subtraction(number1, number2);
            lblResult.Text = answer.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(txtnr1.Text);
            int number2 = int.Parse(txtnr2.Text);
            double answer = Division(number1, number2);
            lblResult.Text = answer.ToString("0.00");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        static int Addition(int num1,int num2)
        {
            int result = 0;
            result = num1 + num2;
            return result;
        }
        static int Subtraction(int num1,int num2)
        {
            int result = 0;
            result = num1 - num2;
            return result;
        }
        static int Multiple(int num1, int num2)
        {
            int result = 0;
            result = num1 * num2;
            return result;
        }
        static double Division(double num1 , double num2)
        {
            double result = 0;
            result = num1 / num2;
            return result;
        }
    }
}
