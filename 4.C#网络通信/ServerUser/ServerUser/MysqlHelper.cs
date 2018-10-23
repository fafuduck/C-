using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ServerUser
{
    public static class MySqlHelper
    {

        private static string connStr = "data source=localhost;database=test;user id=root;password=123456;pooling=false;charset=utf8;";

        public static int Insert(string sql, params MySqlParameter[] ps)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddRange(ps);

                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

    }
}
