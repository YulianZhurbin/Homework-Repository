using System;

namespace _010_Conversions
{
	class Program
	{
		static void Main(string[] args)
		{
			decimal e = 222.718281828459045211223344556677889900m;
				
			Console.BackgroundColor = ConsoleColor.Green;
			Console.ForegroundColor = ConsoleColor.DarkBlue;
			Console.WriteLine($" e (decimal) = {e}");

			// Delay
			Console.ReadKey();

		}
	}
}
