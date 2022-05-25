using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _214_Task3
{
	class Program
	{
		static void Main(string[] args)
		{
			MyDictionary<string, string> myDict = new MyDictionary<string, string>();

			myDict.Add("island","остров");
			myDict.Add("river","река");
			myDict.Add("stream","ручей");
			myDict.Add("delta","дельта");
			myDict.Add("pond","пруд");

			Console.WriteLine("Translation of \"river\" is {0}", myDict["river"]);

			Console.WriteLine("The second translation is {0}", myDict[1]);

			Console.WriteLine("The overall amount of pairs = {0}", myDict.Count);

			Console.WriteLine("All pairs of the dictionary:");
			foreach (string iteratorElement in myDict.GetCollection())
			{
				Console.WriteLine(iteratorElement + "  -  " + myDict[iteratorElement]);
			}

			//Delay
			Console.ReadKey();
		}
	}
}
