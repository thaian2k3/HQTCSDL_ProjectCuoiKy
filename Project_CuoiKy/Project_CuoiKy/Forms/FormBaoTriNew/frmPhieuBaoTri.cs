using Project_CuoiKy.Api;
using Project_CuoiKy.Forms.FormMay;
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

        public frmPhieuBaoTri()
        {
            InitializeComponent();

            btnThemPheuBaoTri.Visible = ACCOUNT.Role.ToUpper() == "ADMIN";
        }
        private void LoadData()
        {
            string query = "select * from PhieuBaoTri";
            dgvBaoTri.DataSource = api.CreateTable(query);
        }
        private void frmPhieuBaoTri_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void ShowFormViewPhieuBaoTri()
        {
            string MaPhieu = helpers.DataInCol(dgvBaoTri, "MaPhieu");
            Forms.FormBaoTri.frmViewChiTietBaotri f2 = new Forms.FormBaoTri.frmViewChiTietBaotri(MaPhieu);
            if (f2.ShowDialog() == DialogResult.OK)
            {
            //    LoadData();
            }
            LoadData();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = $"EXEC proc_ThemPhieuBaoTri";
            bool result = api.ExecQuery(query, "Thêm  thành công");
            this.DialogResult = result ? DialogResult.OK : DialogResult.None;
            LoadData();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Invoke(new EventHandler(this.frmPhieuBaoTri_Load));
        }
        private void txtTimKiem__TextChanged(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM dbo.func_TimPhieuBaoTri('{txtTimKiem.Texts}')";
            dgvBaoTri.DataSource = api.TimKiemKhachHang(query);
        }

        private void dgvBaoTri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                if (e.ColumnIndex == dgvBaoTri.Columns["changes"].Index && ACCOUNT.Role.ToUpper() == "ADMIN")
                {
                    ShowFormViewPhieuBaoTri();
                }
                else if (e.ColumnIndex == dgvBaoTri.Columns["delete"].Index && ACCOUNT.Role.ToUpper() == "ADMIN")
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string MaPhieu = helpers.DataInCol(dgvBaoTri, "MaPhieu");
                        string query1 = $"DELETE from ChiTietPhieuBaoTri WHERE MaPhieu = '{MaPhieu}';" +
                        $"  DELETE from PhieuBaoTri WHERE MaPhieu = '{MaPhieu}'"; //ChiTietPhieuBaoTri xoa trc roi toi phieubaotri vi loi khoa ngoai
                        api.ExecQuery(query1, "Xóa thành công");
                        LoadData();
                    }
                }
            
        }
    }
}
