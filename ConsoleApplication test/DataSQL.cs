using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Intro
{
    public class DataSQL
    {
        public void TableToDGridView(DataGridView dataGridView, string query, string name)
        {
            MySqlConnection connection = Global.connection;
            connection.Open();
            MySqlDataAdapter dataAdapter;
            DataSet dataSet;
            dataAdapter = new MySqlDataAdapter(query, connection);
            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, name);
            dataGridView.DataSource = dataSet;
            dataGridView.DataMember = name;
            connection.Close();
            connection.Dispose();
        }

        public void Buing(int idUser, int price, string itemID, string gunType)
        {
            MySqlConnection connection = Global.connection;
            string query = "";
            connection.Open();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandText = "select umoney from users where uid = " + idUser;
            if (Convert.ToInt32(command.ExecuteScalar()) - price >= 0)
            {
                try
                {
                    command.CommandText = "insert into ownership (userid, gunid, guntype, operationtime) values (" + idUser + "," + itemID + ",'" + gunType + "',now()); update users set umoney = (umoney -" + price + ") where uid = " + idUser + ";";
                    command.ExecuteNonQuery();
                }
                catch (MySqlException e)
                {
                    switch (e.Number)
                    {
                        case 1062:
                            MessageBox.Show("Too fast! You can buy only one item per second. Try again");
                            break;
                    }
                }
            }
            connection.Close();
            connection.Dispose();
        }
    }
}
