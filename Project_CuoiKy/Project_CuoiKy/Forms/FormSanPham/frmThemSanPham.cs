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
    public partial class frmThemSanPham : Form
    {
        private ApiService api = new ApiService();
        private Helpers helpers = new Helpers();
  

        public frmThemSanPham()
        {
            InitializeComponent();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            string donGia = txtDonGia.Texts.Trim() == "" ? "0" : txtDonGia.Texts;
            string query = $"EXEC ThemSanPham N'{txtTenSanPham.Texts}', N'{cboLoaiSP.SelectedValue}', {cboMaNCC.SelectedValue}, {int.Parse(txtSoLuong.Texts)}, {double.Parse(donGia)}";
            this.DialogResult = api.ExecQuery(query, "Thêm sản phẩm thành công") ? DialogResult.OK : DialogResult.None;
        }
        private void LoadComboBox()
        {
            cboMaNCC = helpers.CboData("select distinct MaNCC from NhaCungCap", cboMaNCC, "MaNCC");
            cboMaNCC.Texts = "Mã nhà cung cấp";

            cboLoaiSP = helpers.CboData("select distinct LoaiSP from SanPham", cboLoaiSP, "LoaiSP");
            cboLoaiSP.Texts = "Loại sản phẩm";
        }
        private void frmThemSanPham_Load(object sender, EventArgs e)
        {
            LoadComboBox();
        }

        private void cboLoaiSP_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboMaNCC_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
