using System;

namespace _206_Task2
{
    static class Book
    {
        private static string[] bookArray;

        private static string text = "Это пробный текст . Текст составлен просто случайно. Что приходит в голову, то и попадает в текст . " +
                                     "Вторую строчку нужно тоже заполнить словами, чтобы текст не был пустым ";
        private static void SplitText(string text)
        {
            text.Replace('.', ' ');
            bookArray = text.Split(' ');          
        }

        public static void FindNext(string str)
        {
            SplitText(text);

            for (int i = 0; i < bookArray.Length; i++)
            {
                if (str == bookArray[i])
                {
                    Console.WriteLine(bookArray[i]);
                }
            }
        }

        public static void PrintArray()
        {
            for (int i = 0; i < bookArray.Length; i++)
            {
                Console.Write(bookArray[i] + "  ");
                if (i % 5 == 0 && i != 0)
                {
                    Console.WriteLine();
                } 
            }
        }
    }
}
