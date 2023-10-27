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

namespace Project_CuoiKy.Forms.FormMay
{
    public partial class frmMay : Form
    {
        private ApiService api = new ApiService();
        private Helpers helpers = new Helpers();
        public frmMay()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            string query = "select * from V_XemMayTinh";
            dgvMay.DataSource = api.CreateTable(query);
        }
        private void frmMay_Load(object sender, EventArgs e)
        {
            LoadData();
            
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
    }
}
