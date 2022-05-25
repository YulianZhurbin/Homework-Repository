using System;

namespace _205_Task2
{
    class MyMassive
    {
        int n;
        int[] array;

        public MyMassive(int n)
        {
            this.n = n;
            array = new int[n];
        }

        public int this [int index]
        {
            get
            {
                return array[index];
            }

            set
            {
                if (index >= 0 && index < array.Length)
                {
                    array[index] = value;
                }
                else
                {
                    Console.WriteLine("The index is out of the array scope.");
                }
            }
        }

        public void FillArray(int lowerThreshold, int upperThreshold)
        {
            Random rand = new Random(); 

            for(int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(lowerThreshold, upperThreshold);
            }
        }

        public void ShowArray()
        {
            Console.WriteLine("The array:\n");

            Console.ForegroundColor = ConsoleColor.Green;

            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");
            }

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n");
        }

        public int GetMaxValue()
        {
            Array.Sort(array);
            return array[array.Length - 1];
        }
        
        public int GetMinValue()
        {
            Array.Sort(array);
            return array[0];
        } 

        public int CalculateSumOfElements()
        {
            int sum = 0;
            for(int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        public double FindMeanValue()
        {
            double meanValue = (double)CalculateSumOfElements() / (double)array.Length;

            return meanValue;
        }

        public void ShowEvenElementsOfArray()
        {
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] % 2 == 0)
                {
                    Console.Write(array[i] + "\t");
                }
            }
            Console.WriteLine("\n");
        }
    }
}
