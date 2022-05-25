using System;

namespace ConsoleColors
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.ForegroundColor = ConsoleColor.Red; // Устанавливаем цвет букв
			Console.BackgroundColor = ConsoleColor.White; // Устанавливаем цвет фона

			Console.WriteLine("Hello World!");
			Console.WriteLine("Hello Friends!");

			Console.ResetColor(); // Сбрасываем настройки цвета букв и фона
			Console.WriteLine("Goodbye");

			//Delay
			Console.ReadKey();
		}
	}
}
