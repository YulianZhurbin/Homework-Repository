using System;

namespace _022_CONST_TASKS
{
	class Program
	{
		static void Main(string[] args)
		{
			const double PI = 3.141593;
			const bool MY_CONST = true;

			bool isConstBigger;
			{
				Console.Write(" Enter the compared number: ");
				string textNumber = Console.ReadLine();
				double number = Convert.ToDouble(textNumber);

				isConstBigger = PI > number;
			}

			bool comparison = MY_CONST == isConstBigger;
			Console.Write(comparison);

			// Delay
			Console.ReadKey();
		}
	}
}
