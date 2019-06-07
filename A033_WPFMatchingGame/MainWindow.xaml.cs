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

namespace A033_WPFMatchingGame
{
  /// <summary>
  /// MainWindow.xaml에 대한 상호 작용 논리
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
      BoardSet();
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
        btn.Content = btn.Tag; 
        board.Children.Add(btn);
      }
      
    }

    int[] check = new int[16];
    Random r = new Random();
      
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
