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
    public partial class frmThemKhachHang : Form
    {
        Api.ApiService api = new Api.ApiService();
        public frmThemKhachHang()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = $"EXEC dbo.ThemKhachHang '{txtMaKH.Texts}', N'{txtTenKH.Texts}', '{txtMatKhau.Texts}'";
            bool result = api.ExecQuery(query, "Thêm khách hàng thành công");
            this.DialogResult = result ? DialogResult.OK : DialogResult.None;
        }

        private void frmThemKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void txtMaKH_KeyPress(object sender, KeyPressEventArgs e)
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
