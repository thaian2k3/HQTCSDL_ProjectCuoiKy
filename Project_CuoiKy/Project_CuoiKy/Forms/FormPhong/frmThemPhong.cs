using Project_CuoiKy.Api;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CuoiKy.Forms.FormPhong
{
    public partial class frmThemPhong : Form
    {
        private ApiService api = new ApiService();
        public frmThemPhong()
        {
            InitializeComponent();
            txtGiaPhong.Texts = "0";

            btnThem.Visible = ACCOUNT.Role == "ADMIN";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string giaPhong = txtGiaPhong.Texts.Trim() == "" ? "0" : txtGiaPhong.Texts;
            string query = $"EXEC proc_ThemPhong N'{txtTenPhong.Texts}', N'{txtViTri.Texts}', {float.Parse(giaPhong)}";
            this.DialogResult = api.ExecQuery(query, "Thêm phòng thành công") ? DialogResult.OK : DialogResult.None;
        }

        private void frmThemPhong_Load(object sender, EventArgs e)
        {

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
