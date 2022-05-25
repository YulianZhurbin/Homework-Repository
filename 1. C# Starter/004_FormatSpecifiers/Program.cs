using System;
using System.IO;

namespace _004_FormatSpecifiers
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("1. E, C, D, X formats, respectively: {0:E1},   {1:C},   {2:D},   {3:X}", 2500, 36, 25, 255);

			// Delay
			Console.ReadKey();

		}
	}
}
