using System;

namespace FactoryMethod
{
	class MarsCreator : Creator
	{
		public override Chocolate FactoryMethod()
		{
			return new Mars();
		}
	}
}
