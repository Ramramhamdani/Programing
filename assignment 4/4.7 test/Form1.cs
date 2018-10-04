using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4._7_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtsize_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            string side = txtsize.Text;
            int length = int.Parse(side);
            string output = "";


            if (length > 0)
            {
                for (int row = 1; row <= length; row++)
                {



                    for (int col = 1; col <= length; col++)
                    {


                        if ((row == 1 || row == length) || (col == 1 || col == length))
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
        }

        private void lblsquare_Click(object sender, EventArgs e)
        {

        }
    }
}
