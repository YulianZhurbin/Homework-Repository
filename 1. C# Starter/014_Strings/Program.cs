using System;

namespace _014_Strings
{
	class Program
	{
		static void Main(string[] args)
		{
			string name = "Alex";
			string surname = "Gordon";

			Console.WriteLine(" Hello, {0} {1}! \n Is's a good day today!", name, surname);

			Console.WriteLine($" Hello, {name,-10} {surname,10}!\nIt's a good day today");

			Console.WriteLine(Console.ReadKey());
		}
	}
}
