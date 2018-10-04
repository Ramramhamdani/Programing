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
            int size = int.Parse(txtSize.Text);
            string x = "";
            
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size; j++)
                {
                    if (i==size||j==size||i==1|j==1)
                    {
                        x = x + "X";
                    }
                    else 
                    {
                        x = x + " ";
                    }
                   
                }
                x = x + "\n";
            }
            lblsquare.Text = x;
        }

        private void lblsquare_Click(object sender, EventArgs e)
        {

        }

        private void txtSize_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
