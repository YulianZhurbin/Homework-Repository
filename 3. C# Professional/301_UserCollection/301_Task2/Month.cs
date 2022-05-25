using System;
using System.Collections.Generic;

namespace _301_Task2
{
	class Month
	{
		readonly string name;
		readonly int dayCount;

		public Month(string name, int dayCount)
		{
			this.name = name;
			this.dayCount = dayCount;
		}

		public string Name
		{
			get { return name; }
		}

		public int DayCount 
		{
			get { return dayCount; }
		}
	}
}
