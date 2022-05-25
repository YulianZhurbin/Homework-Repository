using System;

namespace _207_AdditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook("rough paper ", "Kirov Les ", "60 rub");

            notebook.PrintInfo();

            Console.ReadKey();
        }
    }
}
