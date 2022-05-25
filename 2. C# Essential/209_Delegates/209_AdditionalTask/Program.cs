using System;

namespace _209_AdditionalTask
{
    public delegate double Mean(int x,int y,int z);

    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Clear();

                Mean myDelegate = new Mean(delegate (int x, int y, int z) { return (double)(x + y + z) / 3; });

                Console.WriteLine("Enter 3 integer numbers to find the mean");
                int operand1 = Convert.ToInt32(Console.ReadLine());
                int operand2 = Convert.ToInt32(Console.ReadLine());
                int operand3 = Convert.ToInt32(Console.ReadLine());

                double average = myDelegate(operand1, operand2, operand3);

                Console.WriteLine("The mean = {0:F1}", average);

                Console.ReadKey();
            }          
        }
    }
}
