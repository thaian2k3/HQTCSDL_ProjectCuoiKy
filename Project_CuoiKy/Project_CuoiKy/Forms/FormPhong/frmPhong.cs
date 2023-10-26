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

namespace Project_CuoiKy.Forms.FormPhong
{
    public partial class frmPhong : Form
    {
        private ApiService api = new ApiService();
        private Helpers helpers = new Helpers();
        public frmPhong()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            string query = "SELECT * FROM V_XemPhong";
            dgvPhong.DataSource = api.CreateTable(query);
        }
        private void frmPhong_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void ShowFormThemPhong()
        {
            frmThemPhong f2 = new frmThemPhong();
            if (f2.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
        private void ShowFormSuaPhong()
        {
            string maPhong = helpers.DataInCol(dgvPhong, "MaPhong");
            string tenPhong = helpers.DataInCol(dgvPhong, "TenPhong");
            string viTri = helpers.DataInCol(dgvPhong, "ViTri");
            string giaPhong = helpers.DataInCol(dgvPhong, "GiaPhong");
            frmSuaPhong f2 = new frmSuaPhong(maPhong, tenPhong, viTri, giaPhong);
            if (f2.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            ShowFormThemPhong();
        }

        private void dgvPhong_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowFormSuaPhong();
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvPhong.Columns["dgvSua"].Index)
            {
                ShowFormSuaPhong();
            }
            else if (e.ColumnIndex == dgvPhong.Columns["dgvXoa"].Index)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa khách hàng không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string maPhong = helpers.DataInCol(dgvPhong, "MaPhong");
                    string query = $"DELETE from Phong WHERE MaPhong = '{maPhong}'";
                    api.ExecQuery(query, "Xóa khách hàng thành công");
                    LoadData();
                }
            }
        }

        private void txtTimKiem__TextChanged(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM dbo.func_TimPhong('{txtTimKiem.Texts}')";
            dgvPhong.DataSource = api.TimKiemKhachHang(query);
        }
    }
}
