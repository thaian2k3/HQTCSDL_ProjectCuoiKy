using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CuoiKy
{
    public partial class MainForm : Form
    {
        private Form currentChildForm;

        public MainForm()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ToggleSubmenu(Panel submenu)
        {
            submenu.Visible = !submenu.Visible;
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            ToggleSubmenu(pnlSubmenuKhachHang);
        }

        private void btnXemChiTietKH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmKhachHang());
        }
    }
}
