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
        private string SoTienCu;
        private string TinhTrangCu;
        private string GhiChuCu;
        public frmSuaChiTietPhieuBaoTri()
        {
            InitializeComponent();
        }
        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            //string sotien  = txtSoTien.Texts.Trim() == "" ? "0" : txtSoTien.Texts;
            string malk    = txtMaLK.Texts.Trim() == "" ? "0" :   txtMaLK.Texts;
            string maphieu = txtMaPhieu.Texts.Trim() == "" ? "0" : txtMaPhieu.Texts;//int.Parse(txtMaPhieu.Texts)
            string query= "";
            if (cboTinhTrang.Texts == TinhTrangCu)               
            {
                 query = $"EXEC proc_CapNhatChiTietBaoTri {int.Parse(malk)},{int.Parse(maphieu)}, {int.Parse(txtSoTien.Texts)}, N'{TinhTrangCu}', N'{txtGhiChu.Texts}'";
            }
            else
            {
             query = $"EXEC proc_CapNhatChiTietBaoTri {int.Parse(malk)},{int.Parse(maphieu)}, {int.Parse(txtSoTien.Texts)}, N'{cboTinhTrang.SelectedValue}', N'{txtGhiChu.Texts}'"; 
            }
            bool result = api.ExecQuery(query, "Sửa  thành công");
            this.DialogResult = result ? DialogResult.OK : DialogResult.None;
        }
        private void LoadComboBox()
        {
            cboTinhTrang = helpers.CboData("Select distinct TinhTrang from ChiTietPhieuBaoTri", cboTinhTrang, "TinhTrang");
            cboTinhTrang.Texts = TinhTrangCu;
        }
       
        private void frmSuaChiTietPhieuBaoTri_Load(object sender, EventArgs e)
        {
            txtMaPhieu.Texts = MaPhieu;
            txtMaLK.Texts = MaLK;
            SoTienCu = SoTienCu.Replace(".0000", "");
            txtSoTien.Texts = SoTienCu;//result = Convert.ToInt32(double.Parse(strNumber));
            txtGhiChu.Texts = GhiChuCu;
            LoadComboBox();
            //this.MaximizeBox = false;
        }
        public frmSuaChiTietPhieuBaoTri(string MaLK, string MaPhieu,string SoTien, string TinhTrang, string GhiChu)
        {
            InitializeComponent();
            this.MaLK = MaLK;
            this.MaPhieu = MaPhieu;
            this.SoTienCu = SoTien;
            this.TinhTrangCu = TinhTrang;
            this.GhiChuCu= GhiChu;
        }
    }
}
