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

namespace Project_CuoiKy.Forms.FormSanPham
{
    public partial class frmSuaSanPham : Form
    {
        private ApiService api = new ApiService();
        private Helpers helpers = new Helpers();
        private string maSP;
        private string tenSP;
        private string maNCC;
        private string soLuongConLai;
        private string donGia;
        private string loaiSP;

        public frmSuaSanPham()
        {
            InitializeComponent();
        }

        public frmSuaSanPham(string maSP, string tenSP, string loaiSP ,string maNCC, string soLuongConLai, string donGia)
        {
            InitializeComponent();
            this.maSP = maSP;
            this.loaiSP = loaiSP;
            this.tenSP = txtTenSanPham.Texts = tenSP;
            this.maNCC = maNCC;
            this.soLuongConLai = txtSoLuong.Texts = soLuongConLai;
            this.donGia = txtDonGia.Texts = donGia;

            LoadComboBox();
        }
        private void LoadComboBox()
        {
            cboMaNCC = helpers.CboData("select distinct MaNCC from NhaCungCap", cboMaNCC, "MaNCC");
            cboMaNCC.SelectedValue = maNCC;

            cboLoaiSP = helpers.CboData("select distinct LoaiSP from SanPham", cboLoaiSP, "LoaiSP");
            cboLoaiSP.SelectedValue = loaiSP;
        }
        private void btnLuuThongTin_Click(object sender, EventArgs e)
        {
            string donGia = txtDonGia.Texts.Trim() == "" ? "0" : txtDonGia.Texts;
            string query = $"EXEC [SuaThongTinSanPham] {maSP}, N'{txtTenSanPham.Texts}', N'{cboLoaiSP.SelectedValue}', {cboMaNCC.SelectedValue}, {int.Parse(txtSoLuong.Texts)}, {double.Parse(donGia)}";
            this.DialogResult = api.ExecQuery(query, "Sửa sản phẩm thành công") ? DialogResult.OK : DialogResult.None;
        }

        private void cboLoaiSP_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboMaNCC_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
