using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Intro
{
    public partial class Form1 : Form
    {
        LoginForm loginForm = new LoginForm();

        public Form1()
        {
            InitializeComponent();
            Global.dataSQL1.TableToDGridView(pistolsDataGridView, "select * from pistols", "pistols");
            Global.dataSQL1.TableToDGridView(smgsDataGridView, "select * from smgs","smgs");
            loginForm.loggedIn += loggedInText;
        }

        public void updateOwnedData()
        {
            string idUser = Global.login1.idUser.ToString();
            Global.dataSQL1.TableToDGridView(ownedDataGridView, "select * from ((select ownership.operationtime, ownership.guntype, pistols.* from ownership INNER JOIN pistols ON ownership.gunid = pistols.id where userid = " + idUser + @" and guntype = 'pistol') union all (select ownership.operationtime, ownership.guntype, smgs.* from ownership INNER JOIN smgs ON ownership.gunid = smgs.id where userid = " + idUser + @" and guntype = 'smg') )a order by operationtime; ", "owned");

        }

        public void loggedInText()
        {
            currentUserLabel.Text = ("You logged in as "+Global.login1.currentUser+".");
            updateOwnedData();
            buyButton.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            preBuy();
        }

        public void preBuy()
        {
            int currentTab = tabControl1.SelectedIndex;
            string currentID;
            int price = 0;
            MySqlConnection connection = Global.connection;
            string query = "";
            MySqlCommand command = new MySqlCommand(query, connection);
            connection.Open();

            currentID = pistolsDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            switch (currentTab)
                {
                    case 0:
                        command.CommandText = "select price from pistols where id = "+ currentID;
                        Global.gunType = "pistol";
                        break;
                    case 1:
                        command.CommandText = "select price from smgs where id = " + currentID;
                        Global.gunType = "smg";
                        break;
                    case 2:
                        break;
                default:
                        break;
                }
            price = Convert.ToInt32(command.ExecuteScalar());
            command.CommandText = "select umoney from users where uid = " + Global.login1.idUser;
            if (Convert.ToInt32(command.ExecuteScalar()) - price >= 0)
            {
                buyButton.Hide();
                    cancelBuyButton.Show();
                    confirmBuyButton.Show();
                    buingInfoLabel.Text = ("This will cost you " + price + ". Proceed?");
                buingInfoLabel.Show();
                Global.price = price;
                Global.itemID = currentID;
            }
                else
                {
                    buingInfoLabel.Text = "You don't have enough money.";
                buingInfoLabel.Show();
            }
                connection.Close();
                connection.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            goToBuy();
        }

        void goToBuy()
        {
            Global.dataSQL1.Buing(Global.login1.idUser, Global.price, Global.itemID, Global.gunType);
            buingInfoLabel.Show();
            buingInfoLabel.Text = "Done!";
            buyButton.Show();
            cancelBuyButton.Hide();
            confirmBuyButton.Hide();
            updateOwnedData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buyButton.Show();
            cancelBuyButton.Hide();
            confirmBuyButton.Hide();
            buingInfoLabel.Hide();
        }
    }
}
