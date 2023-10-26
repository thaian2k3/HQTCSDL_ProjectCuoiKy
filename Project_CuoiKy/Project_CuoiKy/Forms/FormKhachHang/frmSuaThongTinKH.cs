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
    public partial class frmSuaThongTinKH : Form
    {
        private Api.ApiService api = new Api.ApiService();
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
            string query = $"EXEC dbo.SuaThongTinKhachHang '{txtMaKH.Texts}', '{txtTenKH.Texts}', '{txtMatKhau.Texts}'";
            //bool result = api.SuaThongTin(txtMaKH.Texts, txtTenKH.Texts, txtMatKhau.Texts);
            bool result = api.ExecQuery(query, "Lưu thông tin thành công !");
            this.DialogResult = result ? DialogResult.OK : DialogResult.None;
        }
    }
}
