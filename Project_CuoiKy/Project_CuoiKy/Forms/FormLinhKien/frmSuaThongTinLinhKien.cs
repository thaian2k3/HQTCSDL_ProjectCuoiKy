using CustomControls.RJControls;
using Project_CuoiKy.Api;
using Project_CuoiKy.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_CuoiKy.Forms.FormLinhKien
{
    public partial class frmSuaThongTinLinhKien : Form
    {
        private ApiService api = new ApiService();
        private Helpers helpers = new Helpers();

        private string maLK;
        private string maMay;
        private string maNhaCC;
        private string loaiLinhKien;
        private string tenHang;
        private string tinhTrang;
        private string thongSo;
        private string model;
        public frmSuaThongTinLinhKien()
        {
            InitializeComponent();

            btnSua.Visible = ACCOUNT.Role == "ADMIN";
        }
        public frmSuaThongTinLinhKien(string maLK, string maMay, string maNCC, string loaiLK, string tenHang, string model, string tinhTrang, string thongSo)
        {
            InitializeComponent();
            this.maLK = maLK;
            this.model = txtModel.Texts = model;
            this.tenHang = txtTenHang.Texts = tenHang;
            this.thongSo = txtThongSo.Texts = thongSo;
            this.tinhTrang = txtTinhTrang.Texts = tinhTrang;
            this.loaiLinhKien = loaiLK;
            this.maNhaCC = maNCC;
            this.maMay = maMay;

            LoadComboBox();
        }
        
        private void btnSua_Click(object sender, EventArgs e)
        {
            string maMay;
            if (cboMaMay.SelectedValue != null)
            {
                maMay = cboMaMay.SelectedValue.ToString();
            }
            else
            {
                MessageBox.Show("Chọn máy dùng linh kiện");
                return;
            }
            string maNCC = cboNhaCC.SelectedValue.ToString();
            string loaiLK = cboLoaiLK.SelectedValue.ToString();
            string tenHang = txtTenHang.Texts;
            string model = txtModel.Texts;
            string tinhTrang = txtTinhTrang.Texts;
            string thongSo = txtThongSo.Texts;
            string query = $"EXEC proc_SuaLinhKien {maLK}, {maMay}, {maNCC}, N'{loaiLK}', N'{tenHang}', N'{model}', N'{tinhTrang}', N'{thongSo}'";
            this.DialogResult = api.ExecQuery(query, "Sửa linh kiện thành công") ? DialogResult.OK : DialogResult.None;
        }

        private void LoadComboBox()
        {
            string query = "Select MaMay from May";
            cboMaMay = helpers.CboData(query, cboMaMay, "MaMay");
            if (this.maMay != "")
            {
                cboMaMay.SelectedValue = this.maMay;
            }
            else
            {
                cboMaMay.Texts = "Mã máy";
            }

            string query2 = "Select MaNCC from NhaCungCap";
            cboNhaCC = helpers.CboData(query2, cboNhaCC, "MaNCC");
            cboNhaCC.SelectedValue = this.maNhaCC;

            string query3 = "Select LoaiLK from LinhKien";
            cboLoaiLK = helpers.CboData(query3, cboLoaiLK, "LoaiLK");
            cboLoaiLK.SelectedValue = this.loaiLinhKien;
        }
    }
}
