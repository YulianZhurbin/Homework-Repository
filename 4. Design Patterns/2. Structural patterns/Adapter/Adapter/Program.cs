using System;

namespace Adapter
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
