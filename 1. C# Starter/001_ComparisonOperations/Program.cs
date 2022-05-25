using System;

namespace _001_ComparisonOperations
{
	class Program
	{
		static void Main(string[] args)
		{
			int x = 1, y = 2;

			bool IsEqual = x == y;
			Console.WriteLine($"{x} == {y} = {IsEqual}");

			bool IsNotEqual = x != y;
			Console.WriteLine($"{x} != {y} = {IsNotEqual}");

			bool IsLess = x < y;
			Console.WriteLine($"{x} < {y} = {IsLess}");

			bool IsGreater = x > y;
			Console.WriteLine($"{x} > {y} = {IsGreater}");

			bool IsLessOrEqual = x <= y;
			Console.WriteLine($"{x} <= {y} = {IsLessOrEqual}");

			bool IsGreaterOrEqual = x >= y;
			Console.WriteLine($"{x} >= {y} = {IsGreaterOrEqual}");

			// Delay
			Console.ReadKey();

			bool IsGreater2 = 2 + 2 > 5 * 5;
			Console.WriteLine(IsGreater2);
		}
	}
}
