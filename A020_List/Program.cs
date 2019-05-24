using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A020_List
{
  class Program
  {
    static void Main(string[] args)
    {
      // Generic(일반화) 프로그램
      List<int> a = new List<int>();
      a.Add(10);
      a.Add(20);
      a.Add(50);
      a.Add(40);
      a.Add(30);

      for (int i = 0; i < a.Count; i++)
      {
        Console.WriteLine(a[i]);
      }

      foreach (var item in a)
      {
        Console.WriteLine(item);
      }

      Console.WriteLine("\n정렬 후");
      a.Sort();
      foreach (var item in a)
      {
        Console.WriteLine(item);
      }

      List<string> b = new List<string>();
      b.Add("HELLO");
      b.Add("hello");
      b.Add("Hello");
      foreach (var s in b)
      {
        Console.WriteLine(s);
      }
      b.Sort();
      foreach (var s in b)
      {
        Console.WriteLine(s);
      }
    }
  }
}
