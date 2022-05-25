using System;

namespace _023_IfElseOperatior
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write(" Enter the number:   ");

			string textNumber = Console.ReadLine();
			int number = Convert.ToInt32(textNumber);
			
			const int COMPARED_NUMBER = 3;
			bool isNumberBigger = COMPARED_NUMBER < number; // first case = 6, second case = 1 

			if (isNumberBigger)
			{
				number = number + 10;
			}
			else
			{
				number = number * 10;
			}

			Console.Write(number);

			// Delay
			Console.ReadKey();
		}
	}
}
