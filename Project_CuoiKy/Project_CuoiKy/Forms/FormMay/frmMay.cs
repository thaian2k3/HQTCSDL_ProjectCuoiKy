using CustomControls.RJControls;
using Project_CuoiKy.Api;
using Project_CuoiKy.Forms.FormLichSuDungMay;
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

namespace Project_CuoiKy.Forms.FormMay
{
    public partial class frmMay : Form
    {
        private ApiService api = new ApiService();
        private Helpers helpers = new Helpers();
        private bool isLoading = true;
        public frmMay()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            string query = "select * from V_XemMayTinh";
            dgvMay.DataSource = api.CreateTable(query);
        }
        private void LoadComboBox()
        {
            cboMaPhong = helpers.CboData("select distinct MaPhong from Phong", cboMaPhong, "MaPhong");
            cboMaPhong.Texts = "Mã phòng";
            cboTinhTrang = helpers.CboData("select distinct TinhTrang from May", cboTinhTrang, "TinhTrang");
            cboTinhTrang.Texts = "Tình trạng";
            cboViTri = helpers.CboData("select distinct ViTri from Phong", cboViTri, "ViTri");
            cboViTri.Texts = "Vị trí";
        }
        private void FilterMay(RJComboBox cboMaPhong, RJComboBox cboTinhTrang, RJComboBox cboViTri)
        {
            string query = "select * from V_XemMayTinh";
            List<string> subQueryList = new List<string>();
            if (cboMaPhong.SelectedValue != null)
            {
                subQueryList.Add($"MaPhong={cboMaPhong.SelectedValue}");
            }
            if (cboTinhTrang.SelectedValue != null)
            {
                subQueryList.Add($"TinhTrang=N'{cboTinhTrang.SelectedValue}'");
            }
            if (cboViTri.SelectedValue != null)
            {
                subQueryList.Add($"ViTri=N'{cboViTri.SelectedValue}'");
            }
            query = subQueryList.Count == 0 ? query : $"{query} WHERE {string.Join(" AND ", subQueryList)}";
            dgvMay.DataSource = api.CreateTable(query);
        }   
        private void frmMay_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadComboBox();
            isLoading= false;
        }
        private void ShowFormThemMay()
        {
            frmThemMay f2 = new frmThemMay();
            if (f2.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
        private void ShowFormSuaThongTinMay()
        {
            string maMay = helpers.DataInCol(dgvMay, "MaMay");
            frmSuaThongTinMay f2 = new frmSuaThongTinMay(maMay);
            if (f2.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
        private void ShowFormCauHinhMay()
        {
            string maMay = helpers.DataInCol(dgvMay, "MaMay");
            frmCauHinhMay f2 = new frmCauHinhMay(maMay);
            if (f2.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void ShowFormLichSuDungMay()
        {
           
            frmLichSuDungMay f2 = new frmLichSuDungMay();
            if (f2.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            ShowFormThemMay();
        }

        private void dgvMay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvMay.Columns["dgvSua"].Index)
            {
                ShowFormSuaThongTinMay();
            }
            else if (e.ColumnIndex == dgvMay.Columns["dgvCauHinh"].Index)
            {
                ShowFormCauHinhMay();
            }
            else if (e.ColumnIndex == dgvMay.Columns["dgvXoa"].Index)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa máy không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string maMay = helpers.DataInCol(dgvMay, "MaMay");
                    string query = $"DELETE from May WHERE MaMay = '{maMay}'";
                    api.ExecQuery(query, "Xóa máy thành công");
                    LoadData();
                }
            }
        }

        private void cboMaPhong_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading)
            {
                return;
            }
            FilterMay(cboMaPhong, cboTinhTrang, cboViTri);
        }

        private void cboTinhTrang_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading)
            {
                return;
            }
            FilterMay(cboMaPhong, cboTinhTrang, cboViTri);
        }

        private void cboViTri_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading)
            {
                return;
            }
            FilterMay(cboMaPhong, cboTinhTrang, cboViTri);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Invoke(new EventHandler(this.frmMay_Load));
        }

        private void dgvMay_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowFormCauHinhMay();
        }

        private void btnLsdm_Click(object sender, EventArgs e)
        {
            ShowFormLichSuDungMay();
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvMay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
