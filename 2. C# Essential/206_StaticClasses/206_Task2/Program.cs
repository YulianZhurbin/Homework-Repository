using System;

namespace _206_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "текст";

            FindAndReplaceManager.FindNext(word);

            FindAndReplaceManager.PrintArrayText();

            Console.ReadKey();
        }
    }
}
