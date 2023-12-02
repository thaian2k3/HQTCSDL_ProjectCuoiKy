using CustomControls.RJControls;
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
        private bool isLoading = true;
        public frmPhong()
        {
            InitializeComponent();

            btnThem.Visible = ACCOUNT.Role == "ADMIN";
        }
        private void LoadData()
        {
            string query = "SELECT * FROM V_XemPhong";
            dgvPhong.DataSource = api.CreateTable(query);
        }

        private void LoadComboBox()
        {
            cboTenPhong = helpers.CboData("select distinct TenPhong from Phong", cboTenPhong, "TenPhong");
            cboTenPhong.Texts = "Tên phòng";
            cboViTri = helpers.CboData("select distinct ViTri from Phong", cboViTri, "ViTri");
            cboViTri.Texts = "Vị trí";
        }

        private void frmPhong_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadComboBox();

            isLoading = false;
        }

        private void FilterPhong(RJComboBox cboTenPhong, RJComboBox cboViTri)
        {
            string query = "select * from V_XemPhong";
            List<string> subQueryList = new List<string>();
            if (cboTenPhong.SelectedValue != null)
            {
                subQueryList.Add($"TenPhong=N'{cboTenPhong.SelectedValue}'");
            }
            if (cboViTri.SelectedValue != null)
            {
                subQueryList.Add($"ViTri=N'{cboViTri.SelectedValue}'");
            }
            
            query = subQueryList.Count == 0 ? query : $"{query} WHERE {string.Join(" AND ", subQueryList)}";
            dgvPhong.DataSource = api.CreateTable(query);
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
            if (ACCOUNT.Role != "ADMIN")
            {
                return;
            }
            ShowFormSuaPhong();
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvPhong.Columns["dgvSua"].Index && ACCOUNT.Role == "ADMIN")
            {
                ShowFormSuaPhong();
            }
            else if (e.ColumnIndex == dgvPhong.Columns["dgvXoa"].Index && ACCOUNT.Role == "ADMIN")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa phòng không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string maPhong = helpers.DataInCol(dgvPhong, "MaPhong");
                    string query = $"DELETE from Phong WHERE MaPhong = '{maPhong}'";
                    api.ExecQuery(query, "Xóa phòng thành công");
                    LoadData();
                }
            }
        }

        private void txtTimKiem__TextChanged(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM dbo.func_TimPhong(N'{txtTimKiem.Texts}')";
            dgvPhong.DataSource = api.CreateTable(query);
        }

        private void cboTenPhong_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading)
            {
                return;
            }
            FilterPhong(cboTenPhong, cboViTri);
        }

        private void cboViTri_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading)
            {
                return;
            }
            FilterPhong(cboTenPhong, cboViTri);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Invoke(new EventHandler(this.frmPhong_Load));
        }
    }
}
