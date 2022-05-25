using System;

namespace _011_Arithmetics
{
	class Program
	{
		static void Main(string[] args)
		{
			byte a = 5;
			sbyte b = -27;
			short c = -7;
			ushort d = 7;
			int e = -8;
			uint f = 8;
			long g = 9;
			ulong h = 9;
			float j = 10;

			short m = (short)(a - b - c - d - e - f - g);

			Console.WriteLine(m);

			// Delay 
			Console.ReadKey();
		}
	}
}
