using System;

namespace FactoryMethod
{
	class Snickers : Chocolate
	{
		public Snickers()
		{
			Console.WriteLine(this.GetType() + " is produced");
		}
	}
}
