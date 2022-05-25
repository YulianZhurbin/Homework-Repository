using System;

namespace Facade
{
	class Contractor
	{
		SubcontractorA subcontractorA = new SubcontractorA();
		SubcontractorB subcontractorB = new SubcontractorB();
		SubcontractorC subcontractorC = new SubcontractorC();
		SubcontractorD subcontractorD = new SubcontractorD();

		public void BuildHouse()
		{
			subcontractorA.MakePit();
			subcontractorA.MakeFoundation();

			subcontractorB.MakeFramework();
			subcontractorB.MakeExterior();
			subcontractorB.MakeRoof();

			subcontractorC.MakeInterior();

			subcontractorD.MakeElectricity();
			subcontractorD.MakePlumbing();
		}
	}
}
