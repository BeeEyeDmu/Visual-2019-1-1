using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A029_FormDClock
{
  public partial class Form1 : Form
  {
    Timer t = new Timer();

    public Form1()
    {
      InitializeComponent();
      this.BackColor = Color.DarkOrchid;
      label1.ForeColor = Color.White;

      t.Interval = 10;  // 0.01초
      t.Tick += T_Tick;
      t.Start();  
    }

    private void T_Tick(object sender, EventArgs e)
    {
      string s = string.Format("{0}:{1,3:D3}",
        DateTime.Now.ToString(), DateTime.Now.Millisecond);
      label1.Text = s;
    }

    private void Form1_SizeChanged(object sender, EventArgs e)
    {
      label1.Left = this.Width / 2 - label1.Width / 2;
      label1.Top = this.ClientSize.Height / 2 - label1.Height / 2;
    }
  }
}
