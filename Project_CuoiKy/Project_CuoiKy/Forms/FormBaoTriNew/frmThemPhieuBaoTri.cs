using Project_CuoiKy.Api;
using Project_CuoiKy.Forms.FormBaoTriNew;
using Project_CuoiKy.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CuoiKy.Forms.FormBaoTri
{
    public partial class frmThemPhieuBaoTri : Form
    {

        private ApiService api = new ApiService();
        private Helpers helpers = new Helpers();
        private string MaPhieu;
        public frmThemPhieuBaoTri(string MaPhieu)
        {
            InitializeComponent();    
            this.MaPhieu = MaPhieu;           
        }
        private void frmThemPhieuBaoTri_Load(object sender, EventArgs e)
        {          
            txtMaPhieu.Texts = MaPhieu;
            LoadComboBox();
        }
        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            string SoTien = txtSoTien.Texts.Trim() == "" ? "0" : txtSoTien.Texts;
            string maphieu = txtMaPhieu.Texts.Trim() == "" ? "0" : txtMaPhieu.Texts;
            string query = $"EXEC proc_ThemChiTietBaoTri {cboMaLK.SelectedValue},{int.Parse(maphieu)}, {int.Parse(SoTien)}, N'{cboTinhTrang.SelectedValue}', N'{txtGhiChu.Texts}'";
            bool result = api.ExecQuery(query, "Thêm  thành công");
            this.DialogResult = result ? DialogResult.OK : DialogResult.None;
        }
        private void LoadComboBox()
        {
            cboMaLK = helpers.CboData("Select distinct MaLK from LinhKien", cboMaLK, "MaLK");
            cboMaLK.Texts = "Ma linh kien";

            cboTinhTrang = helpers.CboData("Select distinct TinhTrang from ChiTietPhieuBaoTri", cboTinhTrang, "TinhTrang");
            cboTinhTrang.Texts = "Tinh Trang(Dang bao tri/hoan thanh)";
        }
        private void cboMaLK_OnSelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void label5_Click(object sender, EventArgs e)
        {
        }
        private void label4_Click(object sender, EventArgs e)
        {
        }
        private void txtTenPhong__TextChanged(object sender, EventArgs e)
        {
        }

        private void cboMaPhieu_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboMaLK_OnSelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void cboTinhTrang_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
