using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.Chapter02.Learn
{
  class VariablesChar
  {
    public static void Chars()
    {
      for (char a = 'A'; a <= 'z'; a++)
      {
        Console.WriteLine($"The code of char {a} is {(int)a}");
      }
    }
  }
}
