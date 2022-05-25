using System;

namespace _203_AdditionalTask
{
    class DerivedFromPrinter : Printer
    {
      public override void Print(string value)
      {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(value);
      }
    }
}
