using System;

namespace Adapter
{
	class Adapter : AmericanSocket, ISocket
	{
		public void GetCurrent()
		{
			base.Get120Volts();
		}
	}
}
