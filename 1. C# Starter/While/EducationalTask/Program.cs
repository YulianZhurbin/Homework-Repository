using System;

namespace EducationalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter the second number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            while(firstNumber < secondNumber)
            {
                if (firstNumber % 2 != 0)
                {
                    Console.Write(firstNumber + "  ");
                }

                firstNumber++;
            }

            Console.ReadKey();
        }
    }
}
