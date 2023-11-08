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

namespace Project_CuoiKy.Forms.FormBaoTri
{
    public partial class frmPhieuBaoTri : Form
    {
        private ApiService api = new ApiService();
        private Helpers helpers = new Helpers();
        private bool isLoading = true;
        public frmPhieuBaoTri()
        {
            InitializeComponent();
        }
        //load date
        private void LoadData()
        {
            string query = "select * from PhieuBaoTri";
            dgvBaoTri.DataSource = api.CreateTable(query);
        }
        //
        private void frmPhieuBaoTri_Load(object sender, EventArgs e)
        {

        }
        //void them phieu bao tri
        private void ShowFrmThemPhieuBaoTri()
        {
            frmThemPhieuBaoTri f2 = new frmThemPhieuBaoTri();
            if (f2.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ShowFrmThemPhieuBaoTri();
        }
    }
}
