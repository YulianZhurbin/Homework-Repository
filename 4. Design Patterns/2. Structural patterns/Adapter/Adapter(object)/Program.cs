using System;

namespace Adapter_object_
{
	class Program
	{
		static void Main()
		{
			ISocket socket = new Adapter();

			socket.GetCurrent();

			//Delay
			Console.ReadKey();
		}
	}
}
