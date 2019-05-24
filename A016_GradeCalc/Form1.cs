using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A016_GradeCalc
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      crd1.Text = "2";
      crd2.Text = "3";
      crd3.Text = "3";
      crd4.Text = "3";
      crd5.Text = "3";
      crd6.Text = "1";
    }

    private void button1_Click(object sender, EventArgs e)
    {
      TextBox[] crds = { crd1, crd2, crd3, crd4, crd5, crd6 };
      TextBox[] grds = { grd1, grd2, grd3, grd4, grd5, grd6 };
      int totalCredits = 0;
      double total = 0;

      for(int i=0; i<crds.Length; i++)
      {
        int crd = int.Parse(crds[i].Text);
        double grd = GetGrade(grds[i].Text);
        totalCredits += crd;
        total += crd * grd;
      }

      txtResult.Text = (total / totalCredits).ToString("0.00");

    }

    private double GetGrade(string text)
    {
      if (text == "A+")
        return 4.5;
      else if (text == "A0")
        return 4.0;
      else if (text == "B+")
        return 3.5;
      else if (text == "B0")
        return 3.0;
      else if (text == "C+")
        return 2.5;
      else if (text == "C0")
        return 2.0;
      else if (text == "D+")
        return 1.5;
      else if (text == "D0")
        return 1.0;
      else 
        return 0.0;
    }
  }
}
