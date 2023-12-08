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
            ChartArea area2 = new ChartArea();

            chart1.ChartAreas.Add(area);
            chart2.ChartAreas.Add(area2);
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart2.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

            // Nhóm dữ liệu theo năm và tháng, sau đó tính tổng giá trị trong mỗi tháng của mỗi năm
            var data = db.HoaDons.Where(hd => hd.TinhTrang.Equals("Đã thanh toán"))
                                  .GroupBy(hd => new { hd.NgayTao.Year, hd.NgayTao.Month })
                                  .Select(g => new { Nam = g.Key.Year, Thang = g.Key.Month, DoanhThu = g.Sum(hd => hd.TongGiaTri) })
                                  .OrderBy(d => d.Nam).ThenBy(d => d.Thang);

            // Tạo một mảng chứa các màu
            Color[] colors = { Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.Purple, Color.Orange };

            int colorIndex = 0;
            // Tạo một series cho mỗi năm
            foreach (var year in data.Select(d => d.Nam).Distinct())
            {
                var yearData = data.Where(d => d.Nam == year);

                var series = new Series($"Doanh thu năm {year}");
                series.IsValueShownAsLabel = true;
                series.ChartType = SeriesChartType.Line;
                series.BorderWidth = 3;
                series.MarkerStyle = MarkerStyle.Circle;
                series.MarkerSize = 10;

                var series2 = new Series($"Doanh thu năm {year}");
                series2.IsValueShownAsLabel = true;
                series2.ChartType = SeriesChartType.Column;
                series2.BorderWidth = 3;

                // Gán dữ liệu cho series
                series.Points.DataBindXY(yearData.Select(d => d.Thang), yearData.Select(d => d.DoanhThu));
                series2.Points.DataBindXY(yearData.Select(d => d.Thang), yearData.Select(d => d.DoanhThu));

                // Gán màu cho series
                series.Color = colors[colorIndex % colors.Length];
                series2.Color = colors[colorIndex % colors.Length];

                // Thêm series vào biểu đồ
                chart1.Series.Add(series2);
                chart2.Series.Add(series);

                colorIndex++;
            }

            // Đặt tên cho các trục
            chart1.ChartAreas[0].AxisX.Title = "Tháng";
            chart1.ChartAreas[0].AxisY.Title = "Tổng giá trị";
            chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Number;
            chart1.ChartAreas[0].AxisX.Minimum = 1;
            chart1.ChartAreas[0].AxisX.Maximum = 12;
            chart1.ChartAreas[0].AxisX.Interval = 1;

            // Định dạng lại các nhãn trên trục Y
            chart1.ChartAreas[0].AxisY.LabelStyle.Format = "{0:0,0} đồng";

            // Đặt tên cho các trục
            chart2.ChartAreas[0].AxisX.Title = "Tháng";
            chart2.ChartAreas[0].AxisY.Title = "Tổng giá trị";
            chart2.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Number;
            chart2.ChartAreas[0].AxisX.Minimum = 1;
            chart2.ChartAreas[0].AxisX.Maximum = 12;
            chart2.ChartAreas[0].AxisX.Interval = 1;

            // Định dạng lại các nhãn trên trục Y
            chart2.ChartAreas[0].AxisY.LabelStyle.Format = "{0:0,0} đồng";
        }

        private void frmBieuDo_Load(object sender, EventArgs e)
        {

        }
    }
}
