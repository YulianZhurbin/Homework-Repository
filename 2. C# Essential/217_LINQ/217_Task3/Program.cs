using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _217_Task3
{
	class Program
	{
		static void Main(string[] args)
		{
			List<dynamic> collection = new List<dynamic>
			{
				new { Key = "zero", Value = "0" },
				new { Key = "one", Value = "1" },
				new { Key = "two", Value = "2" },
				new { Key = "three", Value = "3" },
				new { Key = "four", Value = "4" },
				new { Key = "five", Value = "5" },
				new { Key = "six", Value = "6" },
				new { Key = "seven", Value = "7" },
				new { Key = "eight", Value = "8" },
				new { Key = "nine", Value = "9" }
			};

			var query = from pair in collection
						select new { pair.Key, pair.Value };

			foreach (dynamic i in query)
			{
				Console.WriteLine(i.Key + " = " + i.Value);
			}

			Console.ReadKey();
		}
	}
}
