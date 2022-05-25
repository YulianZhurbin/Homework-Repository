using System;

namespace _001_NumericOperations
{
	class Program
	{
		static void Main(string[] args)
		{
			byte augend = 1, addend = 2;
			int sum = augend + addend;                   // addition

			byte minuend = 5, subtrahend = 3;
			int difference = minuend - subtrahend;       // subtraction

			byte multiplicand = 2, multiplier = 3;
			int product = multiplicand * multiplier;     // multiplication

			byte dividend = 9, divisor = 2;
			int quotient = dividend / divisor;           // division (finding quotient)
			int remainder = dividend % divisor;          // division (finding remainder)

			Console.WriteLine(sum);
			Console.WriteLine(difference);
			Console.WriteLine(product);
			Console.WriteLine(quotient);
			Console.WriteLine(remainder);

			// delay
			Console.ReadKey();
		}
	}
}
