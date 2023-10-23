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
    public partial class frmSuaThongTinKH : Form
    {
        private Api.ApiQLKH api = new Api.ApiQLKH();
        private string maKH;
        private string tenKH;
        private string matKhau;

        public frmSuaThongTinKH()
        {
            InitializeComponent();
        }

        public frmSuaThongTinKH(string maKH, string tenKH, string matKhau)
        {
            InitializeComponent();
            this.maKH = txtMaKH.Texts = maKH;
            this.tenKH = txtTenKH.Texts = tenKH;
            this.matKhau = txtMatKhau.Texts = matKhau;
        }

        private void btnLuuThongTin_Click(object sender, EventArgs e)
        {
            bool result = api.SuaThongTin(txtMaKH.Texts, txtTenKH.Texts, txtMatKhau.Texts);
            this.DialogResult = result ? DialogResult.OK : DialogResult.None;
        }
    }
}
