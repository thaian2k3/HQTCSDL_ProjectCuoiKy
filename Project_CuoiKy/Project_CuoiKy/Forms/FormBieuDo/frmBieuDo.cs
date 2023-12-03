using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Project_CuoiKy.Forms.FormBieuDo
{
    public partial class frmBieuDo : Form
    {
        private HoaDonDataContext db = new HoaDonDataContext();
        public frmBieuDo()
        {
            InitializeComponent();
        }

        private void btnLoadChart_Click(object sender, EventArgs e)
        {
            ChartArea area = new ChartArea();
            chart1.ChartAreas.Add(area);

            // Sử dụng Linq để nhóm dữ liệu theo tháng và tính tổng giá trị trong mỗi tháng
            var data = db.HoaDons.Where(hd => hd.TinhTrang.Equals("Đã thanh toán"))
                              .GroupBy(hd => hd.NgayTao.Month)
                              .Select(g => new { Thang = g.Key, DoanhThu = g.Sum(hd => hd.TongGiaTri) })
                              .OrderBy(d => d.Thang);

            // Tạo một series mới cho biểu đồ đường
            var series = new Series("Doanh thu theo tháng");
            series.IsValueShownAsLabel= true;
            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = 3;
            series.MarkerStyle = MarkerStyle.Circle;
            series.MarkerSize = 10;

            // Gán dữ liệu cho series
            series.Points.DataBindXY(data.Select(d => d.Thang), data.Select(d => d.DoanhThu));

            // Thêm series vào biểu đồ
            chart1.Series.Add(series);


            // Đặt tên cho các trục
            chart1.ChartAreas[0].AxisX.Title = "Tháng";
            chart1.ChartAreas[0].AxisY.Title = "Tổng giá trị";
            chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Number;
            chart1.ChartAreas[0].AxisX.Minimum = 1;
            chart1.ChartAreas[0].AxisX.Maximum = 12;
            chart1.ChartAreas[0].AxisX.Interval = 1;

            // Định dạng lại các nhãn trên trục Y
            chart1.ChartAreas[0].AxisY.LabelStyle.Format = "{0:0,0} đồng";
        }
    }
}
