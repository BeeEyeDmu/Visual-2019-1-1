using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A034_TwoValue
{
  class Program
  {
    static void Main(string[] args)
    {
      int a = 10, b = 20;
      Console.WriteLine(a);
      Console.WriteLine(b);
      Console.WriteLine(a + " " + b);
      Console.WriteLine("{0} {1}", a, b);
      Console.WriteLine($"{a} {b}");

      string s = string.Format("{0} {1}", a, b);
      string t = string.Format($"{a} {b}");

      Console.WriteLine(s);
      Console.WriteLine(t);

    }
  }
}
