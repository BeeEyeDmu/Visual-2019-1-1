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

namespace A018_WPFCalc
{
  /// <summary>
  /// MainWindow.xaml에 대한 상호 작용 논리
  /// </summary>
  public partial class MainWindow : Window
  {
    private bool opFlag;
    private double savedValue;
    private string op;

    public MainWindow()
    {
      InitializeComponent();
    }

    private void Number_Click(object sender, RoutedEventArgs e)
    {
      Button btn = sender as Button;
      if (txtResult.Text == "0" || opFlag == true)
      {
        txtResult.Text = btn.Content.ToString();
        opFlag = false;
      }
      else
        txtResult.Text += btn.Content.ToString();
    }

    private void Dot_Click(object sender, RoutedEventArgs e)
    {
      if (txtResult.Text.Contains("."))
        return;
      else
        txtResult.Text += ".";
    }

    private void Op_Click(object sender, RoutedEventArgs e)
    {
      opFlag = true;
      savedValue = double.Parse(txtResult.Text);

      Button btn = sender as Button;
      op = btn.Content.ToString();

      txtExp.Text += txtResult.Text + " " + op;
    }

    private void Equal_Click(object sender, RoutedEventArgs e)
    {
      double value = double.Parse(txtResult.Text);
      switch (op)
      {
        case "+":
          txtResult.Text = (savedValue + value).ToString();
          break;
        case "-":
          txtResult.Text = (savedValue - value).ToString();
          break;
        case "×":
          txtResult.Text = (savedValue * value).ToString();
          break;
        case "÷":
          txtResult.Text = (savedValue / value).ToString();
          break;
      }
      txtExp.Text = "";
    }

    private void PM_Click(object sender, RoutedEventArgs e)
    {
      double v = double.Parse(txtResult.Text);
      v = -v;
      txtResult.Text = v.ToString();
    }

    private void Sqrt_Click(object sender, RoutedEventArgs e)
    {
      double v = double.Parse(txtResult.Text);
      txtExp.Text = "√(" + txtResult.Text + ")";
      v = Math.Sqrt(v);
      txtResult.Text = v.ToString();      
    }

    private void Sqr_Click(object sender, RoutedEventArgs e)
    {
      if(txtExp.Text != "")
        txtExp.Text = "sqr(" + txtExp.Text + ")";
      else
        txtExp.Text = "sqr(" + txtResult.Text + ")";

      double v = double.Parse(txtResult.Text);
      v = v * v;
      txtResult.Text = v.ToString();
    }

    private void Reci_Click(object sender, RoutedEventArgs e)
    {
      if (txtExp.Text != "")
        txtExp.Text = "1/(" + txtExp.Text + ")";
      else
        txtExp.Text = "1/(" + txtResult.Text + ")";

      double v = double.Parse(txtResult.Text);
      v = 1/v;
      txtResult.Text = v.ToString();
    }

    private void CE_Click(object sender, RoutedEventArgs e)
    {
      txtResult.Text = "0";
    }

    private void C_CLick(object sender, RoutedEventArgs e)
    {
      txtResult.Text = "0";
      txtExp.Text = "";
      savedValue = 0;
      op = "";
      opFlag = false;
    }
  }
}
