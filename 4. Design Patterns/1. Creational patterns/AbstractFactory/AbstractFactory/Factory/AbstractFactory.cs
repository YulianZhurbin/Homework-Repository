using System;

namespace AbstractFactory
{
	abstract class AbstractFactory
	{
		public abstract AbstractChocolate CreateChocolate();
		public abstract AbstractFilling CreateFilling();
	}
}
