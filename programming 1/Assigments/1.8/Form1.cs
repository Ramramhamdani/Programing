using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._8
{
    public partial class Form1 : Form
    {
        const double shirt = 30.00;
        const double jeans = 100.00;
        const double VAT = 0.21;

        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputJ = txtJprice.Text;
            string inputT = txtTprice.Text;
            double nrJeans = double.Parse(inputJ);
            double nrTshirts = double.Parse(inputT);
            //the price without VAT

            double priceEX = (jeans * nrJeans) + (shirt * nrTshirts);
            //adding VAT

            double VATpc = priceEX * VAT;
            double total = VATpc + priceEX;

            txtPrice.Text = priceEX.ToString("0.00");
            txtVAT.Text = VATpc.ToString("0.00");
            txtTotalprice.Text = total.ToString("0.00");
            // time and date now 
            lbltime.Text = DateTime.Now.ToString("hh:mm: dd-mm-yyyy");


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_Click(object sender, EventArgs e)
        {

        }

        private void txtVAT_Click(object sender, EventArgs e)
        {

        }

        private void txtTotalprice_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbltime_Click(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToString("hh:mm: dd-mm-yyyy");
        }
    }
}
