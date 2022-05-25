using System;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Specialized;

namespace _302_Task4
{
	class Program
	{
		static void Main()
		{
			Goods turkishApples = new Goods("apples", 1);
			Goods uzbekApples = new Goods("apples", 2);
			Goods turkishBananas = new Goods("bananas", 3);
			Goods russianPlums = new Goods("plums", 1);

			//OrderedDictionary myDict = new OrderedDictionary();
			OrderedDictionary myDict = new OrderedDictionary(new Equalizer());

			myDict.Add(turkishApples, "Turkey");			
			myDict.Add(turkishBananas, "Turkey");
			myDict.Add(uzbekApples, "Uzbekistan");
			//myDict.Add(russianPlums, "Russia");

			foreach (DictionaryEntry item in myDict)
			{
				Console.WriteLine(((Goods)item.Key).Weight);
			}

			//Delay
			Console.ReadKey();
		}

	}

	class Equalizer : IEqualityComparer
	{
		public new bool Equals(object x, object y)
		{
			return (x as Goods).Weight == (y as Goods).Weight;
		}

		public int GetHashCode(object x)
		{
			Goods result = x as Goods;
			if (result != null)
			{
				Console.WriteLine(result.Weight);
				return result.Weight;
			}

			Console.WriteLine("Wrong item of goods!");
			return 0;
		}
	}

	class Goods
	{
		readonly string name;
		readonly int weight;

		public string Name 
		{
			get 
			{
				return name;
			}
		}
		
		public int Weight 
		{
			get 
			{
				return weight;
			}
		}

		public Goods(string name, int weight)
		{
			this.name = name;
			this.weight = weight;
		}
	}
}

