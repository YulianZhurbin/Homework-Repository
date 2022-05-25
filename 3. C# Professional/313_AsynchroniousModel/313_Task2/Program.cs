using System;
using System.Runtime.Remoting.Messaging;
using System.Threading;

namespace _313_Task2
{
	class Program
	{
		static void Main()
		{
			Func<double, double, double> del = new Func<double, double, double>(Square);
			AsyncCallback callback = new AsyncCallback(PrintResult);

			IAsyncResult result = del.BeginInvoke(3, 2, callback, "The square of 3 = {0}");

			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine("Main thread work...");
				Thread.Sleep(200);
			}
			
			Console.WriteLine("Main thread's finished work");
			//Delay
			Console.ReadKey();
		}

		static double Square(double x, double y)
		{
			double result = Math.Pow(x, y);
			return result;
		}

		static void PrintResult(IAsyncResult asyncResult)
		{
			AsyncResult ar = asyncResult as AsyncResult;
			var callbackDel = (Func<double, double, double>)ar.AsyncDelegate;

			Thread.Sleep(1000);

			double result = callbackDel.EndInvoke(asyncResult);
			string str = string.Format(asyncResult.AsyncState.ToString(), result);

			Console.WriteLine(str);

			Console.WriteLine("The callback method has finished working");
		}
	}
}
