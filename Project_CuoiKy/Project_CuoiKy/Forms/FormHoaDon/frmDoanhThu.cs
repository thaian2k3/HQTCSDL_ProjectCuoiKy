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

        public frmDoanhThu()
        {
            InitializeComponent();
        }

        public frmDoanhThu(string ngayTao)
        {
            InitializeComponent();
        }

        private void XuatDoanhThu(DateTime ngayDau, DateTime ngayCuoi)
        {
            string query = $"EXEC proc_LocHoaDonTheoNgay '{ngayDau}', '{ngayCuoi}'";
            rptDoanhThu r = new rptDoanhThu();
            r.SetDataSource(api.CreateTable(query));
            r.SetParameterValue("pStartDate", ngayDau);
            r.SetParameterValue("pEndDate", ngayCuoi);

            crysDoanhThu.ReportSource = r;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            //string query = $"EXEC proc_LocHoaDonTheoNgay '{dtpNgayDau.Value}', '{dtpNgayCuoi.Value}'";
            //rptDoanhThu r = new rptDoanhThu();
            //r.SetDataSource(api.CreateTable(query));
            //r.SetParameterValue("pStartDate", dtpNgayDau.Value);
            //r.SetParameterValue("pEndDate", dtpNgayCuoi.Value);

            //crysDoanhThu.ReportSource = r;
            XuatDoanhThu(dtpNgayDau.Value, dtpNgayCuoi.Value);
        }

        private void btnWeek_Click(object sender, EventArgs e)
        {
            dtpNgayCuoi.Value = dtpNgayDau.Value.AddDays(7);
            XuatDoanhThu(dtpNgayDau.Value, dtpNgayCuoi.Value);
        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            dtpNgayCuoi.Value = dtpNgayDau.Value.AddMonths(1);
            XuatDoanhThu(dtpNgayDau.Value, dtpNgayCuoi.Value);
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            dtpNgayCuoi.Value = dtpNgayDau.Value.AddYears(1);
            XuatDoanhThu(dtpNgayDau.Value, dtpNgayCuoi.Value);
        }
    }
}
