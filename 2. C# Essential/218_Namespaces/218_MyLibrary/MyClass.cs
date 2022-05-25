//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace MyNamespace
{
	/// <summary>
	/// The class is in the same solution!
	/// </summary>
	public class MyClass
	{
		internal virtual int Add(int x, int y)
		{
			return x + y;
		}

		public virtual int Sub(int x, int y)
		{
			return x - y;
		}

		public int Mul(int x, int y)
		{
			return x * y;
		}

		protected internal int Div(int x, int y)
		{
			return x / y;
		}

		public void PrintInfo() 
		{
			System.Console.WriteLine("MyNamespace.MyClass is attached!");
		}
	}
}
