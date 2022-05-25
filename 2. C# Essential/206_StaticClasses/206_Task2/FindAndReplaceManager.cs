using System;

namespace _206_Task2
{
    static class FindAndReplaceManager
    {
        public static void FindNext(string str)
        {
            Console.WriteLine("Searching string \"{0}\"", str);

            Book.FindNext(str);
        }

        public static void PrintArrayText()
        {
            Console.WriteLine("The whole text:");

            Book.PrintArray();
        }
    }
}
