namespace A027_EcgPpg
{
  partial class Form1
  {
    /// <summary>
    /// 필수 디자이너 변수입니다.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 사용 중인 모든 리소스를 정리합니다.
    /// </summary>
    /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form 디자이너에서 생성한 코드

    /// <summary>
    /// 디자이너 지원에 필요한 메서드입니다. 
    /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
    /// </summary>
    private void InitializeComponent()
    {
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.viewAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.autoScrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllToolStripMenuItem,
            this.autoScrollToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(581, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // viewAllToolStripMenuItem
      // 
      this.viewAllToolStripMenuItem.Name = "viewAllToolStripMenuItem";
      this.viewAllToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
      this.viewAllToolStripMenuItem.Text = "View All";
      this.viewAllToolStripMenuItem.Click += new System.EventHandler(this.viewAllToolStripMenuItem_Click);
      // 
      // autoScrollToolStripMenuItem
      // 
      this.autoScrollToolStripMenuItem.Name = "autoScrollToolStripMenuItem";
      this.autoScrollToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
      this.autoScrollToolStripMenuItem.Text = "Auto Scroll";
      this.autoScrollToolStripMenuItem.Click += new System.EventHandler(this.autoScrollToolStripMenuItem_Click);
      // 
      // chart1
      // 
      chartArea2.Name = "ChartArea1";
      this.chart1.ChartAreas.Add(chartArea2);
      this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
      legend2.Name = "Legend1";
      this.chart1.Legends.Add(legend2);
      this.chart1.Location = new System.Drawing.Point(0, 24);
      this.chart1.Name = "chart1";
      series2.ChartArea = "ChartArea1";
      series2.Legend = "Legend1";
      series2.Name = "Series1";
      this.chart1.Series.Add(series2);
      this.chart1.Size = new System.Drawing.Size(581, 366);
      this.chart1.TabIndex = 1;
      this.chart1.Text = "chart1";
      this.chart1.Click += new System.EventHandler(this.chart1_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(581, 390);
      this.Controls.Add(this.chart1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "Form1";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem viewAllToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem autoScrollToolStripMenuItem;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
  }
}

