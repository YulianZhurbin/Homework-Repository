using System;

namespace _021_CheckedAndUnchecked
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write(" Enter the first number: ");
			int firstOperand = Convert.ToInt32(Console.ReadLine());

			Console.Write(" Enter the second number: ");
			int secondOperand = Convert.ToInt32(Console.ReadLine());

			unchecked
			{
				int dif = firstOperand * secondOperand;
				Console.WriteLine(dif);

				int sum = firstOperand + secondOperand;
				Console.WriteLine(sum);
			}

			// Delay
			Console.ReadKey();
		}
	}
}
