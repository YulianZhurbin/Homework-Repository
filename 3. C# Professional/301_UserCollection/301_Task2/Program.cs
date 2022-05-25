using System;
using System.Collections.Generic;

namespace _301_Task2
{
	class Program
	{
		static void Main(string[] args)
		{
			MonthCollection arr = new MonthCollection();

			foreach (Month item in arr.GetMonths(31))
			{
				Console.WriteLine(item.Name);
			}

			Console.WriteLine(new string ('-',20));

			for (int i = 1; i <= arr.Count; i++)
			{
				Console.WriteLine(arr[i].Name + " - " + arr[i].DayCount);
			}

			Console.ReadKey();
		}
	}
}
