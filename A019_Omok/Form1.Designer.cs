﻿namespace A019_Omok
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
      this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.다시시작ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.그리기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.이미지ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.panel1 = new System.Windows.Forms.Panel();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.보기ToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(284, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // 파일ToolStripMenuItem
      // 
      this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.다시시작ToolStripMenuItem,
            this.종료ToolStripMenuItem});
      this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
      this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
      this.파일ToolStripMenuItem.Text = "파일";
      // 
      // 다시시작ToolStripMenuItem
      // 
      this.다시시작ToolStripMenuItem.Name = "다시시작ToolStripMenuItem";
      this.다시시작ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
      this.다시시작ToolStripMenuItem.Text = "다시 시작";
      // 
      // 종료ToolStripMenuItem
      // 
      this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
      this.종료ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
      this.종료ToolStripMenuItem.Text = "종료";
      // 
      // 보기ToolStripMenuItem
      // 
      this.보기ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.그리기ToolStripMenuItem,
            this.이미지ToolStripMenuItem});
      this.보기ToolStripMenuItem.Name = "보기ToolStripMenuItem";
      this.보기ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
      this.보기ToolStripMenuItem.Text = "보기";
      // 
      // 그리기ToolStripMenuItem
      // 
      this.그리기ToolStripMenuItem.Name = "그리기ToolStripMenuItem";
      this.그리기ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
      this.그리기ToolStripMenuItem.Text = "그리기";
      // 
      // 이미지ToolStripMenuItem
      // 
      this.이미지ToolStripMenuItem.Name = "이미지ToolStripMenuItem";
      this.이미지ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.이미지ToolStripMenuItem.Text = "이미지";
      this.이미지ToolStripMenuItem.Click += new System.EventHandler(this.이미지ToolStripMenuItem_Click);
      // 
      // panel1
      // 
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(0, 24);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(284, 237);
      this.panel1.TabIndex = 1;
      this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 261);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.menuStrip1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "오목";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.Move += new System.EventHandler(this.Form1_Move);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 다시시작ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 보기ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 그리기ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 이미지ToolStripMenuItem;
    private System.Windows.Forms.Panel panel1;
  }
}

