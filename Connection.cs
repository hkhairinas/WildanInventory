using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.Entity;
using MySql.Data.MySqlClient;

namespace WildanInventory
{
    class Connection
    {
        public string connect()
        {
            return "Server=localhost;Database=wildaninventory;Uid=root;Pwd=;";
         /*   var connection = new MySqlConnection("Server=localhost;Database=wildaninventory;Uid=root;Pwd=;");
            connection.Open();
            if (connection.State == System.Data.ConnectionState.Open)
            {
                Console.WriteLine("Connection is opened");
            }
            else
            {
                connection.Close();
            }*/
        }
            
    }
}
