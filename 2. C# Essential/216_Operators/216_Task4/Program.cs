using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _216_Task4
{
	class Program
	{
		static void Main(string[] args)
		{
			Date WW2Start = new Date(1, 9, 1939);
			Date ManToSpaceLaunch = new Date(12, 4, 1969);
			int difference = ManToSpaceLaunch - WW2Start;
			Console.WriteLine(difference);

			Console.WriteLine(new string('-', 10));

			Date date1 = new Date(2, 1, 2021);
			Date date2 = new Date(31, 12, 2020);
			int dateDifference = date1 - date2;
			Console.WriteLine(dateDifference);

			Console.WriteLine(new string('-', 10));

			Console.WriteLine(date1.Total);
			int datePlusInt = date1 + 5;
			Console.WriteLine(datePlusInt);

			Console.WriteLine(new string('-', 10));

			Date date3 = new Date(2, 1, 2022);
			Date date4 = new Date(31, 12, 2020);
			Console.WriteLine(date3 - date4);

			Console.WriteLine(new string('-', 10));

			Console.ReadKey();
		}
	}
}
