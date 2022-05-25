using System;


namespace _209_Task2
{
    public delegate double Delegator(int x, int y); 

    class Program
    {      
        static void Main(string[] args)
        {
            while(true)
            {

            Console.Clear();

            Delegator add = (x, y) => x + y;

            Delegator sub = (x, y) => x - y;

            Delegator mul = (x, y) => x * y;

            Delegator div = (int x, int y) =>
            {
                if (y != 0)
                { return (double) x / (double) y;}
                else
                {
                    Console.Write("divisor can't be ");
                    return 0;
                }
            };

            Console.WriteLine("Enter two numbers");
            int firstOperand = Convert.ToInt32(Console.ReadLine());
            int secondOperand = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose one of the operations. Enter add, sub, mul or div");

            string operation = Console.ReadLine();

            switch (operation)
            {
                case "add":
                    Console.WriteLine(add.Invoke(firstOperand, secondOperand));
                    break;

                case "sub":
                    Console.WriteLine(sub.Invoke(firstOperand, secondOperand));
                    break;

                case "mul":
                    Console.WriteLine(mul(firstOperand, secondOperand));
                    break;

                case "div":
                    Console.WriteLine(div(firstOperand, secondOperand));
                    break;

                default:
                    Console.WriteLine("Operation wasn't found");
                    break;
            }

            Console.ReadKey();
            }
        }
    }
}
