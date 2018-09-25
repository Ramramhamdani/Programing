using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._12
{
    public partial class Form1 : Form
    {
        const int price = 12;
        public Form1()
        {
           
            InitializeComponent();
        }

        private void btncal_Click(object sender, EventArgs e)
        {
            int age = int.Parse(txtage.Text);
            Double final;
            if (age < 5 || age >=55)
            {
                final = price * 0;
                lblprice.Text = final.ToString("0.00");
            }
            else if (age>=5 && age<=12)
            {
                final = price * 0.5;
                lblprice.Text = final.ToString("0.00");
            }
            else if (age>=13 && age<=54)
            {
                final = price;
                lblprice.Text = final.ToString("0.00");
            }

        }
    }
}
