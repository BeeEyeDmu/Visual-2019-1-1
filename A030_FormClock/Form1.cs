using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A030_FormClock
{
  public partial class Form1 : Form
  {
    Graphics g;             // Graphics 객체
    private Point center;   // 중심점
    private double radius;  // 반지름
    private int hourHand;   // 시침의 길이
    private int minHand;    // 분침의 길이
    private int secHand;    // 초침의 길이
    private Timer timer1;    // 타이머
    private const int clientSize = 500; // clientSize
    private const int clockSize = 400;  // 시계판의지름
    Label dClock = new Label();

    public Form1()
    {
      InitializeComponent();
            
      this.ClientSize = new Size(clientSize, clientSize+menuStrip1.Height);
      this.Text = "Analog Clock";
      panel1.BackColor = Color.WhiteSmoke;
      this.Padding = new Padding(10);
      g = panel1.CreateGraphics();

      aClockSetting();  // 아날로그 클럭 세팅
      TimerSetting();   // 타이머 세팅
    }

    private void dClockSetting()
    {      
      dClock.Font = new Font("맑은 고딕", 20, FontStyle.Bold);
      dClock.ForeColor = Color.RoyalBlue;
      dClock.Width = clientSize;
      dClock.Height = 40;
      dClock.Location = new Point(0, (int)radius - dClock.Height/2);      
      dClock.TextAlign = ContentAlignment.MiddleCenter;
      panel1.Controls.Add(dClock);
    }

    private void TimerSetting()
    {
      timer1 = new Timer();
      timer1.Interval = 1000;     // 1초에 한번씩
      timer1.Tick += Timer1_Tick;
      timer1.Start();
    }

    private void Timer1_Tick(object sender, EventArgs e)
    {
      DateTime c = DateTime.Now;   // 현재시간

      if (dFlag == false)
      {
        panel1.Refresh();

        DrawClockFace(); // 시계판그리기

        // 시침, 분침, 초침의각도(단위: 라디안)
        double radHr = (c.Hour % 12 + c.Minute / 60.0) * 30 * Math.PI / 180;
        double radMin = (c.Minute + c.Second / 60.0) * 6 * Math.PI / 180;
        double radSec = (c.Second /*+ c.Millisecond/1000.0*/) * 6 * Math.PI / 180;

        DrawHands(radHr, radMin, radSec); // 바늘그리기
      }
      else
      {
        dClock.Text = c.ToString();
      }
    }

    private void DrawHands(double radHr, double radMin, double radSec)
    {
      // 시침
      DrawLine((int)(hourHand * Math.Sin(radHr)),
         (int)(-hourHand * Math.Cos(radHr)),
          0, 0, Brushes.RoyalBlue, 8, center.X, center.Y);
      // 분침
      DrawLine((int)(minHand * Math.Sin(radMin)),
         (int)(-minHand * Math.Cos(radMin)),
          0, 0, Brushes.SkyBlue, 6, center.X, center.Y);
      // 초침
      DrawLine((int)(secHand * Math.Sin(radSec)),
          (int)(-secHand * Math.Cos(radSec)),
          0, 0, Brushes.OrangeRed, 3, center.X, center.Y);

      // 시계 배꼽
      int coreSize = 16;
      Rectangle r = new Rectangle(center.X - coreSize / 2,
          center.Y - coreSize / 2, coreSize, coreSize);
      g.FillEllipse(Brushes.Gold, r);
      Pen p = new Pen(Brushes.DarkRed, 3);
      g.DrawEllipse(p, r);
    }

    private void DrawLine(int x1, int y1, int x2, int y2, Brush color,
        int thick, int cx, int cy)
    {
      Pen pen = new Pen(color, thick);
      pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
      pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
      g.DrawLine(pen, x1 + cx, y1 + cy, x2 + cx, y2 + cy);
    }

    private void DrawClockFace()
    {
      Pen pen = new Pen(Brushes.LightSteelBlue, 30);
      g.DrawEllipse(pen, center.X - clockSize / 2,
        center.Y - clockSize / 2, clockSize, clockSize);
    }

    private void aClockSetting()
    {
      center = new Point(panel1.Width / 2, panel1.Height / 2);
      radius = panel1.Height / 2;

      hourHand = (int)(radius * 0.45);
      minHand = (int)(radius * 0.55);
      secHand = (int)(radius * 0.65);
    }

    /*
    private void T_Tick(object sender, EventArgs e)
    {
      panel1.Refresh();

      int sec = DateTime.Now.Second;
      double secDeg = 6 * sec;  // 1초당 6도씩
      double secRad = secDeg * Math.PI / 180; // 라디안
      double secX = 120 * Math.Sin(secRad);
      double secY = 120 * Math.Cos(secRad);
      int x = 150 + (int)secX;
      int y = 150 - (int)secY;  // -인 점을 주의할 것

      g.DrawLine(new Pen(Color.Blue), new Point(150, 150),
        new Point(x, y));

      int min = DateTime.Now.Minute;
      double minDeg = 6 * min;  // 1초당 6도씩
      double minRad = minDeg * Math.PI / 180; // 라디안
      double minX = 100 * Math.Sin(minRad);
      double minY = 100 * Math.Cos(minRad);
      x = 150 + (int)minX;
      y = 150 - (int)minY;  // -인 점을 주의할 것

      g.DrawLine(new Pen(Color.Red), new Point(150, 150),
        new Point(x, y));

      int hour = DateTime.Now.Hour;
      double hourDeg = 30 * hour + 0.5 * min;  // 1시간당 30도씩
      double hourRad = hourDeg * Math.PI / 180; // 라디안
      double hourX = 80 * Math.Sin(hourRad);
      double hourY = 80 * Math.Cos(hourRad);
      x = 150 + (int)hourX;
      y = 150 - (int)hourY;  // -인 점을 주의할 것

      g.DrawLine(new Pen(Color.Black), new Point(150, 150),
        new Point(x, y));
    }
    */

    bool dFlag = false;

    private void 디지털ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      dFlag = true;
      //dClock.Visible = true;
      dClockSetting();
    }

    private void 아날로그ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      dFlag = false;
      if (dClock != null)
        panel1.Controls.Remove(dClock);
      panel1.Refresh();
      //Console.WriteLine("Analog Click");
    }
  }
}
