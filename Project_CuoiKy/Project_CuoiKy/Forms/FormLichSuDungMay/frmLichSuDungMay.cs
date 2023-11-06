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

namespace Project_CuoiKy.Forms.FormLichSuDungMay
{
    public partial class frmLichSuDungMay : Form
    {
        private ApiService api = new ApiService();
        private Helpers helpers = new Helpers();
        private bool isLoading = true;

        public frmLichSuDungMay()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            string query = "SELECT * FROM V_LichSuDungMay";
            dgvLsdm.DataSource = api.CreateTable(query);
        }
        private void LoadComboBox()
        {
            cboMaMay = helpers.CboData("select distinct MaMay from V_LichSuDungMay", cboMaMay, "MaMay");
            cboMaMay.Texts = "Mã máy";
            cboMaKH = helpers.CboData("select distinct MaKH from V_LichSuDungMay", cboMaKH, "MaKH");
            cboMaKH.Texts = "Mã khách hàng";
        }

        private void frmLichSuDungMay_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadComboBox();

            isLoading = false;
        }
        private void FilterLsdm(RJComboBox cboMaMay, RJComboBox cboMaKH)
        {
            string query = "select * from V_LichSuDungMay";
            List<string> subQueryList = new List<string>();
            if (cboMaKH.SelectedValue != null)
            {
                subQueryList.Add($"MaKH={cboMaKH.SelectedValue}");
            }
            if (cboMaMay.SelectedValue != null)
            {
                subQueryList.Add($"MaMay={cboMaMay.SelectedValue}");
            }

            query = subQueryList.Count == 0 ? query : $"{query} WHERE {string.Join(" AND ", subQueryList)}";
            dgvLsdm.DataSource = api.CreateTable(query);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Invoke(new EventHandler(this.frmLichSuDungMay_Load));
        }

        private void cboMaMay_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading)
            {
                return;
            }
            FilterLsdm(cboMaMay, cboMaKH);
        }

        private void cboMaKH_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading)
            {
                return;
            }
            FilterLsdm(cboMaMay, cboMaKH);
        }
    }
}
