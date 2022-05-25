using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace _304_Task3
{
	class Program
	{
		static void Main()
		{
			StreamReader reader = File.OpenText(@"C:\Users\user\Desktop\test file\Test.txt");

			string pattern = " в | без | до | для | за | через | над | по | из | у | " +
							 "около | под | о | про | на | к | перед | при | с | со | между ";

			string changedString = Regex.Replace(reader.ReadToEnd(), pattern, " ГАВ ");

			reader.Close();

			StreamWriter writer = new StreamWriter(@"C:\Users\user\Desktop\test file\Test.txt");

			writer.Write(changedString);
			
			writer.Close();

			//Delay
			Console.ReadKey();
		}
	}
}
