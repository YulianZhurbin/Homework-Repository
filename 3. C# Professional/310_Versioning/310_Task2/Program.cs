using System;
using System.Collections.Generic;

namespace _310_Task2
{
	class Program
	{
		static void Main()
		{
			List<Menu> weekMenu = new List<Menu>
			{
				new Menu(), 
				new Menu(), 
				new Menu(), 
				new ThursdayMenu(),
				new Menu(),
				new WeekendMenu(), 
				new WeekendMenu()
			};

			int count = 0;
			
			foreach (var item in weekMenu)
			{
				Console.WriteLine("Bring the combo of day{0}", ++count);
				item.BringCombo();
				Console.WriteLine(new string('-', 50));
			}

			//Delay
			Console.ReadKey();
		}
	}
}
