using System;


namespace Strategy
{
	class ArcherStrategy : Strategy
	{
		public override void Attack()
		{
			Console.WriteLine("Attack using the bow");
		}
	}
}
