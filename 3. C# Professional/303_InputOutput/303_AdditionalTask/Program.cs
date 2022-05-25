using System;
using System.Collections.Generic;
using System.IO;

namespace _303_AdditionalTask
{
	class Program
	{
		static void Main()
		{
			for (int i = 0; i < 100; i++)
			{
				Directory.CreateDirectory(@"C:\Users\user\Desktop\test file\Folder_" + $"{i}");
			}

			Console.WriteLine("Files have benn created!");

			//Delay
			Console.ReadKey();

			for (int i = 0; i < 100; i++)
			{
				Directory.Delete(@"C:\Users\user\Desktop\test file\Folder_" + $"{i}");
			}

			Console.WriteLine("Files have been deleted!");
			//Delay
			Console.ReadKey();
		}
	}
}
