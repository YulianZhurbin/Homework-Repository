using System;

namespace _205_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            MyMassive myArray = new MyMassive(n);

            myArray.FillArray(0,10);

            myArray.ShowArray();

            Console.WriteLine("Even elements of array:");
            myArray.ShowEvenElementsOfArray();
            Console.WriteLine($"Maximum element = {myArray.GetMaxValue()} \n");
            Console.WriteLine($"Minimum element = {myArray.GetMinValue()} \n");
            Console.WriteLine($"Sum of elements = {myArray.CalculateSumOfElements()} \n");
            Console.WriteLine($"Mean value of elements = {myArray.FindMeanValue()} \n");
            Console.WriteLine(new string('-', 100));
            Console.WriteLine("Even elements of array:");
            myArray.ShowEvenElementsOfArray();

            // Delay
            Console.ReadKey();
        }
    }
}
