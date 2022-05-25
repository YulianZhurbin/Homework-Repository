using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _215_AdditionalTask
{
	class Calculator
	{
		int op1, op2;

		public Calculator() { }

		public int Op1
		{
			set { this.op1 = value; }
		}
		public int Op2
		{
			set { this.op2 = value; }
		}

		public void Add()
		{
			double sum;

			sum = op1 + op2;
			Console.WriteLine(sum);
		}
		public void Sub()
		{
			double difference;

			difference = op1 - op2;
			Console.WriteLine(difference);
		}
		public void Mul()
		{
			double mul;

			mul = op1 * op2;
			Console.WriteLine(mul);
		}
		public void Div()
		{
			double div;

			try
			{
				if (op2 == 0)
					div = op1 / op2;

				div = (double)op1 / op2;

				Console.WriteLine($"{div:F2}");
			}
			catch (DivideByZeroException e)
			{
				Console.WriteLine(e.Message);
			}
		}

	}
}
