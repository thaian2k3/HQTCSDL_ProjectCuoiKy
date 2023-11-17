using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Project_CuoiKy
{
    internal class ConnectDatabase
    {
        private SqlConnection conn = new SqlConnection($"Data Source=(local);Initial Catalog=HQTCSDL_Project;Integrated Security=True");
        private SqlConnection connByRole = new SqlConnection($"Data Source=(local);Initial Catalog=HQTCSDL_Project;User ID={ACCOUNT.Username};Password={ACCOUNT.Password}");

        public SqlConnection Conn { get => conn; set => conn = value; }
        public SqlConnection ConnByRole { get => connByRole; set => connByRole = value; }

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

        public void OpenConnectionByRole()
        {
            if (ConnByRole.State == ConnectionState.Closed)
            {
                ConnByRole.Open();
            }
        }
        public void CloseConnectionByRole()
        {
            if (ConnByRole.State == ConnectionState.Open)
            {
                ConnByRole.Close();
            }
        }
    }
}
