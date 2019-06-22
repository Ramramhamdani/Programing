using ChapeauLogic;
using ChapeauModel;
using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Login
{
    public partial class Waiter : Form
    {

        public Waiter(User user)
        {
            // 0 = free, 1 = reserved, 2 = occupide, 3 = orderd

            InitializeComponent();
            // hide pnls
            pnlOrderdTable.Hide();
            pnlCurrentOrdersList.Hide();


            Table_Service table_Service = new Table_Service();
            List<Table> tables = table_Service.GetTables();


            foreach (Table table in tables)
            {
                if (table.tableID == 1)
                {
                    switch (table.status)
                    {
                        case 2:
                            btnTable1.BackColor = Color.DarkSeaGreen;
                            break;
                        case 0:
                            btnTable1.BackColor = Color.White;
                            break;
                        case 1:
                            btnTable1.BackColor = Color.IndianRed;
                            break;
                        case 3:
                            btnTable1.BackColor = Color.Violet;
                            break;
                    }
                }
                else if (table.tableID == 2)
                {
                    switch (table.status)
                    {
                        case 2:
                            btnTable2.BackColor = Color.DarkSeaGreen;
                            break;
                        case 0:
                            btnTable2.BackColor = Color.White;
                            break;
                        case 1:
                            btnTable2.BackColor = Color.IndianRed;
                            break;
                        case 3:
                            btnTable2.BackColor = Color.Violet;
                            break;
                    }
                }
                else if (table.tableID == 3)
                {
                    switch (table.status)
                    {
                        case 2:
                            btnTable3.BackColor = Color.DarkSeaGreen;
                            break;
                        case 0:
                            btnTable3.BackColor = Color.White;
                            break;
                        case 1:
                            btnTable3.BackColor = Color.IndianRed;
                            break;
                        case 3:
                            btnTable3.BackColor = Color.Violet;
                            break;
                    }
                }
                else if (table.tableID == 4)
                {
                    switch (table.status)
                    {
                        case 2:
                            btnTable4.BackColor = Color.DarkSeaGreen;
                            break;
                        case 0:
                            btnTable4.BackColor = Color.White;
                            break;
                        case 1:
                            btnTable4.BackColor = Color.IndianRed;
                            break;
                        case 3:
                            btnTable4.BackColor = Color.Violet;
                            break;
                    }
                }
                else if (table.tableID == 5)
                {
                    switch (table.status)
                    {
                        case 2:
                            btnTable5.BackColor = Color.DarkSeaGreen;
                            break;
                        case 0:
                            btnTable5.BackColor = Color.White;
                            break;
                        case 1:
                            btnTable5.BackColor = Color.IndianRed;
                            break;
                        case 3:
                            btnTable5.BackColor = Color.Violet;
                            break;
                    }
                }
                else if (table.tableID == 6)
                {
                    switch (table.status)
                    {
                        case 2:
                            btnTable6.BackColor = Color.DarkSeaGreen;
                            break;
                        case 0:
                            btnTable6.BackColor = Color.White;
                            break;
                        case 1:
                            btnTable6.BackColor = Color.IndianRed;
                            break;
                        case 3:
                            btnTable6.BackColor = Color.Violet;
                            break;
                    }
                }
                else if (table.tableID == 7)
                {
                    switch (table.status)
                    {
                        case 2:
                            btnTable7.BackColor = Color.DarkSeaGreen;
                            break;
                        case 0:
                            btnTable7.BackColor = Color.White;
                            break;
                        case 1:
                            btnTable7.BackColor = Color.IndianRed;
                            break;
                        case 3:
                            btnTable7.BackColor = Color.Violet;
                            break;
                    }
                }
                else if (table.tableID == 8)
                {
                    switch (table.status)
                    {
                        case 2:
                            btnTable8.BackColor = Color.DarkSeaGreen;
                            break;
                        case 0:
                            btnTable8.BackColor = Color.White;
                            break;
                        case 1:
                            btnTable8.BackColor = Color.IndianRed;
                            break;
                        case 3:
                            btnTable8.BackColor = Color.Violet;
                            break;
                    }
                }
                else if (table.tableID == 9)
                {
                    switch (table.status)
                    {
                        case 2:
                            btnTable9.BackColor = Color.DarkSeaGreen;
                            break;
                        case 0:
                            btnTable9.BackColor = Color.White;
                            break;
                        case 1:
                            btnTable9.BackColor = Color.IndianRed;
                            break;
                        case 3:
                            btnTable9.BackColor = Color.Violet;
                            break;
                    }
                }
                else if (table.tableID == 10)
                {
                    switch (table.status)
                    {
                        case 2:
                            btnTable10.BackColor = Color.DarkSeaGreen;
                            break;
                        case 0:
                            btnTable10.BackColor = Color.White;
                            break;
                        case 1:
                            btnTable10.BackColor = Color.IndianRed;
                            break;
                        case 3:
                            btnTable10.BackColor = Color.Violet;
                            break;
                    }
                }
            }
            // Employee number
            lblEmployeeNr.Text = user.ID.ToString();
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
        private void ChangeColor(int tableNumber)
        {
            // execute command from string source
            string source = "if (table.tableID == tableNumber)" +
                " {" +
                "   switch (table.status)" +
                "   {" +
                "       case true:" +
                $"           btnTable{tableNumber}.BackColor = Color.IndianRed;" +
                "           break;" +
                "       case false:" +
                $"           btnTable{tableNumber}.BackColor = Color.White;" +
                "           break;" +
                "   }" +
                " }";
            CSharpCodeProvider provider = new CSharpCodeProvider();
            CompilerParameters parameters = new CompilerParameters
            {
                GenerateInMemory = true,
                GenerateExecutable = false
            };
            CompilerResults compilerResults = provider.CompileAssemblyFromSource(parameters, source);
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
        private void btnTable1_Click_1(object sender, EventArgs e)
        {
            Table table = new Table();
            table.tableID = 1;
            //Check / unckeck / Colores
            // 0 = free.White , 1 = reserved.Red, 2 = occupide.Green, 3 = orderd.Violet
            if (checkBOccupide.Checked)
            {
                btnTable1.BackColor = Color.DarkSeaGreen;
                table.status = 2;
            }
            else if (checkBReserved.Checked)
            {
                btnTable1.BackColor = Color.IndianRed;
                table.status = 1;
            }
            else if (checkBFree.Checked)
            {
                btnTable1.BackColor = Color.White;
                table.status = 0;
            }
            else if (checkBOrdered.Checked)
            {
                btnTable1.BackColor = Color.Violet;
                table.status = 3;
            }
            else
            {
                if (btnTable1.BackColor == Color.Violet)
                {
                    pnlTablesPlan.Hide();
                    pnlOrderdTable.Show();
                }
                else if (btnTable1.BackColor == Color.DarkSeaGreen)
                {
                    pnlTablesPlan.Hide();
                }
            }
            /*------------------------------*/

            //reset Check boxes
            checkBOccupide.Checked = false;
            checkBReserved.Checked = false;
            checkBFree.Checked = false;
            checkBOrdered.Checked = false;
            //send to the database
            changeStatus(table);
        }

        private void btnTable2_Click_1(object sender, EventArgs e)
        {
            Table table = new Table();
            table.tableID = 2;
            //Check / unckeck / Colores
            // 0 = free.White , 1 = reserved.Red, 2 = occupide.Green, 3 = orderd.Violet
            if (checkBOccupide.Checked)
            {
                btnTable2.BackColor = Color.DarkSeaGreen;
                table.status = 2;
            }
            else if (checkBReserved.Checked)
            {
                btnTable2.BackColor = Color.IndianRed;
                table.status = 1;
            }
            else if (checkBFree.Checked)
            {
                btnTable2.BackColor = Color.White;
                table.status = 0;
            }
            else if (checkBOrdered.Checked)
            {
                btnTable2.BackColor = Color.Violet;
                table.status = 3;
            }
            else
            {
                if (btnTable2.BackColor == Color.Violet)
                {
                    pnlTablesPlan.Hide();
                    pnlOrderdTable.Show();
                }
                else if (btnTable2.BackColor == Color.DarkSeaGreen)
                {
                    pnlTablesPlan.Hide();
                }
            }
            /*------------------------------*/

            //reset Check boxes
            checkBOccupide.Checked = false;
            checkBReserved.Checked = false;
            checkBFree.Checked = false;
            checkBOrdered.Checked = false;
            //send to the database
            changeStatus(table);
        }

        private void btnTable3_Click_1(object sender, EventArgs e)
        {
            Table table = new Table();
            table.tableID = 3;
            //Check / unckeck / Colores
            // 0 = free.White , 1 = reserved.Red, 2 = occupide.Green, 3 = orderd.Violet
            if (checkBOccupide.Checked)
            {
                btnTable3.BackColor = Color.DarkSeaGreen;
                table.status = 2;
            }
            else if (checkBReserved.Checked)
            {
                btnTable3.BackColor = Color.IndianRed;
                table.status = 1;
            }
            else if (checkBFree.Checked)
            {
                btnTable3.BackColor = Color.White;
                table.status = 0;
            }
            else if (checkBOrdered.Checked)
            {
                btnTable3.BackColor = Color.Violet;
                table.status = 3;
            }
            else
            {
                if (btnTable3.BackColor == Color.Violet)
                {
                    pnlTablesPlan.Hide();
                    pnlOrderdTable.Show();
                }
                else if (btnTable3.BackColor == Color.DarkSeaGreen)
                {
                    pnlTablesPlan.Hide();
                }
            }
            /*------------------------------*/

            //reset Check boxes
            checkBOccupide.Checked = false;
            checkBReserved.Checked = false;
            checkBFree.Checked = false;
            checkBOrdered.Checked = false;
            //send to the database
            changeStatus(table);
        }

        private void btnTable4_Click_1(object sender, EventArgs e)
        {
            Table table = new Table();
            table.tableID = 4;
            //Check / unckeck / Colores
            // 0 = free.White , 1 = reserved.Red, 2 = occupide.Green, 3 = orderd.Violet
            if (checkBOccupide.Checked)
            {
                btnTable4.BackColor = Color.DarkSeaGreen;
                table.status = 2;
            }
            else if (checkBReserved.Checked)
            {
                btnTable4.BackColor = Color.IndianRed;
                table.status = 1;
            }
            else if (checkBFree.Checked)
            {
                btnTable4.BackColor = Color.White;
                table.status = 0;
            }
            else if (checkBOrdered.Checked)
            {
                btnTable4.BackColor = Color.Violet;
                table.status = 3;
            }
            else
            {
                if (btnTable4.BackColor == Color.Violet)
                {
                    pnlTablesPlan.Hide();
                    pnlOrderdTable.Show();
                }
                else if (btnTable4.BackColor == Color.DarkSeaGreen)
                {
                    pnlTablesPlan.Hide();
                }
            }
            /*------------------------------*/

            //reset Check boxes
            checkBOccupide.Checked = false;
            checkBReserved.Checked = false;
            checkBFree.Checked = false;
            checkBOrdered.Checked = false;
            //send to the database
            changeStatus(table);
        }

        private void btnTable5_Click_1(object sender, EventArgs e)
        {
            Table table = new Table();
            table.tableID = 5;
            //Check / unckeck / Colores
            // 0 = free.White , 1 = reserved.Red, 2 = occupide.Green, 3 = orderd.Violet
            if (checkBOccupide.Checked)
            {
                btnTable5.BackColor = Color.DarkSeaGreen;
                table.status = 2;
            }
            else if (checkBReserved.Checked)
            {
                btnTable5.BackColor = Color.IndianRed;
                table.status = 1;
            }
            else if (checkBFree.Checked)
            {
                btnTable5.BackColor = Color.White;
                table.status = 0;
            }
            else if (checkBOrdered.Checked)
            {
                btnTable5.BackColor = Color.Violet;
                table.status = 3;
            }
            else
            {
                if (btnTable5.BackColor == Color.Violet)
                {
                    pnlTablesPlan.Hide();
                    pnlOrderdTable.Show();
                }
                else if (btnTable5.BackColor == Color.DarkSeaGreen)
                {
                    pnlTablesPlan.Hide();
                }
            }
            /*------------------------------*/

            //reset Check boxes
            checkBOccupide.Checked = false;
            checkBReserved.Checked = false;
            checkBFree.Checked = false;
            checkBOrdered.Checked = false;
            //send to the database
            changeStatus(table);
        }

        private void btnTable6_Click_1(object sender, EventArgs e)
        {
            Table table = new Table();
            table.tableID = 6;

            //Check / unckeck / Colores
            // 0 = free.White , 1 = reserved.Red, 2 = occupide.Green, 3 = orderd.Violet
            if (checkBOccupide.Checked)
            {
                btnTable6.BackColor = Color.DarkSeaGreen;
                table.status = 2;
            }
            else if (checkBReserved.Checked)
            {
                btnTable6.BackColor = Color.IndianRed;
                table.status = 1;
            }
            else if (checkBFree.Checked)
            {
                btnTable6.BackColor = Color.White;
                table.status = 0;
            }
            else if (checkBOrdered.Checked)
            {
                btnTable6.BackColor = Color.Violet;
                table.status = 3;
            }
            else
            {
                if (btnTable6.BackColor == Color.Violet)
                {
                    pnlTablesPlan.Hide();
                    pnlOrderdTable.Show();
                }
                else if (btnTable6.BackColor == Color.DarkSeaGreen)
                {
                    pnlTablesPlan.Hide();
                }
            }
            /*------------------------------*/

            //reset Check boxes
            checkBOccupide.Checked = false;
            checkBReserved.Checked = false;
            checkBFree.Checked = false;
            checkBOrdered.Checked = false;
            //send to the database
            changeStatus(table);
        }

        private void btnTable7_Click_1(object sender, EventArgs e)
        {
            Table table = new Table();
            table.tableID = 7;
            //Check / unckeck / Colores
            // 0 = free.White , 1 = reserved.Red, 2 = occupide.Green, 3 = orderd.Violet
            if (checkBOccupide.Checked)
            {
                btnTable7.BackColor = Color.DarkSeaGreen;
                table.status = 2;
            }
            else if (checkBReserved.Checked)
            {
                btnTable7.BackColor = Color.IndianRed;
                table.status = 1;
            }
            else if (checkBFree.Checked)
            {
                btnTable7.BackColor = Color.White;
                table.status = 0;
            }
            else if (checkBOrdered.Checked)
            {
                btnTable7.BackColor = Color.Violet;
                table.status = 3;
            }
            else
            {
                if (btnTable7.BackColor == Color.Violet)
                {
                    pnlTablesPlan.Hide();
                    pnlOrderdTable.Show();
                }
                else if (btnTable7.BackColor == Color.DarkSeaGreen)
                {
                    pnlTablesPlan.Hide();
                }
            }
            /*------------------------------*/

            //reset Check boxes
            checkBOccupide.Checked = false;
            checkBReserved.Checked = false;
            checkBFree.Checked = false;
            checkBOrdered.Checked = false;
            //send to the database
            changeStatus(table);
        }

        private void btnTable8_Click_1(object sender, EventArgs e)
        {
            Table table = new Table();
            table.tableID = 8;
            //Check / unckeck / Colores
            // 0 = free.White , 1 = reserved.Red, 2 = occupide.Green, 3 = orderd.Violet
            if (checkBOccupide.Checked)
            {
                btnTable8.BackColor = Color.DarkSeaGreen;
                table.status = 2;
            }
            else if (checkBReserved.Checked)
            {
                btnTable8.BackColor = Color.IndianRed;
                table.status = 1;
            }
            else if (checkBFree.Checked)
            {
                btnTable8.BackColor = Color.White;
                table.status = 0;
            }
            else if (checkBOrdered.Checked)
            {
                btnTable8.BackColor = Color.Violet;
                table.status = 3;
            }
            else
            {
                if (btnTable8.BackColor == Color.Violet)
                {
                    pnlTablesPlan.Hide();
                    pnlOrderdTable.Show();
                }
                else if (btnTable8.BackColor == Color.DarkSeaGreen)
                {
                    pnlTablesPlan.Hide();
                }
            }
            /*------------------------------*/

            //reset Check boxes
            checkBOccupide.Checked = false;
            checkBReserved.Checked = false;
            checkBFree.Checked = false;
            checkBOrdered.Checked = false;
            //send to the database
            changeStatus(table);
        }

        private void btnTable9_Click(object sender, EventArgs e)
        {
            Table table = new Table();
            table.tableID = 9;
            //Check / unckeck / Colores
            // 0 = free.White , 1 = reserved.Red, 2 = occupide.Green, 3 = orderd.Violet
            if (checkBOccupide.Checked)
            {
                btnTable9.BackColor = Color.DarkSeaGreen;
                table.status = 2;
            }
            else if (checkBReserved.Checked)
            {
                btnTable9.BackColor = Color.IndianRed;
                table.status = 1;
            }
            else if (checkBFree.Checked)
            {
                btnTable9.BackColor = Color.White;
                table.status = 0;
            }
            else if (checkBOrdered.Checked)
            {
                btnTable9.BackColor = Color.Violet;
                table.status = 3;
            }
            else
            {
                if (btnTable9.BackColor == Color.Violet)
                {
                    pnlTablesPlan.Hide();
                    pnlOrderdTable.Show();
                }
                else if (btnTable9.BackColor == Color.DarkSeaGreen)
                {
                    pnlTablesPlan.Hide();
                }
            }
            /*------------------------------*/
            //reset Check boxes
            checkBOccupide.Checked = false;
            checkBReserved.Checked = false;
            checkBFree.Checked = false;
            checkBOrdered.Checked = false;
            //send to the database
            changeStatus(table);
        }

        private void btnTable10_Click_1(object sender, EventArgs e)
        {
            Table table = new Table();
            table.tableID = 10;
            //Check / unckeck / Colores
            // 0 = free.White , 1 = reserved.Red, 2 = occupide.Green, 3 = orderd.Violet
            if (checkBOccupide.Checked)
            {
                btnTable10.BackColor = Color.DarkSeaGreen;
                table.status = 2;
            }
            else if (checkBReserved.Checked)
            {
                btnTable10.BackColor = Color.IndianRed;
                table.status = 1;
            }
            else if (checkBFree.Checked)
            {
                btnTable10.BackColor = Color.White;
                table.status = 0;
            }
            else if (checkBOrdered.Checked)
            {
                btnTable10.BackColor = Color.Violet;
                table.status = 3;
            }
            else
            {
                if (btnTable10.BackColor == Color.Violet)
                {
                    pnlTablesPlan.Hide();
                    pnlOrderdTable.Show();
                }
                else if (btnTable10.BackColor == Color.DarkSeaGreen)
                {
                    pnlTablesPlan.Hide();
                }
            }
            /*------------------------------*/

            //reset Check boxes
            checkBOccupide.Checked = false;
            checkBReserved.Checked = false;
            checkBFree.Checked = false;
            checkBOrdered.Checked = false;
            //send to the database
            changeStatus(table);
        }

        private void btnOccupide_Click_1(object sender, EventArgs e)
        {
            // check / uncheck / reset
            if (checkBOccupide.Checked == true)
            {
                checkBOccupide.Checked = false;
            }
            else
            {
                checkBOccupide.Checked = true;
                checkBReserved.Checked = false;
                checkBFree.Checked = false;
                checkBOrdered.Checked = false;
            }
            /*------------------------------*/
        }

        private void btnReserved_Click_1(object sender, EventArgs e)
        {
            // check / uncheck / reset
            if (checkBReserved.Checked == true)
            {
                checkBReserved.Checked = false;
            }
            else
            {
                checkBReserved.Checked = true;
                checkBOccupide.Checked = false;
                checkBFree.Checked = false;
                checkBOrdered.Checked = false;
            }
            /*------------------------------*/
        }

        private void btnFree_Click_1(object sender, EventArgs e)
        {
            // check / uncheck / reset
            if (checkBFree.Checked == true)
            {
                checkBFree.Checked = false;
            }
            else
            {
                checkBFree.Checked = true;
                checkBOccupide.Checked = false;
                checkBReserved.Checked = false;
                checkBOrdered.Checked = false;
            }
            /*------------------------------*/
        }

        private void btnOrdered_Click_1(object sender, EventArgs e)
        {
            // check / uncheck / reset
            if (checkBOrdered.Checked == true)
            {
                checkBOrdered.Checked = false;
            }
            else
            {
                checkBOrdered.Checked = true;
                checkBOccupide.Checked = false;
                checkBReserved.Checked = false;
                checkBFree.Checked = false;
            }
            /*------------------------------*/
        }

        private void lblBackToPlan_Click(object sender, EventArgs e)
        {
            //Hiding panels
            pnlOrderdTable.Hide();
            pnlTablesPlan.Show();




        }

        private void btnCash_Click(object sender, EventArgs e)
        {

        }

        private void btnCurrentOrder_Click(object sender, EventArgs e)
        {
            pnlOrderdTable.Hide();
            pnlTablesPlan.Hide();
            pnlCurrentOrdersList.Show();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            pnlOrderdTable.Show();
            pnlTablesPlan.Hide();
            pnlCurrentOrdersList.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
