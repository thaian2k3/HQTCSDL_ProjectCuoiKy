using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CuoiKy
{
    internal class ConnectDatabase
    {
        private SqlConnection conn = new SqlConnection("Data Source=DESKTOP-U2CN98S\\SQLEXPRESS;Initial Catalog=HQTCSDL_Project;Integrated Security=True");

        public SqlConnection Conn { get => conn; set => conn = value; }

        public void OpenConnection()
        {
            if (Conn.State == ConnectionState.Closed)
            {
                Conn.Open();
            }
        }
        public void CloseConnection()
        {
            if (Conn.State == ConnectionState.Open)
            {
                Conn.Close();
            }
        }
    }
}
