using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            int age = int.Parse(txtAge.Text);
            double Star = 10.00;
            double john = 10.50;
            double pepp = 11.00;
            double total = 0;
            double discount = 0;

            if (rbtnStar.Checked)
            {
                //if A star is born is checked the price will be 10
                total = Star;
                if (age > 65)
                {
                    discount = total * 0.25;
                }
                total = total - discount;
            }
            else if (rbtnJohn.Checked)
            {
                //if Johnny English is checked the price will be 10.50
                total = john;
                if (age > 65)
                {
                    discount = total * 0.25;
                }
                total = total - discount;
            }
            else if (rbtnPepp.Checked)
            {
                //if Peppement is checked the price will be 10
                total = pepp;
                if (age > 65)
                {
                    discount = total * 0.25;
                }
                //subtract the value of the discount form the price
                total = total - discount;
            }
            lblPrice.Text = total.ToString("0.00");
        }
    }
}
