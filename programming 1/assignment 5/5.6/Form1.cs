using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5._6
{
    public partial class Form1 : Form
    {
        int[] numbers = new int[20];

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string after = "";
            int count = 0;
            int input = int.Parse(txtnumber.Text);
            for (int i=0;i<numbers.Length;i++)
            {
                if (numbers[i]>=input)
                {
                    numbers[i] = numbers[i] + 10;
                }
                else if (numbers[i]<input)
                {
                    numbers[i] = numbers[i] + 5;
                }
                after = after + "Element " + count.ToString("00") + " = " + numbers[i].ToString()+"\n";
                count++;
            }
            lblafter.Text = after;
            btncompare.Enabled = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Random rnd = new Random();
            int count = 0;
            string label = "";
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(0, 500);
            }
            foreach (int item in numbers)
            {
                label = label + "Element " + count.ToString("00") + " = " + item.ToString() + "\n";
                count++;
            }
            lblbefore.Text = label;
        }
    }
}
