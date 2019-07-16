using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.Chapter02.Learn
{
  class VariablesNullable
  {
    public static void NullableTypes()
    {
      // Nullable types are used for storing information, which is not mandatory.
      // Nullable types can be declared in two ways:

      Nullable<int> n1 = null;
      int? n2 = n1; // or int? n2 = null;

      int i = 5;
      int? ni = i;
      Console.WriteLine(ni); // 5

      Console.WriteLine(ni.HasValue); // True
      i = ni.Value;
      Console.WriteLine(i); // 5

      ni = null;
      Console.WriteLine(ni.HasValue); // False
      // i = ni.Value; // System.InvalidOperationException

      i = ni.GetValueOrDefault();
      Console.WriteLine(i); // 0

    }
  }
}
