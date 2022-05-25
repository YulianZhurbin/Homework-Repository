using System;

namespace _310_Task2
{
	class Menu
	{
		public void BringCombo()
		{
			BringMainDish();
			BringDrink();
			BringSideDish();
			BringWipes();
			BringTray();
		}

		protected virtual void BringDrink()
		{
			Console.WriteLine("Bring a cup of tea");
		}

		protected virtual void BringMainDish()
		{
			Console.WriteLine("Bring a burger");
		}

		protected virtual void BringSideDish() { }

		void BringWipes()
		{
			Console.WriteLine("Bring wipes");
		}

		void BringTray()
		{
			Console.WriteLine("Bring a tray");
		}
	}
}
