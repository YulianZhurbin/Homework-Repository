using System;
using System.Collections.Generic;

namespace _301_AdditionalTask
{
	class Program
	{
		static void Main(string[] args)
		{
			foreach (int item in GetSquaredOddNumbers(new int[] { 0, 1, 2, 3, 4, 5, 6, 7 }))
			{
				Console.WriteLine(item);
			}

			Console.ReadKey();
		}

		static IEnumerable<int> GetSquaredOddNumbers(int[] sequence)
		{
			foreach (int item in sequence)
			{
				if (item % 2 != 0)
				{
					yield return item * item;
				}
			}
		}
	}
}
