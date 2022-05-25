using System;

namespace _206_Task4
{
    static class Extention
    {
        public static int[] SortArray(this int[] value)
        {
            Array.Sort(value);

            return value;
        }
        
        public static int[] FillArray(int[] array)
        {
            Random rand = new Random();

            for(int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 10);
            }

            return array;
        }

        public static void PrintArray(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }

            Console.WriteLine();
        }
    }  

    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];

            Extention.FillArray(array);

            Extention.PrintArray(array);

            array.SortArray();

            Extention.PrintArray(array);

            Console.ReadKey();
        }
    }
}

