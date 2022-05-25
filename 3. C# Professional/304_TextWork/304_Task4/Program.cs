using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace _304_Task4
{
	class Program
	{
		static void Main()
		{
			string billText = File.ReadAllText("Bill.txt");

			Console.WriteLine(billText);

			Console.WriteLine(new string('-', 25));

			string pricePattern = @"\d+[\,\.]\d$";

			var russian = CultureInfo.CurrentCulture;
			var american = new CultureInfo("en-US");

			string rusBill = Regex.Replace(billText, pricePattern, (m) => double.Parse(m.Value.Replace('.', ',')).ToString("F1", russian));
			string amerBill = Regex.Replace(billText, pricePattern, (m) => double.Parse(m.Value.Replace('.', ',')).ToString("F1", american));


			Console.WriteLine(rusBill);
			Console.WriteLine(new string('-', 25));
			Console.WriteLine(amerBill);

			//Delay 
			Console.ReadKey();

			//string datePattern = @"\d{2}\d{}
		}
	}
}
