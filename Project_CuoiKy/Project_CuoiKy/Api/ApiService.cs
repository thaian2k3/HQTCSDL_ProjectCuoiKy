using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CuoiKy.Api
{
    internal class ApiService
    {
        private ConnectDatabase conn = new ConnectDatabase();
        public DataTable CreateTable(string query)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, conn.Conn);
            da.Fill(dt);
            return dt;
        }
        public bool ExecQuery(string query, string messageSuccess = "Thành công", bool showMessageBox = true)
        {
            try
            {
                conn.OpenConnection();
                SqlCommand cmd = new SqlCommand(query, conn.Conn);
                cmd.ExecuteNonQuery();
                if (showMessageBox)
                {
                    MessageBox.Show(messageSuccess, "Thông báo thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Thông báo lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return false;
            }
            finally { conn.CloseConnection(); }
        }
       
        public DataTable TimKiemKhachHang(string query)
        {
            try
            {
                conn.OpenConnection();
                DataTable dt = CreateTable(query);
                return dt;
            }
            finally { conn.CloseConnection(); }
        }

        public String FuncScalar(string query)
        {
            try
            {
                conn.OpenConnection();
                SqlCommand cmd = new SqlCommand(query, conn.Conn);
                return cmd.ExecuteScalar().ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Thông báo lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return null;
            }
            finally { conn.CloseConnection(); }
        }
    }
}

