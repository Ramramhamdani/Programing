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
                passwword = (string)txtPassword.Text
            };
            foreach (User item in users)
            {
                if (item.username==user.username && item.passwword == user.passwword)
                {
                    isUser = true;
                    break;
                }
            }
            if (isUser==true)
            {
                Hide();
                Waiter waiter = new Waiter();
                waiter.ShowDialog();
            }
            else
            {
                MessageBox.Show("invalid username or password");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
