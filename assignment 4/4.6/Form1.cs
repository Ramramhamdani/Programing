﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int years = 0;
            double amount = double.Parse(txtamount.Text);
            while(years!=5)
            {
                years++;
                double capital = amount * 0.05;
                double final = amount + capital;
                amount = final;

            }
            
           
            lblFinal.Text = amount.ToString("€0.00");

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
