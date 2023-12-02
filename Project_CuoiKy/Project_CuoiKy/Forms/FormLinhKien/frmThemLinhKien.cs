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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Project_CuoiKy.Forms.FormLinhKien
{
    public partial class frmThemLinhKien : Form
    {
        private ApiService api = new ApiService();
        private Helpers helpers = new Helpers();

        public frmThemLinhKien()
        {
            InitializeComponent();

            btnThem.Visible = ACCOUNT.Role == "ADMIN";
        }
  
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maMay;
            if (cboMaMay.SelectedValue != null)
            {
                maMay = cboMaMay.SelectedValue.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mã máy", "Lưu ý", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                return;
            }
            string maNCC = cboNhaCC.SelectedValue.ToString();
            string loaiLK = cboLoaiLK.SelectedItem.ToString();
            string tenHang = txtTenHang.Texts;
            string model = txtModel.Texts;
            string tinhTrang = "Đang sử dụng";
            string thongSo = txtThongSo.Texts;
            string query = $"EXEC proc_ThemLinhKien {maMay}, {maNCC}, N'{loaiLK}', N'{tenHang}', N'{model}', N'{tinhTrang}', N'{thongSo}'";
            this.DialogResult = api.ExecQuery(query, "Thêm linh kiện thành công") ? DialogResult.OK : DialogResult.None;
        }

        private void frmThemLinhKien_Load(object sender, EventArgs e)
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
