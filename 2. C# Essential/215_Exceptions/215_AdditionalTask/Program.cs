using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _215_AdditionalTask
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine("Enter the first operand, an operation and the second operand.");

				Calculator myCalculator = new Calculator();

				int op1 = Convert.ToInt32(Console.ReadLine());
				myCalculator.Op1 = op1;

				string operation = Console.ReadLine();

				int op2 = Convert.ToInt32(Console.ReadLine());
				myCalculator.Op2 = op2;

				Console.WriteLine();

				switch (operation)
				{
					case "+":
						myCalculator.Add();
						break;
					case "-":
						myCalculator.Sub();
						break;
					case "*":
						myCalculator.Mul();
						break;
					case "/":
						myCalculator.Div();
						break;
					default:
						Console.WriteLine("Unknown operation.");
						break;
				}

				Console.WriteLine();

				//Delay
				Console.ReadKey();
			}
		}
	}
}
