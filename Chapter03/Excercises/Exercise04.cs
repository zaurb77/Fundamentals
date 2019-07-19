using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.Chapter03.Excercises
{
  class Exercise04
  {
    public static void Exc04()
    {
      /*
       * Write an expression that checks whether the third bit in a given integer is 1 or 0.
       */

      int num = 25;
      bool bit3 = (num & 8) != 0;

      Console.WriteLine(ConvertToBitString(Convert.ToByte(num)));

    }
    private static string ConvertToBitString(byte b)
    {
      return Int32.Parse(Convert.ToString(b, 2)).ToString("0000 0000");
    }
  }
}
