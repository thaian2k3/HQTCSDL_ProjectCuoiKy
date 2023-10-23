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
        Api.ApiQLKH api = new Api.ApiQLKH();
        public frmThemKhachHang()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bool result = api.ThemKhachHang(txtMaKH.Texts, txtTenKH.Texts, txtMatKhau.Texts);
            this.DialogResult = result ? DialogResult.OK : DialogResult.None;
        }
    }
}
