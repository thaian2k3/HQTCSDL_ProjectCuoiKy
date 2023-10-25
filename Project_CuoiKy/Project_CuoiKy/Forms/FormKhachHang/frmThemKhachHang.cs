using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CuoiKy.Forms.FormKhachHang
{
    public partial class frmThemKhachHang : Form
    {
        Api.Api api = new Api.Api();
        public frmThemKhachHang()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //bool result = api.ThemKhachHang(txtMaKH.Texts, txtTenKH.Texts, txtMatKhau.Texts);
            string query = $"EXEC dbo.ThemKhachHang '{txtMaKH.Texts}', '{txtTenKH.Texts}', '{txtMatKhau.Texts}'";
            bool result = api.ExecQuery(query, "Thêm khách hàng thành công");
            this.DialogResult = result ? DialogResult.OK : DialogResult.None;
        }
    }
}
