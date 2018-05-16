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
    public partial class Form2 : Form
    {
        public delegate void LoginDelegate();
        public event LoginDelegate loggedIn;
        public void eventTest()
        {
            
        }
        
        public Form2()
        {
            InitializeComponent();
            //label1.Text = "Enter login and password";
            textBox2.UseSystemPasswordChar = true;
            //button1.Text = "OK";
            this.AcceptButton = button1;
            
            //this.CancelButton = this.Close;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //LoginLogout login1 = new LoginLogout();
            //Data data1 = new Data();
            //data1.dataMain();
            string lIn = textBox1.Text;
            string pIn = textBox2.Text;
            Global.login1.logIn1(lIn, pIn);
            if (Global.login1.isLoggedIn)
            {
                label1.Text = "You logged in!";
                loggedIn();
            }
            else
            {
                label1.Text = "Not logged in.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //LoginLogout login1 = new LoginLogout();
            Global.login1.logOut();
            label1.Text = "You logged out.";
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
