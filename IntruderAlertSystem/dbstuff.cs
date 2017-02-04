using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarm
{
    class dbstuff
    {

        private static MySqlConnection con = null;

        public static MySqlConnection getDBConection()
        {
            if (con == null)
            {
                string connectionString = "Server=localhost;Database=alarm;Uid=sid;Pwd=Password1";
                con = new MySqlConnection(connectionString);
            }

            return con;
        }

    }
}
