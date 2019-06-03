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

namespace A031_WPFCalc
{
  /// <summary>
  /// MainWindow.xaml에 대한 상호 작용 논리
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    private void btnCalc_Click(object sender, RoutedEventArgs e)
    {
      //txtresult.Text = 
      //  (double.Parse(txtNo1.Text) 
      //  + double.Parse(txtNo2.Text)).ToString();
      double a = double.Parse(txtNo1.Text);
      double b = double.Parse(txtNo2.Text);
      double sum = a + b;
      txtresult.Text = sum.ToString();
    }
  }
}
