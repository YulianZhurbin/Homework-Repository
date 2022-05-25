using System;

namespace AbstractFactory
{
	class Client
	{
		AbstractChocolate chocolate;
		AbstractFilling filling;

		public Client(AbstractFactory factory)
		{
			chocolate = factory.CreateChocolate();
			filling = factory.CreateFilling();
		}

		public void MakeChocolateBar()
		{
			chocolate.Cover(filling);
		}
	}
}
