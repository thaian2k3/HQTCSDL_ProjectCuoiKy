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

namespace Project_CuoiKy.Forms.FormBaoTriNew
{
    public partial class frmSuaChiTietPhieuBaoTri : Form
    {
        private ApiService api = new ApiService();
        private Helpers helpers = new Helpers();
        private string MaLK;
        private string MaPhieu;
        public frmSuaChiTietPhieuBaoTri()
        {
            InitializeComponent();
        }
        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            string SoTien = txtSoTien.Texts.Trim() == "" ? "0" : txtSoTien.Texts;
            string malk = txtMaLK.Texts.Trim() == "" ? "0" : txtMaLK.Texts;
            string maphieu = txtMaPhieu.Texts.Trim() == "" ? "0" : txtMaPhieu.Texts;
            string query = $"EXEC proc_CapNhatChiTietBaoTri {int.Parse(malk)},{int.Parse(maphieu)}, {int.Parse(SoTien)}, N'{cboTinhTrang.SelectedValue}', N'{txtGhiChu.Texts}'";
            bool result = api.ExecQuery(query, "Sửa  thành công");
            this.DialogResult = result ? DialogResult.OK : DialogResult.None;
        }
        private void LoadComboBox()
        {
            
            cboTinhTrang = helpers.CboData("Select distinct TinhTrang from ChiTietPhieuBaoTri", cboTinhTrang, "TinhTrang");
            cboTinhTrang.Texts = "Tình trạng(Dang bao tri/hoan thanh)";
        }
        private void label4_Click(object sender, EventArgs e)
        {
        }
        private void frmSuaChiTietPhieuBaoTri_Load(object sender, EventArgs e)
        {
            txtMaPhieu.Texts = MaPhieu;
            txtMaLK.Texts = MaLK;
            LoadComboBox();
        }
        public frmSuaChiTietPhieuBaoTri(string MaLK, string MaPhieu)
        {
            InitializeComponent();
            this.MaLK = MaLK;
            this.MaPhieu = MaPhieu;
        }
        public void LoadData()
        {
        }
    }
}
