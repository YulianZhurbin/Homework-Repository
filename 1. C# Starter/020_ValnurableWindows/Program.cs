using System;

namespace _020_ValnurableWindows
{
	class Program
	{
		static void Main(string[] args)
		{
			double sum;
			{
				int a = 10, b = 20, c = 30;
				sum = a + b + c;
			}

			int dif;
			{
				int x = 50, y = 100, z = 300;
				dif = z - y - x;
			}

			double quotient = dif / sum;

			Console.WriteLine($" The value of the quotient = {quotient}");

			// Delay
			Console.ReadKey();
		}
	}
}
