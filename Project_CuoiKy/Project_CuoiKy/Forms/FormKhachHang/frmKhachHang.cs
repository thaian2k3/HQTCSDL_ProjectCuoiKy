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
        Api.ApiQLKH api = new Api.ApiQLKH();
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
            Forms.FormKhachHang.frmThemKhachHang f2 = new Forms.FormKhachHang.frmThemKhachHang();
            if (f2.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
        private void ShowFormSuaThongTin()
        {
            string maKH = dgvKhachHang.CurrentRow.Cells["MaKH"].Value.ToString();
            string matKhau = dgvKhachHang.CurrentRow.Cells["MatKhau"].Value.ToString();
            string tenKH = dgvKhachHang.CurrentRow.Cells["TenKH"].Value.ToString();
            //float tongTienNap = float.Parse(dtgvKhachHang.CurrentRow.Cells["TongTienNap"].Value.ToString());
            Forms.FormKhachHang.frmSuaThongTinKH f2 = new Forms.FormKhachHang.frmSuaThongTinKH(maKH, tenKH, matKhau);
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
            if (e.ColumnIndex == dgvKhachHang.Columns["dgvSuaThongTin"].Index)
            {
                ShowFormSuaThongTin();
            }
            else if (e.ColumnIndex == dgvKhachHang.Columns["dgvXoaKhachHang"].Index)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa khách hàng không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string maKH = dgvKhachHang.CurrentRow.Cells["MaKH"].Value.ToString();
                    api.XoaKhachHang(maKH);
                    LoadData();
                }
            }
        }

        private void txtTimKiem__TextChanged(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = api.TimKiemKhachHang(txtTimKiem.Texts);
        }
    }
}
