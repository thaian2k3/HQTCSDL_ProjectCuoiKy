using CustomControls.RJControls;
using Project_CuoiKy.Api;
using Project_CuoiKy.Forms.FormPhong;
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
using Microsoft.VisualBasic;
using Project_CuoiKy.Forms.FormHoaDon;

namespace Project_CuoiKy.Forms.FormSanPham
{
    public partial class frmSanPham : Form
    {
        private ApiService api = new ApiService();
        private Helpers helpers = new Helpers();
        private bool isLoading = true;

        private string maHD;
        public frmSanPham()
        {
            InitializeComponent();

            btnXoaHoaDon.Enabled = !(maHD is null);
            btnXuatHoaDon.Enabled = !(maHD is null);
        }

        private void LoadData()
        {
            string query = "SELECT * FROM V_XemSanPham";
            dgvSanPham.DataSource = api.CreateTable(query);
        }

        private void LoadDataCart(string maHD)
        {
            string query = $"SELECT * FROM V_GioHang where MaHDCart = {maHD}";
            dgvCart.DataSource = api.CreateTable(query);
        }

        private void LoadComboBox()
        {
            cboLoaiSP = helpers.CboData("select distinct LoaiSP from SanPham", cboLoaiSP, "LoaiSP");
            cboLoaiSP.Texts = "Loại sản phẩm";

            cboTinhTrang = helpers.CboData("select distinct TinhTrang from SanPham", cboTinhTrang, "TinhTrang");
            cboTinhTrang.Texts = "Tình trạng";

            cboMaKH = helpers.CboData("select distinct MaKH from KhachHang", cboMaKH, "MaKH");
            cboMaKH.Texts = "Chọn số điện thoại";
        }

        private void ShowFormThemSanPham()
        {
            frmThemSanPham f2 = new frmThemSanPham();
            if (f2.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void ShowFormChiTietHoaDon()
        {
            if (maHD is null)
            {
                return;
            }
            frmChiTietHoaDon f2 = new frmChiTietHoaDon(maHD);
            if (f2.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void ShowFormSuaSanPham()
        {
            string maSP = helpers.DataInCol(dgvSanPham, "MaSP");
            string tenSP = helpers.DataInCol(dgvSanPham, "TenSP");
            string maNCC = helpers.DataInCol(dgvSanPham, "MaNCC");
            string soLuongConLai = helpers.DataInCol(dgvSanPham, "SoLuongConLai");
            string donGia = helpers.DataInCol(dgvSanPham, "DonGia");
            string loaiSP = helpers.DataInCol(dgvSanPham, "LoaiSP");
            frmSuaSanPham f2 = new frmSuaSanPham(maSP, tenSP, loaiSP, maNCC, soLuongConLai, donGia);
            if (f2.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadComboBox();

            isLoading = false;
        }

        private void FilterSanPham(RJComboBox cboLoaiSP, RJComboBox cboTinhTrang)
        {
            string query = "select * from V_XemSanPham";
            List<string> subQueryList = new List<string>();

            if (cboLoaiSP.SelectedValue != null)
            {
                subQueryList.Add($"LoaiSP=N'{cboLoaiSP.SelectedValue}'");
            }
            if (cboTinhTrang.SelectedValue != null)
            {
                subQueryList.Add($"TinhTrang=N'{cboTinhTrang.SelectedValue}'");
            }

            query = subQueryList.Count == 0 ? query : $"{query} WHERE {string.Join(" AND ", subQueryList)}";
            dgvSanPham.DataSource = api.CreateTable(query);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ShowFormThemSanPham();
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvSanPham.Columns["dgvThem"].Index && !(this.maHD is null))
            {
                string userInput = Interaction.InputBox("Bạn muốn mua số lượng bao nhiêu?", "Thêm sản phẩm vào giỏ hàng", "1");
                int quantity;
                if (int.TryParse(userInput, out quantity) && quantity > 0)
                {
                    // Thêm sản phẩm vào giỏ hàng với số lượng tương ứng
                    string maSP = helpers.DataInCol(dgvSanPham, "MaSP");
                    string query = $"Exec proc_ThemCTHD {maHD}, {maSP}, {quantity}";
                    api.ExecQuery(query, "Thêm vào giỏ hàng thành công", false);
                    LoadDataCart(maHD);
                    LoadData();
                }
                else
                {
                    // Hiển thị thông báo lỗi nếu người dùng nhập giá trị không hợp lệ
                    MessageBox.Show("Số lượng không hợp lệ. Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.ColumnIndex == dgvSanPham.Columns["dgvXoa"].Index)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa sản phẩm không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string maSP = helpers.DataInCol(dgvSanPham, "MaSP");
                    string query = $"DELETE from SanPham WHERE MaSP = '{maSP}'";
                    api.ExecQuery(query, "Xóa sản phẩm thành công");
                    LoadData();
                }
            }
        }

        private void dgvSanPham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowFormSuaSanPham();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Invoke(new EventHandler(this.frmSanPham_Load));
        }

        private void cboLoaiSP_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading)
            {
                return;
            }
            FilterSanPham(cboLoaiSP, cboTinhTrang);
        }

        private void cboTinhTrang_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading)
            {
                return;
            }
            FilterSanPham(cboLoaiSP, cboTinhTrang);
        }

