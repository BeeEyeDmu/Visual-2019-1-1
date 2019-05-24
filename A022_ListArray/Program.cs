using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A022_ListArray
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] a = new int[10];
      List<int> b = new List<int>();  // Car car = new Car();

      Random r = new Random();  // r.Next()가 랜덤값을 생성

      for (int i = 0; i < 10; i++)
      {
        a[i] = r.Next(100);
        //b[i] = r.Next(100); // 이렇게 쓰면 안된다
        b.Add(r.Next(100));
      }

      PrintIntArray(a);
      PrintIntList(b);

      for (int i = 0; i < 10; i++)
        Console.Write(a[i] + " ");
      Console.WriteLine();

      for (int i = 0; i < 10; i++)
        Console.Write(b[i] + " ");  // 배열형태의 사용법
      Console.WriteLine();

      string[] s1 = new string[10];
      List<string> s2 = new List<string>();

      s1[0] = "asdasfsa";
      s1[1] = "kjshkjas";
      s1[2] = "ajdglka";

      s2.Add("kfgkjdg");
      s2.Add("ksfhgkhgj");
      s2.Add("iegrlie");

      Print(s1);
      PrintList(s2);

      // 정렬
      // 배열: Array.Sort()
      // 리스트: 객체.Sort()

      Array.Sort(a);  // Static 메소드이므로
      // a.Sort();  // 이렇게 쓸 수 없다

      b.Sort(); // 객체, 즉 리스트 이름으로 사용한다

      Array.Sort(s1);
      s2.Sort();

      PrintIntArray(a);
      PrintIntList(b);

      Print(s1);
      PrintList(s2);
    }

    private static void PrintIntList(List<int> b)
    {
      foreach (var item in b)
      {
        Console.Write(item + " ");
      }
      Console.WriteLine();
    }

    private static void PrintIntArray(int[] a)
    {
      foreach (var item in a)
      {
        Console.Write(item + " ");
      }
      Console.WriteLine();
    }

    private static void PrintList(List<string> s2)
    {
      foreach (var item in s2)
        Console.WriteLine(item);
      Console.WriteLine();
    }

    private static void Print(string[] s)
    {
      foreach (var item in s)
        Console.WriteLine(item);
      Console.WriteLine();
    }
  }
}
