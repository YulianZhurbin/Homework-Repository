using System;

namespace _003_AverageTemperature
{
	class Program
	{
		static void Main(string[] args)
		{
			float T_mo = 1, T_tu = 1, T_we = 1;
			float T_sum = T_mo + T_tu - T_we;
			float T_avg = T_sum / 3;

			Console.WriteLine(T_avg);

			// delay
			Console.ReadKey();
		}
	}
}
