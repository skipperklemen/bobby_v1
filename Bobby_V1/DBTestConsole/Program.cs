using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DBTestConsole {
    class Program {
        static void Main(string[] args) {

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection("server=localhost;database=khbobby;uid=root;password=Tavata");

            //open the connection
            connection.Open();

            //query
            string sql = "SELECT * FROM khuser";
            var cmd = new MySqlCommand(sql, connection);

            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read()) {
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", rdr.GetString(0), rdr.GetString(1), rdr.GetString(2),
                        rdr.GetString(3), rdr.GetInt32(4), rdr.GetString(5), rdr.GetString(6));
            }

            Console.ReadLine();

            //close the connection
            connection.Close();
        }
    }
}
