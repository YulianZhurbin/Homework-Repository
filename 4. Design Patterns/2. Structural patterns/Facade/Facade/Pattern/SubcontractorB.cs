using System;

namespace Facade
{
	class SubcontractorB
	{
		public void MakeFramework()
		{
			Console.WriteLine("Wooden framework making");
		}

		public void MakeExterior()
		{
			Console.WriteLine("Exterior making");
		}

		public void MakeRoof()
		{
			Console.WriteLine("Roof making");
		}
	}
}
