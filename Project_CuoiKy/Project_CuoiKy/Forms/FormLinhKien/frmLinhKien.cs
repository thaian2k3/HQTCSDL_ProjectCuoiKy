using CustomControls.RJControls;
using Project_CuoiKy.Api;
using Project_CuoiKy.Forms.FormLichSuDungMay;
using Project_CuoiKy.Forms.FormMay;
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

namespace Project_CuoiKy.Forms.FormLinhKien
{
    public partial class frmLinhKien : Form
    {
        private ApiService api = new ApiService();
        private Helpers helpers = new Helpers();
        private bool isLoading = true;
        public frmLinhKien()
        {
            InitializeComponent();

            btnThem.Visible = ACCOUNT.Role == "ADMIN";
        }

        private void LoadData()
        {
            string query = "select * from V_ThongTinLinhKien";
            dgvLinhKien.DataSource = api.CreateTable(query);
        }
        private void LoadComboBox()
        {
            cboMaMay = helpers.CboData("select distinct MaMay from May", cboMaMay, "MaMay");
            cboMaMay.Texts = "Mã máy";
            cboTinhTrang = helpers.CboData("select distinct TinhTrang from LinhKien", cboTinhTrang, "TinhTrang");
            cboTinhTrang.Texts = "Tình trạng";
            cboLoaiLK = helpers.CboData("select distinct LoaiLK from LinhKien", cboLoaiLK, "LoaiLK");
            cboLoaiLK.Texts = "Loại linh kiện";
        }
        private void FilterMay(RJComboBox cboMaMay, RJComboBox cboTinhTrang, RJComboBox cboLoaiLK)
        {
            string query = "select * from V_ThongTinLinhKien";
            List<string> subQueryList = new List<string>();
            if (cboMaMay.SelectedValue != null)
            {
                subQueryList.Add($"MaMay={cboMaMay.SelectedValue}");
            }
            if (cboTinhTrang.SelectedValue != null)
            {
                subQueryList.Add($"TinhTrang=N'{cboTinhTrang.SelectedValue}'");
            }
            if (cboLoaiLK.SelectedValue != null)
            {
                subQueryList.Add($"LoaiLK=N'{cboLoaiLK.SelectedValue}'");
            }
            query = subQueryList.Count == 0 ? query : $"{query} WHERE {string.Join(" AND ", subQueryList)}";
            dgvLinhKien.DataSource = api.CreateTable(query);
        }
        private void frmLinhKien_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadComboBox();
            isLoading = false;
        }
        private void ShowFormThemLinhKien()
        {
            frmThemLinhKien f2 = new frmThemLinhKien();
            if (f2.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
        private void ShowFormSuaThongTinLinhKien()
        {
            string maLK = helpers.DataInCol(dgvLinhKien, "MaLK");
            string maMay = helpers.DataInCol(dgvLinhKien, "MaMay");
            string maNCC = helpers.DataInCol(dgvLinhKien, "MaNCC");
            string loaiLK = helpers.DataInCol(dgvLinhKien, "LoaiLK");
            string tenHang = helpers.DataInCol(dgvLinhKien, "TenHang");
            string model = helpers.DataInCol(dgvLinhKien, "Model");
            string tinhTrang = helpers.DataInCol(dgvLinhKien, "TinhTrang");
            string thongSo = helpers.DataInCol(dgvLinhKien, "ThongSo");
            frmSuaThongTinLinhKien f2 = new frmSuaThongTinLinhKien(maLK, maMay, maNCC, loaiLK, tenHang, model, tinhTrang, thongSo);
            if (f2.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ShowFormThemLinhKien();
        }

        private void dgvLinhKien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvLinhKien.Columns["dgvSua"].Index && ACCOUNT.Role == "ADMIN")
            {
                ShowFormSuaThongTinLinhKien();
            }
            else if (e.ColumnIndex == dgvLinhKien.Columns["dgvXoa"].Index && ACCOUNT.Role == "ADMIN")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa linh kiện không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string maLK = helpers.DataInCol(dgvLinhKien, "MaLK");
                    string query = $"DELETE from LinhKien WHERE MaLK = '{maLK}'";
                    api.ExecQuery(query, "Xóa linh kiện thành công");
                    LoadData();
                }
            }
        }

        private void cboMaMay_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading)
            {
                return;
            }
            FilterMay(cboMaMay, cboTinhTrang, cboLoaiLK);
        }

        private void cboTinhTrang_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading)
            {
                return;
            }
            FilterMay(cboMaMay, cboTinhTrang, cboLoaiLK);
        }

        private void cboLoaiLK_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading)
            {
                return;
            }
            FilterMay(cboMaMay, cboTinhTrang, cboLoaiLK);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Invoke(new EventHandler(this.frmLinhKien_Load));
        }
    }

}
