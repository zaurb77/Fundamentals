using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.Chapter03.Excercises
{
  class Exercise03
  {
    public static void Exc03()
    {
      int i = 257;

      if ((i % 100)%10 == 7) { Console.WriteLine($"Third digit is 7");}
      else
      {
        Console.WriteLine($"Third digit from right is not 7 but {i%100}");
      }
    }
  }
}
