namespace _218_MyLibrary_OutTheProject
{
	namespace MyNamespace_Out
	{
		/// <summary>
		/// The class is NOT in the same solution!
		/// </summary>
		public class MyClassOut
		{
			internal virtual int AddOut(int x, int y)
			{
				return x + y;
			}

			public virtual int SubOut(int x, int y)
			{
				return x - y;
			}

			public int MulOut(int x, int y)
			{
				return x * y;
			}

			protected internal int DivOut(int x, int y)
			{
				return x / y;
			}

			public void PrintInfo()
			{
				System.Console.WriteLine("MyNamespace.MyClass is attached!");
			}
		}
	}

}
