using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._9
{
    public partial class Form1 : Form
    {
        const int fprice= 175;
        const int hprice = 225;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int totprice;
            int age = int.Parse(txtAge.Text);
            int member = int.Parse(txtMembership.Text);
            if (rbtnFootball.Checked==true)
            {
                         if ( age  > 40 && member>10)
                         {
                            totprice = fprice - 45;
                            lblFeePaid.Text = totprice.ToString("0.00");
                         }
                         else if (member>10)

                         {
                              totprice = fprice - 20;
                              lblFeePaid.Text = totprice.ToString("0.00");
                         }
                         else if (age>40)
                         {
                             totprice = fprice - 25;
                             lblFeePaid.Text = totprice.ToString("0.00");
                         }
                         else
                         {
                            totprice = fprice;
                            lblFeePaid.Text = totprice.ToString("0.00");
                         }

            }
            else if (rbtnHandball.Checked==true)
            {
                         if (age > 40 && member > 10)
                         {
                            totprice = hprice - 45;
                            lblFeePaid.Text = totprice.ToString("0.00");
                         }
                         else if (member > 10)
                         {
                            totprice = hprice - 20;
                             lblFeePaid.Text = totprice.ToString("0.00");
                         }
                         else if (age > 40)
                         {
                            totprice = hprice - 25;
                            lblFeePaid.Text = totprice.ToString("0.00");
                         }
                         else
                         {
                            totprice = hprice;
                            lblFeePaid.Text = totprice.ToString("0.00");
                          }
                
            }
            
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbtnHandball_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFeePaid_Click(object sender, EventArgs e)
        {

        }
    }
}
