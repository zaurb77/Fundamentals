using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.Chapter03.Learn
{
  class Operators
  {

    /*    Category              Operators
          ---------------       ---------------
          arithmetic            -, +, *, /, %, ++, --
          logical               &&, ||, !, ^
          binary                &, |, ^, ~, <<, >>
          comparison            ==,!=, >, <, >=, <=
          assignment            =, +=, -=, *=, /=, %=, &=, |=, ^=, <<=, >>=
          string concatenation  +
          type conversion       (type), as, is, typeof, sizeof
          other                 ., new, (), [], ?:, ??
    */

    public static void ArithmeticalOperators()
    {
      Console.WriteLine("\nArithmetical Operators");
      int squarePerimeter = 17;
      double squareSide = squarePerimeter / 4.0;
      double squareArea = squareSide * squareSide;
      Console.WriteLine($"squareSide = {squareSide}\nsquarePerimeter = {squarePerimeter}\nsquareArea = {squareArea}");

      int a = 5;
      int b = 4;
      Console.WriteLine($"a + b = {a + b}");
      Console.WriteLine($"a + (b++) = {a + (b++)}");
      Console.WriteLine($"a + b = {a + b}");
      Console.WriteLine($"a + (++b) = {a + (++b)}");
      Console.WriteLine($"a + b = {a + b}");
      Console.WriteLine($"14 / a = {14 / a}");
      Console.WriteLine($"14 % a = {14 % a}");

      int one = 1;
      int zero = 0;

      // Console.WriteLine(one / zero); // DivideByZeroException
      // for formatting: http://www.csharp-examples.net/string-format-double/

      double dMinusOne = -1.0;
      double dZero = 0.0;
      Console.WriteLine($"dMinusOne / zero ({dMinusOne} / {zero}) = {dMinusOne / zero} --> (-? stands for Infinity)");
      Console.WriteLine($"dMinusOne / zero ({one} / {dZero}) = {one / dZero} --> (? stands for Infinity)");
    }

    public static void LogicalOperators()
    {
      Console.WriteLine("\nLogical Operators");
      bool a = true;
      bool b = false;
      Console.WriteLine($"bool a = {a}");
      Console.WriteLine($"bool b = {b}");
      Console.WriteLine($"a && b = {a && b} \t=> logical AND returns true only when both vars are true");
      Console.WriteLine($"a || b = {a || b} \t=> logical OR returns true only when at least one of vars is true");
      Console.WriteLine($"!b = {!b} \t=> logical negation ! changes the value of argument");
      Console.WriteLine($"b || true = {b || true}");
      Console.WriteLine($"(5 < 7) ^ (a == b) = {(5 < 7) ^ (a == b)} \t=>Exclusive \"OR\" returns true if only one of the two operands has the value true.");
      Console.WriteLine($"(5 > 7) ^ (a == b) = {(5 > 7) ^ (a == b)} \t=>Exclusive \"OR\" returns true if only one of the two operands has the value true.");

      // Law of De Morgan
      Console.WriteLine("\nLaws of De Morgan");
      if (!(a && b) == (!a || !b))
      {
        Console.WriteLine($"!(a && b) == (!a || !b) ==> {true}");
      }

      if (!(a || b) == (!a && !b))
      {
        Console.WriteLine($"!(a || b) == (!a && !b) ==> {true}");
      }
    }

    public static void BitwiseOperators()
    {
      Console.WriteLine("\nBitwise operators");
      byte a = 3;
      byte b = 5;

      string aByte = ConvertToBitString(a);
      string bByte = ConvertToBitString(b);

      // byte ab = a | b;

      Console.WriteLine($"a | b ({a} | {b}) \t==> {aByte} | {bByte} ==> {ConvertToBitString(Convert.ToByte(a | b))} = {a | b}");
      Console.WriteLine($"a & b ({a} & {b}) \t==> {aByte} & {bByte} ==> {ConvertToBitString(Convert.ToByte(a & b))} = {a & b}");
      Console.WriteLine($"a ^ b ({a} ^ {b}) \t==> {aByte} ^ {bByte} ==> {ConvertToBitString(Convert.ToByte(a ^ b))} = {a ^ b}");
      Console.WriteLine($"~a & b (~{a} & {b}) ==> {aByte} & {bByte} ==> {ConvertToBitString(Convert.ToByte(~a & b))} = {~a & b}");
      Console.WriteLine($"a << 1 \t\t==> {ConvertToBitString(Convert.ToByte(a << 1))} = {a << 1}");
      Console.WriteLine($"a << 2 \t\t==> {ConvertToBitString(Convert.ToByte(a << 2))} = {a << 2}");
      Console.WriteLine($"a >> 1 \t\t==> {ConvertToBitString(Convert.ToByte(a >> 1))} = {a >> 1}");
    }

    private static string ConvertToBitString(byte b)
    {
      return Int32.Parse(Convert.ToString(b, 2)).ToString("0000 0000");
    }

    public static void IsOperator()
    {
      Console.WriteLine("\nIs operator");
      var a = 5;
      if (a is int)
        {
          Console.WriteLine(true + " a is " + a.GetType());
        }
        else Console.WriteLine(false + " a is " + a.GetType());
    }

    public static void DoubleQuestionMarkOperator()
    {
      /*
       * The operator ?? is similar to the conditional operator ?:.
       * The difference is that it is placed between two operands and
       * returns the left operand only if its value is not null, otherwise
       * it returns the right operand.
       */
      Console.WriteLine("\n?? operator");
      int? a = 5;
      Console.WriteLine(a ?? -1);

      string name = null;
      Console.WriteLine(name ?? "no name");
    }

  }
}


