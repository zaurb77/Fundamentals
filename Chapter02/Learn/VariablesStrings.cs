using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.Chapter02.Learn
{
  class VariablesStrings
  {
    public static void Strings()
    {
      // Declare some variables
      string firstName = "John";
      string lastName = "Smith";
      string fullName = firstName + " " + lastName;
      // Print the results on the console
      Console.WriteLine("Hello, " + firstName + "!");
      Console.WriteLine("Your full name is " + fullName + ".");
    }
  }
}
