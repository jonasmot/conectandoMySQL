using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conectandoMysql
{
    public class BancoContext
    {
        MySqlConnection conn;
        string connection = "server = localhost; database = sucos; user = root; password =jh271142; port = 3306";



        public BancoContext()
        {
            conn = new MySqlConnection(connection);
            conn.Open();
        }

        public void OpenBD()
        {
            conn.Open();
        }

        public void CloseBD()
        {
            conn.Close();
        }

        public MySqlConnection GetConnection()
        {
            return conn;
        }
        
    }
}

