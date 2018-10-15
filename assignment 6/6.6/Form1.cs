using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtNumber.Text);
            RefAnswer(ref number);
            lblResult.Text = number.ToString();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtNumber.Text);
            int square = 0;
            OutAnswer(number, out square);
            lblResult.Text = square.ToString();
        }

        private void btnValue_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtNumber.Text);
            int square = ValueAnswer(number);
            lblResult.Text = square.ToString();
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        static void RefAnswer(ref int number)
        {
            number = number * number;
        }
        static void OutAnswer(int number, out int Answer)
        {
            Answer = number * number;
        }
        static int ValueAnswer(int num)
        {
            int result = num * num;
            return result;
        }
    }
}
