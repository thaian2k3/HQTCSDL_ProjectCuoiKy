using CustomControls.RJControls;
using Project_CuoiKy.Api;
using Project_CuoiKy.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CuoiKy.Forms.FormHoaDon
{
    public partial class frmHoaDon : Form
    {
        private ApiService api = new ApiService();
        private Helpers helpers = new Helpers();
        public frmHoaDon()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            string query = "SELECT * FROM HoaDon";
            dgvHoaDon.DataSource = api.CreateTable(query);
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ShowFormSuaThongTin()
        {
            string maHD = helpers.DataInCol(dgvHoaDon, "MaHD");
            bool isPaid = helpers.DataInCol(dgvHoaDon, "TinhTrang").Equals("Đã thanh toán");
            Forms.FormHoaDon.frmChiTietHoaDon f2 = new Forms.FormHoaDon.frmChiTietHoaDon(maHD, isPaid);
            if (f2.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void dgvHoaDon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowFormSuaThongTin();
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvHoaDon.Columns["dgvXacNhanThanhToan"].Index && dgvHoaDon.Rows[e.RowIndex].Cells["TinhTrang"].Value.ToString() != "Đã thanh toán")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xác nhận hóa đơn không?", "Xác nhận thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string maHD = dgvHoaDon.CurrentRow.Cells["MaHD"].Value.ToString();
                    string query = $"UPDATE HoaDon SET TinhTrang = N'Đã thanh toán' WHERE MaHD='{maHD}'";
                    api.ExecQuery(query, "Thanh toán hóa đơn thành công");
                    LoadData();
                }
            }
        }

        private void txtTimKiem__TextChanged(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM dbo.func_TimHoaDon('{txtTimKiem.Texts}')";
            dgvHoaDon.DataSource = api.TimKiemKhachHang(query);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Invoke(new EventHandler(this.frmHoaDon_Load));
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string query;
            query = $"SELECT * FROM func_LocHoaDonTheoNgayBD_KT('{dtpNgayDau.Value}', '{dtpNgayCuoi.Value}')";
            dgvHoaDon.DataSource = api.TimKiemKhachHang(query);
        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnInThongTin_Click(object sender, EventArgs e)
        {
            string ngayTao = helpers.DataInCol(dgvHoaDon, "NgayTao");
            frmDoanhThu f = new frmDoanhThu(ngayTao);
            f.ShowDialog();
        }
    }
}
