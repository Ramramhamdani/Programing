using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = 0;
            int[] dice = new int[6];
            string ountput = "";
            int count = 0;
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = 0;
            }
            Random rnd = new Random();
            while (count < 6000)
            {
                
                    number = rnd.Next(1, 7);
                    if (number == 1)
                    {
                        dice[0]++;
                    }
                    else if (number == 2)
                    {
                        dice[1]++;
                    }
                    else if (number == 3)
                    {
                        dice[2]++;
                    }
                    else if (number == 4)
                    {
                        dice[3]++;
                    }
                    else if (number == 5)
                    {
                        dice[4]++;
                    }
                    else if (number == 6)
                    {
                        dice[5]++;
                    }

                
                count++;
            }
            lblAnswer.Text = "Number of throws of value 1 = " + dice[0] + "\n" +
                "Number of throws of value 2 = " + dice[1] + "\n" + "Number of throws of value 3 = " + dice[2] + "\n"
                + "Number of throws of value 4 = " + dice[3] + "\n" + "Number of throws of value 5 = " + dice[4] + "\n"
                + "Number of throws of value 6 = " + dice[5] + "\n";
        }
    }
}
