﻿using System;


namespace _009_EscapeSequence
{
	class Program
	{
		static void Main(string[] args)
		{
			string a = "Happy birthday, Joel"; // Happy birthday, Joel 
			string b = @"Happy birthday, Joel"; // Happy birthday, Joel 
			string c = "hello \t world"; // hello world 
			string d = @"hello \t world"; // hello \t world 
			string e = "Joe said \"Hello\" to me"; // Joe said "Hello" to me 
			string f = @"Joe said ""Hello"" to me"; // Joe said "Hello" to me 
			string g = "\\\\server\\share\\file.txt"; // \\server\share\file.txt 
			string h = @"\\server\share\file.txt"; // \\server\share\file.txt 
			string i = "one\r\ntwo\r\nthree";
			string j = @"one 
             two 
             three";

			Console.Write(i);

			// Delay
			Console.ReadKey();
		}
	}
}
