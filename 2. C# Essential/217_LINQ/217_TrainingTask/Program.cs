using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _217_TrainingTask
{
	class Program
	{
		static void Main(string[] args)
		{
			ArrayList arrList = new ArrayList() { 1, 2, "3" };
			var query = from dynamic n in arrList select n + 2;
			foreach (var item in query)
				Console.WriteLine(item);


			Console.ReadKey();
		}
	}
}
