using Project_CuoiKy.Api;
using Project_CuoiKy.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CuoiKy.Forms.FormBaoTriNew
{
    public partial class frmChiTietPhieuBaoTri : Form
    {
        private ApiService api = new ApiService();

        private Helpers helpers = new Helpers();

        public frmChiTietPhieuBaoTri()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ShowFormSuaPhieuBaoTri();
        }
        private void ShowFormSuaPhieuBaoTri()
        {
            string MaPhieu = helpers.DataInCol(dgvChiTietBaoTri, "MaPhieu");
            Forms.FormBaoTri.frmViewChiTietBaotri f2 = new Forms.FormBaoTri.frmViewChiTietBaotri(MaPhieu);
            if (f2.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
        private void LoadData()
        {
            string query = "select * from PhieuBaoTri";
            dgvChiTietBaoTri.DataSource = api.CreateTable(query);
        }

        private void frmChiTietPhieuBaoTri_Load(object sender, EventArgs e)
        {

        }
    }
}
