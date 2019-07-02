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

namespace Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            bool isUser = false;
            Users_Service users_Service = new Users_Service();
            List<User> users = users_Service.GetUsers();
            User user = new User()
            {
                username = (string)txtUsername.Text,
                passwword = (string)txtPassword.Text,
            };
            
            foreach (User item in users)
            {
                if (item.username==user.username && item.passwword == user.passwword)
                {
                    isUser = true;
                    //user function
                    user.ID = item.ID;
                    user.type = users_Service.GetTask(user);
                    break;
                }
            }
            if (isUser==true)
            {
                
                if (user.type == "waiter")
                {
                    Hide();
                    Waiter waiter = new Waiter(user);
                    waiter.ShowDialog();
                }
                else if (user.type == "chef")
                {
                    Hide();
                    Chef chef = new Chef(user);
                    chef.ShowDialog();
                }
                else if (user.type == "bartender")
                {
                    Hide();
                    Bartender bartender = new Bartender(user);
                    bartender.ShowDialog();
                }
                
            }
            else
            {
                MessageBox.Show("invalid username or password");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
