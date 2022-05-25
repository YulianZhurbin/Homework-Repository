using System;

namespace Facade
{
	class SubcontractorA
	{
		public void MakePit()
		{
			Console.WriteLine("Pit making");
		}

		public void MakeFoundation()
		{
			Console.WriteLine("Concrete foundation making");
		}
	}
}
