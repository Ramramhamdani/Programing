using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauModel;
using ChapeauLogic;

namespace Login
{
    public partial class Bartender : Form
    {
        public Bartender(User user)
        {
            InitializeComponent();

            //show the table plan for the bartender
            pnlDirectOrder.Hide();
            pnlOrdered.Hide();
            pnlBartender.Show();

            //show the user ID
            lblEmployeeNum.Text = user.ID.ToString();

            Start();
        }
        void Start()
        {
            

            // color of the table 
            Table_Service table_Service = new Table_Service();
            List<Table> tables = table_Service.GetTables();


            foreach (Table table in tables)
            {
                if (table.tableID == 1)
                {
                    ChangeColor(table, btnTable1);
                }
                else if (table.tableID == 2)
                {
                    ChangeColor(table, btnTable2);
                }
                else if (table.tableID == 3)
                {
                    ChangeColor(table, btnTable3);
                }
                else if (table.tableID == 4)
                {
                    ChangeColor(table, btnTable4);
                }
                else if (table.tableID == 5)
                {
                    ChangeColor(table, btnTable5);
                }
                else if (table.tableID == 6)
                {
                    ChangeColor(table, btnTable6);
                }
                else if (table.tableID == 7)
                {
                    ChangeColor(table, btnTable7);
                }
                else if (table.tableID == 8)
                {
                    ChangeColor(table, btnTable8);
                }
                else if (table.tableID == 9)
                {
                    ChangeColor(table, btnTable9);
                }
                else if (table.tableID == 10)
                {
                    ChangeColor(table, btnTable10);
                }
            }
        }
        private void ChangeColor(Table table, Button button)
        {
            // Drinks IDs are from 7 to 10 (CategoryID)
            MenuItem_Service menuItem_Service = new MenuItem_Service();
            List<ChapeauModel.MenuItem> menuItems = menuItem_Service.GetItems(7, 10, table.tableID);

            switch (table.status)
            {
                case 2:
                    button.BackColor = Color.White;
                    break;
                case 0:
                    button.BackColor = Color.White;
                    break;
                case 1:
                    button.BackColor = Color.White;
                    break;
                case 3:
                    if (menuItems.Count == 0)
                    {
                        button.BackColor = Color.White;
                        break;
                    }
                    else
                    {
                        button.BackColor = Color.Violet;
                        break;
                    }
            }
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            this.Close();
            this.Hide();
            form.ShowDialog();
        }

        private void btnTable1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            TableOrders(button);
        }
        private void ShowPanel(Panel panelName)
        {
            //hide all panels
            pnlBartender.Hide();
            pnlOrdered.Hide();
            pnlDirectOrder.Hide();

            //show passed panel
            panelName.Show();
        }
        private void TableOrders(Button button)
        {
            List<Button> Buttons = TablesButtons();
            int tableNumber = Buttons.IndexOf(button) + 1;
            if (button.BackColor == Color.SeaGreen || button.BackColor == Color.Violet)
            {
                OrderItems_Service orderItems_Service = new OrderItems_Service();
                List<OrderItems> orderItems = orderItems_Service.GetOrderItems(7,10,tableNumber);
                lblOrderID.Text = orderItems[0].OrderID.ToString();

                ShowPanel(pnlOrdered);
                lblNumber.Text = tableNumber.ToString();
                MenuItem_Service menuItem_Service = new MenuItem_Service();
                List<ChapeauModel.MenuItem> menuItems = menuItem_Service.GetItems(7, 10, tableNumber);
                ListViewMenus(listViewCurrentDrinkOrder, "Drinks", menuItems);
            }
        }
        public List<Button> TablesButtons()
        {
            List<Button> buttons = new List<Button>();
            buttons.Add(btnTable1);
            buttons.Add(btnTable2);
            buttons.Add(btnTable3);
            buttons.Add(btnTable4);
            buttons.Add(btnTable5);
            buttons.Add(btnTable6);
            buttons.Add(btnTable7);
            buttons.Add(btnTable8);
            buttons.Add(btnTable9);
            buttons.Add(btnTable10);
            return buttons;
        }
        void ListViewMenus(ListView listview, string Header, List<ChapeauModel.MenuItem> menuList)
        {
            //Clear the listview before filling it again
            listview.Clear();
             
            //List view Allign
            listview.Columns.Add(Header);
            listview.Columns[0].Width = 800;
            listview.Columns.Add("name");
            listview.Columns[1].Width = 0;
            listview.Columns.Add("Stock");
            listview.Columns[2].Width = 0;
            listview.Columns.Add("CategoruID");
            listview.Columns[3].Width = 0;
            listview.Columns.Add("MenuItemID");
            listview.Columns[4].Width = 0;

            foreach (var Item in menuList)
            {
                ListViewItem li = new ListViewItem(Item.name);
                li.SubItems.Add(Item.name);
                li.SubItems.Add(Item.price.ToString());
                li.SubItems.Add(Item.stock.ToString());
                li.SubItems.Add(Item.CategoryID.ToString());
                li.SubItems.Add(Item.menuItemID.ToString());
                listview.Items.Add(li);
            }
        }

        private void lblDone_Click(object sender, EventArgs e)
        {
            int tableNumber = int.Parse(lblNumber.Text);
            int orderID = int.Parse(lblOrderID.Text);
            OrderItems_Service orderItems_Service = new OrderItems_Service();
            orderItems_Service.ChangeStatus(1, orderID, 28, 48);
            ShowPanel(pnlBartender);
            Start();
        }

        private void lblBackToTablesBar_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlBartender);
            Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Start();
        }
    }
}
