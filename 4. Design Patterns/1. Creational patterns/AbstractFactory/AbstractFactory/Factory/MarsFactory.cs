using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
	class MarsFactory : AbstractFactory
	{
		public override AbstractChocolate CreateChocolate()
		{
			return new MarsChocolate();
		}
		public override AbstractFilling CreateFilling()
		{
			return new MarsFilling();
		}
	}
}
