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

namespace A025_susiPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Chart Control in winForm";
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            // chart1 컨트롤에 Collection에 있었던 내용을 삭제
            chart1.ChartAreas.Clear();
            chart1.Series.Clear();

            // ChartArea 추가
            chart1.ChartAreas.Add("Draw");
            chart1.ChartAreas["Draw"].BackColor = Color.Blue;

            // ChartArea X축과 Y축을 설정
            chart1.ChartAreas["Draw"].AxisX.Minimum = 0;                                           //최소값
            chart1.ChartAreas["Draw"].AxisX.Maximum = 100;                                            //최대값
                                                          //간격
            chart1.ChartAreas["Draw"].AxisX.MajorGrid.LineColor = Color.Gray;                     // 선 색
            chart1.ChartAreas["Draw"].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;  //모눈선 스타일

            chart1.ChartAreas["Draw"].AxisY.Minimum = 0;
            chart1.ChartAreas["Draw"].AxisY.Maximum = 100;
           
            chart1.ChartAreas["Draw"].AxisY.MajorGrid.LineColor = Color.Gray;
            chart1.ChartAreas["Draw"].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            // Series 추가(Sin)      
            chart1.Series.Add("O(Log2n)");
            chart1.Series["O(Log2n)"].ChartType = SeriesChartType.Line;
            chart1.Series["O(Log2n)"].Color = Color.LightGreen;
            chart1.Series["O(Log2n)"].BorderWidth = 2;
            chart1.Series["O(Log2n)"].LegendText = "O(Log2n)";

            // Series 추가(Cos)   
            chart1.Series.Add("O(n)");
            chart1.Series["O(n)"].ChartType = SeriesChartType.Line;
            chart1.Series["O(n)"].Color = Color.Orange;
            chart1.Series["O(n)"].BorderWidth = 2;
            chart1.Series["O(n)"].LegendText = "O(n)";

            chart1.Series.Add("O(n^2)");
            chart1.Series["O(n^2)"].ChartType = SeriesChartType.Line;
            chart1.Series["O(n^2)"].Color = Color.Yellow;
            chart1.Series["O(n^2)"].BorderWidth = 2;
            chart1.Series["O(n^2)"].LegendText = "O(n^2)";

           chart1.Series.Add("O(nLog2n)");
            chart1.Series["O(nLog2n)"].ChartType = SeriesChartType.Line;
            chart1.Series["O(nLog2n)"].Color = Color.Pink;
            chart1.Series["O(nLog2n)"].BorderWidth = 2;
            chart1.Series["O(nLog2n)"].LegendText = "O(nLog2n)";

            for (double x = -100; x < 10000; x +=0.1)
            {

                double y = Math.Log(x, 2);
                chart1.Series["O(Log2n)"].Points.AddXY(x, y);

                y = x;
                chart1.Series["O(n)"].Points.AddXY(x, y);

                y = Math.Pow(x, 2);
                chart1.Series["O(n^2)"].Points.AddXY(x, y);

                y = Math.Log(x, 2) * x;
                chart1.Series["O(nLog2n)"].Points.AddXY(x, y);
            }
        }
        }
}
