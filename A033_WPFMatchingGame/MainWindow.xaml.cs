using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace A033_WPFMatchingGame
{
  /// <summary>
  /// MainWindow.xaml에 대한 상호 작용 논리
  /// </summary>
  public partial class MainWindow : Window
  {
    DispatcherTimer myTimer = new DispatcherTimer();

    public MainWindow()
    {
      InitializeComponent();

      BoardSet();
      myTimer.Interval = new TimeSpan(0,0,0,0,750); // 0.75초
      myTimer.Tick += MyTimer_Tick;
    }

    private void MyTimer_Tick(object sender, EventArgs e)
    {
      first.Content = MakeImage("../../Images/check.png");
      second.Content = MakeImage("../../Images/check.png");
      first = null;
      second = null;
      myTimer.Stop();
    }

    // 16개의 겹치지 않는 랜덤 숫자를 갖는 버튼을 만들어 넣기
    private void BoardSet()
    {
      for(int i = 0; i<16; i++)
      {
        Button btn = new Button();
        btn.Background = Brushes.White;
        btn.Margin = new Thickness(10);
        btn.Tag = TagSet() % 8;
        //btn.Content = btn.Tag; 
        btn.Content = MakeImage("../../Images/check.png");
        btn.Click += Btn_Click;
        board.Children.Add(btn);
      }      
    }

    string[] icon = {"딸기", "레몬", "모과", "배",
    "사과", "수박", "파인애플", "포도"};

    // C#에서 필드는 자동으로 초기화된다
    // (메서드 안의 변수는 초기화되지 않음)
    Button first;   // Butotn first = null; 과 같다
    Button second;

    private void Btn_Click(object sender, RoutedEventArgs e)
    {
      Button btn = sender as Button;
      //MessageBox.Show(btn.Tag.ToString());
      btn.Content = MakeImage("../../Images/" + 
        icon[(int)btn.Tag] + ".png");

      if(first == null) // 지금 눌린 버튼이 첫번째 버튼이라면
      {
        first = btn;
        return;
      }
      else // 지금 눌린 버튼이 두번째 버튼이라면
      {
        second = btn;
        ButtonDiable();
      }

      if((int)first.Tag == (int)second.Tag)
      {
        first = null;
        second = null;
        matched += 2;
        if (matched >= 16) // 모든 그림이 맞추어졌다면
        {
          MessageBoxResult result = MessageBox.Show(
            "성공! 다시 하겠습니까?", "Success",
            MessageBoxButton.YesNo);
          if(result == MessageBoxResult.Yes)
          {
            NewGame();
          }
          else
          {
            Close();
          }
        }
      }
      else
      {
        myTimer.Start();
      }
    }

    private void NewGame()
    {
      for(int i=0; i<16; i++)
      {
        check[i] = 0;
      }
      board.Children.Clear();
      BoardSet();
      matched = 0;
    }

    private Image MakeImage(string v)
    {
      BitmapImage bi = new BitmapImage();
      bi.BeginInit();
      bi.UriSource = new Uri(v, UriKind.Relative);
      bi.EndInit();

      Image myImage = new Image();
      myImage.Margin = new Thickness(10);
      myImage.Stretch = Stretch.Fill;
      myImage.Source = bi;

      return myImage;
    }

    int[] check = new int[16];
    Random r = new Random();
    private int matched;

    // 버튼의 그림을 나타내는 겹치지 않는 랜덤 숫자를 리턴
    private int TagSet()
    {
      int v = r.Next(16);
      while (RndCheck(v) == false)
        v = r.Next(16);
      return v;
    }

    private bool RndCheck(int v)
    {
      if (check[v] == 0)
      {
        check[v] = 1;
        return true;
      }
      else
        return false;
    }
  }
}
