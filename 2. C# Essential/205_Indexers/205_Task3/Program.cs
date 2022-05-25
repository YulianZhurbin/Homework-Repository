using System;

namespace _205_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMatrix matrix = new MyMatrix(3,3);

            matrix.FillMatrix(0,10);

            matrix.PrintMatrix();

            matrix.WidenMatrix(2,2);

            matrix[0, 3] = 1;
            matrix[0, 4] = 1;

            matrix[1, 3] = 1;
            matrix[1, 4] = 1;

            matrix[2, 3] = 1;
            matrix[2, 4] = 1;

            matrix[3, 0] = 1;
            matrix[3, 1] = 1;
            matrix[3, 2] = 1;
            matrix[3, 3] = 1;
            matrix[3, 3] = 1;
            matrix[3, 4] = 1;

            matrix[4, 0] = 1;
            matrix[4, 1] = 1;
            matrix[4, 2] = 1;
            matrix[4, 3] = 1;
            matrix[4, 3] = 1;
            matrix[4, 4] = 1;

            matrix.PrintMatrix();

            Console.ReadKey();


        }
    }
}
