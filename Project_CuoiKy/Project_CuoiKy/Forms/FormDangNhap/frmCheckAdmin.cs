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

namespace Project_CuoiKy.Forms.FormDangNhap
{
    public partial class frmCheckAdmin : Form
    {
        ApiService apiAdmin = new ApiService();
        public frmCheckAdmin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            bool isValidAccount = bool.Parse(apiAdmin.FuncScalarAdmin($"select dbo.func_CheckLogin('{txtUsername.Texts}', '{txtPassword.Texts}')"));

            if (isValidAccount && txtUsername.Texts.Equals("sa"))
            {
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Xác nhận tài khoản ADMIN thành công", "Thông báo thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                this.DialogResult = DialogResult.None;
                MessageBox.Show("Tài khoản ADMIN không chính xác", "Thông báo lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }
    }
}
