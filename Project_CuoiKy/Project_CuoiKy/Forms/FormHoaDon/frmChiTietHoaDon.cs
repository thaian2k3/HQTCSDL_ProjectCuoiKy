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
            dgvChiTietHoaDon.DataSource = api.CreateTable(query);
        }

        private void dgvChiTietHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSoLuong.Texts = helpers.DataInCol(dgvChiTietHoaDon, "SoLuong");
            if (e.ColumnIndex == dgvChiTietHoaDon.Columns["dgvXoaHoaDon"].Index)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa phòng không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string maHD = helpers.DataInCol(dgvChiTietHoaDon, "MaHoaDon");
                    string maSP = helpers.DataInCol(dgvChiTietHoaDon, "MaSP");
                    string query = $"DELETE from ChiTietHoaDon WHERE MaHD = '{maHD}' AND MaSP = '{maSP}'";
                    api.ExecQuery(query, "Xóa phòng thành công");
                    LoadData();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtSoLuong.Texts.Length > 0)
            {
                string maHD = helpers.DataInCol(dgvChiTietHoaDon, "MaHoaDon");
                string maSP = helpers.DataInCol(dgvChiTietHoaDon, "MaSP");
                string query = $"UPDATE ChiTietHoaDon SET SoLuong = {txtSoLuong.Texts} WHERE MaHD = '{maHD}' AND MaSP = '{maSP}'";
                api.ExecQuery(query, "Xóa phòng thành công");
                LoadData();
            }
        }
    }
}
