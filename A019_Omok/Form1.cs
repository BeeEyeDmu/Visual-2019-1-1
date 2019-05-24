using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A019_Omok
{
  enum STONE { none, black, white};

  public partial class Form1 : Form
  {
    int margin = 30;
    int 눈 = 30;
    int 화점 = 10;
    int 돌 = 28;
    Graphics g;
    Brush wBrush = new SolidBrush(Color.White);
    Brush bBrush = new SolidBrush(Color.Black);
    private bool flag;

    STONE[,] 바둑판 = new STONE[19, 19]; // 0:빈칸, 1:검은돌, 2:흰돌
    private bool imageFlag = true;

    int stoneCnt = 1; // 수순
    Font font = new Font("맑은 고딕", 10);  // 수순 출력용

    List<Revive> lstRevive = new List<Revive>();
    private string dirName;

    public Form1()
    {
      InitializeComponent();
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      ClientSize = new Size(2*margin + 18 * 눈,
        menuStrip1.Height + 2*margin + 18 * 눈);
      panel1.BackColor = Color.Orange;
      
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      base.OnPaint(e);
      Draw바둑판();
      Draw바둑돌();
    }

    private void Draw바둑돌()
    {
      // 2차원배열인 바둑판[x,y]를 모두 읽으면서
      // 저장된 값이 STONE.none이면 안 그리고
      // STONE.black이면 (x,y)에 검은 돌을 그리고
      // STONE.white이면 (x,y)에 흰돌을 그린다
      for (int x = 0; x < 19; x++)
      {
        for (int y = 0; y < 19; y++)
        {
          if (바둑판[x, y] == STONE.black)
              g.FillEllipse(bBrush,
                margin + 눈 * x - 눈 / 2, margin + 눈 * y - 눈 / 2,
                돌, 돌);

          else if (바둑판[x, y] == STONE.white)
              g.FillEllipse(wBrush,
                margin + 눈 * x - 눈 / 2, margin + 눈 * y - 눈 / 2,
                돌, 돌);
        }
      }
    }

    private void Draw바둑판()
    {
      g = panel1.CreateGraphics();
      Pen pen = new Pen(Color.Black);

      for (int i = 0; i < 19; i++)
      {
        // 가로줄
        g.DrawLine(pen, margin, margin + i * 눈,
          margin + 18 * 눈, margin + i * 눈);
        // 세로줄
        g.DrawLine(pen, margin + i * 눈, margin,
          margin + i * 눈, margin + 눈 * 18);
      }

      for(int x = 3; x <=15; x+=6)
        for(int y = 3; y<=15; y += 6)
        {
          g.FillEllipse(bBrush, 
            margin + 눈 * x - 화점/2, margin + 눈 * y - 화점/2,
            화점, 화점);
        }
    }

    private void Form1_Move(object sender, EventArgs e)
    {
      Draw바둑판();
      Draw바둑돌();
    }

    private void panel1_MouseDown(object sender, MouseEventArgs e)
    {
      //MessageBox.Show(e.X + ", " + e.Y);
      // 좌표변환
      int x = (e.X - margin + 눈/2) / 눈;
      int y = (e.Y - margin + 눈/2) / 눈;

      if (바둑판[x, y] != STONE.none)
        return;

      Rectangle r
        = new Rectangle(
          margin + 눈 * x - 눈 / 2,
          margin + 눈 * y - 눈 / 2,
          돌,
          돌);

      if (flag == false)  // 검은돌
      {
        if (imageFlag == false)  // FillEllipse()로 그리기
        {
          g.FillEllipse(bBrush, r);
        }
        else  // 이미지로 그리기
        {
          Bitmap bmp = new Bitmap("../../Images/black.png");
          g.DrawImage(bmp, r);
        }
        lstRevive.Add(new Revive(x, y, STONE.black, stoneCnt));
        //Revive rev = new Revive(x, y, STONE.black, stoneCnt);
        //lstRevive.Add(rev);

        DrawStoneSequence(stoneCnt++, Brushes.White, r); // 추가
        flag = true;
        바둑판[x, y] = STONE.black;
      }
      else  // 흰돌
      {
        if (imageFlag == false)
        {
          g.FillEllipse(wBrush,r);
        }
        else
        {
          Bitmap bmp = new Bitmap("../../Images/white.png");
          g.DrawImage(bmp,r);
        }
        lstRevive.Add(new Revive(x, y, STONE.white, stoneCnt));
        DrawStoneSequence(stoneCnt++, Brushes.Black, r); // 추가
        flag = false;
        바둑판[x, y] = STONE.white;
      }

      CheckOmok(x, y);
    }

    private void DrawStoneSequence(int v, Brush color, Rectangle r)
    {
      StringFormat stringFormat = new StringFormat();
      stringFormat.Alignment = StringAlignment.Center;
      stringFormat.LineAlignment = StringAlignment.Center;
      g.DrawString(v.ToString(), font, color, r, stringFormat);

    }

    private void CheckOmok(int x, int y)
    {
      // (1) 좌우, (2) 상하 (3) 대각선 (4) 역대각선 방향으로 
      // 같은 색깔의 돌이 놓여있는지 체크한다
      int cnt = 1;

      // (1-1) 오른쪽 방향
      for (int i = x + 1; i < 19; i++)
        if (바둑판[x, y] == 바둑판[i, y])
          cnt++;
        else
          break;
      // (1-2) 왼쪽
      for (int i = x - 1; i >= 0; i--)
        if (바둑판[x, y] == 바둑판[i, y])
          cnt++;
        else
          break;

      if (cnt >= 5)
      {
        OmokComplete(x, y);
        return;
      }

      cnt = 1;
      // (2-1) 위쪽 : y좌표가 줄어드는 쪽
      for (int i = y - 1; i >= 0; i--)
        if (바둑판[x, y] == 바둑판[x, i])
          cnt++;
        else
          break;
      // (2-2) 아래쪽 : y좌표가 커지는 쪽
      for (int i = y + 1; i < 19; i++)
        if (바둑판[x, y] == 바둑판[x, i])
          cnt++;
        else
          break;

      if (cnt >= 5)
      {
        OmokComplete(x, y);
        return;
      }

      cnt = 1;
      // (3-1) 대각선방향: x는 증가, y는 감소 방향
      for (int i = x + 1, j = y - 1; i < 19 && j >= 0; i++, j--)
        if (바둑판[x, y] == 바둑판[i, j])
          cnt++;
        else
          break;

      // (3-2) 대각선 왼쪽 : x는 감소, y는 증가방향
      for (int i = x - 1, j = y + 1; i >= 0 && j < 19; i--, j++)
        if (바둑판[x, y] == 바둑판[i, j])
          cnt++;
        else
          break;

      if (cnt >= 5)
      {
        OmokComplete(x, y);
        return;
      }

      cnt = 1;
      // (4-1) 역대각선 오른쪽, x도 증가, y도 증가
      for (int i = x + 1, j = y + 1; i < 19 && j < 19; i++, j++)
        if (바둑판[x, y] == 바둑판[i, j])
          cnt++;
        else
          break;

      // (4-2) 역대각선 왼쪽, x도 감소, y도 감소
      for (int i = x - 1, j = y - 1; i >=0 && j >=0; i--, j--)
        if (바둑판[x, y] == 바둑판[i, j])
          cnt++;
        else
          break;

      if (cnt >= 5)
      {
        OmokComplete(x, y);
        return;
      }
    }

    private void OmokComplete(int x, int y)
    {
      MessageBox.Show(바둑판[x, y].ToString().ToUpper() + " Wins!!");

      // 파일에 저장하고자 한다면
      SaveGame();


      // 테스트: lstRevive 값들을 출력
      //string s = "";
      //foreach (var item in lstRevive)
      //{
      //  s += String.Format("{0} {1} {2} {3}",
      //    item.X,
      //    item.Y,
      //    item.Stone,
      //    item.Seq);
      //  s += "\n";
      //}
      //MessageBox.Show(s);
    }

    private void SaveGame()
    {      
      // 문서 폴더의 경로
      string documentPath =
        Path.Combine(Environment.ExpandEnvironmentVariables
        ("%userprofile%"), "Documents").ToString();
      dirName = documentPath + "/Omok/";

      if (!Directory.Exists(dirName))
        Directory.CreateDirectory(dirName);

      string fileName = dirName + DateTime.Now.ToShortDateString()
        + "-" + DateTime.Now.Hour + DateTime.Now.Minute + ".omk";
      FileStream fs = new FileStream(fileName, FileMode.Create);
      StreamWriter sw = new StreamWriter(fs, Encoding.Default);

      foreach (Revive item in lstRevive)
      {
        sw.WriteLine("{0} {1} {2} {3}",
           item.X, item.Y, item.Stone, item.Seq);
      }
      sw.Close();
      fs.Close();
    }

    private void 이미지ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      imageFlag = true;
    }
  }
}
