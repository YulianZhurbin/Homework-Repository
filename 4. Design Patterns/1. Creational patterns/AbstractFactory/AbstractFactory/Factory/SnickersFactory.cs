using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
	class SnickersFactory : AbstractFactory
	{
		public override AbstractChocolate CreateChocolate()
		{
			return new SnickersChocolate();
		}
		public override AbstractFilling CreateFilling()
		{
			return new SnickersFilling();
		}
	}
}
