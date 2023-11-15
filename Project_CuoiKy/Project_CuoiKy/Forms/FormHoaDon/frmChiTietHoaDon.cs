using Project_CuoiKy.Api;
using Project_CuoiKy.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Không có gì hết
namespace Project_CuoiKy.Forms.FormHoaDon
{
    public partial class frmChiTietHoaDon : Form
    {
        private Api.ApiService api = new Api.ApiService();
        private Helpers helpers = new Helpers();
        private string maHD;
        public frmChiTietHoaDon()
        {
            InitializeComponent();
        }
        public frmChiTietHoaDon(string maHD)
        {
            InitializeComponent();
            this.maHD = maHD;
            LoadData();
        }
        public void LoadData()
        {
            string query = $"SELECT * FROM func_InChiTietHoaDon({maHD})";
            dgvChiTietBaoTri.DataSource = api.CreateTable(query);
        }

        private void dgvChiTietHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSoLuong.Texts = helpers.DataInCol(dgvChiTietBaoTri, "SoLuong");
            if (e.ColumnIndex == dgvChiTietBaoTri.Columns["dgvXoaHoaDon"].Index)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa chi tiết hóa đơn không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string maHD = helpers.DataInCol(dgvChiTietBaoTri, "MaHoaDon");
                    string maSP = helpers.DataInCol(dgvChiTietBaoTri, "MaSP");
                    string query = $"DELETE from ChiTietHoaDon WHERE MaHD = '{maHD}' AND MaSP = '{maSP}'";
                    api.ExecQuery(query, "Xóa chi tiết hóa đơn thành công");
                    LoadData();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtSoLuong.Texts.Length > 0)
            {
                string maHD = helpers.DataInCol(dgvChiTietBaoTri, "MaHoaDon");
                string maSP = helpers.DataInCol(dgvChiTietBaoTri, "MaSP");
                string query = $"UPDATE ChiTietHoaDon SET SoLuong = {txtSoLuong.Texts} WHERE MaHD = '{maHD}' AND MaSP = '{maSP}'";
                api.ExecQuery(query, "Sửa chi tiết hóa đơn thành công");
                LoadData();
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xác nhận hóa đơn không?", "Xác nhận thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string query = $"UPDATE HoaDon SET TinhTrang = N'Đã thanh toán' WHERE MaHD='{maHD}'";
                api.ExecQuery(query, "Thanh toán hóa đơn thành công");
                btnThanhToan.Enabled = false;
                LoadData();
            }
        }

        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {

        }

        private void dgvChiTietHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
