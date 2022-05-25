using System;

namespace Strategy
{
	class Warrior
	{
		Strategy strategy;

		public Warrior(Strategy strategy)
		{
			this.strategy = strategy;
		}

		public void Attack()
		{
			strategy.Attack();
		}
	}
}
