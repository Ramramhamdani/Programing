using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncal_Click(object sender, EventArgs e)
        {
            string input = txtsalary.Text;
            int salary = int.Parse(input);
            Double Raise = salary * 0.05;
            double newsalary;

            if (Raise<75)
            {
                newsalary = salary + 75;
            }
            else
            {
                newsalary = salary + Raise;
            }
            lblraise.Text = Raise.ToString("€0.00");
            lblnew.Text = newsalary.ToString("€0.00");

            
        }

        private void txtsalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblraise_Click(object sender, EventArgs e)
        {

        }

        private void lblnew_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
