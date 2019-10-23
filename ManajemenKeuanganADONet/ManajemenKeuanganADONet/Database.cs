using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ManajemenKeuanganADONet
{
    class Database
    {
        public Database()
        {

        }
        public SqlConnection connect()
        {
            string connection_string = @"Data Source=BC104-PC\SQLEXPRESS;Initial Catalog=db_peternak;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connection_string);
            return conn;
        }

        public SqlCommand runQuery(String query)
        {
            SqlConnection conn = connect();
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            conn.Close();

            return cmd;
        }

    }
}
