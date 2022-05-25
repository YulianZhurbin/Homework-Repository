using System;


namespace _208_Task2
{
    enum Color : byte
    {
        Red = 1,
        Yellow = 2,
        Green = 3,
        Blue = 4,
        DarkBlue = 5,
        Magenta = 6
    }

    static class ColouredPrinter
    {
        public static void Print(string @string, int color)
        {
            Console.WriteLine();

            switch (color)
            {
                case 1:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(@string);
                        break;
                    }
                case 2:
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(@string);
                        break;
                    }
                case 3:
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(@string);
                        break;
                    }
                case 4:
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(@string);
                        break;
                    }
                case 5:
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine(@string);
                        break;
                    }
                case 6:
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine(@string);
                        break;
                    }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a text.");

            string @string = Console.ReadLine();

            Console.WriteLine("Choose a color.");

            string subtle = Console.ReadLine();

            bool flag = Enum.IsDefined(typeof(Color), subtle);

            if (flag == true)
            {
                Color color = (Color)Enum.Parse(typeof(Color), subtle);

                ColouredPrinter.Print(@string, (int)color);
            }
            else
            {
                Console.WriteLine("There is no such a color.");
            }

            //Delay
            Console.ReadKey();
        }
    }
}
