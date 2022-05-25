using System;

namespace AbstractFactory
{
	class Program
	{
		static void Main()
		{
			Client client = null;

			client = new Client(new SnickersFactory());
			client.MakeChocolateBar();

			client = new Client(new MarsFactory());
			client.MakeChocolateBar();

			//Delay
			Console.ReadKey();
		}
	}
}
