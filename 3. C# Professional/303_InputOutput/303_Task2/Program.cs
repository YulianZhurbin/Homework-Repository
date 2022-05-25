using System;
using System.Collections.Generic;
using System.IO;

namespace _303_Task2
{
	class Program
	{
		static void Main()
		{
			FileStream someFile = new FileStream(@"C:\Users\user\Desktop\test file\TestFile.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

			Console.WriteLine("Pointer = {0}", someFile.Position);

			for (int i = 0; i < 200; i++)
			{
				someFile.WriteByte((byte)i);
			}

			Console.WriteLine("Pointer = {0}", someFile.Position);

			someFile.Position = 0;

			for (int i = 0; i < 200; i++)
			{
				Console.Write("  " + someFile.ReadByte());
			}

			someFile.Close();

			//Delay
			Console.ReadKey();




		}
	}
}
