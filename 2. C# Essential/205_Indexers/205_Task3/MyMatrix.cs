using System;

namespace _205_Task3
{
    class MyMatrix
    {
        int[,] array;

        public int this [int index1, int index2]
        {
            get
            {
                return array[index1, index2];
            }

            set
            {
                array[index1, index2] = value;
            }
        }

        public MyMatrix(int stringAmount, int columnAmount)
        {
            array = new int[stringAmount, columnAmount];
        }

        public void FillMatrix(int lowerThreshold, int upperThreshold)
        {
            Random rand = new Random();

            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(lowerThreshold, upperThreshold);
                }
            }
        }

        public void PrintMatrix()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i,j] + "  ");
                }

                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
        }

        public void WidenMatrix(int additionalStrings, int additionalColumns)
        {
            int[,] matrix = new int[array.GetLength(0) + additionalStrings, array.GetLength(1) + additionalColumns];

            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    matrix[i,j] = array[i, j];
                }
            }

            array = matrix;
        }
    }
}
