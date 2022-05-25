using System;

namespace _206_AdditionalTask
{
    static class Calculator
    {
        public static void Add(int firstOperand, int secondOperand)
        {
            int sum = firstOperand + secondOperand;

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("x + y = {0}", sum);

            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void Subtract(int firstOperand, int secondOperand)
        {
            int difference = firstOperand - secondOperand;

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("x - y = {0}", difference);

            Console.ForegroundColor = ConsoleColor.Gray;
        } 

        public static void Times(int firstOperand, int secondOperand)
        {
            int product = firstOperand * secondOperand;

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("x * y = {0}", product);

            Console.ForegroundColor = ConsoleColor.Gray;
        } 

        public static void Devide(double firstOperand, double secondOperand)
        {
            double quotient = firstOperand / secondOperand;

            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("x / y = {0:F2}", quotient);

            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter x and y.");

                int x = Convert.ToInt32(Console.ReadLine()), y = Convert.ToInt32(Console.ReadLine());

                Calculator.Add(x, y);
                Calculator.Subtract(x, y);
                Calculator.Times(x, y);
                Calculator.Devide(x, y);

                Console.WriteLine("\n");
            }
        }
    }
}
