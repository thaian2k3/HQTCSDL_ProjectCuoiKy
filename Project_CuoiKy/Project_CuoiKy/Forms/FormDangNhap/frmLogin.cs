using Project_CuoiKy.Api;
using System;
using System.Collections;
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
            bool isValidAccount = bool.Parse(apiAdmin.FuncScalarAdmin($"select dbo.func_CheckLogin('{txtUsername.Texts}', '{txtPassword.Texts}')"));
           
            if (isValidAccount)
            {
                ACCOUNT.Username = txtUsername.Texts;
                ACCOUNT.Password = txtPassword.Texts;
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
                string query = "";
                
                if (optStaff.Checked)
                {
                    query = $"EXEC proc_ThemTaiKhoan '{txtUsernameRegister.Texts}', '{txtPasswordRegister.Texts}', 'STAFF'";
                    if (apiAdmin.ExecQueryAdmin(query, "Đăng ký thành công"))
                    {
                        tabControlLogin.SelectedTab = tabDangNhap;
                    }
                }
                else
                {
                    frmCheckAdmin f2 = new frmCheckAdmin();
                    query = $"EXEC proc_ThemTaiKhoan '{txtUsernameRegister.Texts}', '{txtPasswordRegister.Texts}', 'ADMIN'";
                    if (f2.ShowDialog() == DialogResult.OK && apiAdmin.ExecQueryAdmin(query, "Đăng ký tài khoản ADMIN thành công"))
                    {
                        tabControlLogin.SelectedTab = tabDangNhap;
                    }
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu không trùng nhau", "Thông báo lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            txtConfirmPasswordRegister.Texts = "";
            txtPasswordRegister.Texts = "";
            txtUsernameRegister.Texts = "";
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
