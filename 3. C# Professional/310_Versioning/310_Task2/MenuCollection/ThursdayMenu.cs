using System;

namespace _310_Task2
{
	class ThursdayMenu : Menu
	{

		protected override void BringDrink()
		{
			Console.WriteLine("Bring a glass of Pepsi");
		}

		protected override void BringMainDish()
		{
			Console.WriteLine("Bring a fish burger");
		}
	}
}
