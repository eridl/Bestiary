using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Bestiary
{
    class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 3306;
            string database = "test";
            string user = "root";
            string password = "root";

            return DBMySQLUtils.GetDBConnection(host, port, database, user, password);
        }
    }
}
