using System;

namespace _203_AdditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer text1 = new Printer();
            DerivedFromPrinter text2 = new DerivedFromPrinter();

            string sentence = "Hello, World!";
            text1.Print(sentence);

            Printer text3 = text2 as Printer;
            text3.Print(sentence);

            // Delay
            Console.ReadKey();

        }
    }
}
