using System;
using System.Collections.Generic;

namespace _310_AdditionalTask
{
	class Warrior
	{
		public void Attack()
		{
			AttackByHand();
			AttackByLeg();
		}

		protected virtual void AttackByHand()
		{
			Console.WriteLine("Club hit: 10 hp");
		}
		
		protected virtual void AttackByLeg()
		{
			Console.WriteLine("Leg hit: 15 hp");
		}
	}

	class SwordWarrior : Warrior
	{
		protected override void AttackByHand()
		{
			Console.WriteLine("Sword hit: 30 hp");
		}
	}

	class Archer : Warrior
	{
		protected override void AttackByHand()
		{
			Console.WriteLine("Bow shoot: hp 20");
		}
	}

	class MiddleArcher : Archer
	{
		protected override void AttackByHand()
		{
			Console.WriteLine("Bow shoot: hp 30");
		}
	}

	class Program
	{
		static void Main()
		{
			Console.WriteLine("Warrior attacks");
			Warrior warrior = new Warrior();
			warrior.Attack();
			Console.WriteLine(new string('-',50));

			Console.WriteLine("Sword warrior attacks");
			SwordWarrior swordWarrior = new SwordWarrior();
			swordWarrior.Attack();
			Console.WriteLine(new string('-', 50));
			
			Console.WriteLine("Archer attacks");
			Archer archer = new Archer();
			archer.Attack();
			Console.WriteLine(new string('-', 50));

			Console.WriteLine("Middle-archer attacks");
			MiddleArcher middleArcher = new MiddleArcher();
			middleArcher.Attack();
			Console.WriteLine(new string('-', 50));
			Console.WriteLine(new string('-', 50));

			List<Warrior> squad = new List<Warrior> { new Warrior(), new SwordWarrior(), new Archer(), new MiddleArcher()};

			foreach (var unit in squad)
			{ 
				unit.Attack();
				Console.WriteLine(new string('-', 50));
			}

			//Delay
			Console.ReadKey();
		}
	}
}