        private void txtTimKiem__TextChanged(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM dbo.func_TimKiemSanPham('{txtTimKiem.Texts}')";
            dgvSanPham.DataSource = api.TimKiemKhachHang(query);
        }

        private void cboMaKH_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading || cboMaKH.SelectedValue is null)
            {
                txtTenKH.Texts = "";
                return;
            }
            txtTenKH.Texts = api.FuncScalar($"SELECT TenKH from KhachHang where MaKH = '{cboMaKH.SelectedValue}'");
        }

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            this.maHD = api.FuncScalar($"DECLARE @MaHDnew int\r\nEXEC proc_TaoHoaDon '{cboMaKH.SelectedValue}', '{DateTime.Now}', @MaHDnew OUTPUT;\r\nSELECT @MaHDnew");

            if (!(maHD is null))
            {
                MessageBox.Show("Tạo hóa đơn thành công", "Thông báo thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtMaHD.Texts = maHD;
                btnXoaHoaDon.Enabled = true;
                btnTaoHoaDon.Enabled = false;
                btnXuatHoaDon.Enabled = true;
            }
        }

        private void btnXoaHoaDon_Click(object sender, EventArgs e)
        {
            
            txtMaHD.Texts = "";
            txtTenKH.Texts = "";
            string queryTimHD = $"DELETE from HoaDon WHERE MaHD = '{maHD}'";
            string queryXoaCTHD = $"DELETE from ChiTietHoaDon where MaHD = '{maHD}'";

            api.ExecQuery(queryXoaCTHD, "", false);
            LoadDataCart(maHD);

            api.ExecQuery(queryTimHD, "Xóa hoá đơn thành công");
            this.maHD = null;
            btnXoaHoaDon.Enabled = false;
            btnTaoHoaDon.Enabled = true;
            btnXuatHoaDon.Enabled = false;
            this.Invoke(new EventHandler(this.frmSanPham_Load));
        }

        private void dgvCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvCart.Columns["dgvSuaCart"].Index && !(this.maHD is null))
            {
                int quantity = int.Parse(helpers.DataInCol(dgvCart, "SoLuongCart"));
                string userInput = Interaction.InputBox("Bạn muốn sửa số lượng bao nhiêu?", "Sửa số lượng sản phẩm", quantity.ToString());
                if (int.TryParse(userInput, out quantity) && quantity > 0)
                {
                    // Thêm sản phẩm vào giỏ hàng với số lượng tương ứng
                    string maSP = helpers.DataInCol(dgvCart, "MaSPCart");
                    string query = $"Update ChiTietHoaDon set SoLuong = {quantity} where MaSP = {maSP} and MaHD = {maHD}";
                    api.ExecQuery(query, "Sửa số lượng thành công", false);
                    LoadDataCart(maHD);
                    LoadData();
                }
            }
            else if (e.ColumnIndex == dgvCart.Columns["dgvXoaCart"].Index)
            {
                if (maHD is null)
                {
                    return;
                }
                string maSP = helpers.DataInCol(dgvCart, "MaSPCart");
                string query = $"DELETE from ChiTietHoaDon WHERE MaSP = '{maSP}' and MaHD = '{maHD}'";
                api.ExecQuery(query, "Xóa sản phẩm thành công", false);
                LoadData();
                LoadDataCart(maHD);
            }
        }

        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            ShowFormChiTietHoaDon();
        }
    }
}
