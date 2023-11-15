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
        //private bool isLoading = true;
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
        private void frmPhieuBaoTri_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        //void them phieu bao tri ---------------------------------
        private void ShowFormViewPhieuBaoTri()
        {
            string MaPhieu = helpers.DataInCol(dgvBaoTri, "MaPhieu");
            Forms.FormBaoTri.frmViewChiTietBaotri f2 = new Forms.FormBaoTri.frmViewChiTietBaotri(MaPhieu);
            if (f2.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
        //click2lan de sua
        
        //them phieu bao tri
        private void btnThem_Click(object sender, EventArgs e)
        {
            //ShowFrmThemPhieuBaoTri();
        }
        

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Invoke(new EventHandler(this.frmPhieuBaoTri_Load));
        }

        private void dgvBaoTri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvBaoTri_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowFormViewPhieuBaoTri();
        }

        private void dgvBaoTri_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ShowFormViewPhieuBaoTri();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            // $"EXEC proc_ThemPhong N'{txtTenPhong.Texts}', N'{txtViTri.Texts}', {float.Parse(giaPhong)}";
            string query = $"EXEC proc_ThemPhieuBaoTri  ";
            bool result = api.ExecQuery(query, "Thêm  thành công");
            this.DialogResult = result ? DialogResult.OK : DialogResult.None;
        }

        private void txtTimKiem__TextChanged(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM dbo.func_TimPhieuBaoTri('{txtTimKiem.Texts}')";
            dgvBaoTri.DataSource = api.TimKiemKhachHang(query);
        }

        private void dgvBaoTri_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvBaoTri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                if (e.ColumnIndex == dgvBaoTri.Columns["changes"].Index)
                {
                    ShowFormViewPhieuBaoTri();
                }
                else if (e.ColumnIndex == dgvBaoTri.Columns["delete"].Index)
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string MaPhieu = helpers.DataInCol(dgvBaoTri, "MaPhieu");
                        string query = $"DELETE from PhieuBaoTri WHERE MaPhieu = '{MaPhieu}'";
                        api.ExecQuery(query, "Xóa thành công");
                        LoadData();
                    }
                }
            
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
