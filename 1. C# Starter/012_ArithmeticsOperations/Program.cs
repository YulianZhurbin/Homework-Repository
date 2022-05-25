using System;


namespace _012_ArithmeticsOperations
{
	class Program
	{
		static void Main(string[] args)
		{
			{
				int x = 10, y = 12, z = 3;
				x += y - x++ * z;
				Console.WriteLine(x);
			}

			{
				int x = 10, y = 12, z = 3;
				z = --x - y * 5;
				Console.WriteLine(z);
			}

			{
				int x = 10, y = 12, z = 3;
				y /= x + 5 % z;
				Console.WriteLine(y);
			}

			{
				int x = 10, y = 12, z = 3;
				z = x++ + y * 5;
				Console.WriteLine(z);
			}

			{
				int x = 10, y = 12, z = 3;
				x = y - x++ * z;
				Console.WriteLine(x);
			}

			// Delay
			Console.ReadKey();



			


		}
	}
}
