using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace _306_Task3
{
	class Program
	{
		static void Main()
		{
			Assembly assembly = null;

			try
			{
				assembly = Assembly.Load("306_Task2_Library");
				Console.WriteLine("The library's successfully");
			}
			catch(FileNotFoundException ex)
			{
				Console.WriteLine(ex.Message);
			}

			Type temperature = assembly.GetType("_306_Task2_Library.Temperature");

			Console.WriteLine("Enter the temperature, C: ");


			double quantity = Convert.ToDouble(Console.ReadLine());

			object instance = Activator.CreateInstance(temperature, quantity);

			MethodInfo method = temperature.GetMethod("ConvertToF");

			double convertedTemp = (double)method.Invoke(instance, null);

			Console.WriteLine(convertedTemp + " F");

			dynamic instanceD = Activator.CreateInstance(temperature, quantity);

			Console.WriteLine(instanceD.ConvertToF() + " F"); 

			//Delay
			Console.ReadKey();
		}
	}
}
