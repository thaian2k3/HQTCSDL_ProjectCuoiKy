using CustomControls.RJControls;
using Project_CuoiKy.Api;
using Project_CuoiKy.Forms.FormPhong;
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

namespace Project_CuoiKy.Forms.FormSanPham
{
    public partial class frmSanPham : Form
    {
        private ApiService api = new ApiService();
        private Helpers helpers = new Helpers();
        private bool isLoading = true;
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            string query = "SELECT * FROM V_XemSanPham";
            dgvSanPham.DataSource = api.CreateTable(query);
        }

        private void LoadComboBox()
        {
            cboLoaiSP = helpers.CboData("select distinct LoaiSP from SanPham", cboLoaiSP, "LoaiSP");
            cboLoaiSP.Texts = "Loại sản phẩm";
            cboTinhTrang = helpers.CboData("select distinct TinhTrang from SanPham", cboTinhTrang, "TinhTrang");
            cboTinhTrang.Texts = "Tình trạng";
        }

        private void ShowFormThemSanPham()
        {
            
            frmThemSanPham f2 = new frmThemSanPham();
            if (f2.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void ShowFormSuaSanPham()
        {
            string maSP = helpers.DataInCol(dgvSanPham, "MaSP");
            string tenSP = helpers.DataInCol(dgvSanPham, "TenSP");
            string maNCC = helpers.DataInCol(dgvSanPham, "MaNCC");
            string soLuongConLai = helpers.DataInCol(dgvSanPham, "SoLuongConLai");
            string donGia = helpers.DataInCol(dgvSanPham, "DonGia");
            string loaiSP = helpers.DataInCol(dgvSanPham, "LoaiSP");
            frmSuaSanPham f2 = new frmSuaSanPham(maSP, tenSP, loaiSP, maNCC, soLuongConLai, donGia);
            if (f2.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadComboBox();

            isLoading = false;
        }

        private void FilterSanPham(RJComboBox cboLoaiSP, RJComboBox cboTinhTrang)
        {
            string query = "select * from V_XemSanPham";
            List<string> subQueryList = new List<string>();

            if (cboLoaiSP.SelectedValue != null)
            {
                subQueryList.Add($"LoaiSP=N'{cboLoaiSP.SelectedValue}'");
            }
            if (cboTinhTrang.SelectedValue != null)
            {
                subQueryList.Add($"TinhTrang=N'{cboTinhTrang.SelectedValue}'");
            }

            query = subQueryList.Count == 0 ? query : $"{query} WHERE {string.Join(" AND ", subQueryList)}";
            dgvSanPham.DataSource = api.CreateTable(query);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ShowFormThemSanPham();
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvSanPham.Columns["dgvSua"].Index)
            {
                ShowFormSuaSanPham();
            }
            else if (e.ColumnIndex == dgvSanPham.Columns["dgvXoa"].Index)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa sản phẩm không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string maSP = helpers.DataInCol(dgvSanPham, "MaSP");
                    string query = $"DELETE from SanPham WHERE MaSP = '{maSP}'";
                    api.ExecQuery(query, "Xóa sản phẩm thành công");
                    LoadData();
                }
            }
        }

        private void dgvSanPham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowFormSuaSanPham();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Invoke(new EventHandler(this.frmSanPham_Load));
        }

        private void cboLoaiSP_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading)
            {
                return;
            }
            FilterSanPham(cboLoaiSP, cboTinhTrang);
        }

        private void cboTinhTrang_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading)
            {
                return;
            }
            FilterSanPham(cboLoaiSP, cboTinhTrang);
        }

        private void txtTimKiem__TextChanged(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM dbo.func_TimKiemSanPham('{txtTimKiem.Texts}')";
            dgvSanPham.DataSource = api.TimKiemKhachHang(query);
        }
    }
}
