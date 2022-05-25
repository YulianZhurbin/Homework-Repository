using MyNamespace;
using static System.Console;
using _218_MyLibrary_OutTheProject;
using _218_MyLibrary_OutTheProject.MyNamespace_Out;

namespace Space
{
	class MyClass1 : MyClass
	{
		public double Div1(int x, int y)
		{
			return base.Div(x, y);
		}

		public override int Sub(int x, int y)
		{
			return y - x;
		}
	}
	class Program1
	{
		static void Main()
		{
			MyClass inst = new MyClass();

			inst.PrintInfo();

			System.Console.WriteLine(inst.Mul(1, 2));

			MyClass1 inst1 = new MyClass1();

			WriteLine(inst1.Div1(3, 2));

			WriteLine("MyClass1.Sub: {0}", inst1.Sub(3, 2));

			WriteLine("MyClass.Sub: {0}", inst.Sub(3, 2));

			WriteLine(new string('-', 30));

			MyClassOut instOut = new MyClassOut();

			WriteLine("MyClassOut.Mul: {0}", instOut.MulOut(33, 1));

			System.Console.ReadKey();
		}
	}
}
