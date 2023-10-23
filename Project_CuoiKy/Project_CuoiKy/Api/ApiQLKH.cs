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
    internal class ApiQLKH
    {
        ConnectDatabase conn = new ConnectDatabase();
        public DataTable CreateTable(string query)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, conn.Conn);
            da.Fill(dt);
            return dt;
        }

        public bool ThemKhachHang(string MaKH, string TenKH, string MatKhau)
        {
            try
            {
                conn.OpenConnection();
                string query = $"EXEC dbo.ThemKhachHang '{MaKH}', '{TenKH}', '{MatKhau}'";
                SqlCommand cmd = new SqlCommand(query, conn.Conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Thông báo lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return false;
            }
            finally { conn.CloseConnection(); }
        }
        public bool SuaThongTin(string MaKH, string TenKH, string MatKhau)
        {
            try
            {
                conn.OpenConnection();
                string query = $"EXEC dbo.SuaThongTinKhachHang '{MaKH}', '{TenKH}', '{MatKhau}'";
                SqlCommand cmd = new SqlCommand(query, conn.Conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Lưu thông tin thành công", "Thông báo thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Thông báo lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return false;
            }
            finally { conn.CloseConnection(); }
        }
        public bool XoaKhachHang(string MaKH)
        {
            try
            {
                conn.OpenConnection();
                string query = $"DELETE from KhachHang WHERE MaKH = '{MaKH}'";
                SqlCommand cmd = new SqlCommand(query, conn.Conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa khách hàng thành công", "Thông báo thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Thông báo lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return false;
            }
            finally { conn.CloseConnection(); }
        }
        public DataTable TimKiemKhachHang(string information)
        {
            try
            {
                conn.OpenConnection();
                string query = $"SELECT * FROM dbo.func_TimKhachHang('{information}')";
                DataTable dt = CreateTable(query);
                return dt;
            }
            finally { conn.CloseConnection(); }
        }
    }
}

