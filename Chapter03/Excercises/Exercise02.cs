using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.Chapter03.Excercises
{
  class Exercise02
  {
    /* Write a Boolean expression that checks
       * whether a given integer is divisible by both 5 and 7,
       * without a remainder.
       */
    public static void Ex02()
    {

      int a = 35;
      int b = 41;
      int c = 40;
      int d = 140;

      CheckDivision(a);
      CheckDivision(b);
      CheckDivision(c);
      CheckDivision(d);

    }

    private static void CheckDivision(int i)
    {
      if ((i % 5==0) && (i % 7 == 0))
      {
        Console.WriteLine($"The number {i} is divisible by 5 and 7");
      }
      else
      {
        Console.WriteLine($"The number {i} is NOT divisible by 5 and 7");
      }

      ;

    }
  }
}
