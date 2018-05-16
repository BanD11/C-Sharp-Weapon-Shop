using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intro
{
    public partial class LoginForm : Form
    {
        public delegate void LoginDelegate();
        public event LoginDelegate loggedIn;
        
        public LoginForm()
        {
            InitializeComponent();
            passwordTextBox.UseSystemPasswordChar = true;
            AcceptButton = okButton;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lIn = loginTextBox.Text;
            string pIn = passwordTextBox.Text;
            Global.login1.logIn1(lIn, pIn);
            if (Global.login1.isLoggedIn)
            {
                enterLoginPasswordLabel.Text = "You logged in!";
                loggedIn();
            }
            else
            {
                enterLoginPasswordLabel.Text = "Not logged in.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Global.login1.logOut();
            enterLoginPasswordLabel.Text = "You logged out.";
        }
    }
}
