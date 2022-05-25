using System;

namespace FactoryMethod
{
	class Mars : Chocolate
	{
		public Mars()
		{
			Console.WriteLine(this.GetType() + " is produced");
		}
	}
}
