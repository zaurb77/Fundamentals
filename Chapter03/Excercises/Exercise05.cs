using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.Chapter03.Excercises
{
  class Exercise05
  {
    public static void Exc05()
    {
      /*
       * Write an expression that calculates the area
       * of a trapezoid by given sides a, b and height h.
       * Formula of a trapezoid surface is: S = (a + b) * h / 2.
       */

      float a = 10;
      float b = 20;
      float h = 35;

      float s = (a + b) * h / 2;

      Console.WriteLine($"Trapezoid surface is: {s}");
    }
  }
}
