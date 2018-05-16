using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Intro
{
    public class Global
    {
        static public LoginLogout login1 = new LoginLogout();
        static public DataSQL dataSQL1 = new DataSQL();
        static public int price;
        static public string itemID;
        static public string gunType;
        static public MySqlConnection connection = new MySqlConnection("server=localhost;user id=band11;password=12345;database=weapon_shop;port=3306;");
    }
}
