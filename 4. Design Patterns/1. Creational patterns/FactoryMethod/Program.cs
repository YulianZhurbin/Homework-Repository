using System;

namespace FactoryMethod
{
	class Program
	{
		static void Main()
		{
			Creator creator = null;
			Chocolate chocolate = null;

			creator = new SnickersCreator();
			chocolate = creator.FactoryMethod();

			creator = new MarsCreator();
			chocolate = creator.FactoryMethod();

			//Delay
			Console.ReadKey();
		}
	}
}
