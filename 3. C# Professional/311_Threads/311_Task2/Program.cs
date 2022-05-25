using System;
using System.IO;
using System.Threading;

namespace _311_Task2
{
	class Program
	{
		static object block = new object();
		static StreamWriter resultFile;

		public static void ReadText(object path)
		{
			Console.WriteLine("Thread{0} started working", Thread.CurrentThread.ManagedThreadId);

			StreamReader fileStream = new StreamReader((string)path);
			string text = fileStream.ReadToEnd();

			Thread.Sleep(1000);                //Helping to show parallel work of the threads 

			lock (block)
			{
				resultFile.WriteLine(text + "\n");
			}

			fileStream.Close();

			Console.WriteLine("Thread{0} finished working", Thread.CurrentThread.ManagedThreadId);
		}

		static void Main()
		{
			string resultPath = @"ResultFile.txt";
			resultFile = new StreamWriter(resultPath);

			string path1 = @"Thread1File.txt";
			Thread thread1 = new Thread(ReadText);
			thread1.Start(path1);

			string path2 = @"Thread2File.txt";
			Thread thread2 = new Thread(ReadText);
			thread2.Start(path2);

			thread1.Join();
			thread2.Join();

			resultFile.Close();

			Console.WriteLine(new string('-', 30));

			Console.WriteLine("Content of ResultFile.txt:\n");

			Console.ForegroundColor = ConsoleColor.Green;

			StreamReader finalFile = new StreamReader(resultPath);

			string finalText = finalFile.ReadToEnd();

			Console.WriteLine(finalText);

			//Delay
			Console.ReadKey();
			
			

		}
	}
}
