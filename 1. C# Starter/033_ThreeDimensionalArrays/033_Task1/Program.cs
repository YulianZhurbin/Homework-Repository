using System;

namespace _033_Task1
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] bookList = {"Brave New World", "Tom Sawyer's Adventures", "CLR via C#"};

			Console.WriteLine(" There are next books in the library database: ");
			
			// printing the list of books
			{
				Console.ForegroundColor = ConsoleColor.Yellow;

				for (int i = 0; i < bookList.Length; i++)
				{
					Console.Write($"\"{bookList[i]}\"    ");
				}

				Console.WriteLine("\n");
				Console.ForegroundColor = ConsoleColor.Gray;
			}

			const int ROOM_NUMBER = 3, SHELVING_NUMBER = 5, SHELF_NUMBER = 10, PLACE_NUMBER = 10;
			string[,,,] archive = new string[ROOM_NUMBER, SHELVING_NUMBER, SHELF_NUMBER, PLACE_NUMBER];

			archive [0, 1, 1, 1] = bookList[0];
			archive [1, 4, 9, 9] = bookList[0];
			archive [2, 2, 2, 2] = bookList[1];
			archive [2, 3 ,3 ,3] = bookList[2];

			// search of a book
			{
				while (true)
				{
					Console.WriteLine("Enter the title of book");

					Console.ForegroundColor = ConsoleColor.Yellow;

					string bookName = Console.ReadLine();

					Console.ForegroundColor = ConsoleColor.Gray;

					for (int t = 0; t < ROOM_NUMBER; t++)
					{
						for (int i = 0; i < SHELVING_NUMBER; i++)
						{
							for (int j = 0; j < SHELF_NUMBER; j++)
							{
								for (int k = 0; k < PLACE_NUMBER; k++)
								{
									if (bookName == archive[t, i, j, k])
									{
										Console.WriteLine($"The book \"{bookName}\" is in room {t + 1} in shelving {i + 1} " +
														  $"on shelf {j + 1} at place {k + 1}");
									}
								}
							}
						}
					}

					Console.WriteLine();
				}
			}

			// Delay
			Console.ReadKey();

		}
	}
}
