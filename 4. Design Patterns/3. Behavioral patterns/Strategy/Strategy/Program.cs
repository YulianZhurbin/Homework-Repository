using System;

namespace Strategy
{
	class Program
	{
		static void Main()
		{
			Strategy strategy = new ArcherStrategy();
			Warrior warrior = new Warrior(strategy);
			warrior.Attack();

			strategy = new SwordsmanStrategy();
			warrior = new Warrior(strategy);
			warrior.Attack();

			//Delay
			Console.ReadKey();
		}
	}
}
