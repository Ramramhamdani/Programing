using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._4
{
    public partial class Form1 : Form
    {
        const double VAT = 0.21;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {
            string input = txtprice.Text;
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            string input = txtprice.Text;
            double VAT = 0.21;
            double price = double.Parse(input);
            double VATOnPrice = price * VAT;
            double total = VATOnPrice + price;

            lblVAT.Text =VATOnPrice.ToString();
            lblPrice.Text = input.ToString();
            lbltotal.Text = total.ToString();

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {
            lblPrice.Text = txtprice.ToString();
        }

        private void lblVAT_Click(object sender, EventArgs e)
        {
           
        }

        private void lbltotal_Click(object sender, EventArgs e)
        {

        }
    }
}
