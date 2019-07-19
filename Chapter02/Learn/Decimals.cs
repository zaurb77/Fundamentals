using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.Chapter02.Learn
{
  class Decimals
  {
    // Example of the Decimal fields.
    
      public static void DecimalsDemo()
      {
        const string numberFmt = "{0,-25}{1,45:N0}";
        const string exprFmt = "{0,-55}{1,15}";

        Console.WriteLine(
          "This example of the fields of the Decimal structure " +
          "\ngenerates the following output.\n");
        Console.WriteLine(numberFmt, "Field or Expression", "Value");
        Console.WriteLine(numberFmt, "-------------------", "-----");

        // Display the values of the Decimal fields.
        Console.WriteLine(numberFmt, "Decimal.MaxValue", Decimal.MaxValue);
        Console.WriteLine(numberFmt, "Decimal.MinValue", Decimal.MinValue);
        Console.WriteLine(numberFmt, "Decimal.MinusOne", Decimal.MinusOne);
        Console.WriteLine(numberFmt, "Decimal.One", Decimal.One);
        Console.WriteLine(numberFmt, "Decimal.Zero", Decimal.Zero);
        Console.WriteLine();

        // Display the values of expressions of the Decimal fields.
        Console.WriteLine(exprFmt,
          "( Decimal.MinusOne + Decimal.One ) == Decimal.Zero",
          (Decimal.MinusOne + Decimal.One) == Decimal.Zero);
        Console.WriteLine(exprFmt,
          "Decimal.MaxValue + Decimal.MinValue",
          Decimal.MaxValue + Decimal.MinValue);
        Console.WriteLine(exprFmt,
          "Decimal.MinValue / Decimal.MaxValue",
          Decimal.MinValue / Decimal.MaxValue);
        Console.WriteLine("{0,-40}{1,30}",
          "100000000000000M / Decimal.MaxValue",
          100000000000000M / Decimal.MaxValue);
      }
    }
}
