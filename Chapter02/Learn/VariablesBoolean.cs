using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.Chapter02.Learn
{
  class VariablesBoolean
  {
    public static void BooleanTestAB()
    {
      int a = 1;
      int b = 2;
      
      // check which one is greater
      bool greaterAB = (a > b);

      // print results in console
      if (greaterAB)
      {
        Console.WriteLine("A > B");
      }
      else
      {
        Console.WriteLine("A <= B");
      }
    }

  }
}
