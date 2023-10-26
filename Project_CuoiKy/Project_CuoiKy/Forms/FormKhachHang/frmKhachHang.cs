using Project_CuoiKy.Utils;
using Project_CuoiKy.Forms;
using Project_CuoiKy.Api;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CuoiKy.Forms
{
    public partial class frmKhachHang : Form
    {
        private ApiService api = new ApiService();
        private Helpers helpers = new Helpers();
        public frmKhachHang()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            string query = "SELECT * FROM V_ThongTinKhachHang";
            dgvKhachHang.DataSource = api.CreateTable(query);
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void ShowFormThemKhachHang()
        {
            FormPhong.frmThemKhachHang f2 = new FormPhong.frmThemKhachHang();
            if (f2.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
        private void ShowFormSuaThongTin()
        {
            string maKH = helpers.DataInCol(dgvKhachHang, "MaKH");
            string matKhau = helpers.DataInCol(dgvKhachHang, "MatKhau");
            string tenKH = helpers.DataInCol(dgvKhachHang, "TenKH");
            //float tongTienNap = float.Parse(dtgvKhachHang.CurrentRow.Cells["TongTienNap"].Value.ToString());
            FormPhong.frmSuaThongTinKH f2 = new FormPhong.frmSuaThongTinKH(maKH, tenKH, matKhau);
            if (f2.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void dgvKhachHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           ShowFormSuaThongTin();
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            ShowFormThemKhachHang();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvKhachHang.Columns["dgvSua"].Index)
            {
                ShowFormSuaThongTin();
            }
            else if (e.ColumnIndex == dgvKhachHang.Columns["dgvXoa"].Index)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa khách hàng không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string maKH = helpers.DataInCol(dgvKhachHang, "MaKH");
                    string query = $"DELETE from KhachHang WHERE MaKH = '{maKH}'";
                    api.ExecQuery(query, "Xóa khách hàng thành công");
                    LoadData();
                }
            }
        }

        private void txtTimKiem__TextChanged(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM dbo.func_TimKhachHang('{txtTimKiem.Texts}')";
            dgvKhachHang.DataSource = api.TimKiemKhachHang(query);
        }
    }
}
