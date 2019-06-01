using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using ChapeauDAL;
using ChapeauLogic;
using ChapeauModel;

namespace ChapeauUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Table_Service table_Service = new Table_Service();
            //List<Table> tables = table_Service.GetTables();
            Users_Service users_Service = new Users_Service();
            List<User> users = users_Service.GetUsers();

            lstTest.View = View.Details;
            lstTest.Columns.Add("employeeID");
            lstTest.Columns.Add("name");

            foreach (User table in users)
            {
                ListViewItem list = new ListViewItem(table.username.ToString());
                list.SubItems.Add(table.passwword.ToString());
                lstTest.Items.Add(list);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
