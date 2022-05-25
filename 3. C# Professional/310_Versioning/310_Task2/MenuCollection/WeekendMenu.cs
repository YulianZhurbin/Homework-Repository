using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _310_Task2
{
	class WeekendMenu : Menu
	{

		protected override void BringDrink()
		{
			Console.WriteLine("Bring a glass of Cola");
		}

		protected override void BringMainDish()
		{
			Console.WriteLine("Bring a cheese burger");
		}

		protected override void BringSideDish() 
		{
			Console.WriteLine("Bring a pack of french fries");
		}
	}
}
