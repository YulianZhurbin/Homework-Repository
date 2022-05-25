using System;

namespace _205_AdditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string rus = "rus";
            string ua = "ua";
            string eng = "eng";


            Dictionary dictionary = new Dictionary();

            Console.WriteLine(dictionary["книга", rus, eng]);
            Console.WriteLine(dictionary["дом", rus, rus]);
            Console.WriteLine(dictionary["pen", eng, rus]);
            Console.WriteLine(dictionary["сонце", ua, eng]);
            Console.WriteLine(dictionary["карандаш", rus, ua]);
            Console.WriteLine(dictionary["яблуко", ua, rus]);
            Console.WriteLine(dictionary["солнце", rus, ua]);

            Console.WriteLine(new string('-', 20));

            /* for (int i = 0; i < 6; i++)
             {
                 Console.WriteLine(dictionary[i]);
             }
            */

            Console.WriteLine(dictionary[7]);
            // Delay.
            Console.ReadKey();
        }
    }
}
