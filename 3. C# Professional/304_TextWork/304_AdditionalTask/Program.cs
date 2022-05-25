using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _304_AdditionalTask
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Enter a login:");

			const string LOGIN_PATTERN = @"^[a-zA-Z]+$";

			Regex regex = new Regex(LOGIN_PATTERN);

			string login;

			while (true)
			{
				login = Console.ReadLine();

				if (!regex.IsMatch(login))
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Not allowed login! Only latin letters are allowed.");
					Console.ForegroundColor = ConsoleColor.Gray;
					continue;
				}

				break;
			}

			Console.WriteLine("Enter a keyword:");

			const string KEYWORD_PATTERN = @"^[a-zA-Z0-9]+$";
			const string LETTER_PATTERN = @"[a-zA-Z]";
			const string DIGIT_PATTERN = @"\d";

			string keyword;

			while (true)
			{
				keyword = Console.ReadLine();

				if (!Regex.IsMatch(keyword, LETTER_PATTERN) || !Regex.IsMatch(keyword, DIGIT_PATTERN) || 
					!Regex.IsMatch(keyword, KEYWORD_PATTERN))
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Not allowed keyword! Only latin letters and digits are allowed, " +
									  "\nand a keyword has to have at least one letter and one digit.");
					Console.ForegroundColor = ConsoleColor.Gray;
					continue;
				}

				break;
			}

			Console.WriteLine("Login is {0}\nKeyword is {1}", login, keyword);

			//Delay
			Console.ReadKey();
		}
	}
}
