using Project_CuoiKy.Api;
using Project_CuoiKy.Forms.FormBaoTriNew;
using Project_CuoiKy.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
           // this.FormBorderStyle = FormBorderStyle.FixedSingle; //ko cho thay doi kich thuoc
            //this.MaximizeBox = false;
        }
        private void frmThemPhieuBaoTri_Load(object sender, EventArgs e)
        {
            txtMaPhieu.Texts = MaPhieu;
            LoadComboBox();
        }
        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            // chỗ nãy lỗi mã linh kiện ko dc trống
            if (cboMaLK.SelectedValue == null)
            {
                MessageBox.Show("Thiếu mã linh kiện!", "Lỗi");
                return;
            }
            string SoTien = txtSoTien.Texts.Trim() == "" ? "0" : txtSoTien.Texts;
            string query = $"EXEC proc_ThemChiTietBaoTri {cboMaLK.SelectedValue},{int.Parse(txtMaPhieu.Texts)}, {int.Parse(SoTien)}, N'{cboTinhTrang.SelectedValue}', N'{txtGhiChu.Texts}'";
            bool result = api.ExecQuery(query, "Thêm  thành công");
            this.DialogResult = result ? DialogResult.OK : DialogResult.None;
        }
        private void LoadComboBox()
        {
            cboMaLK = helpers.CboData("Select distinct MaLK from LinhKien", cboMaLK, "MaLK");
            cboMaLK.Texts = "   ";
            cboTinhTrang = helpers.CboData("Select distinct TinhTrang from ChiTietPhieuBaoTri", cboTinhTrang, "TinhTrang");
            cboTinhTrang.Texts = "   ";
        }
    }
}
