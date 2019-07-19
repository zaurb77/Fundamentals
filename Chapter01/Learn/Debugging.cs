using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.Chapter01.Learn
{
  class Debugging
  {
    public static void GenerateException()
    {
      //throw new NotImplementedException("Intended exception");    // Ctrl+F5 to start running without debugging
      Console.WriteLine("Hello C#");
      Console.ReadKey();
    }
  }
}
