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

namespace Project_CuoiKy.Forms.FormMay
{
    public partial class frmSuaThongTinMay : Form
    {
        private ApiService api = new ApiService();
        private Helpers helpers = new Helpers();
        private bool isLoading = true;
        private string maMay;
        private string maPhong;

        public frmSuaThongTinMay()
        {
            InitializeComponent();

            btnLuuThongTin.Visible = ACCOUNT.Role == "ADMIN";
        }

        public frmSuaThongTinMay(string maMay, string maPhong)
        {
            InitializeComponent();
            this.maMay = maMay;
            this.maPhong = maPhong;
        }

        private void frmSuaThongTinMay_Load(object sender, EventArgs e)
        {
            string query = "Select MaPhong from Phong";
            cboMaPhong = helpers.CboData(query, cboMaPhong, "MaPhong");
            cboMaPhong.SelectedValue = maPhong;
            DataTable dt = api.CreateTable($"SELECT * FROM Phong WHERE MaPhong = {maPhong}");
            DataRow row = dt.Rows[0];
            txtTenPhong.Texts = row["TenPhong"].ToString();
            txtViTri.Texts = row["ViTri"].ToString();
            txtGiaPhong.Texts = row["GiaPhong"].ToString();
            this.isLoading = false;
        }

        private void cboMaPhong_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoading)
            {
                string maPhong = cboMaPhong.SelectedValue.ToString();
                DataTable dt = api.CreateTable($"SELECT * FROM Phong WHERE MaPhong = {maPhong}");
                DataRow row = dt.Rows[0];
                txtTenPhong.Texts = row["TenPhong"].ToString();
                txtViTri.Texts = row["ViTri"].ToString();
                txtGiaPhong.Texts = row["GiaPhong"].ToString();
            }
        }

        private void btnLuuThongTin_Click(object sender, EventArgs e)
        {
            string maPhong = cboMaPhong.SelectedValue.ToString();
            string query = $"EXEC proc_SuaMay {maMay}, {maPhong}";
            this.DialogResult = api.ExecQuery(query, "Lưu thông tin thành công") ? DialogResult.OK : DialogResult.None;
        }

        private void txtGiaPhong_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự có phải là số hay không, hoặc có phải là ký tự chấp nhận được (ví dụ: backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Nếu không phải số, không cho phép ký tự được nhập vào TextBox
                e.Handled = true;
            }
        }
    }
}
