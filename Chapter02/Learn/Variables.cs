using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.Chapter02.Learn
{
  class Variables
  {
    public string Show()
    {
      return ("MyType");

    }

    public static void VarTypes()
    {
      Console.WriteLine("VALUE TYPE:");
      Console.WriteLine("---------------------------------------------");
      Console.WriteLine("Integers:");
      byte a = 12;
      Console.WriteLine("byte\tA = {0}\t{1}\t{2}\t{3}", a, typeof(byte), byte.MaxValue, byte.MinValue);
      sbyte b = 12;
      Console.WriteLine("sbyte\tB = {0}\t{1}\t{2}\t{3}", b, typeof(sbyte), sbyte.MaxValue, sbyte.MinValue);
      short c = 12;
      Console.WriteLine("short\tC = {0}\t{1}\t{2}\t{3}", c, typeof(short), short.MaxValue, short.MinValue);
      ushort d = 12;
      Console.WriteLine("ushort\tD = {0}\t{1}\t{2}\t{3}", d, typeof(ushort), ushort.MaxValue, ushort.MinValue);
      int e = 12;
      Console.WriteLine("int\tE = {0}\t{1}\t{2}\t{3}", e, typeof(int), int.MaxValue, int.MinValue);
      uint f = 12;
      Console.WriteLine("unit\tF = {0}\t{1}\t{2}\t{3}", f, typeof(uint), uint.MaxValue, uint.MinValue);
      long g = 12;
      Console.WriteLine("long\tG = {0}\t{1}\t{2}\t{3}", g, typeof(long), long.MaxValue, long.MinValue);
      ulong h = 12;
      Console.WriteLine("ulong\tH = {0}\t{1}\t{2}\t{3}", h, typeof(ulong), ulong.MaxValue, ulong.MinValue);

      Console.WriteLine("\nFloating Point:");
      float i = 123.34f;
      Console.WriteLine("float\tI = {0}\t{1}\t{2}\t{3}", i, typeof(float), float.MaxValue, float.MinValue);
      double j = 123.34;
      Console.WriteLine("double\tJ = {0}\t{1}\t{2}\t{3}", j, typeof(double), double.MaxValue, double.MinValue);
      decimal k = 123.34m;
      Console.WriteLine("decimal\tK = {0}\t{1}\t{2}\t{3}", k, typeof(decimal), decimal.MaxValue, decimal.MinValue);

      Console.WriteLine("\nText:");
      char l = 'f';
      Console.WriteLine("char\tL = {0}\t{1}", l, typeof(char));

      Console.WriteLine("\nBoolean:");
      bool m = true;
      Console.WriteLine("bool\tM = {0}\t{1}", m, typeof(bool));

      Console.WriteLine("\nREFERENCE TYPE:");
      Console.WriteLine("---------------------------------------------");
      string n = "Hello";
      Console.WriteLine("string\tn = {0}\t{1}", n, typeof(string));
      object o = 12.34;
      Console.WriteLine("object\tn = {0}\t{1}", o, typeof(object));
      Variables p = new Variables();
      Console.WriteLine("MyDataType\tp = {0}\t{1}", p.Show(), typeof(Variables));
      int[] q = { 12, 45, 56 };
      Console.WriteLine("int[]\tq = {0}", typeof(int[]));

      Console.WriteLine("\nNullable TYPE:");
      Console.WriteLine("---------------------------------------------");
      string r = null;
      Console.WriteLine("string\tr = {0}\t{1}", r, typeof(string));
      int? s = null;
      Console.WriteLine("int\ts = {0}\t{1}", s, typeof(int?));

      Console.WriteLine("\nEXAMPLE: Real Floating-Point Types");
      Console.WriteLine("---------------------------------------------");
      float floatPI = 3.141592653589793238f; Console.WriteLine("float floatPI (3.141592653589793238f)\t=\t{0}", floatPI); // 3.14
      double doublePI = 3.141592653589793238; Console.WriteLine("double doublePI (3.141592653589793238)\t=\t{0}", doublePI); // 3.14
      double nan = Double.NaN; Console.WriteLine("double NaN (invalid number)\t=\t{0}", nan); // NaN
      double pInfinity = Double.PositiveInfinity; Console.WriteLine("Double.PositiveInfinity\t=\t{0}", pInfinity); // Infinity
      double nInfinity = Double.NegativeInfinity; Console.WriteLine("Double.NegativeInfinity\t=\t{0}", nInfinity); // Infinity
      Console.WriteLine("\nEXAMPLE: Real numbers with decimal precision");
      Console.WriteLine("---------------------------------------------");
      decimal decimalPI = 3.14159265358979323846m; Console.WriteLine("decimal (3.14159265358979323846m)\t=\t{0}", decimalPI);
      Console.ReadKey();
    }

  }
}
