using System;

namespace AbstractFactory
{
	class SnickersChocolate : AbstractChocolate
	{
		public override void Cover(AbstractFilling filling)
		{
			Console.WriteLine(this + " cover " + filling);
		}
	}
}
