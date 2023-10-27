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

namespace Project_CuoiKy.Forms.FormMay
{
    public partial class frmCauHinhMay : Form
    {
        private string maMay;
        private ApiService api = new ApiService();

        public frmCauHinhMay()
        {
            InitializeComponent();
        }

        public frmCauHinhMay(string maMay)
        {
            InitializeComponent();
            this.maMay = maMay;
        }

        private string LayTenLK(string loaiLK)
        {
            return api.FuncScalar($"SELECT dbo.LayTenLK({maMay}, N'{loaiLK}')");
        }

        private void frmCauHinhMay_Load(object sender, EventArgs e)
        {
            txtChuot.Texts = LayTenLK(lblChuot.Text);
            txtBanPhim.Texts = LayTenLK(lblBanPhim.Text);
            txtTaiNghe.Texts = LayTenLK(lblTaiNghe.Text);
            txtManHinh.Texts = LayTenLK(lblManHinh.Text);
        }

        private void btnThoát_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
