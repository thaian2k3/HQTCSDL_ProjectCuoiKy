using Project_CuoiKy.Api;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CuoiKy.Forms.FormDangNhap
{
    public partial class frmLogin : Form
    {
        private ApiService apiAdmin = new ApiService();
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            ACCOUNT.Username = txtUsername.Texts;
            ACCOUNT.Password = txtPassword.Texts;

            bool isValidAccount = bool.Parse(apiAdmin.FuncScalarAdmin($"select dbo.func_CheckLogin('{txtUsername.Texts}', '{txtPassword.Texts}')"));
           
            if (isValidAccount)
            {
                // Gán thuộc tính role trong ACCOUNT
                ACCOUNT.Role = apiAdmin.FuncScalarAdmin($"select dbo.func_GetRoleByUsername('{txtUsername.Texts}')");
                //Show main form
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            } 
            else
            {
                MessageBox.Show("Sai username hoặc password", "Thông báo lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txtPasswordRegister.Texts.Equals(txtConfirmPasswordRegister.Texts))
            {
                string query = $"INSERT INTO TaiKhoan(username, [password], role) VALUES ('{txtUsernameRegister.Texts}', '{txtPasswordRegister.Texts}', 'STAFF')";
                apiAdmin.ExecQueryAdmin(query, "Đăng ký thành công");
                tabControlLogin.SelectedTab = tabDangNhap;
                txtConfirmPasswordRegister.ResetText();
                txtConfirmPasswordRegister.ResetText();
                txtUsernameRegister.ResetText();
            }
            else
            {
                MessageBox.Show("Mật khẩu không trùng nhau", "Thông báo lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TabPage selectedTab = tabControlLogin.SelectedTab;
                if (selectedTab.Name == "tabDangNhap")
                {
                    btnDangNhap_Click(sender, e);
                }
                else
                {
                    btnDangKy_Click(sender, e);
                }
            }
        }
    }
}
