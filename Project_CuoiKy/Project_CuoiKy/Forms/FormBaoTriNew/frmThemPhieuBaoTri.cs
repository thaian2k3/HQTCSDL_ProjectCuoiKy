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

            btnHoanTat.Visible = ACCOUNT.Role.ToUpper() == "ADMIN";
           // this.FormBorderStyle = FormBorderStyle.FixedSingle; //ko cho thay doi kich thuoc
            //this.MaximizeBox = false;
        }
        private void frmThemPhieuBaoTri_Load(object sender, EventArgs e)
        {
            txtMaPhieu.Texts = MaPhieu;
            LoadComboBox();
            //txtSoTien.KeyPress += txtSoTien_KeyPress;
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

            string query = $"EXEC proc_ThemChiTietBaoTri {cboMaLK.SelectedValue},{int.Parse(txtMaPhieu.Texts)}, {int.Parse(SoTien)}, N'Đang bảo trì', N'{txtGhiChu.Texts}'";
            bool result = api.ExecQuery(query, "Thêm  thành công");
            this.DialogResult = result ? DialogResult.OK : DialogResult.None;
        }
        private void LoadComboBox()
        {
            cboMaLK = helpers.CboData("Select distinct MaLK from LinhKien", cboMaLK, "MaLK");
            cboMaLK.Texts = "Chọn mã linh kiện";
        }

        private void txtSoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự có phải là số hay không, hoặc có phải là ký tự chấp nhận được (ví dụ: backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Nếu không phải số, không cho phép ký tự được nhập vào TextBox
                e.Handled = true;
            }
        }

        //private void txtSoTien_KeyPress(object sender, KeyPressEventArgs e)
        //{            
        //        // Kiểm tra xem ký tự có phải là số hay không, hoặc có phải là ký tự chấp nhận được (ví dụ: backspace)
        //        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        //        {
        //            // Nếu không phải số, không cho phép ký tự được nhập vào TextBox
        //            e.Handled = false;
        //        }  
        //}
    }
}
