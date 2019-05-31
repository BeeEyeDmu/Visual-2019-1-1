namespace A030_FormClock
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
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.시계종류ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.디지털ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.아날로그ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.panel1 = new System.Windows.Forms.Panel();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.시계종류ToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(284, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // 시계종류ToolStripMenuItem
      // 
      this.시계종류ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.디지털ToolStripMenuItem,
            this.아날로그ToolStripMenuItem});
      this.시계종류ToolStripMenuItem.Name = "시계종류ToolStripMenuItem";
      this.시계종류ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
      this.시계종류ToolStripMenuItem.Text = "시계 종류";
      // 
      // 디지털ToolStripMenuItem
      // 
      this.디지털ToolStripMenuItem.Name = "디지털ToolStripMenuItem";
      this.디지털ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.디지털ToolStripMenuItem.Text = "디지털";
      this.디지털ToolStripMenuItem.Click += new System.EventHandler(this.디지털ToolStripMenuItem_Click);
      // 
      // 아날로그ToolStripMenuItem
      // 
      this.아날로그ToolStripMenuItem.Name = "아날로그ToolStripMenuItem";
      this.아날로그ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.아날로그ToolStripMenuItem.Text = "아날로그";
      this.아날로그ToolStripMenuItem.Click += new System.EventHandler(this.아날로그ToolStripMenuItem_Click);
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      this.panel1.Location = new System.Drawing.Point(0, 24);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(284, 237);
      this.panel1.TabIndex = 1;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 261);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "Form1";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem 시계종류ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 디지털ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 아날로그ToolStripMenuItem;
    private System.Windows.Forms.Panel panel1;
  }
}

