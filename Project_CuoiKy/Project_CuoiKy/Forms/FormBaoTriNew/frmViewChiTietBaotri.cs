using Project_CuoiKy.Forms.FormBaoTriNew;
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
    public partial class frmViewChiTietBaotri : Form
    {
        private Api.ApiService api = new Api.ApiService();
        private Helpers helpers = new Helpers();

        private string MaPhieu;
        public void LoadData()
        {
            string query = $"SELECT * FROM V_XuatPhieuBaoTri  WHERE MaPhieu={MaPhieu}";
            dgvChiTietBaoTri.DataSource = api.CreateTable(query);
        }
        public frmViewChiTietBaotri(string MaPhieu)
        {
            InitializeComponent();
            this.MaPhieu = MaPhieu;
            LoadData();
        }

        private void frmChiTietBaotri_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvChiTietBaoTri_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //double clickon cell dgv View sem phieu bao tri
            string MaLK = helpers.DataInCol(dgvChiTietBaoTri, "MaLK");
            string MaPhieu= helpers.DataInCol(dgvChiTietBaoTri, "MaPhieuBT");
            frmSuaChiTietPhieuBaoTri f = new frmSuaChiTietPhieuBaoTri(MaLK,MaPhieu);
            if (f.ShowDialog() == DialogResult.OK)
            {
               LoadData();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemPhieuBaoTri f2 = new frmThemPhieuBaoTri(MaPhieu);
            if (f2.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void dgvChiTietBaoTri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvChiTietBaoTri.Columns["delete"].Index)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string MaLK = helpers.DataInCol(dgvChiTietBaoTri, "MaLK");
                    string query = $"DELETE from ChiTietPhieuBaoTri WHERE MaLK = '{MaLK}'";
                    api.ExecQuery(query, "Xóa thành công");
                    LoadData();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Invoke(new EventHandler(this.frmChiTietBaotri_Load));
        }
    }
}
