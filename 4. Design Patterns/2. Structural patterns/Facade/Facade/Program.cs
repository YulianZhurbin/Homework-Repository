using System;

namespace Facade
{
	class Program
	{
		static void Main()
		{
			Contractor constructionCompany = new Contractor();
			constructionCompany.BuildHouse();

			//Delay
			Console.ReadKey();
		}
	}
}
