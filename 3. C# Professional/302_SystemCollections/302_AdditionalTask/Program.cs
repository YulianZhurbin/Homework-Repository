using System;
using System.Collections.Generic;
using System.Collections;

namespace _302_AdditionalTask
{
	class Program
	{
		static void Main(string[] args)
		{
			SortedList myList = new SortedList(new Descender());

			myList.Add(0, "apple");
			myList.Add(1, "banana");
			myList.Add(2, "coconut");
			myList.Add(3, "dragon fruit");

			foreach (DictionaryEntry item in myList)
			{
				Console.WriteLine(item.Key + " - " + item.Value);
			}

			Console.WriteLine(new string('-', 40));

			SortedList myListStraight = new SortedList();

			myListStraight.Add(0, "apple");
			myListStraight.Add(1, "banana");
			myListStraight.Add(2, "coconut");
			myListStraight.Add(3, "dragon fruit");

			foreach (DictionaryEntry item in myListStraight)
			{
				Console.WriteLine(item.Key + " - " + item.Value);
			}

			//Delay
			Console.ReadKey();
		}
	}

	class Descender : IComparer
	{
		public int Compare(object x, object y)
		{
			int result = (int)y - (int)x;
			return result;
		}
	}
}
