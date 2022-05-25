using System;

namespace Strategy
{
	class SwordsmanStrategy : Strategy
	{
		public override void Attack()
		{
			Console.WriteLine("Attack using the sword");
		}
	}
}
