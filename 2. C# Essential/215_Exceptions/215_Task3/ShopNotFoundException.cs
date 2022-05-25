using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _215_Task3
{
	class ShopNotFoundException : Exception
	{
		public ShopNotFoundException(string massage) : base(massage) { }
	}
}
