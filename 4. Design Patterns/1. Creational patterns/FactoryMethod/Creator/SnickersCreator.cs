using System;

namespace FactoryMethod
{
	class SnickersCreator : Creator
	{
		public override Chocolate FactoryMethod()
		{
			return new Snickers();
		}
	}
}
