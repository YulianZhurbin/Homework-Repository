using System;

namespace _207_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a number of train");

                string trainNumber = Console.ReadLine();

                Console.WriteLine(Archive.GetInfo(trainNumber) + "\n");
            }        
        }
    }
}
