using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _214_Task3;
using static System.Console;
using Dict = _214_Task3.MyDictionary<string, string>;

namespace _218_Task1
{
	class Program
	{
		static void Main()
		{
			//MyDictionary<string, string> myDict = new MyDictionary<string, string>();
			Dict myDict = new Dict();

			myDict.Add("apple", "яблоко");
			myDict.Add("pear", "груша");
			myDict.Add("cranberry", "клюква");
			myDict.Add("orange", "апельсин");

			WriteLine("The dictionary has {0} pairs", myDict.Count);

			foreach (string i in myDict.GetCollection()) 
			{
				WriteLine(i + " - " + myDict[i]);
			}

			//Delay
			ReadKey();
		}
	}
}
