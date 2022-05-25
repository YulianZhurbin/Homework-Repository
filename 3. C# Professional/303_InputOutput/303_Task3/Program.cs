using System;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace _303_Task3
{
	class Program
	{
		static void Main()
		{

			FileStream stream = new FileStream(@"C:\Users\user\Desktop\test file\TestFile.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
			StreamWriter writer = new StreamWriter(stream, Encoding.GetEncoding(1251));
			writer.WriteLine("Some text1!");
			writer.WriteLine("Some text2!");
			writer.WriteLine("Some text3!");

			writer.Close();

			StreamReader reader = File.OpenText(@"C:\Users\user\Desktop\test file\TestFile.txt");
			string input;

			while ((input = reader.ReadLine()) != null)
			{
				Console.WriteLine(input);
			}

			reader.Close();

			FileStream stream1 = File.OpenRead(@"C:\Users\user\Desktop\test file\TestFile.txt");

			FileStream destination = File.Create(@"C:\Users\user\Desktop\test file\archive1.zip");

			GZipStream compressor = new GZipStream(destination, CompressionMode.Compress);

			Console.WriteLine("Do you want to archive the file?");

			if (Console.ReadLine() == "yes")
			{

				int theByte = stream1.ReadByte();

				while (theByte != -1)
				{
					compressor.WriteByte((byte)theByte);
					theByte = stream1.ReadByte();
				}
			}

			stream1.Close();
			compressor.Close();

			//Delay
			Console.ReadKey();
		}
	}
}
