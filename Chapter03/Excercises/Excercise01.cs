using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.Chapter03.Excercises
{
  class Excercise01
  {
    // Write an expression that checks whether an integer is odd or even.
    public static void Exc01()
    {
      int a = 8;
      int b = 11;

      CheckEvenOdd(a);
      CheckEvenOdd(b);

      for (int j = 0; j <= 20; j++)
      {
        CheckEvenOdd(j);
      }
    }
    private static void CheckEvenOdd(int i)
    {
      if (i % 2 == 0)
      {
        Console.WriteLine($"{i} is an EVEN number");
      }
      else
      {
        Console.WriteLine($"{i} is an ODD number");
      }
    }
  }
}
