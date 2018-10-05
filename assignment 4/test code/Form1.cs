using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_code
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            int length = int.Parse(txtSize.Text);
            string output = "";
            for (int i = 1; i <= length; i++)
            {
                for (int j = 1; j <= length; j++)
                {
                    if (j==1||i==1||j==length||i==length)
                    {
                        output = output + "X";
                    }
                    else
                    {
                        output = output + " ";

                    }

                }
                output = output + "\n";
            }
            lblsquare.Text = output;
        }

        private void lblsquare_Click(object sender, EventArgs e)
        {

        }

        private void txtSize_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
