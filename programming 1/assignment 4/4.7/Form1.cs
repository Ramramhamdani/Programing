using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtside_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSquare_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string side = txtside.Text;
            int length = int.Parse(side);
            string output = "";
            

            if (length > 0)
            {
                //the first "for" makes new line every time the number of the Xs equals the length
                 
                for (int row = 1; row <= length; row++)
                {

                    //the second "for" fills every line with the number of Xs
                   
                    for (int col=1;col<=length;col++)
                    {

                        
                        if ((row == 1 || row == length)||(col==1||col==length))
                        {
                            output = output + "X";

                        }

                        else 
                        {
                            output = output+" ";

                        }
                       
                        

                    }
                    output = output + "\n";
                    
                }

                lblSquare.Text = output;
                
            }
            
           
        }
    }
}
