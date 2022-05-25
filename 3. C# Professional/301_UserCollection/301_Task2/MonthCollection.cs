using System;
using System.Collections.Generic;

namespace _301_Task2
{
	class MonthCollection
	{
		Month[] collection = new Month[12]
		{
			new Month("January", 31),
			new Month("February", 28),
			new Month("March", 31),
			new Month("April", 30),
			new Month("May", 31),
			new Month("June", 30),
			new Month("July", 31),
			new Month("August", 31),
			new Month("September", 30),
			new Month("October", 31),
			new Month("November", 30),
			new Month("December", 31)
		};

		public Month this[int i]
		{		
			get 
			{
				if (i < 1 || i > 12)
				{
					try
					{
						throw new Exception("The request is out of 12-month range!");
					}
					catch (Exception e)
					{
						Console.WriteLine(e.Message);
					}

					return null;
				}
				else
				{
					return collection[i - 1];
				}
			}
		}

		public IEnumerable<Month> GetMonths(int dayCount)
		{
			switch (dayCount)
			{
				case 31:
					yield return collection[0];
					yield return collection[2];
					yield return collection[4];
					yield return collection[6];
					yield return collection[7];
					yield return collection[9];
					yield return collection[11];
					yield break;

				case 30:
					yield return collection[3];
					yield return collection[5];
					yield return collection[8];
					yield return collection[10];
					yield break;

				case 28:
				case 29:
					yield return collection[1];
					yield break;

				default:
					Console.WriteLine("No matches have been found!");
					yield break;
			}
		}

		public IEnumerable<Month> GetMonths()
		{
			foreach (Month item in collection)
			{
				yield return item;
			}
		}

		public int Count 
		{
			get { return collection.Length; }
		}
	}
}
