using System;
using System.IO;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Intro
    {
        public class LoginLogout
        {
            public string currentUser = "";
            public int idUser = -1;
            public bool isLoggedIn = false;
            public void logIn1(string lIn, string pIn)
            {
                string query = ("select * from users where uname = '"+lIn+"' and upass = '"+pIn+"'");
                MySqlConnection connection = Global.connection;
                MySqlCommand command1 = new MySqlCommand(query, connection);
                connection.Open();

                if (command1.ExecuteScalar() != null)
                {
                    string dbIdUser = command1.ExecuteScalar().ToString();
                    idUser = Convert.ToInt32(dbIdUser);
                    command1.CommandText = ("select uname from users where uid = '"+ dbIdUser + "'");
                    isLoggedIn = true;
                    currentUser = command1.ExecuteScalar().ToString();
                }
                connection.Close();
                connection.Dispose();
            }

            public void logOut()
            {
                isLoggedIn = false;
            }
        }
    }