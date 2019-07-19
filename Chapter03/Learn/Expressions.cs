using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.Chapter03.Learn
{
  class Expressions
  {
    public static void Samples()
    {
      Console.WriteLine("Expressions");
      Console.WriteLine("Example of behaviour of data types and operators");

      // first example
      double d = 1 / 2;
      Console.WriteLine(d);

      // second example
      double half = (double) 1 / 2;
      Console.WriteLine(half);

      // third example
      float f = 1 / 2;
      Console.WriteLine(f);

      float ff = (float)1 / 2;
      Console.WriteLine(ff);


      Console.WriteLine("Division by Zero");
      int num = 1;
      double denum = 0; // The value is 0.0 (real number)
      int zeroInt = (int) denum; // The value is 0 (integer number)
      
      Console.WriteLine(num/denum); // Infinity
      Console.WriteLine(denum / denum); // NaN
      Console.WriteLine(zeroInt / zeroInt); // DivideByZeroException
    }
  }
}
