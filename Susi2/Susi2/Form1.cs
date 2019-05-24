using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Susi2
{
  public partial class Form1 : Form
  {
    int mrg = 50;
    int sqrSize = 30;
    int gridSize = 100;
    Graphics g;
    Pen pen = new Pen(Color.Black);
    Pen dashPen = new Pen(Color.Blue);

    public Form1()
    {
      InitializeComponent();      
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      base.OnPaint(e);

      for (int i = 0; i < 5; i++)
      {
        g.DrawLine(pen, mrg, mrg + i * gridSize, mrg + 4 * gridSize, mrg + i*gridSize );  // 가로선
        g.DrawLine(pen, mrg + i * gridSize, mrg, mrg + i * gridSize, mrg + 4 * gridSize);
      }

      g.DrawLine(dashPen, mrg, mrg, mrg + 4 * gridSize, mrg + 4 * gridSize);
      g.DrawLine(dashPen, mrg, mrg + 4 * gridSize, mrg + 4 * gridSize, mrg);

      int half = mrg + 2 * gridSize;
      int end = mrg + 4 * gridSize;

      g.DrawLine(dashPen, mrg, half, half, mrg);
      g.DrawLine(dashPen, half, mrg, end, half);
      g.DrawLine(dashPen, mrg, half, half, end);
      g.DrawLine(dashPen, half, end, end, half);

      for (int x = 1; x <= 3; x += 2)
        for (int y = 1; y <= 3; y += 2)
        {
          Rectangle r = new Rectangle(mrg + x * gridSize - sqrSize / 2, 
            mrg + y * gridSize - sqrSize / 2, sqrSize, sqrSize);
          g.FillEllipse(new SolidBrush(Color.Red), r);
        }
      g.FillEllipse(new SolidBrush(Color.Red), 
        new Rectangle(half - sqrSize/2, half - sqrSize/2, sqrSize, sqrSize));
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this.Text = "학번 이름";
      this.ClientSize = new Size(2 * mrg + 4 * gridSize, 2 * mrg + 4 * gridSize + menuStrip1.Height);
      g = panel1.CreateGraphics();
      panel1.BackColor = Color.Orange;
    }

    private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void Form1_Move(object sender, EventArgs e)
    {
      Invalidate(); // Paint 이벤트를 강제로 만듭니다. 
                    // ONPaint()호출
    }
  }
}
