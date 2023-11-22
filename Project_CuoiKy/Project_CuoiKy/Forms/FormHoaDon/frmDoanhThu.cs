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

namespace Project_CuoiKy.Forms.FormHoaDon
{
    public partial class frmDoanhThu : Form
    {
        ApiService api = new ApiService();
        Helpers helper = new Helpers();
        private string ngayTao;

        public frmDoanhThu()
        {
            InitializeComponent();
        }

        public frmDoanhThu(string ngayTao)
        {
            InitializeComponent();
            this.ngayTao = ngayTao;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            
            string query = $"EXEC proc_LocHoaDonTheoNgay '{dtpNgayDau.Value}', '{dtpNgayCuoi.Value}'";
            rptDoanhThu r = new rptDoanhThu();
            r.SetDataSource(api.CreateTable(query));
            r.SetParameterValue("pStartDate", dtpNgayDau.Value);
            r.SetParameterValue("pEndDate", dtpNgayCuoi.Value);

            crysDoanhThu.ReportSource = r;
        }
      
    }
}
