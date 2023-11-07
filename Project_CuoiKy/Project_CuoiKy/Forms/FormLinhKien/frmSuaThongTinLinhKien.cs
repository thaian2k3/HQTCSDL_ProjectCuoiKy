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
        private string model;
        private string tinhTrang;
        private string thongSo;
        public frmSuaThongTinLinhKien()
        {
            InitializeComponent();
        }
        public frmSuaThongTinLinhKien(string maLK, string maMay, string maNCC, string loaiLK, string tenHang, string model, string tinhTrang, string thongSo)
        {
            InitializeComponent();
            this.maLK = maLK;
            txtModel.Texts = maNCC;
            txtTenHang.Texts = tenHang;
            txtThongSo.Texts = thongSo;
            txtTinhTrang.Texts = tinhTrang;
            /// không biết đổ dữ liệu vào 2 cái này sao hết máy ông, help
            /*GanGiaTriChoCBO(cboNhaCC, maNCC);
            GanGiaTriChoCBO(cboMaMay, maMay);*/
            cboLoaiLK.SelectedItem = loaiLK;
        }
        private void GanGiaTriChoCBO(RJComboBox ComboBox1, string value)
        {
            int Selected = 1;
            int count = ComboBox1.Items.Count;
            for (int i = 0; (i <= (count - 1)); i++)
            {
                ComboBox1.SelectedIndex = i;
                if ((string)(ComboBox1.SelectedValue) == value)
                {
                    Selected = i;
                }

            }

            ComboBox1.SelectedIndex = Selected;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string maMay = cboMaMay.SelectedValue.ToString();
            string maNCC = cboNhaCC.SelectedValue.ToString();
            string loaiLK = cboLoaiLK.SelectedItem.ToString();
            string tenHang = txtTenHang.Texts;
            string model = txtModel.Texts;
            string tinhTrang = txtTinhTrang.Texts;
            string thongSo = txtThongSo.Texts;
            string query = $"EXEC proc_SuaLinhKien {maLK}, {maMay}, {maNCC}, N'{loaiLK}', N'{tenHang}', N'{model}', N'{tinhTrang}', N'{thongSo}'";
            this.DialogResult = api.ExecQuery(query, "Sửa linh kiện thành công") ? DialogResult.OK : DialogResult.None;
        }

        private void frmSuaThongTinLinhKien_Load(object sender, EventArgs e)
        {
            string query = "Select MaMay from May";
            cboMaMay = helpers.CboData(query, cboMaMay, "MaMay");
            cboMaMay.Texts = "Chọn mã máy";
            string query2 = "Select MaNCC from NhaCungCap";
            cboNhaCC = helpers.CboData(query2, cboNhaCC, "MaNCC");
            cboNhaCC.Texts = "Chọn mã nhà cung cấp";
        }
    }
}
