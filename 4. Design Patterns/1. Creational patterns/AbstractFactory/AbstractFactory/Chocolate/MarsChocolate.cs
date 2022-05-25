using System;

namespace AbstractFactory
{
	class MarsChocolate : AbstractChocolate
	{
		public override void Cover(AbstractFilling filling)
		{
			Console.WriteLine(this + " cover " + filling);
		}
	}
}
