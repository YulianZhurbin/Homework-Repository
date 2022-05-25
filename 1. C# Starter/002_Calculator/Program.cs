using System;

namespace _002_Calculator
{
	class Program
	{
		static void Main(string[] args)
		{
			string a = "Hello", b = "World";
			string text = a + " " + b;
			text += "!";
            
			Console.WriteLine(text);
			Console.Write("Enter the augend: ");
			string stringAugend = Console.ReadLine();

			Console.Write("Enter the addend: ");
			string stringAddend = Console.ReadLine();

			int augend = Convert.ToInt32(stringAugend);
			int addend = Convert.ToInt32(stringAddend);

			int sum = augend + addend;

			string result = string.Format("Result : {0} + {1} + {2}", augend, addend, sum);

			Console.WriteLine(result);

			// Delay
			Console.ReadKey();
		}
	}
}
