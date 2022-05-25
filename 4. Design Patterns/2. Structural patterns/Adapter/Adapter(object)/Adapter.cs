using System;

namespace Adapter_object_
{
	class Adapter : ISocket
	{
		AmericanSocket americanSocket = new AmericanSocket();

		public void GetCurrent()
		{
			americanSocket.Get120Volts();
		}
	}
}
