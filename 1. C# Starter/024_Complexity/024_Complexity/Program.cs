using System;

namespace _024_Complexity
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(" Enter the number: ");

			double value;
			int g;
			const int Y = 2, THRESHOLD = 15;
			string textNumber = Console.ReadLine();
			int number = Convert.ToInt32(textNumber);
			bool IsNumberLessThreshold = THRESHOLD > number;

			if (IsNumberLessThreshold)
			{
				g = Y;
				value = g + Math.PI;
			}
			else
			{
				const int Z = 3;
				g = Z;
				value = g + Math.PI * 2;
			}

			Console.WriteLine($" The number g = {g}, The magnitude of value = {value}");

			// Delay
			Console.ReadKey();
		}
	}
}
