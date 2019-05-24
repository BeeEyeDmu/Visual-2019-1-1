using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A024_Susi3_RandomArray_
{
  class Program
  {
    // 문제: 주사위 2개를 던져서 나오는 숫자의 합을 구한다
    // 100만번 던진다
    // 출력: 
    // 2 -> 00000
    // 3 -> 00000
    // ...
    // 12 -> 00000
    // r.Next(1,7)

    static void Main(string[] args)
    {
      int[] cnt = new int[13];
      Random r = new Random();

      for(int i = 0; i<1000000; i++)
      {
        //cnt[r.Next(1, 7) + r.Next(1, 7)]++;
        int a = r.Next(1, 7);
        int b = r.Next(1, 7);
        cnt[a + b]++;

      }

      for(int i=2; i<=12; i++)
        Console.WriteLine("{0} -> {1}", i, cnt[i]);
    }
  }
}
