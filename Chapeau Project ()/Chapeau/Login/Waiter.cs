using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauLogic;
using ChapeauModel;
using System.Diagnostics;
using System.Reflection;
using System.CodeDom.Compiler;
using Microsoft.CSharp;

namespace Login
{
    public partial class Waiter : Form
    {
        public Waiter(User user)
        {
            // 0 = free, 1 = reserved, 2 = occupide, 3 = orderd

            InitializeComponent();

            //Hide and show pnls
            ShowHidePnl(pnlTablesPlan);

            Start();
            
            // Employee number
            lblEmployeeNr.Text = user.ID.ToString();
        }
        void Start()
        {
            Table_Service table_Service = new Table_Service();
            List<Table> tables = table_Service.GetTables();
            List<Button> buttons = TablesButtons();

            int buttonNumber = 1;

            foreach (Table table in tables)
            {
                if (table.tableID == buttonNumber)
                {
                    ChangeColor(table, buttons[buttonNumber - 1]);
                }
                buttonNumber++;
            }
        }

        void TableColor(Table table, Button button)
        {            
            //Check / unckeck / Colores
            // 0 = free.White , 1 = reserved.Red, 2 = occupide.Green, 3 = orderd.Violet
            if (checkBOccupide.Checked)
            {
                button.BackColor = Color.DarkSeaGreen;
                table.status = 2;
                //Send to database
                changeStatus(table);
            }
            else if (checkBReserved.Checked)
            {
                button.BackColor = Color.IndianRed;
                table.status = 1;
                //Send to database
                changeStatus(table);
            }
            else if (checkBFree.Checked)
            {
                button.BackColor = Color.White;
                table.status = 0;
                //Send to database
                changeStatus(table);
            }
            else if (checkBOrdered.Checked)
            {
                button.BackColor = Color.Violet;
                table.status = 3;
                //Send to database
                changeStatus(table);
            }                
            else
            {
                //Opens tables order
                TablesOrder(button);
            }            
        }
        void TablesOrder(Button button)
        {
            if (button.BackColor == Color.Violet)
            {
                ShowHidePnl(pnlOrderdTable);              
            }
            else if (button.BackColor == Color.DarkSeaGreen)
            {
                ShowHidePnl(pnlOrderMenu);               
            }
        }
        void ShowHidePnl(Panel pnlName)
        {
            //Hide pnl
            pnlCurrentOrdersList.Hide();
            pnlCurrentOrderSubmition.Hide();
            pnlDinnerMenu.Hide();
            pnlLunchMenu.Hide();
            pnlDrinksMenu.Hide();
            pnlOrderdTable.Hide();
            pnlOrderMenu.Hide();
            pnlTablesPlan.Hide();

            //Show pnl
            pnlName.Show();

        }
        void ListViewMenus(ListView listview, string Header, List<ChapeauModel.MenuItem> menuList)
        {
            //Clear the listview before filling it again
            listview.Clear();

            //List view Allign
            listview.Columns.Add(Header);
            listview.Columns[0].Width = 800;
            listview.Columns.Add("Price");
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
        
        ChapeauModel.MenuItem ListViewSelectedMenuItem(ListView listview)
        {
            string listName = listview.SelectedItems[0].SubItems[1].Text;
            decimal listPrice = decimal.Parse(listview.SelectedItems[0].SubItems[2].Text);
            int listStock = int.Parse(listview.SelectedItems[0].SubItems[3].Text);
            int listCategory = int.Parse(listview.SelectedItems[0].SubItems[4].Text);
            int listID = int.Parse(listview.SelectedItems[0].SubItems[5].Text);
            
            
            ChapeauModel.MenuItem item = new ChapeauModel.MenuItem(listName, listPrice, listStock, listCategory, listID);
            return item;
        } 
        void ResetCheckBoxes()
        {
            //reset Check boxes
            checkBOccupide.Checked = false;
            checkBReserved.Checked = false;
            checkBFree.Checked = false;
            checkBOrdered.Checked = false;
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
        

        private void ChangeColor(Table table, Button button)
        {
            switch (table.status)
            {
                case 2:
                    button.BackColor = Color.DarkSeaGreen;
                    break;
                case 0:
                    button.BackColor = Color.White;
                    break;
                case 1:
                    button.BackColor = Color.IndianRed;
                    break;
                case 3:
                    button.BackColor = Color.Violet;
                    break;
            }
        }
        private void lblLogout_Click_1(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            this.Close();
            login.ShowDialog();
        }

        private void changeStatus(Table table)
        {
            Table_Service table_Service = new Table_Service();
            table_Service.UpdateStatus(table);
            
        }
        private void btnTables_click(object sender, EventArgs e)
        {
            Table table = new Table();
            List<Button> buttons = TablesButtons();
            var btn = (Button)sender;

            int f = 0;
            for (int i = 1; i < 11; i++)
            {
                if (btn.Name == buttons[i-1].Name)
                {
                    table.tableID = i;
                    continue;
                }                               
            }
            //Open tables Order
            TableColor(table, btn);
            ResetCheckBoxes();
        }
        void ShowHideCheckBox(CheckBox checkBox)
        {
            if (checkBox.Checked == true)
            {
                checkBox.Checked = false;
            }
            else
            {
                //Checking all boxes off
                checkBFree.Checked = false;
                checkBOccupide.Checked = false;
                checkBOrdered.Checked = false;
                checkBReserved.Checked = false;

                //checking on the needed box
                checkBox.Checked = true;
            }
        }
        void btnTableStatus(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            CheckBox checkBox = new CheckBox();
            
            switch (btn.Name)
            {
                case "btnOccupide":
                    checkBox=checkBOccupide;
                    break;
                case "btnReserved":
                    checkBox = checkBReserved;
                    break;
                case "btnFree":
                    checkBox = checkBFree;
                    break;
                case "btnOrdered":
                    checkBox = checkBOrdered;
                    break;
                default:
                    break;
            }
            //
            ShowHideCheckBox(checkBox);
        }       
        private void lblBackToPlan_Click(object sender, EventArgs e)
        {
            ShowHidePnl(pnlTablesPlan);
        }

        private void btnCash_Click(object sender, EventArgs e)
        {

        }

        private void btnCurrentOrder_Click(object sender, EventArgs e)
        {
            //Hide show pnl
            ShowHidePnl(pnlCurrentOrdersList);
            //Listview

        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            //Hide show pnl
            ShowHidePnl(pnlOrderdTable);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            //Hide show pnl
            ShowHidePnl(pnlOrderMenu);


        }
        
        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            //Hide show pnl
            ShowHidePnl(pnlOrderdTable);
        }

        private void lblBackToMenusPage_Click(object sender, EventArgs e)
        {
            //Hide show pnl
            ShowHidePnl(pnlOrderMenu);
        }

        private void lblBackToMenuOrder_Click(object sender, EventArgs e)
        {
            //Hide show pnl
            ShowHidePnl(pnlOrderMenu);
        }

        private void lblBackToMenusPage1_Click(object sender, EventArgs e)
        {
            //Hide show pnl
            ShowHidePnl(pnlOrderMenu);
        }

        private void lblBackToOrderMenu_Click(object sender, EventArgs e)
        {
            //Hide show pnl
            ShowHidePnl(pnlTablesPlan);
        }
        void btnMenuPanelNavigator(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            Panel panel = new Panel();
            
            switch (btn.Name)
            {
                case "btnLunchMenu":
                    panel = pnlLunchMenu;
                    break;
                case "btnDinnerMenu":
                    panel = pnlDinnerMenu;
                    break;
                case "btnDrinks":
                    panel = pnlDrinksMenu;
                    break;                
                default:
                    break;
            }
            ShowHidePnl(panel);
        }       
        private void btnCurrentOrder1_Click(object sender, EventArgs e)
        {
            //Hide show pnl
            ShowHidePnl(pnlCurrentOrderSubmition);

            //Current menu listview
            MenuItem_Service MenuItemService = new MenuItem_Service();
            List<ChapeauModel.MenuItem> MenuOrderList = MenuItemService.GetLunchItems();

            // List view method
            ListViewMenus(listViewCurrentOrderSubmition, "Current Order", MenuOrderList);
        }
        void AddItemBtn(object sender, EventArgs e)
        {
            ChapeauModel.MenuItem item = new ChapeauModel.MenuItem();

            item = ListViewSelectedMenuItem(listViewDinnerMenu);

            OrderItems_Service orderItems = new OrderItems_Service();
            List<OrderItems> orderItemsList = orderItems.GetOrderItems(item.menuItemID);

            

        }
        private void btnAddDrinks_Click(object sender, EventArgs e)
        {
            
        }

        private void listViewDrinksMenu_SelectedIndexChanged(object sender, EventArgs e)
        { 
        }

        private void lblBackToMenus_Click(object sender, EventArgs e)
        {
            //Hide show panels
            ShowHidePnl(pnlOrderMenu);
        }
        void MenuPanelIdicator(int categoryID, ListView menuListview, Panel menuPanel, string menuName)
        {
            if (categoryID == 4 || categoryID == 5 || categoryID == 6)
            {
                menuListview = listViewDinnerMenu;
                menuPanel = pnlDinnerMenu;
            }
            else if (categoryID == 1 || categoryID == 2 || categoryID == 3)
            {
                menuListview = listViewLunchMenu;
                menuPanel = pnlLunchMenu;
            }
            else
            {
                menuListview = listViewDrinksMenu;
                menuPanel = pnlDrinksMenu;
            }
            //Hide show pnl
            ShowHidePnl(menuPanel);

            //menu listview
            MenuItem_Service menuItemService = new MenuItem_Service();
            List<ChapeauModel.MenuItem> MenuList = menuItemService.GetMenuItems(categoryID);

            //List view method
            ListViewMenus(menuListview, menuName, MenuList);
        }
        private void btnMenusIndicator(object sender, EventArgs e)
        {           
            //ID and name are used to indicates and show the btn type 
            int categoryID = 0;
            string menuName = "";

            //ListView, panel  setter
            ListView menuListview = new ListView();
            Panel menuPanel = new Panel();

            var btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnDinnerStarters":
                    categoryID = 4;
                    menuName = "Starters";                    
                    break;
                case "btnDinnerMains":
                    categoryID = 5;
                    menuName = "Dinner Mains";                   
                    break;                
                case "btnDinnerDesserts":
                    categoryID = 6;
                    menuName = "Desserts";                    
                    break;
                case "btnLunchBites":
                    categoryID = 3;
                    menuName = "Bites";
                    break;
                case "btnLunchMain":
                    categoryID = 1;
                    menuName = "Lunch Main";
                    break;
                case "btnLunchSpecials":
                    categoryID = 2;
                    menuName = "Specials";
                    break;
                case "btnDrinksBeers":
                    categoryID = 8;
                    menuName = "Beers";                   
                    break;
                case "btnDrinksHotDrinks":
                    categoryID = 10;
                    menuName = "Hot Drinks";                    
                    break;
                case "btnDrinksSoftDrinks":
                    categoryID = 7;
                    menuName = "Soft Drinks";                   
                    break;
                case "btnDrinksWines":
                    categoryID = 9;
                    menuName = "Wines";                    
                    break;
                default:
                    break;
            }
            //Panel and listview setter
            MenuPanelIdicator(categoryID, menuListview, menuPanel, menuName);                        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Start();
        }
    }
}
