using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _217_AdditionalTask
{
	class Calculator 
	{
		public dynamic Add(dynamic op1, dynamic op2)
		{
			return op1 + op2;
		}		
		
		public dynamic Sub(dynamic op1, dynamic op2)
		{
			return op1 - op2;
		}

		public dynamic Mul(dynamic op1, dynamic op2)
		{
			return op1 * op2;
		}

		public dynamic Div(dynamic op1, dynamic op2)
		{
			return op1 / op2;
		}


	}
	class Program
	{
		static void Main(string[] args)
		{
			dynamic calc = new Calculator();

			Console.WriteLine(calc.Add(3,2));
			Console.WriteLine(calc.Sub(3,2));
			Console.WriteLine(calc.Mul(3,2));
			Console.WriteLine(calc.Div(3,2));

			//Delay
			Console.ReadKey();
		}
	}
}
