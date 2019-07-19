using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.Chapter03.Learn
{
  class TypeConversion
  {
    public static void ExplicitTypeConversion()
    {
      Console.WriteLine("Explicit type conversion");
      double myDouble = 5.1532d;
      Console.WriteLine($"Output 5.1532d = {myDouble}");

      long myLong = (long) myDouble;
      Console.WriteLine($"Convert explicitly myDouble to myLong produces: {myLong}");

      myDouble = 5e9d;
      Console.WriteLine($"myDouble 5e9d = {myDouble}");

      int myInt = (int) myDouble;
      Console.WriteLine($"myInt = {myInt}");
      Console.WriteLine($"Minimum value of int is: {int.MinValue}");
    }

    public static void DataLossExample()
    {
      long myLong = long.MaxValue;
      int myInt = (int) myLong;
      //int myInt = checked((int)myLong); // use checked keyword to check for overflow in integer types

      Console.WriteLine($"myLong value is: {myLong}\nAfter conversion to int, the myInt is: {myInt}");
    }
  }
}
